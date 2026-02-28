using Microsoft.EntityFrameworkCore;
using System.Configuration; // Cần thiết để đọc chuỗi kết nối từ App.config

namespace QuanLyCuaHangTapHoa.Data
{
    public class QLTHContext : DbContext
    {
        // Khai báo các bảng dữ liệu (DbSet)
        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }

        // Cấu hình kết nối SQL Server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Lấy chuỗi kết nối có tên "QLTapHoaConnection" đã khai báo trong App.config
                string connectionString = ConfigurationManager.ConnectionStrings["QLTapHoaConnection"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        // Cấu hình bổ sung (Fluent API) - Ví dụ thiết lập quan hệ hoặc giá trị mặc định
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình đơn giá và số lượng để tránh lỗi làm tròn nếu cần
            modelBuilder.Entity<SanPham>()
                .Property(s => s.DonGia)
                .IsRequired();

            // Thiết lập quan hệ 1-N giữa HoaDon và HoaDon_ChiTiet
            modelBuilder.Entity<HoaDon_ChiTiet>()
                .HasOne(ct => ct.HoaDon)
                .WithMany(hd => hd.HoaDon_ChiTiet)
                .HasForeignKey(ct => ct.HoaDonID);
        }
    }
}