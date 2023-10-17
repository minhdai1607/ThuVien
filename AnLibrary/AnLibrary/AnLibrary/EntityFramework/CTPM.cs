using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnLibrary.EntityFramework
{
    [Table("CTPM")]
    public class CTPM
    {
        [Key]
        public int MaCTPM { get; set; }
        public int MaPM { get; set; }
        public PhieuMuon PhieuMuon { get; set; }
        public int Ma { get; set; }
        public Sach Sach { get; set; }
        public int GiaThue { get; set; }
    }
}
