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
using System.IO;

namespace WinFormsApp.Controls
{
    public partial class XamlDocumentEditor : UserControl
    {
        public XamlData Xaml { get; set; }

        public XamlDocumentEditor(XamlData xaml)
        {
            InitializeComponent();

            Xaml = xaml;
            LoadFromFile(Xaml);
        }

        private async void LoadFromFile(XamlData xaml)
        { 
            if (!File.Exists(xaml.FileName))
                throw new FileNotFoundException();

            using (var reader = File.OpenText(xaml.FileName))
            {
                codeEditor.Text = await reader.ReadToEndAsync();
            }
        }
    }
}
