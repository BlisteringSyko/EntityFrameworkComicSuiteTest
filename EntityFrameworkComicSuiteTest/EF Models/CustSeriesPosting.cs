using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkComicSuiteTest
{
    [Table("DCDCustSeriesPosting")]
    public class CustSeriesPosting
    {

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [Required]
        public int custid { get; set; }

        [Required]
        public string catalogtype { get; set; }

        [Required]
        public int catalogno { get; set; }

        [Required]
        public int seriescode { get; set; }

        [Required]
        public int itemid { get; set; }

        [Required]
        public int orderlineid { get; set; }

        [Required]
        public int subqty { get; set; }

        [Required]
        public int subqtysold { get; set; }

        [Required]
        public int status { get; set; }

        public DateTime? datecontacted { get; set; }
        public DateTime? datesold { get; set; }

        [Required]
        public string retailerno { get; set; }

        [Required]
        public int dcdorderlineid { get; set; }

        [Required]
        public string fiftyfifty { get; set; }

        [Required]
        public string numvar { get; set; }

        [Required]
        public string bag { get; set; }

        [Required]
        public string board { get; set; }

        [Required]
        public string reported { get; set; }

        [Required]
        public DateTime? DateCreated { get; set; }

        public int? DCDPullBoxItemListId { get; set; }

        [Required]
        public string IsActive { get; set; }

        [Required]
        public DateTime? DateLastModified { get; set; }

        public virtual Customer Cust { get; set; }

    }
}
