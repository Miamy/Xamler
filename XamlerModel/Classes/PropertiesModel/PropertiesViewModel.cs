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
        }

        public void FillProperties()
        {
            var instance = Activator.CreateInstance(Parent);
            var allProperties = Parent.GetBindableProperties();

            if (allProperties != null)
            {
                foreach (var current in allProperties)
                {
                    var property = new PropertyViewModel(current, instance);
                    if (Node?.Attributes != null)
                    {
                        var xmlAttribute = Node.Attributes.GetNamedItem(current.Name);
                        property.XmlValue = xmlAttribute?.Value;

                    }
                    Properties.Add(property);
                }
            }
        }
  
    }

   
}