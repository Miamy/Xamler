using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using WinFormsApp.Classes.Helpers;
using XamlerModel.Classes.ToolboxModel;

namespace XamlerModel.Classes.PropertiesModel
{
    public class PropertyViewModel : INotifyPropertyChanged
    {
        public enum PropertiesKind { All, Assigned }

        public PropertyInfo PropertyInfo { get; set; }

        private XmlAttribute _xmlAttribute;
        public XmlAttribute XmlAttribute
        {
            get => _xmlAttribute;
            set
            {
                _xmlAttribute = value;
                XmlValue = _xmlAttribute?.Value;
            }
        }

        private object _xmlValue;
        public object XmlValue
        {
            get => _xmlValue;
            set
            {
                if (_xmlValue == value)
                {
                    return;
                }

                try
                {
                    _xmlValue = Convert.ChangeType(value, Type, CultureInfo.GetCultureInfo("en-US")); //CurrentUICulture); 
                }
                catch (Exception)
                {
                    _xmlValue = value;
                }

                if (_xmlValue.Equals(DefaultValue))
                {
                    _xmlValue = null;
                }
                else
                {
                    if (XmlAttribute != null)
                    {
                        XmlAttribute.Value = _xmlValue.ToString();
                    }
                }

                OnPropertyChanged();
                OnPropertyChanged("HasValue");
                if (Parent != null)
                {
                    Parent.OnPropertyChanged("XmlValue");
                    Parent.OnPropertyChanged("ChildrenXmlValue");
                    Parent.OnPropertyChanged("HasValue");                    
                }
            }
        }
        public object DefaultValue { get; set; }
        public object Value
        {
            get
            {
                if (HasValue)
                    return XmlValue;
                return DefaultValue;
            }
            set
            {
                XmlValue = value;
                //OnPropertyChanged();
            }
        }
        public bool HasValue => XmlValue != null;

        public ObservableCollection<PropertyViewModel> Children { get; }

        public string Name => PropertyInfo.Name;
        public Type Type => PropertyInfo.PropertyType;


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

        #endregion 

        public PropertyViewModel Parent { get; set; }




        public PropertyViewModel(PropertyViewModel parent, PropertyInfo propertyInfo, object instance, string parentPrefix = "", XmlNode node = null)
        {
            PropertyInfo = propertyInfo;
            Parent = parent;
            PropertyChanged += PropertyViewModel_PropertyChanged;

            if (parentPrefix == "")
            {
                Children = new ObservableCollection<PropertyViewModel>();

                var children = PropertyInfo.PropertyType.GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance).OrderBy(p => p.Name);
                foreach (var child in children)
                {
                    if (child.PropertyType.IsPrimitive && child.DeclaringType?.Name != "String")
                    {
                        try
                        {
                            Children.Add(new PropertyViewModel(this, child, instance, PropertyInfo.Name + "."));
                        }
                        catch (Exception) // no paramless constructor...
                        {
                        }
                    }
                }
            }

            DefaultValue = GetPropertyValue(instance, parentPrefix + PropertyInfo.Name);

            if (node != null)
            {
                if (node?.Attributes != null)
                {
                    var xmlAttribute = (XmlAttribute)node.Attributes.GetNamedItem(PropertyInfo.Name);
                    if (xmlAttribute != null)
                    {
                        XmlAttribute = xmlAttribute;
                    }
                }
            }
        }

        private void PropertyViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ChildrenXmlValue")
            {
                XmlValue = GetComplexXmlValue();
                OnPropertyChanged("Value");
            }
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
                try
                {
                    return property?.GetValue(instance, null);
                }
                catch (Exception) // TODO: you MUST call Forms.Init()...
                {
                    var t = property?.GetType();
                    if (t.IsValueType && t.HasParameterlessConstructor())
                        return Activator.CreateInstance(t);

                    return null;
                }

            }
        }

        public string GetComplexXmlValue()
        {
            var result = "";
            if (Children == null)
            {
                return result;
            }
            foreach (var child in Children)
            {
                result += child.Value + ",";
            }
            if (result.Length > 1)
            {
                return result.Substring(0, result.Length - 1);
            }
            return result;
        }
    }
}