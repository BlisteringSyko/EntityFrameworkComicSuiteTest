using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkComicSuiteTest
{
    // this table is apearantly never used. DCDSpecialOrders has a Status column instead.

    [Table("DCDSpecialOrdersHist")]
    public class SpecialOrderHistory
    {
        [Key]
        [Column(Order = 0)]
        public int CustID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ItemId { get; set; }

        [Required]
        public string Diamdno { get; set; }

        public string Reported { get; set; }

        [Key]
        [Column(Order = 5)]
        public string Retailerno { get; set; }

        public virtual Customer Cust { get; set; }

    }
}
