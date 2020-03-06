using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Classes.Helpers
{
    internal static class WindowHelperClass
    {
        internal static void SetActivePanel(List<Panel> panelsList, Control active)
        {
            bool SetColor(Control panel, Color color)
            {
                foreach (Control child in panel.Controls)
                {
                    if (child.Name.IndexOf("PanelCaption") > -1)
                    {
                        child.BackColor = color;
                        return true;
                    }
                }

                if (panel.Parent is Panel parent)
                {
                    return SetColor(parent, color);
                }

                return false;
            }

            foreach (var window in panelsList)            
            {
                SetColor(window, SystemColors.InactiveCaption);
            }

            SetColor(active, SystemColors.ActiveCaption);

        }
    }
}
