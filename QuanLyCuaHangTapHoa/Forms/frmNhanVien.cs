using QuanLyCuaHangTapHoa.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyCuaHangTapHoa.Forms
{
    public partial class frmNhanVien : Form
    {
        QLTHContext db = new QLTHContext();
        bool isAdding = false;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetState();
        }
        void LoadData()
        {
            var list = db.NhanVien.Select(nv => new
            {
                nv.ID,
                nv.HoTen,
                nv.SoDienThoai,                
                nv.TenDangNhap,
                // Chuyển kiểu bool sang chuỗi để hiển thị
                QuyenHan = nv.QuyenHan ? "Quản lý" : "Nhân viên"
            }).OrderByDescending(x => x.ID).ToList();

            dgvNhanVien.DataSource = list;
        }
        void SetEditingMode(bool isEditing)
        {
            txtHoVaTen.Enabled = txtDienThoai.Enabled = isEditing;
            txtTenDangNhap.Enabled = txtMatKhau.Enabled = cboQuyenHan.Enabled = isEditing;

            btnLuu.Enabled = btnHuy.Enabled = isEditing;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = !isEditing;
        }
        void ResetState()
        {
            txtID.Clear();
            txtHoVaTen.Clear();
            txtDienThoai.Clear();            
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            if (cboQuyenHan.Items.Count > 0) cboQuyenHan.SelectedIndex = 1; // Mặc định là Nhân viên

            SetEditingMode(false);
            isAdding = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Họ tên!");
                return;
            }

            try
            {
                if (isAdding)
                {
                    // THÊM MỚI
                    var nv = new NhanVien
                    {
                        HoTen = txtHoVaTen.Text.Trim(),
                        SoDienThoai = txtDienThoai.Text.Trim(),                        
                        TenDangNhap = txtTenDangNhap.Text.Trim(),
                        // Mã hóa mật khẩu ngay khi thêm
                        MatKhau = BC.HashPassword(txtMatKhau.Text),
                        QuyenHan = cboQuyenHan.SelectedIndex == 0 // Index 0 là Quản lý
                    };
                    db.NhanVien.Add(nv);
                }
                else
                {
                    // CHỈNH SỬA
                    int id = int.Parse(txtID.Text);
                    var nv = db.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoTen = txtHoVaTen.Text.Trim();
                        nv.SoDienThoai = txtDienThoai.Text.Trim();
                        nv.TenDangNhap = txtTenDangNhap.Text.Trim();
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 0;

                        // Kiểm tra nếu có nhập mật khẩu mới thì mới mã hóa lại
                        if (!string.IsNullOrEmpty(txtMatKhau.Text))
                        {
                            nv.MatKhau = BC.HashPassword(txtMatKhau.Text);
                        }
                        else
                        {
                            // Lệnh này ép Entity Framework KHÔNG cập nhật cột MatKhau (theo tài liệu trang 14)
                            db.Entry(nv).Property(x => x.MatKhau).IsModified = false;
                        }
                    }
                }
                db.SaveChanges();
                MessageBox.Show("Lưu thông tin nhân viên thành công!");
                LoadData();
                ResetState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvNhanVien.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtHoVaTen.Text = row.Cells["HoVaTen"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();                
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();

                // Hiển thị quyền lên ComboBox
                string quyen = row.Cells["QuyenHan"].Value.ToString();
                cboQuyenHan.SelectedIndex = (quyen == "Quản lý") ? 0 : 1;

                txtMatKhau.Clear(); // Để trống mật khẩu vì lý do bảo mật
                SetEditingMode(false);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetState();
            isAdding = true;
            SetEditingMode(true);
            txtHoVaTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;
            isAdding = false;
            SetEditingMode(true);
            txtMatKhau.PlaceholderText = "Để trống nếu không đổi mật khẩu";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;

            if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var nv = db.NhanVien.Find(int.Parse(txtID.Text));
                if (nv != null)
                {
                    db.NhanVien.Remove(nv);
                    db.SaveChanges();
                    LoadData();
                    ResetState();
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
