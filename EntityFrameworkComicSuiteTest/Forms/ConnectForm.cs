using System;
using System.Drawing;
using System.Windows.Forms;
using EntityFrameworkComicSuiteTest.Services;
using formCustomizer;

namespace EntityFrameworkComicSuiteTest
{
    public partial class ConnectForm : Form
    {

        FormCustomizer formCustomizer;
        ServiceConnectForm service;

        public ConnectForm()
        {
            InitializeComponent();

            base.SetStyle(ControlStyles.ResizeRedraw, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            button1.Tag = this;

            service = new ServiceConnectForm();

            if (formCustomizer is null) formCustomizer = new FormCustomizer(base.Handle, this);

            SetFormCustomizerInitialColors();

            RegisterEvents();

            RegisterBindings();

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
            formCustomizer.InputTextColor = ColorTranslator.FromHtml("#DCDCDC");
            formCustomizer.InputColor = ColorTranslator.FromHtml("#494949");
            formCustomizer.TextStatusStripColor = Color.Black;
        }

        void RegisterEvents()
        {
            textBox1.TextChanged += new EventHandler(service.InputCredentialsChanged);
            textBox2.TextChanged += new EventHandler(service.InputCredentialsChanged);
            textBox3.TextChanged += new EventHandler(service.InputCredentialsChanged);

            comboBox1.DropDown += new System.EventHandler(service.comboBox1_DropDown);

            button1.Click += new System.EventHandler(service.button1_Click);
        }

        void RegisterBindings()
        {
            textBox1.DataBindings.Add(new Binding("Text", service, "ServerName", false, DataSourceUpdateMode.OnPropertyChanged));
            textBox2.DataBindings.Add(new Binding("Text", service, "UserName", false, DataSourceUpdateMode.OnPropertyChanged));
            textBox3.DataBindings.Add(new Binding("Text", service, "Password", false, DataSourceUpdateMode.OnPropertyChanged));

            comboBox1.DataBindings.Add(new Binding("SelectedValue", service, "Database", false, DataSourceUpdateMode.OnPropertyChanged));

            numericUpDown1.DataBindings.Add(new Binding("Value", service, "TimeOut", false, DataSourceUpdateMode.OnPropertyChanged));

            button1.DataBindings.Add(new Binding("Enabled", service, "CanConnect", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        void UpdateFormCustomizer()
        {
            formCustomizer.setTitleBar(panelControlBox);
            formCustomizer.setTitleLabel(labelWindowTitle);
            formCustomizer.setCloseButton(buttonClose);  
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
