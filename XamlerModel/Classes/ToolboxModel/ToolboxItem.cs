using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XamlerModel.Classes.ToolboxModel
{
    public class ToolboxItem
    {
        private const string ToolboxItemsPath = @"Images\Toolbox\";
        public Type Type { get; set; }
        public string Name => Type.Name;

        public string ImageName
        {
            get
            {
                var path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), ToolboxItemsPath, Type.Name + ".png");
                return File.Exists(path) ? path : null;
            }
        }

    public ToolboxItem(Type type)
        {
            Type = type;
        }
    }
}
