using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace XamlerModel.Classes
{
    /// <summary>
    /// A UI-friendly wrapper around a Person object.
    /// </summary>
    public class PropertyViewModel :  INotifyPropertyChanged
    {

        private readonly PropertyInfo _property;

        private bool _isExpanded;
        private bool _isSelected;

        public object Value { get; set; }
        public object DefaultValue { get; set; }

        public PropertyViewModel(PropertyInfo person)
            : this(person, null)
        {
        }

        private PropertyViewModel(PropertyInfo person, PropertyViewModel parent)
        {
            _property = person;
            Parent = parent;

            //Children = new ReadOnlyCollection<PropertyViewModel>(
            //        (from child in _property. Children select new PropertyViewModel(child, this))
            //         .ToList<PropertyViewModel>());
        }


        public ReadOnlyCollection<PropertyViewModel> Children { get; }

        public string Name
        {
            get { return _property.Name; }
        }


        #region IsExpanded

        /// <summary>
        /// Gets/sets whether the TreeViewItem 
        /// associated with this object is expanded.
        /// </summary>
        public bool IsExpanded
        {
            get { return _isExpanded; }
            set
            {
                if (value != _isExpanded)
                {
                    _isExpanded = value;
                    this.OnPropertyChanged("IsExpanded");
                }

                // Expand all the way up to the root.
                if (_isExpanded && Parent != null)
                    Parent.IsExpanded = true;
            }
        }

        #endregion // IsExpanded

        #region IsSelected

        /// <summary>
        /// Gets/sets whether the TreeViewItem 
        /// associated with this object is selected.
        /// </summary>
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (value != _isSelected)
                {
                    _isSelected = value;
                    this.OnPropertyChanged("IsSelected");
                }
            }
        }

        #endregion // IsSelected

        #region NameContainsText

        public bool NameContainsText(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(this.Name))
                return false;

            return this.Name.IndexOf(text, StringComparison.InvariantCultureIgnoreCase) > -1;
        }

        #endregion // NameContainsText


        public PropertyViewModel Parent { get; }



        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion // INotifyPropertyChanged Members
    }
}