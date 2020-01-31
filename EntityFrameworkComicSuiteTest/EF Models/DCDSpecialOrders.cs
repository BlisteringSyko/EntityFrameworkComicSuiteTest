using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkComicSuiteTest
{
    [Table("DCDSpecialOrders")]
    public class SpecialOrder
    {
        [Key]
        [Column(Order = 0)]
        public string RetailerNo { get; set; }
        [Key]
        [Column(Order = 1)]
        public string CatalogType { get; set; }
        [Key]
        [Column(Order = 2)]
        public int CatalogNo { get; set; }
        [Key]
        [Column(Order = 3)]
        public int CustID { get; set; }
        [Key]
        [Column(Order = 4)]
        public int ItemId { get; set; }
        public int QtyOrdered { get; set; }
        public int QtyReceived { get; set; }
        public int QtySold { get; set; }
        public DateTime? DateOrdered { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DateContacted { get; set; }
        public DateTime? DateSold { get; set; }

        [Required]
        public string Diamdno { get; set; }
        public string contacted { get; set; }
        public int status { get; set; }
        public int orderlineid { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int specordercounter { get; set; }

        public int dcdorderlineid { get; set; }

        [Required]
        [StringLength(1)]
        public string pullfromorder { get; set; }

        [Required]
        [StringLength(1)]
        public string reported { get; set; }

        [Required]
        public string isActive { get; set; }


        public virtual Customer Cust { get; set; }

    }
}
