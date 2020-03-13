using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace WpfApp.Classes.Extensions
{
    public static class TreeViewEx
    {
        /// <summary>
        /// Select specified item in a TreeView
        /// </summary>
        public static void SelectItem(this TreeView treeView, object item)
        {
            var tvItem = treeView.ItemContainerGenerator.ContainerFromItem(item) as TreeViewItem;
            if (tvItem != null)
            {
                tvItem.IsSelected = true;
                treeView.Items.MoveCurrentTo(tvItem.DataContext);
            }
        }
    }


    public static class TextBoxEx
    {
        public static void MoveToLineStart(this TextBox textBox, int lineNumber)
        {
            var skipChars = textBox.GetCharacterIndexFromLineIndex(lineNumber);
            textBox.Select(skipChars, 0);
            textBox.Focus();
            textBox.ScrollToLine(lineNumber);
        }

        public static void MoveToLineEnd(this TextBox textBox, int lineNumber)
        {
            int skipChars = textBox.GetCharacterIndexFromLineIndex(lineNumber + 1);
            if (skipChars == -1)   //to check for last line
            {
                textBox.Select(textBox.Text.Length, 0);
            }
            else
            {
                textBox.Select(skipChars - 1, 0);
            }
            textBox.Focus();
            textBox.ScrollToLine(lineNumber);
        }
    }

}
