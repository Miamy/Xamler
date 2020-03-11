using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamlerModel;
using System.IO;
using System.Runtime.InteropServices;
using XamlerModel.Classes;

namespace WinFormsApp.Controls
{
    public partial class XamlDocumentEditor : UserControl
    {
        public XamlDocument Xaml { get; set; }

        public XamlDocumentEditor(XamlDocument xaml)
        {
            InitializeComponent();

            Xaml = xaml;
            LoadFromFile(Xaml);

            codeEditor.Buddy = numbers;
        }

        private async void LoadFromFile(XamlDocument xaml)
        {
            if (!File.Exists(xaml.FileName))
                throw new FileNotFoundException();

            using (var reader = File.OpenText(xaml.FileName))
            {
                codeEditor.Text = await reader.ReadToEndAsync();
            }


            numbers.Visible = false;
            numbers.Clear();
            for (var i = 1; i < codeEditor.Lines.Length; i++)
                numbers.AppendText(i.ToString() + Environment.NewLine);
            numbers.Visible = true;
        }

        public void Save()
        {
        }

        private void codeEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void UpdateInterface()
        {
            var caret_pos = codeEditor.GetCaretPosition();
            positionLabel.Text = $"Ln: {caret_pos.Y} Ch: {caret_pos.X}";
        }

        private void codeEditor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void codeEditor_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInterface();
        }

        private void codeEditor_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateInterface();
        }
    }


    public static class TextBoxExtentions
    {
        public static Point GetCaretPosition(this TextBox textBox)
        {
            int s = textBox.SelectionStart;
            int y = textBox.GetLineFromCharIndex(s);
            int x = s - textBox.GetFirstCharIndexFromLine(y);

            return new System.Drawing.Point(x + 1, y + 1);
        }
    }
}
