using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WinFormsApp.Classes.Helpers;
using WinFormsApp.Controls;
using WinFormsApp.Windows;
using XamlerModel;
using XamlerModel.Interfaces;

namespace WinFormsApp
{
    public partial class MainWindow : Form
    {
        private List<Panel> _toolWindows;
        private List<XamlDocumentEditor> _editors;

        public IAppSettings AppSettings { get; set; }
        public List<XamlData> Models { get; set; }

        private XamlData _currentModel;
        public XamlData CurrentModel
        {
            get => _currentModel;
            set
            {
                if (_currentModel == value)
                    return;

                _currentModel = value;
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

        private void LoadTreeFromXmlDocument()
        {
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
                leftContainer.Panel1,
                leftContainer.Panel2,
                rightContainer.Panel1,
                rightContainer.Panel2
            };

            Models = new List<XamlData>();
            _editors = new List<XamlDocumentEditor>();

            FillToolbox();
        }

        public void Save()
        {
            foreach (var editor in _editors)
            {
                editor.Save();
            }
        }

        private void FillToolbox()
        {
            /*var assembly = Assembly.LoadFrom(textBox2.Text);
            listBox1.Items.Clear();
            listBox1.DataSource = assembly.GetLoadableTypes().ToList();

      //private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
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

        }

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
            openFileDialog.InitialDirectory = @"e:\CSharp\";
            openFileDialog.DefaultExt = "xaml";
            openFileDialog.Filter = "xaml files (*.xaml)|*.xaml|All files (*.*)|*.*";
            openFileDialog.FileName = "MainPageSecondTry.xaml";

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

            var xaml = new XamlData(filename);
            Models.Add(xaml);
            AddDocument(xaml);

            CurrentModel = xaml;
        }

        private void AddDocument(XamlData xaml)
        {
            var tab = new TabPage(xaml.FileName)
            {
                Tag = xaml
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
            CurrentModel = (XamlData)selectedTab.Tag;

        }
    }
}
