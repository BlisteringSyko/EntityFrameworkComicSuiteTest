using BrightIdeasSoftware;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EntityFrameworkComicSuiteTest.Services
{
    class ServiceForm1 : IDisposable
    {

        public Model1 db { get; set; }
        public string Title { get; set; }
        public string StatusLabel { get; set; }
        public string LoadingLabel { get; set; }
        public Color BorderColor { get; set; }
        public Color BackColor { get; set; }

        OLVListItem _olvSelectedListItem;
        int _olvSelectedSubItemIndex;
        bool _canEdit;

        bool is_odd(int n)
        {
            return n % 2 != 0;
        }

        readonly SqlConnectionStringBuilder sqlBuilder;

        public ServiceForm1(SqlConnectionStringBuilder sqlBuilder)
        {
            this.sqlBuilder = sqlBuilder;
            db = new Model1(sqlBuilder.ToString());
            Title = $"CS Customers  (db: {sqlBuilder.InitialCatalog})";
            StatusLabel = "Customers: " + db.Customers.Count();

            _olvSelectedListItem = null;
            _olvSelectedSubItemIndex = 0;
            _canEdit = false;
        }

        internal void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(_olvSelectedListItem is null))
            {
                ToolStripItem x = (ToolStripItem)sender;
                ContextMenuStrip c = (ContextMenuStrip)x.Owner;
                FastObjectListView f = (FastObjectListView)c.SourceControl;
                f.EditSubItem(_olvSelectedListItem, _olvSelectedSubItemIndex);
            }
        }

        internal void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.showConnectForm();
        }

        internal void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (_olvSelectedListItem is null || !_canEdit) e.Cancel = true;
        }

        internal void fastObjectListView1_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                Thread _thread = new Thread(() =>
                {
                    CustomerForm customerForm = new CustomerForm(((Customer)e.Model).ID, sqlBuilder);
                    Application.Run(customerForm);
                });
                _thread.SetApartmentState(ApartmentState.STA);
                _thread.Start();

            }
        }

        internal void fastObjectListView1_CellRightClick(object sender, CellRightClickEventArgs e)
        {
            if (!(e.Item is null) && e.ColumnIndex < e.ListView.Columns.Count - 1)
            {
                _olvSelectedListItem = e.Item;
                _olvSelectedSubItemIndex = e.ColumnIndex;
                if (e.Column.IsEditable) _canEdit = true; else _canEdit = false;
            } else
            {
                _olvSelectedListItem = null;
                _olvSelectedSubItemIndex = 0;
            }
        }

        internal void fastObjectListView1_CellEditFinished(object sender, CellEditEventArgs e)
        {
            if (e.Value != e.NewValue)
            {
                db.SaveChanges();
            }
        }

        internal void fastObjectListView1_FormatCell(object sender, FormatCellEventArgs e)
        {
            Customer customer = (Customer)e.Model;
            Color bcolor = BorderColor;
            
            if (((FastObjectListView)sender).SelectedIndex != -1 && ((Customer)((FastObjectListView)sender).SelectedObjects[0]).Equals(customer))
            {
                    bcolor = Color.Black;
            }

            if (e.Column.IsVisible)
            {
                switch (is_odd(e.ColumnIndex))
                {
                    case true:
                        e.SubItem.Decoration = new CellBorderDecoration()
                        {
                            BoundsPadding = new Size(-2, 0),
                            BorderPen = new Pen(bcolor),
                            FillBrush = null,
                            CornerRounding = 0
                        };
                        break;
                    case false:
                        e.SubItem.Decoration = new CellBorderDecoration()
                        {
                            BoundsPadding = new Size(2, 0),
                            BorderPen = new Pen(bcolor),
                            FillBrush = null,
                            CornerRounding = 0
                        };
                        break;
                }

                switch (e.ColumnIndex)
                {
                    case 0:
                        // the first column is kind of weird, 
                        //the defualt bounds push the left side out of view, 
                        //and pulls the right over by a single pixel. 
                        //Everything above is to adjust the rest to make a uniform grid

                        e.SubItem.Decoration = new CellBorderDecoration()
                        {
                            BoundsPadding = new Size(1, 0),
                            BorderPen = new Pen(bcolor),
                            FillBrush = null,
                            CornerRounding = 0
                        };
                        break;
                    case 12:
                        // the last column fills the empty space to the right of the grid.
                        e.SubItem.Decoration = new CellBorderDecoration()
                        {
                            BoundsPadding = new Size(1, 1),
                            BorderPen = null,
                            FillBrush = new SolidBrush(BackColor),
                            CornerRounding = 0
                        };
                        break;
                }
            }

        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Program.showConnectForm();
                    db.Dispose();
                }


                disposedValue = true;
            }
        }

        ~ServiceForm1()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
