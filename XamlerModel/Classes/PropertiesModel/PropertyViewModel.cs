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

        //public bool HasDefaultValue => /*Value == null && DefaultValue == null || */XmlValue != null && XmlValue.Equals(DefaultValue);

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


       

        public PropertyViewModel(PropertyInfo propertyInfo, object instance, bool goDeeper = true)
        {
            PropertyInfo = propertyInfo;

            //Children = new ReadOnlyCollection<PropertyViewModel>(
            //        (from child in Property.GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance).OrderBy(p => p.Name)
            //         select new PropertyViewModel(child.PropertyType, this)).ToList());

            Children = new ObservableCollection<PropertyViewModel>();
            if (goDeeper)
            {
                //var children = PropertyInfo.PropertyType.GetBindableProperties(); 
                var children = PropertyInfo.PropertyType.GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance).OrderBy(p => p.Name);
                foreach (var child in children)
                {
                    //if (!child.PropertyType.IsAbstract && !child.PropertyType.IsPrimitive && child.PropertyType != typeof(string))
                    //{
                    //    try
                    //    {
                    //        var instanceOfChild = Activator.CreateInstance(child.PropertyType);
                    //        Children.Add(new PropertyViewModel(child, instanceOfChild, false));
                    //    }
                    //    catch (Exception) // no paramless constructor...
                    //    {
                    //    }
                    //}

                    if (child.PropertyType.IsPrimitive)
                    {
                        try
                        {
                            Children.Add(new PropertyViewModel(child, null, false));
                        }
                        catch (Exception) // no paramless constructor...
                        {
                        }
                    }
                }
            }

            DefaultValue = GetDefaultValue(PropertyInfo, instance);
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

        public static object GetDefaultValue(PropertyInfo property, object instance)
        {
            if (instance == null)
                return "";
            object value = null;
            try
            {
                value = property.GetValue(instance);
            }
            catch (Exception)
            {
            }
            if (value == null)
                return "";
            if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string) || property.PropertyType.IsValueType)
                return value.ToString();

            try
            {
                return GetComplexValue(value);
            }
            catch (Exception)
            {
                return "<>";
            }
            
        }

        public static string GetComplexValue(object instance)
        {
            var val = instance.GetType()
                          .GetProperties()
                          .Where(p => p.CanRead)
                          .ToList();
            var res = "";
            foreach (var pair in val)
                res += pair.GetValue(instance).ToString() + ";";
            return res;
        }
    }
}