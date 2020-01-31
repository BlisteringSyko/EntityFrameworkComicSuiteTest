using BrightIdeasSoftware;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace EntityFrameworkComicSuiteTest.Services
{
    class ServiceCustomerForm : IDisposable
    {
        public Model1 db { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }

        public Customer Customer { get; set; }

        bool _changeMade = false;
        public Color BorderColor { get; set; }

        public string Label1 { get; set; }
        public string LastVisit { get; set; }
        public string TotalVisits { get; set; }
        public string TotalSales { get; set; }
        public string TotalSavings { get; set; }
        public string AccountOpened { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes
        {
            get
            {
                return Customer.Notes;
            }
            set
            {
                Customer.Notes = value;
                _changeMade = true;
            } 
        }
        public string SubscriptionsLabel { get; set; }
        public string SubscriptionsPostingLabel { get; set; }
        public string SpecialOrdersLabel { get; set; }

        public ServiceCustomerForm(SqlConnectionStringBuilder sqlBuilder, int customerID)
        {
            db = new Model1(sqlBuilder.ToString());

            Customer = (db.Customers.First(x => x.ID == customerID));

            Title = $"{Customer.LastName}, {Customer.FirstName}  ({Customer.AccountNumber}) (db: {sqlBuilder.InitialCatalog})";

            Label1 = $"{Customer.LastName}, {Customer.FirstName}  ({Customer.AccountNumber})";
            LastVisit = "Last Visit: " + Customer.LastVisit.ToString("MMMM dd, yyyy  h:mm:ss tt");
            TotalVisits = "Total Visits: " + Customer.TotalVisits;
            TotalSales = "Total Sales: " + string.Format(new CultureInfo("en-US", false), "{0:c2}", Customer.TotalSales);
            TotalSavings = "Total Savings: " + string.Format(new CultureInfo("en-US", false), "{0:c2}", Customer.TotalSavings);
            AccountOpened = "Account Opened: " + Customer.AccountOpened.ToString("MMMM dd, yyyy  h:mm:ss tt");
            Phone = "Phone: " + Customer.PhoneNumber;
            Email = "Email: " + Customer.EmailAddress;
            
            SubscriptionsLabel = $"Subscriptions ({Customer.CustSeries.Count})";
            SpecialOrdersLabel = $"Special Order Postings ({Customer.SpecialOrders.Count})";
            SubscriptionsPostingLabel = $"Subscription Postings ({Customer.CustSeriesPosted.Count})";
        }

        internal void fastObjectListView1_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                string n = Regex.Replace(e.Item.SubItems[1].Text.Trim(), @"\s+", "-").ToUpper();
                Process.Start($"https://www.previewsworld.com/Catalog/Series/{((CustSeries)e.Model).SeriesCode}-{n}");
                e.Handled = true;
            }
        }

        internal void fastObjectListView2_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                Process.Start($"https://www.previewsworld.com/Catalog/{((SpecialOrder)e.Model).Diamdno}");
            }
        }

        internal void fastObjectListView3_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                Alias alias = db.Aliases.FirstOrDefault(w => w.ItemID == ((CustSeriesPosting)e.Model).itemid);
                Process.Start($"https://www.previewsworld.com/Catalog/{alias.alias}");
            }
        }

        internal void fastObjectListView_FormatRow(object sender, FormatRowEventArgs e)
        {
            e.Item.Decoration = new RowBorderDecoration()
            {
                BoundsPadding = new Size(2, 0),
                BorderPen = new Pen(BorderColor, 1),
                FillBrush = null,
                CornerRounding = 0
            };
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (_changeMade) db.SaveChanges();
                    db.Dispose();
                }

                disposedValue = true;
            }
        }

        ~ServiceCustomerForm()
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
