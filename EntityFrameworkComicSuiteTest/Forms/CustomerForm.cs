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

            SetOlvAspectGetters();

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
            fastObjectListView1.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(service.fastObjectListView_FormatRow);
            fastObjectListView1.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(service.fastObjectListView1_CellClick);

            fastObjectListView2.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(service.fastObjectListView_FormatRow);
            fastObjectListView2.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(service.fastObjectListView2_CellClick);

            fastObjectListView3.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(service.fastObjectListView_FormatRow);

            fastObjectListView3.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(service.fastObjectListView3_CellClick);
        }

        void RegisterBindings()
        {
            this.DataBindings.Add(new Binding("Text", service, "Title"));
            labelWindowTitle.DataBindings.Add(new Binding("Text", service, "Title"));

            label1.DataBindings.Add(new Binding("Text", service, "Label1"));
            label2.DataBindings.Add(new Binding("Text", service, "LastVisit"));
            label3.DataBindings.Add(new Binding("Text", service, "TotalVisits"));
            label4.DataBindings.Add(new Binding("Text", service, "TotalSales"));
            label5.DataBindings.Add(new Binding("Text", service, "TotalSavings"));
            label6.DataBindings.Add(new Binding("Text", service, "AccountOpened"));
            label7.DataBindings.Add(new Binding("Text", service, "Phone"));
            label8.DataBindings.Add(new Binding("Text", service, "Email"));

            textBox1.DataBindings.Add(new Binding("Text", service, "Notes"));

            groupBox1.DataBindings.Add(new Binding("Text", service, "SubscriptionsLabel"));
            groupBox2.DataBindings.Add(new Binding("Text", service, "SpecialOrdersLabel"));
            groupBox4.DataBindings.Add(new Binding("Text", service, "SubscriptionsPostingLabel"));
        }

        void SetOlvAspectGetters()
        {
            olvColumn1.AspectGetter = delegate (object x)
            {
                return ((CustSeries)x).SeriesCode;
            };
            olvColumn2.AspectGetter = delegate (object x)
            {
                DCDSeries s = service.db.DCDSeries.First(z => z.code == ((CustSeries)x).SeriesCode);
                return s.description;
            };
            olvColumn3.AspectGetter = delegate (object x)
            {
                return ((CustSeries)x).Quantity;
            };
            olvColumn4.AspectGetter = delegate (object x)
            {
                return ((CustSeries)x).IsActive;
            };
            olvColumn5.AspectGetter = delegate (object x)
            {
                return ((CustSeries)x).VariantNo;
            };
            olvColumn6.AspectGetter = delegate (object x)
            {
                return ((CustSeries)x).CreatedDate;
            };
            olvColumn7.AspectGetter = delegate (object x)
            {
                return ((SpecialOrder)x).Diamdno;
            };
            olvColumn8.AspectGetter = delegate (object x)
            {
                return ((SpecialOrder)x).QtyOrdered;
            };
            olvColumn9.AspectGetter = delegate (object x)
            {
                Item item = service.db.Item.Find(((SpecialOrder)x).ItemId);
                return $"{item.Description} {item.SubDescription1} {item.SubDescription2} {item.SubDescription3}";
            };
            olvColumn10.AspectGetter = delegate (object x)
            {
                Alias alias = service.db.Aliases.FirstOrDefault(w => w.ItemID == ((CustSeriesPosting)x).itemid);
                return alias.alias;
            };
            olvColumn11.AspectGetter = delegate (object x)
            {
                return ((CustSeriesPosting)x).subqty;
            };
            olvColumn12.AspectGetter = delegate (object x)
            {
                Item item = service.db.Item.Find(((CustSeriesPosting)x).itemid);
                return $"{item.Description} {item.SubDescription1} {item.SubDescription2} {item.SubDescription3}";
            };
            olvColumn13.AspectGetter = delegate (object x)
            {
                return GetStatus(((SpecialOrder)x).status);
            };
            olvColumn14.AspectGetter = delegate (object x)
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
            fastObjectListView1.BackColor = formCustomizer.BackColor;
            fastObjectListView1.ForeColor = Color.WhiteSmoke;
            fastObjectListView1.AlternateRowBackColor = formCustomizer.ShadowColor;

            fastObjectListView1.SelectedBackColor = formCustomizer.BorderColor;
            fastObjectListView1.SelectedForeColor = Color.Black;

            fastObjectListView2.BackColor = formCustomizer.BackColor;
            fastObjectListView2.ForeColor = Color.WhiteSmoke;
            fastObjectListView2.AlternateRowBackColor = formCustomizer.ShadowColor;
                              
            fastObjectListView2.SelectedBackColor = formCustomizer.BorderColor;
            fastObjectListView2.SelectedForeColor = Color.Black;


            fastObjectListView3.BackColor = formCustomizer.BackColor;
            fastObjectListView3.ForeColor = Color.WhiteSmoke;
            fastObjectListView3.AlternateRowBackColor = formCustomizer.ShadowColor;

            fastObjectListView3.SelectedBackColor = formCustomizer.BorderColor;
            fastObjectListView3.SelectedForeColor = Color.Black;

            foreach (OLVColumn item in fastObjectListView1.Columns)
            {
                var headerstyle = new HeaderFormatStyle();
                headerstyle.SetBackColor(formCustomizer.BackColor);
                headerstyle.SetForeColor(Color.WhiteSmoke);
                item.HeaderFormatStyle = headerstyle;
            }
            foreach (OLVColumn item in fastObjectListView2.Columns)
            {
                var headerstyle = new HeaderFormatStyle();
                headerstyle.SetBackColor(formCustomizer.BackColor);
                headerstyle.SetForeColor(Color.WhiteSmoke);
                item.HeaderFormatStyle = headerstyle;
            }

            foreach (OLVColumn item in fastObjectListView3.Columns)
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
            fastObjectListView1.SetObjects(service.Customer.CustSeries);
            fastObjectListView2.SetObjects(service.Customer.SpecialOrders);
            fastObjectListView3.SetObjects(service.Customer.CustSeriesPosted);
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
