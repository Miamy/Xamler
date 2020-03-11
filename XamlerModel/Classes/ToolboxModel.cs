using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Classes.Helpers;

namespace XamlerModel.Classes
{
    public class ToolboxModel
    {
        private Assembly _assembly;

        public string AssemblyPath { get; set; }

        public List<Type> Types { get; set; }

        public ToolboxModel(string assemblyPath)
        {
            if (!File.Exists(assemblyPath))
            {
                return;
            }
            _assembly = Assembly.LoadFrom(assemblyPath);
            FillToolbox();
        }

        public ToolboxModel()
        {
        }


        private void FillToolbox()
        {
            if (_assembly == null)
            {
                return;
            }
            var parent = _assembly.GetType("Xamarin.Forms.BindableObject");
            Types = _assembly.GetLoadableTypes().Where(t => t.IsPublic && t.IsClass && t.IsSubclassOf(parent)).ToList();
        }

        public Type GetType(string typeName)
        {
            if (_assembly == null)
            {
                return null; 
            }
            return _assembly.GetType(typeName);
        }

        public static Type GetTypeStatic(string typeName)
        {
            var toolbox = new ToolboxModel(Constants.PathToAssembly);
            return toolbox.GetType(typeName);
        }

    }
}
