using Microsoft.EntityFrameworkCore;

namespace QuanLyGhiDanh.Data
{
    public class QuanLyGhiDanhContext: DbContext
    {
        public QuanLyGhiDanhContext(DbContextOptions<QuanLyGhiDanhContext> opt) : base(opt)
        {
        }
        #region DbSet
        public DbSet<BoMon>? BoMons { get; set; }
        public DbSet<GiaoVien>? GiaoViens { get; set; }
        public DbSet<HocVien>? HocViens { get; set; }
        public DbSet<KhoaHoc>? KhoaHocs { get; set; }
        public DbSet<LopHoc>? LopHocs { get; set; }
        public DbSet<NhomBoMon>? NhomBoMons { get; set; }
        #endregion
    }
}

