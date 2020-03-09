using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using XamlerModel.Classes;

namespace WpfApp.Controls.EditorView
{
    /// <summary>
    /// Interaction logic for EditorView.xaml
    /// </summary>
    public partial class EditorView : UserControl
    {
        private XamlDocument _document;
        public XamlDocument Document 
        { 
            get => _document; 
            internal set
            {
                if (_document == value)
                    return;

                _document = value;

                if (!File.Exists(_document.FileName))
                    throw new FileNotFoundException();

                using (var reader = File.OpenText(_document.FileName))
                {
                    //TextEditor.Text = await reader.ReadToEndAsync();
                    TextEditor.Text = reader.ReadToEnd();
                }
                TextEditor.UpdateLayout();
            }
        }


        public EditorView(XamlDocument document)
        {
            InitializeComponent();
            Document = document;            
        }

    }
}
