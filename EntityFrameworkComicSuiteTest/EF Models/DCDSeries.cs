using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkComicSuiteTest
{
    [Table("DCDSeries")]
    public class DCDSeries
    {
        [Key]
        public int code { get; set; }
        public string description { get; set; }
        
    }
}
