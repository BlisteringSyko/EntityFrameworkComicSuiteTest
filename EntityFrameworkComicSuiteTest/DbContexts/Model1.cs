using System.Data.Entity;

namespace EntityFrameworkComicSuiteTest
{

    public class Model1 : DbContext
    {
        public Model1(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<Model1>(null);
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustSeries> DCDCustSeries { get; set; }
        public virtual DbSet<DCDSeries> DCDSeries { get; set; }
        public virtual DbSet<SpecialOrder> DCDSpecialOrders { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Alias> Aliases { get; set; }
        public virtual DbSet<SpecialOrderHistory> DCDSpecialOrderHist { get; set; }
    }

}