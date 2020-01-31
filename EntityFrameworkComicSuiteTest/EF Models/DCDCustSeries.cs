using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkComicSuiteTest
{
    [Table("DCDCustSeries")]
    public class CustSeries
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SeriesCode { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Quantity { get; set; }

        public int? LastBatchPosted { get; set; }

        [StringLength(6)]
        public string Retailerno { get; set; }

        [Required]
        [StringLength(1)]
        public string fiftyfifty { get; set; }

        [Required]
        [StringLength(1)]
        public string numvar { get; set; }

        public int startissue { get; set; }

        public int endissue { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string SeriesGroup { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        [Required]
        [StringLength(1)]
        public string PostSubIssues { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VariantNo { get; set; }

        [Required]
        [StringLength(1)]
        public string IsActive { get; set; }


        [ForeignKey("CustID")]
        public virtual Customer Cust { get; set; }

    }
}
