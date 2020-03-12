using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlerModel.Classes.ToolboxModel
{
    public class ToolboxItem
    {
        public Type Type { get; set; }
        public string Name => Type.Name;

        public string ImageName => @"c:\CSharp\_Workspace\Xamler\XamlerModel\Images\Toolbox\" + Type.Name + ".png";


        public ToolboxItem(Type type)
        {
            Type = type;
        }
    }
}
