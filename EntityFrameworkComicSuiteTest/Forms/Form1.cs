using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using EntityFrameworkComicSuiteTest.Services;
using formCustomizer;

namespace EntityFrameworkComicSuiteTest
{
    public partial class Form1 : Form
    {

        public FormCustomizer formCustomizer { get; set; }
        ServiceForm1 service;

        public Form1(SqlConnectionStringBuilder sqlBuilder)
        {
            InitializeComponent();

            base.SetStyle(ControlStyles.ResizeRedraw, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Sizable;

            fOlvCustomers.Tag = this;

            service = new ServiceForm1(sqlBuilder);

            if (formCustomizer is null) formCustomizer = new FormCustomizer(base.Handle, this);

            SetFormCustomizerInitialColors();

            fOlvCustomers.AddDecoration(new EditingCellBorderDecoration { UseLightbox = true, BorderPen = new Pen(formCustomizer.BorderColor, 1), FillBrush = new SolidBrush(Color.FromArgb(230, 0, 0, 0)), BoundsPadding = new Size(2, 2), CornerRounding = 5 });

            RegisterEvents();

            RegisterBindings();

            SetOlvAspectGetters();

            SetOlvAspectPutters();

            UpdateFormCustomizer();
            formCustomizer._exclusions.Add(panelStatusStrip);
            formCustomizer._exclusions.Add(labelStatusStrip);
            formCustomizer.updateControlStyles(this);       
        }

        void SetFormCustomizerInitialColors()
        {
            formCustomizer.BackColor = ColorTranslator.FromHtml("#494949");
            formCustomizer.TextColor = ColorTranslator.FromHtml("#E9671B");
            formCustomizer.TitleTextColor = ColorTranslator.FromHtml("#DCDCDC");
            formCustomizer.MenuTextColor = ColorTranslator.FromHtml("#DCDCDC");
            formCustomizer.ControlButtonTextColor = ColorTranslator.FromHtml("#E9671B");
            formCustomizer.BorderColor = ColorTranslator.FromHtml("#E9671B");
            formCustomizer.ShadowColor = ColorTranslator.FromHtml("#292929");
            formCustomizer.TextStatusStripColor = Color.White;
        }

        void RegisterEvents()
        {
            fOlvCustomers.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(service.fOlvCustomers_CellClick);
            fOlvCustomers.CellEditFinished += new BrightIdeasSoftware.CellEditEventHandler(service.fOlvCustomers_CellEditFinished);
            fOlvCustomers.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(service.fOlvCustomers_CellRightClick);
            fOlvCustomers.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(service.fOlvCustomers_FormatCell);

            exitToolStripMenuItem.Click += new System.EventHandler(service.exitToolStripMenuItem_Click);

            editToolStripMenuItem.Click += new System.EventHandler(service.editToolStripMenuItem_Click);

            connectToolStripMenuItem.Click += new System.EventHandler(service.connectToolStripMenuItem_Click);

            contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(service.contextMenuStrip1_Opening);
        }

        void RegisterBindings()
        {
            this.DataBindings.Add(new Binding("Text", service, "Title"));
            labelWindowTitle.DataBindings.Add(new Binding("Text", service, "Title"));

            labelStatusStrip.DataBindings.Add(new Binding("Text", service, "StatusLabel"));
        }

        void SetOlvAspectGetters()
        {
            olvCustAccontNumber.AspectGetter = delegate (object x) {
                return ((Customer)x).AccountNumber;
            };
            olvCustFirstName.AspectGetter = delegate (object x) {
                return ((Customer)x).FirstName;
            };
            olvCustLastName.AspectGetter = delegate (object x) {
                return ((Customer)x).LastName;
            };
            olvCustSO.AspectGetter = delegate (object x) {
                return ((Customer)x).SpecialOrders.Count;
            };
            olvCustEmail.AspectGetter = delegate (object x)
            {
                return ((Customer)x).EmailAddress;
            };
            olvCustPhone.AspectGetter = delegate (object x)
            {
                return ((Customer)x).PhoneNumber;
            };
            olvCustLastVisit.AspectGetter = delegate (object x)
            {
                return ((Customer)x).LastVisit.ToString("yyyy/MM/dd");
            };
            olvCustSpent.AspectGetter = delegate (object x)
            {
                return ((Customer)x).TotalSales;
            };
            olvCustSaved.AspectGetter = delegate (object x)
            {
                return ((Customer)x).TotalSavings;
            };
            olvCustCsId.AspectGetter = delegate (object x)
            {
                return ((Customer)x).ID;
            };
            olvCustSubs.AspectGetter = delegate (object x)
            {
                return ((Customer)x).CustSeries.Count;
            };
            olvCustJoined.AspectGetter = delegate (object x)
            {
                return ((Customer)x).AccountOpened.ToString("yyyy/MM/dd");
            };
        }

        void SetOlvAspectPutters()
        {
            olvCustAccontNumber.AspectPutter = delegate (object x, object newValue) {
                ((Customer)x).AccountNumber = newValue.ToString();
            };
            olvCustFirstName.AspectPutter = delegate (object x, object newValue) {
                ((Customer)x).FirstName = newValue.ToString();
            };
            olvCustLastName.AspectPutter = delegate (object x, object newValue) {
                ((Customer)x).LastName = newValue.ToString();
            };
            olvCustEmail.AspectPutter = delegate (object x, object newValue) {
                ((Customer)x).EmailAddress = newValue.ToString();
            };
            olvCustPhone.AspectPutter = delegate (object x, object newValue) {
                ((Customer)x).PhoneNumber = newValue.ToString();
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Task.Factory.StartNew
            (() => {
                 Thread.Sleep(500);
                 Invoke(new Action(load)); // to give the form time to actually display before loading the listview, so that the user can see some sort of loading progress.
            });
        }

        void load()
        {
            lblLoadStatus.Visible = true;
            fOlvCustomers.Visible = false;

            fOlvCustomers.SetObjects(service.db.Customers);

            lblLoadStatus.Text = "Generating Indexes!";
            this.Refresh();

            fOlvCustomers.Sort(olvCustSubs, System.Windows.Forms.SortOrder.Ascending);

            lblLoadStatus.Text = "EVEN MORE Indexes!";
            this.Refresh();

            fOlvCustomers.Sort(olvCustSO, System.Windows.Forms.SortOrder.Ascending);

            lblLoadStatus.Text = "Sorting Last Names!";
            this.Refresh();

            fOlvCustomers.Sort(olvCustLastName, System.Windows.Forms.SortOrder.Ascending);

            lblLoadStatus.Text = "Ta da!";
            this.Refresh();

            fOlvCustomers.Visible = true;
            lblLoadStatus.Visible = false;
        }

        void UpdateFormCustomizer()
        {
            formCustomizer.setTitleBar(panelControlBox);
            formCustomizer.setTitleLabel(labelWindowTitle);
            formCustomizer.setMenuStrip(menuStrip1);
            formCustomizer.setIcon(pictureBoxWindowicon);
            formCustomizer.setCloseButton(buttonClose);
            formCustomizer.setMaxiButton(buttonMax);
            formCustomizer.setMiniButton(buttonMin);
            formCustomizer.setStatusStrip(panelStatusStrip);

            service.BackColor = formCustomizer.BackColor;
            service.BorderColor = formCustomizer.BorderColor;
            
            panelContent.BackColor = formCustomizer.BackColor;

            panelStatusStrip.BackColor = formCustomizer.BorderColor;
            labelStatusStrip.ForeColor = formCustomizer.TextStatusStripColor;

            fOlvCustomers.BackColor = formCustomizer.BackColor;
            fOlvCustomers.ForeColor = Color.WhiteSmoke;
            fOlvCustomers.AlternateRowBackColor = formCustomizer.ShadowColor;

            fOlvCustomers.SelectedBackColor = formCustomizer.BorderColor;
            fOlvCustomers.SelectedForeColor = Color.Black;

            foreach (OLVColumn item in fOlvCustomers.Columns)
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
