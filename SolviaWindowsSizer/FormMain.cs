using SolviaWindowsSizer.Helpers;
using SolviaWindowsSizer.Extensions;
using System;
using System.Text;
using System.Windows.Forms;

namespace SolviaWindowsSizer
{
    public partial class FormMain : Form
    {
        ListViewItemComparer lvwColumnSorter = new ListViewItemComparer();
        public FormMain()
        {
            InitializeComponent();

            // Add columns to the ListView.
            listViewWindows.Columns.Add("Window Title", -2, HorizontalAlignment.Left);
            listViewWindows.Columns.Add("hWnd", -2, HorizontalAlignment.Left);

            // Wire events
            listViewWindows.SelectedIndexChanged += listViewWindows_SelectedIndexChanged;
            listViewWindows.ItemActivate += new EventHandler(listViewWindows_ItemActivate);
            listViewWindows.ColumnClick += new ColumnClickEventHandler(listViewWindows_ColumnClick);

            // labelHints
            labelHints2.AutoSize = true;  // Enable auto-sizing
            labelHints2.AutoEllipsis = true;  // Show ellipsis if the text is trimmed


            // Enumerate windows and add them to the ListView.
            EnumerateWindowsAndAddToListView();
        }

        private void listViewWindows_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listViewWindows.ListViewItemSorter = lvwColumnSorter;

            // Prüfe, ob die angeklickte Spalte bereits die Sortierspalte ist.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Wechsle die Sortierreihenfolge
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Setze die Sortierspalte auf die neue Spalte
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Führe die Sortierung mit den neuen Einstellungen aus
            this.listViewWindows.Sort();
        }

        private void EnumerateWindowsAndAddToListView()
        {
            listViewWindows.Items.Clear(); // Clear existing items.

            Win32Api.EnumWindows((hWnd, lParam) =>
            {
                int length = Win32Api.GetWindowTextLength(hWnd);
                if (length > 0 && Win32Api.IsWindowVisible(hWnd))
                {
                    StringBuilder builder = new StringBuilder(length + 1);
                    Win32Api.GetWindowText(hWnd, builder, length + 1);
                    ListViewItem item = new ListViewItem(builder.ToString());
                    item.SubItems.Add(hWnd.ToString());
                    item.Tag = hWnd; // Store the window handle in the Tag property.
                    listViewWindows.Items.Add(item);
                }
                return true; // Continue enumeration
            }, 0);

            listViewWindows.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewWindows.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ResizeSelectedWindow()
        {
            if (listViewWindows.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewWindows.SelectedItems[0];
                int resultX, resultY;
                bool bx = int.TryParse(textBoxX.Text, out resultX);
                bool by = int.TryParse(textBoxY.Text, out resultY);

                if (bx && by)
                {
                    IntPtr hWnd = (IntPtr)item.Tag;
                    if (hWnd != IntPtr.Zero)
                    {
                        if (Win32Api.IsIconic(hWnd))
                        {
                            var swr = Win32Api.ShowWindow(hWnd, Win32Api.SW_RESTORE);
                        }
                        var sw = Win32Api.ShowWindow(hWnd, Win32Api.SW_SHOW);
                        var sfw = Win32Api.SetForegroundWindow(hWnd);
                        var mw = Win32Api.MoveWindow(hWnd, 10, 10, resultX, resultY, true);
                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F5))
            {
                EnumerateWindowsAndAddToListView();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void listViewWindows_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResizeSelectedWindow();
        }

        private void listViewWindows_ItemActivate(object sender, EventArgs e)
        {
            ResizeSelectedWindow();
        }
    }
}