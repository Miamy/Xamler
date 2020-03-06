using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XamlerModel
{
    public class XamlData
    {
        public string FileName { get; set; }
        public XmlDocument Dom { get; set; }

        public XamlData(string filename)
        {
            FileName = filename;
            LoadFromFile();
            CreateAndLoadDom();
        }

        private void CreateAndLoadDom()
        {
            try
            {
                Dom = new XmlDocument();
                Dom.Load(FileName);
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadFromFile()
        {
            if (!File.Exists(FileName))
                throw new FileNotFoundException();
        }
    }
}
