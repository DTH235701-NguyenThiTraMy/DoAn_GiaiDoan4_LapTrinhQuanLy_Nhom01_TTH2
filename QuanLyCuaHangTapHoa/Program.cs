using System;
using System.Windows.Forms;
using System.Linq;
using QuanLyCuaHangTapHoa.Data;
using QuanLyCuaHangTapHoa.Forms;

namespace QuanLyCuaHangTapHoa
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        // Thêm đoạn này vào đầu hàm Main trong Program.cs
        
        public static NhanVien nvDangNhap;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //ApplicationConfiguration.Initialize();
            //Application.Run(new Forms.frmMain());

            // ====== SEED ADMIN ======
            try
            {
                using (var db = new QLTHContext())
                {
                    db.Database.EnsureCreated();
                    if (!db.NhanVien.Any())
                    {
                        db.NhanVien.Add(new NhanVien
                        {
                            HoTen = "Quản Trị Viên",
                            TenDangNhap = "admin",
                            SoDienThoai = "0123456789",
                            MatKhau = BCrypt.Net.BCrypt.HashPassword("admin123"),
                            QuyenHan = true
                        });
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không thể kết nối CSDL!", "Lỗi");
                return;
            }
            // ========================

            // ====== LOGIN LOOP ======
            while (true)
            {
                frmDangNhap login = new frmDangNhap();

                // Thoát login → thoát app
                if (login.ShowDialog() != DialogResult.OK)
                    break;

                // Đăng nhập OK → vào Main
                Application.Run(new frmMain());

                // Khi frmMain đóng (đăng xuất)
                nvDangNhap = null;
            }
            // ========================

            Application.Exit();
        }
    }
}