using System.Data.Entity;

namespace AnLibrary.EntityFramework
{
    public class dbContext : DbContext
    {
        public dbContext() : base("DefaultConnectionString")
        {

        }
        public DbSet<DocGia> DocGias
        {
            get; set;
        }
        public DbSet<CTPM> CTPMs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhieuMuon> PhieuMuons { get; set; }
        public DbSet<Sach> Saches { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<NXB> NXBs { get; set; }

    }
}
