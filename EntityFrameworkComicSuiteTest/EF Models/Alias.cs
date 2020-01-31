using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkComicSuiteTest
{

    [Table("Alias")]
    public class Alias
    {
        public int ID { get; set; }

        public int ItemID { get; set; }

        [Column("Alias")]
        [Required]
        [StringLength(25)]
        public string alias { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] DBTimeStamp { get; set; }

    }
}
