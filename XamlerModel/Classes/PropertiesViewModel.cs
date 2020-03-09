using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Input;


namespace XamlerModel.Classes
{
    /// <summary>
    /// This is the view-model of the UI.  It provides a data source
    /// for the TreeView (the FirstGeneration property), a bindable
    /// SearchText property, and the SearchCommand to perform a search.
    /// </summary>
    public class PropertiesViewModel
    {
        #region Data

        readonly PropertyViewModel _rootPerson;
        IEnumerator<PropertyViewModel> _matchingPeopleEnumerator;
        string _searchText = string.Empty;

        #endregion // Data

        #region Constructor

        public PropertiesViewModel(Type rootType)
        {
            //_rootPerson = new PropertyViewModel(rootType);

            FirstGeneration = new List<PropertyViewModel>();

            var bindable = rootType.GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance).OrderBy(p => p.Name).ToList();
            if (bindable != null)
            {
                var instance = Activator.CreateInstance(rootType);

                foreach (var attribute in bindable)
                {
                        FirstGeneration.Add(new PropertyViewModel(attribute)/*, GetDefaultValue(attribute, instance).ToString()*/);
                }
            }



            SearchCommand = new SearchFamilyTreeCommand(this);
        }

        #endregion // Constructor

        #region Properties

        #region FirstGeneration

        public List<PropertyViewModel> FirstGeneration { get; }

        #endregion // FirstGeneration

        #region SearchCommand

        /// <summary>
        /// Returns the command used to execute a search in the family tree.
        /// </summary>
        public ICommand SearchCommand { get; }

        private class SearchFamilyTreeCommand : ICommand
        {
            readonly PropertiesViewModel _familyTree;

            public SearchFamilyTreeCommand(PropertiesViewModel familyTree)
            {
                _familyTree = familyTree;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            event EventHandler ICommand.CanExecuteChanged
            {
                // I intentionally left these empty because
                // this command never raises the event, and
                // not using the WeakEvent pattern here can
                // cause memory leaks.  WeakEvent pattern is
                // not simple to implement, so why bother.
                add { }
                remove { }
            }

            public void Execute(object parameter)
            {
                _familyTree.PerformSearch();
            }
        }

        #endregion // SearchCommand

        #region SearchText

        /// <summary>
        /// Gets/sets a fragment of the name to search for.
        /// </summary>
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                if (value == _searchText)
                    return;

                _searchText = value;

                _matchingPeopleEnumerator = null;
            }
        }

        #endregion // SearchText

        #endregion // Properties

        #region Search Logic

        void PerformSearch()
        {
            if (_matchingPeopleEnumerator == null || !_matchingPeopleEnumerator.MoveNext())
                VerifyMatchingPeopleEnumerator();

            var person = _matchingPeopleEnumerator.Current;

            if (person == null)
                return;

            // Ensure that this person is in view.
            if (person.Parent != null)
                person.Parent.IsExpanded = true;

            person.IsSelected = true;
        }

        void VerifyMatchingPeopleEnumerator()
        {
            var matches = FindMatches(_searchText, _rootPerson);
            _matchingPeopleEnumerator = matches.GetEnumerator();

            if (!_matchingPeopleEnumerator.MoveNext())
            {
                System.Windows.MessageBox.Show(
                    "No matching names were found.",
                    "Try Again",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                    );
            }
        }

        IEnumerable<PropertyViewModel> FindMatches(string searchText, PropertyViewModel person)
        {
            if (person.NameContainsText(searchText))
                yield return person;

            foreach (PropertyViewModel child in person.Children)
                foreach (PropertyViewModel match in FindMatches(searchText, child))
                    yield return match;
        }

        #endregion // Search Logic


        public static object GetDefaultValue(PropertyInfo property, object instance)
        {
            var value = property.GetValue(instance);
            if (value == null)
                return "";
            if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string))
                return value.ToString();
            return GeneratePropertiesDictionary(value);
        }

        public static string GeneratePropertiesDictionary(object myClass)
        //public static List<PropertyInfo> GeneratePropertiesDictionary(object myClass)
        {
            var val = myClass.GetType()
                          .GetProperties()
                          .Where(p => p.CanRead)
                          //.ToDictionary(p => p.Name, p => p.GetValue(myClass, null));
                          .ToList();
            var res = "";
            foreach (var pair in val)
                //res += pair.Value.ToString() + ";";
                res += pair.ToString() + ";";
            return res;
        }
    }
}