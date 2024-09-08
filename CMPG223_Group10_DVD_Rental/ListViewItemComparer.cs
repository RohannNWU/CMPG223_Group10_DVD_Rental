/*
 * CMPG223 Project - G10 DVD Rentals
 * Date Created: 03/08/2024
 * Rohann Venter, 25130757
 * Jacques van Heerden, 35317906 
 * Francois Verster, 40723380
 * Stefan Venter, 39066894
 * Christo Prinsloo, 21052239
 */

using System.Collections;
using System.Windows.Forms;

namespace CMPG223_Group10_DVD_Rental
{
    public class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;

        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int result;
            result = string.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            
            if (order == SortOrder.Descending)
            {
                result = -result;
            }

            return result;
        }
    }
}