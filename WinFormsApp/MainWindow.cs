using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WinFormsApp.Classes.Helpers;
using WinFormsApp.Controls;
using WinFormsApp.Windows;
using XamlerModel;
using XamlerModel.Classes;
using XamlerModel.Classes.PropertiesModel;
using XamlerModel.Interfaces;

namespace WinFormsApp
{
    public partial class MainWindow : Form
    {
        

        private List<Panel> _toolWindows;
        private List<XamlDocumentEditor> _editors;

        public IAppSettings AppSettings { get; set; } = new AppSettings();
        public List<XamlDocument> Models { get; set; }

        private XamlDocument _currentModel;
        public XamlDocument CurrentModel
        {
            get => _currentModel;
            set
            {
                if (_currentModel == value)
                    return;

                if (_currentModel != null)
                    _currentModel.PropertyChanged -= CurrentModelPropertyChanged;

                _currentModel = value;

                if (_currentModel != null)
                    _currentModel.PropertyChanged += CurrentModelPropertyChanged;

                foreach (var editor in _editors)
                {
                    if (editor.Xaml == value)
                    {
                        documentsTabControl.SelectedTab = (TabPage)editor.Parent;
                        break;
                    }
                }

                LoadTreeFromXmlDocument();
            }
        }

        ToolboxModel Toolbox { get; set; }


        private void CurrentModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "CurrentNode":
                    FillPropertiesTable();
                    break;
            }
        }

        private void LoadTreeFromXmlDocument()
        {
            try
            {
                objectsTreeView.BeginUpdate();
                try
                {
                    objectsTreeView.Nodes.Clear();

                    foreach (XmlNode node in CurrentModel.Dom.DocumentElement.ChildNodes)
                    {
                        if (node.Name == "namespace" && node.ChildNodes.Count == 0 && string.IsNullOrEmpty(GetAttributeText(node, "name")))
                            continue;
                        AddNode(objectsTreeView.Nodes, node);
                    }

                    objectsTreeView.ExpandAll();
                }
                finally
                {
                    objectsTreeView.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static string GetAttributeText(XmlNode inXmlNode, string name)
        {
            XmlAttribute attr = inXmlNode.Attributes?[name];
            return attr?.Value;
        }

        private void AddNode(TreeNodeCollection nodes, XmlNode inXmlNode)
        {
            string text = GetAttributeText(inXmlNode, "name");
            if (string.IsNullOrEmpty(text))
                text = inXmlNode.Name + "  ";


            if (inXmlNode.Attributes != null)
            {
                foreach (XmlAttribute attribute in inXmlNode.Attributes)
                {
                    text += attribute.Name + "=" + attribute.Value + ", ";
                }
            }

            TreeNode newNode = nodes.Add(text);
            newNode.Tag = inXmlNode;

            if (inXmlNode.HasChildNodes)
            {
                XmlNodeList nodeList = inXmlNode.ChildNodes;
                for (int i = 0; i <= nodeList.Count - 1; i++)
                {
                    var xNode = inXmlNode.ChildNodes[i];
                    AddNode(newNode.Nodes, xNode);
                }
            }


        }

        public MainWindow()
        {
            InitializeComponent();

            _toolWindows = new List<Panel>
            {
                leftInnerContainer.Panel1,
                leftInnerContainer.Panel2,
                rightContainer.Panel1,
                rightContainer.Panel2
            };

            Models = new List<XamlDocument>();
            _editors = new List<XamlDocumentEditor>();

            Toolbox = new ToolboxModel(Constants.PathToAssembly);
            toolBoxListBox.DataSource = Toolbox.Types;

            tabPagePropertiesAll.Tag = PropertyViewModel.PropertiesKind.All;
            tabPagePropertiesAssigned.Tag = PropertyViewModel.PropertiesKind.Assigned;


        }

        private void LoadSettings()
        {
            AppSettings.Load(this);

            AppSettings.Load(mainContainer);
            AppSettings.Load(leftContainer);
            AppSettings.Load(centerContainer);
            AppSettings.Load(rightContainer);
            AppSettings.Load(leftInnerContainer);
        }

        public void Save()
        {
            AppSettings.Save(this);

            AppSettings.Save(mainContainer);
            AppSettings.Save(leftContainer);
            AppSettings.Save(leftInnerContainer);
            AppSettings.Save(centerContainer);
            AppSettings.Save(rightContainer);

            foreach (var editor in _editors)
            {
                editor.Save();
            }
        }


        //private void toolBoxListBox_SelectedValueChanged(object sender, EventArgs e)
        /*{
            listBox2.Items.Clear();

            var list = (ListBox)sender;
            var selected = (Type)list.SelectedItem;
            if (selected == null)
                return;

            var properties = selected.GetProperties();
            foreach(var property in properties)
            {
                listBox2.Items.Add(property);
            }
        }*/



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void toolWindowClick(object sender, EventArgs e)
        {
            WindowHelperClass.SetActivePanel(_toolWindows, (Control)sender);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"D:\Projects\Csharp\_Workspace\loadpad\loadpad\ConfigPages";
            //@"e:\CSharp\";
            openFileDialog.DefaultExt = "xaml";
            openFileDialog.Filter = "xaml files (*.xaml)|*.xaml|All files (*.*)|*.*";
            openFileDialog.FileName = "NewSettingsPage.xaml";

            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            var filename = openFileDialog.FileName;
            if (!File.Exists(filename))
                return;

            var existing = Models.FirstOrDefault(x => x.FileName == filename);
            if (existing != null)
            {
                CurrentModel = existing;
                return;
            }

            var xaml = new XamlDocument(filename);
            Models.Add(xaml);
            AddDocument(xaml);

            CurrentModel = xaml;
        }

        private void AddDocument(XamlDocument xaml)
        {
            var tab = new TabPage(Path.GetFileName(xaml.FileName))
            {
                Tag = xaml,
                ToolTipText = xaml.FileName
            };

            var editor = new XamlDocumentEditor(xaml, AppSettings)
            {
                Parent = tab,
                Dock = DockStyle.Fill
            };
            _editors.Add(editor);

            documentsTabControl.TabPages.Add(tab);
            //documentsTabControl.SelectedTab = tab;
        }

        private void aboutXamlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new AboutBox();
            dialog.ShowDialog();
        }

        private void documentsTabControl_Selected(object sender, TabControlEventArgs e)
        {
            var selectedTab = ((TabControl)sender).SelectedTab;
            if (selectedTab == null)
                return;
            CurrentModel = (XamlDocument)selectedTab.Tag;

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void tabControlProperties_Selected(object sender, TabControlEventArgs e)
        {
            tableLayoutProperties.Parent = tabControlProperties.SelectedTab;
            FillPropertiesTable();
        }

        private void FillPropertiesTable()
        {
            tableLayoutProperties.Controls.Clear();
            if (tableLayoutProperties.Parent == null)
                return;

            tableLayoutProperties.SuspendLayout();
            try
            {
                tableLayoutProperties.RowCount = 1;
                tableLayoutProperties.RowStyles.Clear();
                tableLayoutProperties.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));

                var node = CurrentModel.CurrentNode;
                if (node == null)
                    return;

                var properties = new Dictionary<string, string>();

                var kind = (PropertyViewModel.PropertiesKind)tableLayoutProperties.Parent?.Tag;
                switch (kind)
                {
                    case PropertyViewModel.PropertiesKind.All:
                        var typeName = "Xamarin.Forms." + node.Name;
                        var type = Toolbox.GetType(typeName);
                        if (type == null)
                            return;
                        //Where(p => p.Name.IndexOf("Property") > -1).
                        //var bindable = type.GetFields().Where(p => Attribute.IsDefined(p, typeof(BindableAttribute))).OrderBy(p => p.Name).ToList();
                        var bindable = type.GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance).OrderBy(p => p.Name).ToList();
                        if (bindable != null)
                        {
                            var instance = Activator.CreateInstance(type);

                            foreach (var attribute in bindable)
                            {
                                if (!properties.ContainsKey(attribute.Name))
                                    properties.Add(attribute.Name, GetDefaultValue(attribute, instance).ToString());
                            }
                        }

                        break;
                    case PropertyViewModel.PropertiesKind.Assigned:
                        if (node.Attributes != null)
                        {
                            foreach (XmlAttribute attribute in node.Attributes)
                            {
                                properties.Add(attribute.Name, attribute.Value);
                            }
                        }

                        break;
                }

                Label label;
                TextBox textBox;
                tableLayoutProperties.RowCount = properties.Count;
                for (var i = 0; i < properties.Count; i++)
                {
                    label = new Label
                    {
                        Text = properties.Keys.ElementAt(i),
                        TextAlign = ContentAlignment.MiddleLeft
                    };
                    tableLayoutProperties.Controls.Add(label, 0, i);

                    textBox = new TextBox
                    {
                        Text = properties.Values.ElementAt(i),
                        BorderStyle = BorderStyle.None,
                        Width = tableLayoutProperties.ClientSize.Width / 2,
                        TextAlign = HorizontalAlignment.Left
                    };
                    tableLayoutProperties.Controls.Add(textBox, 1, i);
                }
                tableLayoutProperties.Height = 20 * tableLayoutProperties.RowCount;
            }
            finally
            {
                tableLayoutProperties.ResumeLayout();
            }
        }

        private void objectsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var view = (TreeView)sender;
            if (e.Node == null)
            {
                CurrentModel.CurrentNode = null;
            }
            else
            {
                CurrentModel.CurrentNode = (XmlNode)e.Node.Tag;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var options = new OptionsForm();
            options.ShowDialog();
        }


        public static object GetDefaultValue(PropertyInfo property, object instance)
        {
            var value = property.GetValue(instance);
            if (value == null)
                return "";
            if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string))
                return value.ToString();
            return GeneratePropertiesDictionary(value);
        }

        public static string GeneratePropertiesDictionary(object myClass)
        //public static List<PropertyInfo> GeneratePropertiesDictionary(object myClass)
        {
            var val = myClass.GetType()
                          .GetProperties()
                          .Where(p => p.CanRead)
                          //.ToDictionary(p => p.Name, p => p.GetValue(myClass, null));
                          .ToList();
            var res = "";
            foreach (var pair in val)
                //res += pair.Value.ToString() + ";";
                res += pair.ToString() + ";";
            return res;
        }
    }
}
