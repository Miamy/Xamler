using System;
using System.Collections.Generic;
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
            _assembly = Assembly.LoadFrom(assemblyPath);
            FillToolbox();
        }

        public ToolboxModel()
        {
        }


        private void FillToolbox()
        {
            var parent = _assembly.GetType("Xamarin.Forms.BindableObject");
            Types = _assembly.GetLoadableTypes().Where(t => t.IsPublic && t.IsClass && t.IsSubclassOf(parent)).ToList();
        }

        public Type GetType(string typeName)
        {
            return _assembly.GetType(typeName);
        }

        public static Type GetTypeStatic(string typeName)
        {
            var toolbox = new ToolboxModel(@"C:\Users\Miamy\.nuget\packages\xamarin.forms\4.1.0.618606\build\net46\Xamarin.Forms.Core.dll");
            return toolbox.GetType(typeName);
        }

    }
}
