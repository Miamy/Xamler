using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup.Primitives;
using System.Xml;
using WinFormsApp.Classes.Helpers;

namespace XamlerModel.Classes.PropertiesModel
{
    public class PropertiesViewModel
    {
        public Type Parent { get; set; }
        public List<PropertyViewModel> Properties { get; private set; }
        public List<PropertyViewModel> AssignedProperties => Properties.Where(p => p.XmlValue != null).ToList();
        public XmlNode Node { get; set; }

        public PropertiesViewModel(Type parent, XmlNode node)
        {
            Parent = parent;
            Node = node;

            Properties = new List<PropertyViewModel>();
            FillProperties();

            SearchCommand = new PropertiesViewModel.SearchInPropertiesCommand(this);
        }

        public void FillProperties()
        {
            Properties.Clear();
            if (!Parent.HasParameterlessConstructor())
            {
                return;
            }

            var instance = Activator.CreateInstance(Parent);
            var allProperties = Parent.GetBindableProperties();

            if (allProperties != null)
            {
                foreach (var current in allProperties)
                {
                    if (!string.IsNullOrEmpty(SearchText) && current.Name.IndexOf(SearchText, StringComparison.InvariantCultureIgnoreCase) == -1)
                    {
                        continue;
                    }

                    var property = new PropertyViewModel(null, current, instance, "", Node);               
                    Properties.Add(property);
                }
            }
        }


        string _searchText = string.Empty;


        public ICommand SearchCommand { get; }

        private class SearchInPropertiesCommand : ICommand
        {
            readonly PropertiesViewModel _propertiesModel;

            public SearchInPropertiesCommand(PropertiesViewModel propertiesModel)
            {
                _propertiesModel = propertiesModel;
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
                _propertiesModel.FillProperties();
            }
        }

        public string SearchText
        {
            get => _searchText;
            set
            {
                if (value == _searchText)
                    return;

                _searchText = value;
            }
        }



    }

}