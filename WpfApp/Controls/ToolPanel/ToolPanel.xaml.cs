using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfApp.Controls.ToolPanel
{
    /// <summary>
    /// Interaction logic for ToolPanel.xaml
    /// </summary>
    /// [ContentProperty("Items")]
    public partial class ToolPanel : UserControl, INotifyPropertyChanged
    {
        private Brush _backColor;
        public Brush BackColor
        {
            get => _backColor;
            set
            {
                _backColor = value;
                RaisePropertyChanged("BackColor");
            }
        }

        private Brush _foreColor;
        public Brush ForeColor
        {
            get => _foreColor;
            set
            {
                _foreColor = value;
                RaisePropertyChanged("ForeColor");
            }
        }

        public string Caption { get; set; }

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set
            {
                _isActive = value;
                if (value)
                {
                    BackColor = new SolidColorBrush(Colors.LightCoral);
                    ForeColor = new SolidColorBrush(Colors.Black);
                }
                else
                {
                    BackColor = new SolidColorBrush(Colors.Navy);
                    ForeColor = new SolidColorBrush(Colors.White);
                }



            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static readonly DependencyProperty PlaceHolderProperty =
        DependencyProperty.Register("PlaceHolder", typeof(object), typeof(ToolPanel), new UIPropertyMetadata(null));
        public object PlaceHolder
        {
            get { return (object)GetValue(PlaceHolderProperty); }
            set { SetValue(PlaceHolderProperty, value); }
        }



        public ToolPanel()
        {
            InitializeComponent();
            DataContext = this;
            IsActive = false;
        }
    }
}
