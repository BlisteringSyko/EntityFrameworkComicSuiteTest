using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkComicSuiteTest
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public string SubDescription1 { get; set; }
        public string SubDescription2 { get; set; }
        public string SubDescription3 { get; set; }
    }
}
