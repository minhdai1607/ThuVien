using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnLibrary.EntityFramework
{
    [Table("DocGia")]
    public class DocGia
    {
        [Key]
        public int MaDG { get; set; }
        public string TenDG { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public Status Status { get; set; }

    }
}
