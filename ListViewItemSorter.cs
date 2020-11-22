using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ListViewRepro
{
    class ListViewItemSorter : Comparer<ListViewItem>
    {
        public override int Compare(ListViewItem x, ListViewItem y)
        {
            return StringComparer.OrdinalIgnoreCase.Compare(x.Text, y.Text);
        }
    }
}
