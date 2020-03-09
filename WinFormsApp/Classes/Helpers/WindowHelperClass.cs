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
            bool SetColor(Control panel, bool isActive)
            {
                Color backColor, foreColor;
                if (isActive)
                {
                    backColor = SystemColors.ActiveCaption;
                    foreColor = SystemColors.ActiveCaptionText;
                }
                else
                {
                    backColor = SystemColors.InactiveCaption;
                    foreColor = SystemColors.InactiveCaptionText;
                }

                var child = panel.FindControlByPartOfName("PanelCaption");
                if (child != null)
                {
                    child.BackColor = backColor;
                    var label = child.FindControlByPartOfName("PanelLabel");
                    if (label != null)
                    {
                        label.ForeColor = foreColor;
                    }
                    return true;
                }

                if (panel.Parent is Panel parent)
                {
                    return SetColor(parent, isActive);
                }

                return false;
            }

            foreach (var window in panelsList)
            {
                SetColor(window, false);
            }

            SetColor(active, true);

        }
    }
}
