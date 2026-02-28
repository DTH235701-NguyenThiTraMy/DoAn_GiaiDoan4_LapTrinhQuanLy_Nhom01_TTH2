using QuanLyCuaHangTapHoa.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCuaHangTapHoa.Forms
{
    public partial class frmKhachHang : Form
    {
        QLTHContext db = new QLTHContext();
        bool isAdding = false;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetState();
        }
        // 1. Tải danh sách khách hàng lên Grid
        void LoadData()
        {
            var list = db.KhachHang
                .Select(k => new
                {
                    k.ID,
                    k.HoTen,
                    k.SoDienThoai,
                    k.DiaChi
                })
                .OrderByDescending(x => x.ID)
                .ToList();

            dgvKhachHang.DataSource = list;
        }

        // 2. Thiết lập trạng thái các nút và ô nhập
        void SetEditingMode(bool isEditing)
        {
            txtHoVaTen.Enabled = isEditing;
            txtDienThoai.Enabled = isEditing;
            txtDiaChi.Enabled = isEditing;

            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
        }
        // 3. Xóa trắng các ô nhập liệu
        void ResetState()
        {
            txtID.Clear();
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();

            SetEditingMode(false);
            isAdding = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra ràng buộc dữ liệu (Validate)
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Họ tên khách hàng không được để trống!", "Thông báo");
                return;
            }

            try
            {
                if (isAdding)
                {
                    // Thêm mới khách hàng
                    var kh = new KhachHang
                    {
                        HoTen = txtHoVaTen.Text.Trim(),
                        SoDienThoai = txtDienThoai.Text.Trim(),
                        DiaChi = txtDiaChi.Text.Trim()
                    };
                    db.KhachHang.Add(kh);
                }
                else
                {
                    // Cập nhật khách hàng cũ
                    int id = int.Parse(txtID.Text);
                    var kh = db.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.HoTen = txtHoVaTen.Text.Trim();
                        kh.SoDienThoai = txtDienThoai.Text.Trim();
                        kh.DiaChi = txtDiaChi.Text.Trim();
                    }
                }

                db.SaveChanges();
                MessageBox.Show("Đã lưu thông tin khách hàng thành công!", "Thông báo");
                LoadData();
                ResetState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo");
                return;
            }

            try
            {
                int id = int.Parse(txtID.Text);
                var kh = db.KhachHang.Find(id);

                if (kh != null)
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng: {kh.HoTen}?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        db.KhachHang.Remove(kh);
                        db.SaveChanges();

                        MessageBox.Show("Xóa khách hàng thành công!");
                        LoadData();
                        ResetState();
                    }
                }
            }
            catch (Exception ex)
            {
                // Lưu ý: Nếu khách hàng đã có Hóa đơn, SQL sẽ chặn không cho xóa
                MessageBox.Show("Không thể xóa khách hàng này (Có thể do dữ liệu liên quan): " + ex.Message, "Lỗi");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadData(); // Nếu ô tìm kiếm trống, hiển thị lại toàn bộ
                return;
            }

            // Tìm kiếm trong DB theo Tên hoặc Số điện thoại
            var filteredList = db.KhachHang
                .Where(k => k.HoTen.ToLower().Contains(keyword) || k.SoDienThoai.Contains(keyword))
                .Select(k => new
                {
                    k.ID,
                    k.HoTen,
                    k.SoDienThoai,
                    k.DiaChi
                })
                .OrderByDescending(x => x.ID)
                .ToList();

            dgvKhachHang.DataSource = filteredList;

            if (filteredList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng nào khớp với từ khóa!", "Thông báo");
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
            txtHoVaTen.Focus();
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvKhachHang.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value?.ToString();
                txtHoVaTen.Text = row.Cells["HoVaTen"].Value?.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();

                SetEditingMode(false);
            }
        }
    }
}
