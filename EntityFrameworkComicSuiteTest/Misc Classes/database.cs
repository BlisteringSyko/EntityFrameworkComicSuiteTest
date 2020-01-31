namespace EntityFrameworkComicSuiteTest.Misc_Classes
{
    public class Database
    {
        // this class is for binding the comobox on the ConnectForm to the list of databases from sql
        public string name { get; set; }

        public Database(string Name)
        {
            this.name = Name;
        }
    }
}
