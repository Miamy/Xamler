﻿using System;
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
using XamlerModel;

namespace WinFormsApp
{
    public partial class MainWindow : Form
    {
        private List<Panel> _toolWindows;
        private List<XamlDocumentEditor> _editors;

        public List<XamlData> Models { get; set; }

        private XamlData _currentModel;
        public XamlData CurrentModel
        {
            get => _currentModel;
            set
            {
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
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainWindow_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void splitter_SplitterMoved(object sender, SplitterEventArgs e)
        {

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
            var tab = new TabPage(xaml.FileName);

            var editor = new XamlDocumentEditor(xaml)
            {
                Parent = tab,
                Dock = DockStyle.Fill
            };
            _editors.Add(editor);

            documentsTabControl.TabPages.Add(tab);
            //documentsTabControl.SelectedTab = tab;
        }
    }
}
