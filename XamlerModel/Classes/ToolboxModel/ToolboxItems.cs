using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Classes.Helpers;

namespace XamlerModel.Classes.ToolboxModel
{
    public class ToolboxItems
    {
        private Assembly _assembly;

        public string AssemblyPath { get; set; }

        public List<ToolboxItem> Types { get; set; }

        public ToolboxItems(string assemblyPath)
        {
            if (!File.Exists(assemblyPath))
            {
                return;
            }
            _assembly = Assembly.LoadFrom(assemblyPath);
            FillToolbox();
        }

        public ToolboxItems()
        {
        }


        private void FillToolbox()
        {
            if (_assembly == null)
            {
                return;
            }
            var parent = _assembly.GetType("Xamarin.Forms.BindableObject");
            Types = _assembly.GetLoadableTypes().Where(t => t.IsPublic && t.IsClass && t.IsSubclassOf(parent)).Select(t => new ToolboxItem(t)).ToList();
/*
            var path = @"e:\_Images\_VS\VS2019 Image Library\vswin2019\";
            foreach (var type in Types)
            {
                var name = type.Name;
                if (Directory.Exists(path + name))
                {
                    File.Copy(path + name + "\\" + name + "_16x.png", @"c:\CSharp\_Workspace\Xamler\XamlerModel\Images\Toolbox\" + name + ".png");
                }
            }
*/
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
            var toolbox = new ToolboxItems(Constants.PathToAssembly);
            return toolbox.GetType(typeName);
        }

    }
}
