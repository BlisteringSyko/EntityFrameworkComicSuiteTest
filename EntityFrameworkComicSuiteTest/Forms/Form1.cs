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

            fastObjectListView1.Tag = this;

            service = new ServiceForm1(sqlBuilder);

            if (formCustomizer is null) formCustomizer = new FormCustomizer(base.Handle, this);

            SetFormCustomizerInitialColors();

            fastObjectListView1.AddDecoration(new EditingCellBorderDecoration { UseLightbox = true, BorderPen = new Pen(formCustomizer.BorderColor, 1), FillBrush = new SolidBrush(Color.FromArgb(230, 0, 0, 0)), BoundsPadding = new Size(2, 2), CornerRounding = 5 });

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
            fastObjectListView1.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(service.fastObjectListView1_CellClick);
            fastObjectListView1.CellEditFinished += new BrightIdeasSoftware.CellEditEventHandler(service.fastObjectListView1_CellEditFinished);
            fastObjectListView1.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(service.fastObjectListView1_CellRightClick);
            fastObjectListView1.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(service.fastObjectListView1_FormatCell);

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
            olvColumn1.AspectGetter = delegate (object x) {
                return ((Customer)x).AccountNumber;
            };
            olvColumn2.AspectGetter = delegate (object x) {
                return ((Customer)x).FirstName;
            };
            olvColumn3.AspectGetter = delegate (object x) {
                return ((Customer)x).LastName;
            };
            olvColumn4.AspectGetter = delegate (object x) {
                return ((Customer)x).SpecialOrders.Count;
            };
            olvColumn6.AspectGetter = delegate (object x)
            {
                return ((Customer)x).EmailAddress;
            };
            olvColumn7.AspectGetter = delegate (object x)
            {
                return ((Customer)x).PhoneNumber;
            };
            olvColumn8.AspectGetter = delegate (object x)
            {
                return ((Customer)x).LastVisit.ToString("yyyy/MM/dd");
            };
            olvColumn9.AspectGetter = delegate (object x)
            {
                return ((Customer)x).TotalSales;
            };
            olvColumn10.AspectGetter = delegate (object x)
            {
                return ((Customer)x).TotalSavings;
            };
            olvColumn11.AspectGetter = delegate (object x)
            {
                return ((Customer)x).ID;
            };
            olvColumn12.AspectGetter = delegate (object x)
            {
                return ((Customer)x).CustSeries.Count;
            };
            olvColumn13.AspectGetter = delegate (object x)
            {
                return ((Customer)x).AccountOpened.ToString("yyyy/MM/dd");
            };
        }

        void SetOlvAspectPutters()
        {
            olvColumn1.AspectPutter = delegate (object x, object newValue) {
                ((Customer)x).AccountNumber = newValue.ToString();
            };
            olvColumn2.AspectPutter = delegate (object x, object newValue) {
                ((Customer)x).FirstName = newValue.ToString();
            };
            olvColumn3.AspectPutter = delegate (object x, object newValue) {
                ((Customer)x).LastName = newValue.ToString();
            };
            olvColumn6.AspectPutter = delegate (object x, object newValue) {
                ((Customer)x).EmailAddress = newValue.ToString();
            };
            olvColumn7.AspectPutter = delegate (object x, object newValue) {
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
            label1.Visible = true;
            fastObjectListView1.Visible = false;

            fastObjectListView1.SetObjects(service.db.Customers);

            label1.Text = "Generating Indexes!";
            this.Refresh();

            fastObjectListView1.Sort(olvColumn12, System.Windows.Forms.SortOrder.Ascending);

            label1.Text = "EVEN MORE Indexes!";
            this.Refresh();

            fastObjectListView1.Sort(olvColumn4, System.Windows.Forms.SortOrder.Ascending);

            label1.Text = "Sorting Last Names!";
            this.Refresh();

            fastObjectListView1.Sort(olvColumn3, System.Windows.Forms.SortOrder.Ascending);

            label1.Text = "Ta da!";
            this.Refresh();

            fastObjectListView1.Visible = true;
            label1.Visible = false;
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

            fastObjectListView1.BackColor = formCustomizer.BackColor;
            fastObjectListView1.ForeColor = Color.WhiteSmoke;
            fastObjectListView1.AlternateRowBackColor = formCustomizer.ShadowColor;

            fastObjectListView1.SelectedBackColor = formCustomizer.BorderColor;
            fastObjectListView1.SelectedForeColor = Color.Black;

            foreach (OLVColumn item in fastObjectListView1.Columns)
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
