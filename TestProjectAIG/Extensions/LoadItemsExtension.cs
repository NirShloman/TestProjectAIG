using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProjectAIG.Extensions
{
    public static class LoadItemsExtension
    {
        public static void LoadItemsToCheckedListBox(this CheckedListBox checkedListBox, List<string> items)
        {
            foreach (var item in items)
            {
                checkedListBox.Items.Add(item);
            }
        }

        public static void LoadItemsToComboBox(this ComboBox comboBox, List<string> items)
        {
            foreach (var item in items)
            {
                comboBox.Items.Add(item);
            }
        }
    }
}