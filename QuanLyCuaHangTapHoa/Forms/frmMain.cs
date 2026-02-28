using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyCuaHangTapHoa.Forms;

namespace QuanLyCuaHangTapHoa.Forms
{
    public partial class frmMain : Form
    {
        // Biến lưu trữ form con hiện tại để quản lý
        private Form activeForm = null;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmrClock.Start();

            // Kiểm tra đăng nhập
            if (Program.nvDangNhap == null)
            {
                MessageBox.Show("Bạn chưa đăng nhập!", "Lỗi");
                this.Close();
                return;
            }

            // Hiển thị thông tin người dùng
            lblUser.Text = "Xin chào: " + Program.nvDangNhap.HoTen;

            // Phân quyền
            if (!Program.nvDangNhap.QuyenHan)
            {
                mnuNhanVien.Visible = false;
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnContent.Controls.Clear();
            pnContent.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();
        }
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLoaiSanPham());
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSanPham());
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmKhachHang());
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.nvDangNhap = null;
                this.Close(); // Program.cs sẽ lo phần còn lại
            }
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoaDon());
        }
    }
}
