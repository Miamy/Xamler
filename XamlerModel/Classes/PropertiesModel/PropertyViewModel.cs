using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using WinFormsApp.Classes.Helpers;

namespace XamlerModel.Classes.PropertiesModel
{
    public class PropertyViewModel : INotifyPropertyChanged
    {
        public enum PropertiesKind { All, Assigned }

        public PropertyInfo PropertyInfo { get; set; }

        public object XmlValue { get; set; }
        public object DefaultValue { get; set; }
        public object Value
        {
            get
            {
                if (XmlValue != null)
                    return XmlValue;
                return DefaultValue;
            }
        }

        public ObservableCollection<PropertyViewModel> Children { get; }

        public string Name => PropertyInfo.Name;
        public Type Type => PropertyInfo.PropertyType;

        public XmlAttribute Attribute { get; set; }


        #region IsExpanded

        private bool _isExpanded;
        /// <summary>
        /// Gets/sets whether the TreeViewItem 
        /// associated with this object is expanded.
        /// </summary>
        public bool IsExpanded
        {
            get => _isExpanded;
            set
            {
                if (value != _isExpanded)
                {
                    _isExpanded = value;
                    OnPropertyChanged();
                }

                // Expand all the way up to the root.
                if (_isExpanded && Parent != null)
                    Parent.IsExpanded = true;
            }
        }

        #endregion // IsExpanded

        #region IsSelected

        private bool _isSelected;

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (value != _isSelected)
                {
                    _isSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion // IsSelected

        #region NameContainsText

        public bool NameContainsText(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(Name))
                return false;

            return Name.IndexOf(text, StringComparison.InvariantCultureIgnoreCase) > -1;
        }

        #endregion // NameContainsText

        public PropertyViewModel Parent { get; }


       

        public PropertyViewModel(PropertyInfo propertyInfo, object instance, string parentPrefix = "")
        {
            PropertyInfo = propertyInfo;

            Children = new ObservableCollection<PropertyViewModel>();
            if (parentPrefix == "")
            {
                var children = PropertyInfo.PropertyType.GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance).OrderBy(p => p.Name);
                foreach (var child in children)
                {
                    if (child.PropertyType.IsPrimitive && child.DeclaringType?.Name != "String")
                    {
                        try
                        {
                            Children.Add(new PropertyViewModel(child, instance, PropertyInfo.Name + "."));
                        }
                        catch (Exception) // no paramless constructor...
                        {
                        }
                    }
                }
            }

            DefaultValue = GetPropertyValue(instance, parentPrefix + PropertyInfo.Name);
        }

        public PropertyViewModel(XmlAttribute attribute)
        {
            Attribute = attribute;

            var typeName = "Xamarin.Forms." + attribute.ParentNode.Name;
            var type = ToolboxModel.GetTypeStatic(typeName);
            if (type == null)
                return;

        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion // INotifyPropertyChanged Members

   
        public static object GetPropertyValue(object instance, string propertyName)
        {
            if (instance == null)
            {
                throw new ArgumentException("Value cannot be null.", "instance");
            }
            if (propertyName == null)
            {
                throw new ArgumentException("Value cannot be null.", "propertyName");
            }

            if (propertyName.Contains(".")) 
            {
                var temp = propertyName.Split(new char[] { '.' }, 2);
                return GetPropertyValue(GetPropertyValue(instance, temp[0]), temp[1]);
            }
            else
            {
                var property = instance.GetType().GetProperty(propertyName);
                return property?.GetValue(instance, null);
            }
        }
    }
}