using BrightIdeasSoftware;
using EntityFrameworkComicSuiteTest.Services;
using formCustomizer;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EntityFrameworkComicSuiteTest
{
    public partial class CustomerForm : Form
    {
        FormCustomizer formCustomizer;
        ServiceCustomerForm service;

        public CustomerForm(int customerID, SqlConnectionStringBuilder sqlBuilder)
        {
            InitializeComponent();

            base.SetStyle(ControlStyles.ResizeRedraw, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Sizable;

            service = new ServiceCustomerForm(sqlBuilder, customerID);

            if (formCustomizer is null) formCustomizer = new FormCustomizer(base.Handle, this);

            formCustomizer.isDialog = true;
            SetFormCustomizerInitialColors();
            service.BorderColor = formCustomizer.BorderColor;

            RegisterEvents();

            RegisterBindings();

            SetfOlvSubscriptionsAspectGetters();
            SetfOlvSubPostingAspectGetters();
            SetfOlvSpecialOrdersAspectGetters();

            UpdateFormCustomizer();
            formCustomizer.updateControlStyles(this);
        }

        void SetFormCustomizerInitialColors()
        {
            formCustomizer.BackColor = ColorTranslator.FromHtml("#494949");
            formCustomizer.TextColor = ColorTranslator.FromHtml("#DCDCDC");
            formCustomizer.TitleTextColor = ColorTranslator.FromHtml("#DCDCDC");
            formCustomizer.MenuTextColor = ColorTranslator.FromHtml("#DCDCDC");
            formCustomizer.ControlButtonTextColor = ColorTranslator.FromHtml("#E9671B");
            formCustomizer.BorderColor = ColorTranslator.FromHtml("#E9671B");
            formCustomizer.ShadowColor = ColorTranslator.FromHtml("#292929");
            formCustomizer.TextStatusStripColor = Color.Black;
            formCustomizer.InputColor = ColorTranslator.FromHtml("#494949");
            formCustomizer.InputTextColor = ColorTranslator.FromHtml("#DCDCDC");
        }

        void RegisterEvents()
        {
            fOlvSubscriptions.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(service.fastObjectListView_FormatRow);
            fOlvSubscriptions.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(service.fOlvSubscriptions_CellClick);

            fOlvSpecialOrders.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(service.fastObjectListView_FormatRow);
            fOlvSpecialOrders.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(service.fOlvSpecialOrders_CellClick);

            fOlvSubPosting.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(service.fastObjectListView_FormatRow);

            fOlvSubPosting.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(service.fOlvSubPosting_CellClick);
        }

        void RegisterBindings()
        {
            this.DataBindings.Add(new Binding("Text", service, "Title"));
            labelWindowTitle.DataBindings.Add(new Binding("Text", service, "Title"));

            lblHeader.DataBindings.Add(new Binding("Text", service, "Header"));
            lblLastVisit.DataBindings.Add(new Binding("Text", service, "LastVisit"));
            lblTotalVisits.DataBindings.Add(new Binding("Text", service, "TotalVisits"));
            lblTotalSales.DataBindings.Add(new Binding("Text", service, "TotalSales"));
            lblTotalSavings.DataBindings.Add(new Binding("Text", service, "TotalSavings"));
            lblAccountOpened.DataBindings.Add(new Binding("Text", service, "AccountOpened"));
            lblPhone.DataBindings.Add(new Binding("Text", service, "Phone"));
            lblEmail.DataBindings.Add(new Binding("Text", service, "Email"));

            txtNotes.DataBindings.Add(new Binding("Text", service, "Notes"));

            gbSubscriptions.DataBindings.Add(new Binding("Text", service, "SubscriptionsLabel"));
            gbSpecialOrders.DataBindings.Add(new Binding("Text", service, "SpecialOrdersLabel"));
            gbSubscriptionPostings.DataBindings.Add(new Binding("Text", service, "SubscriptionsPostingLabel"));
        }



        void SetfOlvSubscriptionsAspectGetters()
        {
            olvColSubSeriesCode.AspectGetter = delegate (object x)
            {
                return ((CustSeries)x).SeriesCode;
            };
            olvColSubSeriesName.AspectGetter = delegate (object x)
            {
                DCDSeries s = service.db.DCDSeries.First(z => z.code == ((CustSeries)x).SeriesCode);
                return s.description;
            };
            olvColSubQty.AspectGetter = delegate (object x)
            {
                return ((CustSeries)x).Quantity;
            };
            olvColSubAvtive.AspectGetter = delegate (object x)
            {
                return ((CustSeries)x).IsActive;
            };
            olvColSubVarient.AspectGetter = delegate (object x)
            {
                return ((CustSeries)x).VariantNo;
            };
            olvColSubCreated.AspectGetter = delegate (object x)
            {
                return ((CustSeries)x).CreatedDate;
            };
        }

        void SetfOlvSpecialOrdersAspectGetters()
        {
            olvColSoItem.AspectGetter = delegate (object x)
            {
                return ((SpecialOrder)x).Diamdno;
            };
            olvColSoQty.AspectGetter = delegate (object x)
            {
                return ((SpecialOrder)x).QtyOrdered;
            };
            olvColSoDesc.AspectGetter = delegate (object x)
            {
                Item item = service.db.Item.Find(((SpecialOrder)x).ItemId);
                return $"{item.Description} {item.SubDescription1} {item.SubDescription2} {item.SubDescription3}";
            };
            olvColSoStatus.AspectGetter = delegate (object x)
            {
                return GetStatus(((SpecialOrder)x).status);
            };
        }

        void SetfOlvSubPostingAspectGetters()
        {
            olvColSpItem.AspectGetter = delegate (object x)
            {
                Alias alias = service.db.Aliases.FirstOrDefault(w => w.ItemID == ((CustSeriesPosting)x).itemid);
                return alias.alias;
            };
            olvColSpQty.AspectGetter = delegate (object x)
            {
                return ((CustSeriesPosting)x).subqty;
            };
            olvColSpDesc.AspectGetter = delegate (object x)
            {
                Item item = service.db.Item.Find(((CustSeriesPosting)x).itemid);
                return $"{item.Description} {item.SubDescription1} {item.SubDescription2} {item.SubDescription3}";
            };
            olvColSpStatus.AspectGetter = delegate (object x)
            {
                return GetStatus(((CustSeriesPosting)x).status);
            };
        }

        string GetStatus(int i)
        {
            switch (i)
            {
                case 0:
                    return "Created";
                case 2:
                    return "Posted";
                case 3:
                    return "On Order";
                case 4:
                    return "PreContact";
                case 6:
                    return "Received";
                case 10:
                    return "Contacted";
            }

            return i.ToString();
        }

        void UpdateFormCustomizer()
        {
            formCustomizer.setTitleBar(panelControlBox);
            formCustomizer.setTitleLabel(labelWindowTitle);
            formCustomizer.setIcon(pictureBoxWindowicon);
            formCustomizer.setCloseButton(buttonClose);
            formCustomizer.setMaxiButton(buttonMax);
            formCustomizer.setMiniButton(buttonMin);


            splitContainer1.BackColor = formCustomizer.BorderColor;
            splitContainer1.Panel1.BackColor = formCustomizer.BackColor;
            splitContainer1.Panel2.BackColor = formCustomizer.BackColor;
            splitContainer1.SplitterWidth = 2;

            splitContainer2.BackColor = formCustomizer.BorderColor;
            splitContainer2.Panel1.BackColor = formCustomizer.BackColor;
            splitContainer2.Panel2.BackColor = formCustomizer.BackColor;
            splitContainer2.SplitterWidth = 2;

            panelContent.BackColor = formCustomizer.BackColor;
            fOlvSubscriptions.BackColor = formCustomizer.BackColor;
            fOlvSubscriptions.ForeColor = Color.WhiteSmoke;
            fOlvSubscriptions.AlternateRowBackColor = formCustomizer.ShadowColor;

            fOlvSubscriptions.SelectedBackColor = formCustomizer.BorderColor;
            fOlvSubscriptions.SelectedForeColor = Color.Black;

            fOlvSpecialOrders.BackColor = formCustomizer.BackColor;
            fOlvSpecialOrders.ForeColor = Color.WhiteSmoke;
            fOlvSpecialOrders.AlternateRowBackColor = formCustomizer.ShadowColor;
                              
            fOlvSpecialOrders.SelectedBackColor = formCustomizer.BorderColor;
            fOlvSpecialOrders.SelectedForeColor = Color.Black;


            fOlvSubPosting.BackColor = formCustomizer.BackColor;
            fOlvSubPosting.ForeColor = Color.WhiteSmoke;
            fOlvSubPosting.AlternateRowBackColor = formCustomizer.ShadowColor;

            fOlvSubPosting.SelectedBackColor = formCustomizer.BorderColor;
            fOlvSubPosting.SelectedForeColor = Color.Black;

            foreach (OLVColumn item in fOlvSubscriptions.Columns)
            {
                var headerstyle = new HeaderFormatStyle();
                headerstyle.SetBackColor(formCustomizer.BackColor);
                headerstyle.SetForeColor(Color.WhiteSmoke);
                item.HeaderFormatStyle = headerstyle;
            }
            foreach (OLVColumn item in fOlvSpecialOrders.Columns)
            {
                var headerstyle = new HeaderFormatStyle();
                headerstyle.SetBackColor(formCustomizer.BackColor);
                headerstyle.SetForeColor(Color.WhiteSmoke);
                item.HeaderFormatStyle = headerstyle;
            }

            foreach (OLVColumn item in fOlvSubPosting.Columns)
            {
                var headerstyle = new HeaderFormatStyle();
                headerstyle.SetBackColor(formCustomizer.BackColor);
                headerstyle.SetForeColor(Color.WhiteSmoke);
                item.HeaderFormatStyle = headerstyle;
            }

        }

        protected override void WndProc(ref Message m)
        {
            if (formCustomizer is null) formCustomizer = new FormCustomizer(base.Handle, this);
            if (formCustomizer.pWndProc(ref m)) base.WndProc(ref m);
        }

        internal void CustForm_Load(object sender, EventArgs e)
        {
            fOlvSubscriptions.SetObjects(service.Customer.CustSeries);
            fOlvSpecialOrders.SetObjects(service.Customer.SpecialOrders);
            fOlvSubPosting.SetObjects(service.Customer.CustSeriesPosted);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Dispose();
        }

        protected override void Dispose(bool disposing)
        {
            if (service != null) service.Dispose();
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

    }
}
