using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamlerModel.Interfaces;

namespace XamlerModel.Classes
{
    internal class AppSettings : IAppSettings
    {
        public void Load(SplitContainer container)
        {
            var val = ConfigurationManager.AppSettings[container.Name + "_" + "SplitterDistance"];
            if (int.TryParse(val, out var distance))
            {
                //if (container.Panel1.Controls.Count > 0)
                //    container.Panel1.Controls[0].Dock = DockStyle.None;
                //if (container.Panel2.Controls.Count > 0)
                //    container.Panel2.Controls[0].Dock = DockStyle.None;
                
                container.SplitterDistance = distance;
                //if (container.Panel1.Controls.Count > 0)
                //    container.Panel1.Controls[0].Dock = DockStyle.Fill;
                //if (container.Panel2.Controls.Count > 0)
                //    container.Panel2.Controls[0].Dock = DockStyle.Fill;
            }
        }

        public void Save(SplitContainer container)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection appSettings = config.AppSettings;
            var key = container.Name + "_" + "SplitterDistance";
            appSettings.Settings.Remove(key);
            appSettings.Settings.Add(key, container.SplitterDistance.ToString());

            config.Save(ConfigurationSaveMode.Modified);
        }

        public void Save(Form form)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection appSettings = config.AppSettings;
            
            var key = form.Name + "_" + "WindowState";
            appSettings.Settings.Remove(key);
            appSettings.Settings.Add(key, form.WindowState.ToString());

            key = form.Name + "_" + "Width";
            appSettings.Settings.Remove(key);
            appSettings.Settings.Add(key, form.Width.ToString());

            key = form.Name + "_" + "Height";
            appSettings.Settings.Remove(key);
            appSettings.Settings.Add(key, form.Height.ToString());

            key = form.Name + "_" + "Left";
            appSettings.Settings.Remove(key);
            appSettings.Settings.Add(key, form.Left.ToString());

            key = form.Name + "_" + "Top";
            appSettings.Settings.Remove(key);
            appSettings.Settings.Add(key, form.Top.ToString());

            config.Save(ConfigurationSaveMode.Modified);
        }

        public void Load(Form form)
        {
            var val = ConfigurationManager.AppSettings[form.Name + "_" + "Width"];
            if (int.TryParse(val, out var intValue))
            {
                form.Width = intValue;
            }
            val = ConfigurationManager.AppSettings[form.Name + "_" + "Height"];
            if (int.TryParse(val, out intValue))
            {
                form.Height = intValue;
            }
            val = ConfigurationManager.AppSettings[form.Name + "_" + "Left"];
            if (int.TryParse(val, out intValue))
            {
                form.Left = intValue;
            }
            val = ConfigurationManager.AppSettings[form.Name + "_" + "Top"];
            if (int.TryParse(val, out intValue))
            {
                form.Top = intValue;
            }
            val = ConfigurationManager.AppSettings[form.Name + "_" + "WindowState"];
            if (int.TryParse(val, out intValue))
            {
                form.WindowState = (FormWindowState)intValue;
            }
        }

        public AppSettings()
        {
            var version = ConfigurationManager.AppSettings["version"];
        }
    }
}
