using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XamlerModel.Classes
{
    public class XamlDocument : INotifyPropertyChanged
    {
        public string FileName { get; set; }
        public XmlDocument Dom { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private XmlNode _currentNode;
        public XmlNode CurrentNode
        {
            get => _currentNode;
            set
            {
                _currentNode = value;
                OnPropertyChanged();
            }
        }

        public XamlDocument()
        {
            CreateDom();
        }

        public XamlDocument(string filename) : this()
        {
            FileName = filename;
            LoadDom();
        }

        private void CreateDom()
        {
            Dom = new XmlDocument();
        }

        private void LoadDom()
        {
            if (!File.Exists(FileName))
                throw new FileNotFoundException();

            try
            {
                Dom.Load(FileName);
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
