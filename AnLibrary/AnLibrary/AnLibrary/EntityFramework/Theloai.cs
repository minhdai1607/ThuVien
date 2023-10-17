using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnLibrary.EntityFramework
{
    [Table("TheLoai")]
    public class TheLoai
    {
        [Key]
        public int MaTL { get; set; }
        public string TenTL { get; set; }
    }
}
