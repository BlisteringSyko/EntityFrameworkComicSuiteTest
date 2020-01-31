using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EntityFrameworkComicSuiteTest.Misc_Classes;
using System.Threading;

namespace EntityFrameworkComicSuiteTest.Services
{
    class ServiceConnectForm : IDisposable
    {
        public string Title { get; set; }
        public string ServerName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int TimeOut { get; set; }
        public List<Database> Databases { get; set; }
        public object Database { get; set; }
        public bool CanConnect { get; set; }

        public ServiceConnectForm()
        {
            Databases = new List<Database>();
            Database = "";
            ServerName = "(local)";
            UserName = "sa";
            Password = "Password1";
            TimeOut = 1;
            CanConnect = false;
        }

        public void GetDatabaseList()
        {
            Databases.Clear();
            Console.WriteLine($"{ServerName} {UserName} {Password}");
            if (!(ServerName is null) && !(UserName is null) && !(Password is null))
            {
                string conString = $"server={ServerName};uid={UserName};pwd={Password}; database=master; Connection Timeout={TimeOut}";
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {

                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                        {
                            using (IDataReader dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    Databases.Add(new Database(dr[0].ToString()));
                                }
                            }
                        }
                    }

                    if (Databases.Count > 0) Database = Databases[0];
                    CanConnect = true;
                }
                catch (Exception ex)
                {
                    CanConnect = false;
                    MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + ex.InnerException);
                }
            }

            if (Databases.Count == 0)
            {
                CanConnect = false;
            }
        }

        internal void InputCredentialsChanged(object sender, EventArgs e)
        {
            CanConnect = false;
            Databases.Clear();
        }

        internal void comboBox1_DropDown(object sender, EventArgs e)
        {
            GetDatabaseList();
            ((ComboBox)sender).DataSource = null;
            ((ComboBox)sender).DisplayMember = "name";
            ((ComboBox)sender).ValueMember = "name";
            ((ComboBox)sender).DataSource = Databases;
            ((ComboBox)sender).SelectedIndex = ((ComboBox)sender).Items.Count - 1;
        }

        internal void button1_Click(object sender, EventArgs e)
        {
            if (ServerName.Trim() != "" && UserName.Trim() != "" && Password.Trim() != "" && Database.ToString().Trim() != "" && CanConnect)
            {
                SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
                sqlBuilder.DataSource = ServerName;
                sqlBuilder.InitialCatalog = Database.ToString();
                sqlBuilder.UserID = UserName;
                sqlBuilder.Password = Password;
                sqlBuilder.PersistSecurityInfo = true;

                ((ConnectForm)(((Button)sender).Tag)).Hide();

                Thread _thread = new Thread(() =>
                {
                    Form1 form1 = new Form1(sqlBuilder);
                    form1.formCustomizer.isDialog = true;
                    Application.Run(form1);
                });
                _thread.SetApartmentState(ApartmentState.STA);
                _thread.Start();
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
                    Databases = null;
                }

                disposedValue = true;
            }
        }


        ~ServiceConnectForm()
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
