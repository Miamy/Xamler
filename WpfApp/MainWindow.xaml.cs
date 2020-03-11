using ClientWPF.Commands;
using Itenso.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
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
using System.Xml;
using WpfApp.Commands;
using WpfApp.Controls.EditorView;
using WpfApp.Controls.ToolPanel;
using XamlerModel;
using XamlerModel.Classes;
using XamlerModel.Classes.PropertiesModel;

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

        public ToolboxModel Toolbox { get; set; }


        //public IAppSettings AppSettings { get; set; } = new AppSettings();
        public XamlDocuments Models { get; set; }

        //private List<EditorView> _editors;
        public ObservableCollection<EditorView> Editors { get; set; }

        private TreeView _objectsTreeView;
        private TreeView _propertiesTree;

        private readonly WindowSettings windowSettings;

        public string LastXamlFolder { get; set; }

        public MainWindow()
        {
            // create settings before InitializeComponent()
            windowSettings = new WindowSettings(this);

            InitializeComponent();


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

            Toolbox = new ToolboxModel(Constants.PathToAssembly);
            var ToolBoxListBox = (ListBox)GetByUid(ToolboxToolbox, "ToolBoxListBoxUid");
            if (ToolBoxListBox != null)
            {
                ToolBoxListBox.ItemsSource = Toolbox.Types; //this should be done in code, because listbox located inside a container
            }

            Editors = new ObservableCollection<EditorView>();

            //EditorsContainer.ItemsSource = Editors;

            _propertiesTree = (TreeView)GetByUid(PropertiesToolbox, "PropertiesTree");

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

        private void PropertiesTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.RemovedItems.Count > 0)
            {
                var oldPage = (TabItem)e.RemovedItems[0];
                oldPage.Content = null;
            }
            if (e.AddedItems.Count > 0)
            {
                var newPage = (TabItem)e.AddedItems[0];
                newPage.Content = _propertiesTree;
            }

            FillPropertiesTable();
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
            var main = (MainWindow)Application.Current.MainWindow;

            var openFile = new Microsoft.Win32.OpenFileDialog
            {
                InitialDirectory = //@"D:\Projects\Csharp\_Workspace\loadpad\loadpad\ConfigPages",
                    main.LastXamlFolder,
                //@"e:\CSharp\";
                DefaultExt = "xaml",
                Filter = "xaml files (*.xaml)|*.xaml|All files (*.*)|*.*",
                FileName = "MainPageSecondTry.xaml"
            };

            if (openFile.ShowDialog() != true)
                return;

            var filename = openFile.FileName;
            if (!File.Exists(filename))
                return;

            var command = main.Models.AddDocumentCommand;
            command.Execute(filename);
            main.LastXamlFolder = System.IO.Path.GetFullPath(filename);
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

        private void ObjectsView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (Models.CurrentModel == null)
            {
                return;
            }

            Models.CurrentModel.CurrentNode = (XmlNode)e.NewValue;
            if (Models.CurrentModel.CurrentNode == null)
            {
                return;
            }


        }


        private void ModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "CurrentModel":
                    var model = ((XamlDocuments)sender).CurrentModel;
                    if (model == null)
                    {
                        return;
                    }

                    if (_objectsTreeView != null)
                    {
                        _objectsTreeView.ItemsSource = model.Dom;
                    }

                    model.PropertyChanged += ModelPropertyChanged;
                    break;

                case "CurrentNode":
                    var doc = (XamlDocument)sender;
                    if (doc == null)
                    {
                        return;
                    }

                    var node = doc.CurrentNode;
                    if (node == null)
                    {
                        return;
                    }

                    FillPropertiesTable();

                    break;
            }
        }

        private void FillPropertiesTable()
        {
            var node = Models.CurrentModel?.CurrentNode;
            if (node == null)
            {
                return;
            }

            var typeName = "Xamarin.Forms." + node.Name;
            var type = Toolbox.GetType(typeName);
            if (type == null)
                return;

            //var root = new PropertyViewModel(type, null);
            var parent = (TabItem)_propertiesTree.Parent;
            PropertyViewModel.PropertiesKind kind;
            switch (parent.Uid)
            {
                case "AllPropertiesPage":
                    kind = PropertyViewModel.PropertiesKind.All;
                    break;
                case "AssignedPropertiesPage":
                    kind = PropertyViewModel.PropertiesKind.Assigned;
                    break;
                default:
                    kind = PropertyViewModel.PropertiesKind.All;
                    break;
            }

            var propertiesViewModel = new PropertiesViewModel(type, node);

            //_propertiesTree.DataContext = propertiesViewModel;
            switch (kind)
            {
                case PropertyViewModel.PropertiesKind.All:
                    _propertiesTree.ItemsSource = propertiesViewModel.Properties;
                    break;
                case PropertyViewModel.PropertiesKind.Assigned:
                    _propertiesTree.ItemsSource = propertiesViewModel.AssignedProperties;
                    break;
            }
        }

        private void ModelsDocumentAdded(object sender, XamlDocumentChangedEventArgs e)
        {
            var editor = new EditorView(e.Document)
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };
            Editors.Add(editor);

            var tab = new TabItem
            {
                Content = editor,
                Header = System.IO.Path.GetFileName(e.Document.FileName),
                Tag = e.Document.FileName,
                VerticalAlignment = VerticalAlignment.Stretch
            };
            EditorsContainer.Items.Add(tab);
            EditorsContainer.SelectedItem = tab;
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            //windowSettings.Save();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            windowSettings.Settings.Add(new DependencyPropertySetting("LeftContainer.Width", LeftContainer, FrameworkElement.WidthProperty, LeftContainer.Width));
            windowSettings.Settings.Add(new DependencyPropertySetting("RightContainer.Width", RightContainer, FrameworkElement.WidthProperty, RightContainer.Width));
            windowSettings.Settings.Add(new DependencyPropertySetting("BottomContainer.Height", BottomContainer, FrameworkElement.HeightProperty, BottomContainer.Height));

            //windowSettings.Settings.Add(new DependencyPropertySetting("ToolboxToolbox.ActualHeight", ToolboxToolbox, FrameworkElement.ActualHeightProperty, ToolboxToolbox.ActualHeight));
            windowSettings.Settings.Add(new PropertySetting("LastXamlFolder", this, "LastXamlFolder", LastXamlFolder));
        }
    }
}
