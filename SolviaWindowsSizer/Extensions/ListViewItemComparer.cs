using System.Collections;
using System.Windows.Forms;

namespace SolviaWindowsSizer.Extensions
{
    public class ListViewItemComparer : IComparer
    {
        private int col;
        public int SortColumn
        {
            get { return col; }
            set { col = value; }
        }

        private SortOrder sortOrder;
        public SortOrder Order
        {
            get { return sortOrder; }
            set { sortOrder = value; }
        }

        public ListViewItemComparer()
        {
            col = 0;
            sortOrder = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            sortOrder = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = string.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            if (sortOrder == SortOrder.Descending)
                returnVal *= -1;
            return returnVal;
        }
    }
}