using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Classes.Helpers
{
    public static class ControlExtentions
    {
        public static Control FindControl(this Control root, string name)
        {
            if (root == null) 
                throw new ArgumentNullException("root");
            foreach (Control child in root.Controls)
            {
                if (child.Name == name) 
                    return child;
                Control found = FindControl(child, name);
                if (found != null) 
                    return found;
            }
            return null;
        }

        public static Control FindControlByPartOfName(this Control root, string name)
        {
            if (root == null)
                throw new ArgumentNullException("root");
            foreach (Control child in root.Controls)
            {
                if (child.Name.IndexOf(name) > -1)
                    return child;
                Control found = FindControlByPartOfName(child, name);
                if (found != null)
                    return found;
            }
            return null;
        }
    }
}
