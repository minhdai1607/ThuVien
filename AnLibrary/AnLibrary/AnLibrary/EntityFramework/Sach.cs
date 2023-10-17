using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnLibrary.EntityFramework
{
    [Table("Sach")]
    public class Sach
    {
        [Key]
        [Display(Name = "Mã sách")]
        public int Ma { get; set; }
        [Display(Name = "Mã thể loại")]
        public int MaTL { get; set; }
        public TheLoai TL { get; set; }
        [Display(Name = "Tên sách")]
        public string TenSach { get; set; }
        [Display(Name = "Giá mua sách")]
        public int Giamua { get; set; }
        [Display(Name = "Giá cho thuê")]
        public int Giathue { get; set; }
        [Display(Name = "Tác giả")]
        public string TacGia { get; set; }
        [Display(Name = "Mã Nhà xuất bản")]
        public int MaNXB { get; set; }
        public NXB NXB { get; set; }
        [Display(Name = "Số lượng")]
        public int SoLuong { get; set; }
        public Status Status { get; set; }

        public StatusBook statusBook { get; set; }

        public enum StatusBook
        {
            [Display(Name = "Còn")]
            Active = 1,
            [Display(Name = "Hết")]
            DeActive = 2,
        }
    }
}
