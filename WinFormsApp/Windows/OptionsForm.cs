using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Windows
{
    public partial class OptionsForm : Form
    {

        Dictionary<int, string> children;

        public OptionsForm()
        {
            InitializeComponent();

            children = new Dictionary<int, string>
            {
                { 0, "ColorsOptions" },
                { 1,  "XamarinOptions" }
            };
        }

        private void optionsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            containerPanel.Controls.Clear();
            if (e.Node == null || e.Node.Tag == null)
            {
                return;
            }

            if (!int.TryParse(e.Node.Tag.ToString(), out var panelIndex))
            {
                return;
            }

            if (!children.Keys.Contains(panelIndex))
            {
                return;
            }

            var type = Assembly.GetExecutingAssembly().GetType("WinFormsApp.Windows.OptionsChildren." + children[panelIndex]);
            if (type == null)
            {
                return;
            }

            var child = (UserControl)Activator.CreateInstance(type);
            child.Parent = containerPanel;
        }
    }
}
