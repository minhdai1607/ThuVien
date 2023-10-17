
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AnLibrary.EntityFramework
{
    [Table("ThuThu")]
    public class NhanVien
    {
        [Key]
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string TK { get; set; }
        public string MatKhau { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public Status Status { get; set; }
        public List<PhieuMuon> PM { get; set; }
    }
}
