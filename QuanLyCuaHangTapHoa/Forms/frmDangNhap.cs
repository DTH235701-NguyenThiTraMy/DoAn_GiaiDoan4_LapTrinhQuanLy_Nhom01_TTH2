using QuanLyCuaHangTapHoa.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyCuaHangTapHoa.Forms
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            // 1. Kiểm tra nhập liệu
            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using (var db = new QLTHContext())
                {
                    // 2. Tìm nhân viên theo tên đăng nhập
                    var nv = db.NhanVien.FirstOrDefault(x => x.TenDangNhap == tenDN);

                    // 3. Kiểm tra tồn tại & xác thực mật khẩu bằng BCrypt
                    if (nv != null && BC.Verify(matKhau, nv.MatKhau))
                    {
                        // Lưu thông tin nhân viên đăng nhập
                        Program.nvDangNhap = nv;

                        // Báo đăng nhập thành công cho Program.cs
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Tên đăng nhập hoặc mật khẩu không chính xác!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        txtMatKhau.Clear();
                        txtMatKhau.Focus();
                    }
                }
            }
            catch
            {
                MessageBox.Show(
                    "Không thể kết nối cơ sở dữ liệu. Vui lòng thử lại sau!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
