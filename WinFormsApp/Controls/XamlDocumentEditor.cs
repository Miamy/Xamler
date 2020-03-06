using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamlerModel;
using XamlerModel.Interfaces;
using System.IO;
using System.Runtime.InteropServices;

namespace WinFormsApp.Controls
{
    public partial class XamlDocumentEditor : UserControl
    {
        private IAppSettings _settings;
        public XamlData Xaml { get; set; }

        public XamlDocumentEditor(XamlData xaml, IAppSettings settings)
        {
            InitializeComponent();
            _settings = settings;

            Xaml = xaml;
            LoadFromFile(Xaml);

            codeEditor.Buddy = numbers;
        }

        private async void LoadFromFile(XamlData xaml)
        {
            if (!File.Exists(xaml.FileName))
                throw new FileNotFoundException();

            using (var reader = File.OpenText(xaml.FileName))
            {
                codeEditor.Text = await reader.ReadToEndAsync();
            }


            numbers.Visible = false;
            numbers.Clear();
            for (var i = 1; i < codeEditor.Lines.Length; i++)
                numbers.AppendText(i.ToString() + Environment.NewLine);
            numbers.Visible = true;
        }

        public void Save()
        {
            _settings.Save(mainSplitContainer);
        }
    }




}
