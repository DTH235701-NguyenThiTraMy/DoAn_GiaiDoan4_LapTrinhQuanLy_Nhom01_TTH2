using QuanLyCuaHangTapHoa.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCuaHangTapHoa.Forms
{
    public partial class frmSanPham : Form
    {
        QLTHContext db = new QLTHContext();
        bool isAdding = false;
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadLoaiSP(); // Nạp danh sách vào ComboBox trước
            LoadData();   // Sau đó mới nạp danh sách sản phẩm
            ResetState();
        }

        // 1. Nạp dữ liệu vào ComboBox Loại sản phẩm
        void LoadLoaiSP()
        {
            var listLoai = db.LoaiSanPham.ToList();
            cboLoaiSanPham.DataSource = listLoai;
            cboLoaiSanPham.DisplayMember = "TenLoai"; // Hiển thị tên
            cboLoaiSanPham.ValueMember = "ID";         // Giá trị ẩn bên dưới là ID
        }

        // 2. Tải danh sách sản phẩm lên Grid (Có lấy tên Loại sản phẩm)
        void LoadData()
        {
            var list = db.SanPham.Select(p => new
            {
                p.ID,
                p.TenSanPham,
                TenLoai = p.LoaiSanPham.TenLoai, // Lấy tên từ bảng Loại
                p.LoaiSanPhamID,                 // Giữ ID để xử lý ComboBox
                p.DonViTinh,
                p.DonGia,
                p.SoLuong
            }).OrderByDescending(x => x.ID).ToList();

            dgvSanPham.DataSource = list;

            // Ẩn cột ID loại không cần thiết trên Grid
            if (dgvSanPham.Columns["LoaiSanPhamID"] != null)
                dgvSanPham.Columns["LoaiSanPhamID"].Visible = false;
        }
        void SetEditingMode(bool isEditing)
        {
            txtTenSP.Enabled = isEditing;
            cboLoaiSanPham.Enabled = isEditing;
            txtDVT.Enabled = isEditing;
            numDonGia.Enabled = isEditing;
            numDonGia.Enabled = isEditing;

            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
        }
        void ResetState()
        {
            txtID.Clear();
            txtTenSP.Clear();
            txtDVT.Clear();            
            if (cboLoaiSanPham.Items.Count > 0) cboLoaiSanPham.SelectedIndex = 0;

            SetEditingMode(false);
            isAdding = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetState();
            isAdding = true;
            SetEditingMode(true);
            txtTenSP.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã chọn sản phẩm chưa
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo");
                return;
            }

            try
            {
                int id = int.Parse(txtID.Text);
                // 2. Tìm sản phẩm trong DB
                var sp = db.SanPham.Find(id);

                if (sp != null)
                {
                    // 3. Xác nhận xóa
                    DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm: {sp.TenSanPham}?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        db.SanPham.Remove(sp);
                        db.SaveChanges(); // Lưu thay đổi vào CSDL

                        MessageBox.Show("Xóa sản phẩm thành công!");
                        LoadData();   // Tải lại bảng
                        ResetState(); // Xóa trắng các ô nhập liệu
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;
            isAdding = false;
            SetEditingMode(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra validate cơ bản
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống!");
                return;
            }

            try
            {
                if (isAdding)
                {
                    var sp = new SanPham
                    {
                        TenSanPham = txtTenSP.Text.Trim(),
                        LoaiSanPhamID = (int)cboLoaiSanPham.SelectedValue, // Lấy ID từ ComboBox
                        DonViTinh = txtDVT.Text.Trim(),
                        DonGia = decimal.Parse(numDonGia.Text),
                        SoLuong = int.Parse(numSoLuong.Text)
                    };
                    db.SanPham.Add(sp);
                }
                else
                {
                    int id = int.Parse(txtID.Text);
                    var sp = db.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.TenSanPham = txtTenSP.Text.Trim();
                        sp.LoaiSanPhamID = (int)cboLoaiSanPham.SelectedValue;
                        sp.DonViTinh = txtDVT.Text.Trim();
                        sp.DonGia = decimal.Parse(numDonGia.Text);
                        sp.SoLuong = int.Parse(numSoLuong.Text);
                    }
                }
                db.SaveChanges();
                MessageBox.Show("Đã lưu thành công!");
                LoadData();
                ResetState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi định dạng số hoặc hệ thống: " + ex.Message);
            }
        }

        // 4. Click Grid đổ dữ liệu ngược lại Control
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSanPham.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                txtDVT.Text = row.Cells["DonViTinh"].Value.ToString();
                numDonGia.Text = row.Cells["DonGia"].Value.ToString();
                numSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

                // Đổ giá trị vào ComboBox dựa trên ID loại
                cboLoaiSanPham.SelectedValue = row.Cells["LoaiSanPhamID"].Value;

                SetEditingMode(false);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetState();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
