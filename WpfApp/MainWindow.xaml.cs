using ClientWPF.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using WpfApp.Commands;
using WpfApp.Controls.EditorView;
using WpfApp.Controls.ToolPanel;
using XamlerModel;
using XamlerModel.Classes;
using XamlerModel.Interfaces;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<ToolPanel> _toolPanels;
        private ToolPanel _activeToolPanel
        {
            set
            {
                foreach (var panel in _toolPanels)
                {
                    panel.IsActive = false;
                }
                value.IsActive = true;
            }
        }

        public ToolboxModel ToolboxModel { get; set; }


        //public IAppSettings AppSettings { get; set; } = new AppSettings();
        public XamlDocuments Models { get; set; }

        //private List<EditorView> _editors;
        public ObservableCollection<EditorView> Editors { get; set; }

    private TreeView _objectsTreeView; 


        public MainWindow()
        {
            InitializeComponent();

            //EditorsContainer.Items.Clear();

            CreateCommands();

            _toolPanels = new List<ToolPanel>
            {
                ObjectsToolbox,
                PropertiesToolbox,
                SolutionToolbox,
                ToolboxToolbox
            };

            foreach (var panel in _toolPanels)
            {
                panel.MouseLeftButtonDown += Toolbox_MouseLeftButtonDown;
            }

            _objectsTreeView = (TreeView)GetByUid(this, "ObjectsTreeView");


            Models = new XamlDocuments();
            Models.PropertyChanged += ModelPropertyChanged;
            Models.DocumentAdded += ModelsDocumentAdded;

            ToolboxModel = new ToolboxModel(@"C:\Users\Miamy\.nuget\packages\xamarin.forms\4.1.0.618606\build\net46\Xamarin.Forms.Core.dll");
            var ToolBoxListBox = (ListBox)GetByUid(ToolboxToolbox, "ToolBoxListBoxUid");
            if (ToolBoxListBox != null)
            {
                ToolBoxListBox.ItemsSource = ToolboxModel.Types; //this should be done in code, because listbox located inside a container
            }

            Editors = new ObservableCollection<EditorView>();

            //EditorsContainer.ItemsSource = Editors;


            DataContext = this;
        }

        private void Toolbox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is ToolPanel panel)
            {
                _activeToolPanel = panel;
            }
        }

        public static UIElement GetByUid(DependencyObject rootElement, string uid)
        {
            foreach (UIElement element in LogicalTreeHelper.GetChildren(rootElement).OfType<UIElement>())
            {
                if (element.Uid == uid)
                    return element;
                UIElement resultChildren = GetByUid(element, uid);
                if (resultChildren != null)
                    return resultChildren;
            }
            return null;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        #region Commands
        private static void CreateCommands()
        {
            var binding = new CommandBinding(CommonCommands.ExitApplication, DoExitApplication, CanDoExitApplication);
            CommonCommands.ExitApplication.InputGestures.Add(new KeyGesture(Key.F4, ModifierKeys.Alt, " "));
            CommandManager.RegisterClassCommandBinding(typeof(Window), binding);

            binding = new CommandBinding(CommonCommands.OpenFile, DoOpenFile, CanDoOpenFile);
            CommonCommands.OpenFile.InputGestures.Add(new KeyGesture(Key.O, ModifierKeys.Control, " "));
            CommandManager.RegisterClassCommandBinding(typeof(Window), binding);

        }


        private static void CanDoExitApplication(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private static void DoExitApplication(object sender, ExecutedRoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown(); // TODO
        }


        private static void CanDoOpenFile(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private static void DoOpenFile(object sender, ExecutedRoutedEventArgs e)
        {
            var openFile = new Microsoft.Win32.OpenFileDialog
            {
                InitialDirectory = @"D:\Projects\Csharp\_Workspace\loadpad\loadpad\ConfigPages",
                //@"e:\CSharp\";
                DefaultExt = "xaml",
                Filter = "xaml files (*.xaml)|*.xaml|All files (*.*)|*.*",
                FileName = "NewSettingsPage.xaml"
            };

            if (openFile.ShowDialog() != true)
                return;

            var filename = openFile.FileName;
            if (!File.Exists(filename))
                return;

            var main = (MainWindow)Application.Current.MainWindow;

            var command = main.Models.AddDocumentCommand;
            command.Execute(filename);

        }

        private RelayCommand _closeCommand;

        public RelayCommand CloseCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new RelayCommand(w => CloseCommandMethod(w), null);
                }
                return _closeCommand;
            }
        }

        private void CloseCommandMethod(object parameter)
        {
            //List<Employee> employees = TabControl1.ItemsSource as List<Employee>;
            //EditorsContainer.ClearValue(ItemsControl.ItemsSourceProperty);
            //employees.RemoveAll(w => w.ID == (parameter as int?).GetValueOrDefault());
            //EditorsContainer.ItemsSource = employees;
        }
        #endregion

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            
        }


        private void ModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "CurrentModel":
                    var doc = ((XamlDocuments)sender).CurrentModel;
                    if (doc == null)
                    {
                        return;
                    }
                    //FillPropertiesTable();

                    if (_objectsTreeView != null)
                    {
                        _objectsTreeView.ItemsSource = doc.Dom;
                    }

                    break;
            }
        }

        private void ModelsDocumentAdded(object sender, XamlDocumentChangedEventArgs e)
        {
            var editor = new EditorView(e.Document);
            Editors.Add(editor);

            var tab = new TabItem
            {
                Content = editor,
                Header = System.IO.Path.GetFileName(e.Document.FileName),
                Tag = e.Document.FileName
            };
            EditorsContainer.Items.Add(tab);
            
        }


       
    }
}
