using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnLibrary.EntityFramework
{
    [Table("PhieuMuon")]
    public class PhieuMuon
    {
        [Key]
        public int MaPM { get; set; }
        public string MaNV { get; set; }
        public NhanVien NhanVien { get; set; }
        public int MaDG { get; set; }
        public DocGia DocGia { get; set; }
        public DateTime? NgayMuon { get; set; } = DateTime.Now;
        public DateTime? HanTra { get; set; }
        public DateTime? NgayTra { get; set; }
        public DateTime? NgayCapNhat { get; set; } = DateTime.Now;
        public int TongTien { get; set; }
        public statusPM statusPM { get; set; }

    }
    public enum statusPM
    {
        [Display(Name = "Đã Trả")]
        Active = 1,
        [Display(Name = "Chưa Trả")]
        DeActive = 2,
        [Display(Name = "Bị Huỷ")]
        Cancel = 3
    }
}
