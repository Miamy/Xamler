using ClientWPF.Commands;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XamlerModel.Classes
{
    public class XamlDocuments : INotifyPropertyChanged
    {
        public List<XamlDocument> Documents; 

        private XamlDocument _currentModel;
        public XamlDocument CurrentModel
        {
            get => _currentModel;
            set
            {
                if (_currentModel == value)
                    return;

                _currentModel = value;
                OnPropertyChanged();
            }
        }


        public ICommand AddDocumentCommand { get; private set; }


        public XamlDocuments()
        {
            Documents = new List<XamlDocument>();
            CreateCommands();
        }

        #region Event handlers

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public delegate void XamlDocumentChangedEventHandler(object sender, XamlDocumentChangedEventArgs e);
        public event XamlDocumentChangedEventHandler DocumentAdded;
        protected void OnDocumentAdded(XamlDocument document)
        {
            DocumentAdded?.Invoke(this, new XamlDocumentChangedEventArgs(document));
        }
        #endregion // Event handlers


        private void CreateCommands()
        {
            AddDocumentCommand = new RelayCommand(DoAddDocument, CanDoAddDocument);
        }

        private bool CanDoAddDocument(object obj)
        {
            return true;
        }

        private void DoAddDocument(object obj)
        {
            var filename = (string)obj;
            var existing = Documents.FirstOrDefault(x => x.FileName == filename);
            if (existing != null)
            {
                CurrentModel = existing;
                return;
            }

            var doc = new XamlDocument(filename);
            Documents.Add(doc);
            OnDocumentAdded(doc);
            CurrentModel = doc;
        }
    }
}
