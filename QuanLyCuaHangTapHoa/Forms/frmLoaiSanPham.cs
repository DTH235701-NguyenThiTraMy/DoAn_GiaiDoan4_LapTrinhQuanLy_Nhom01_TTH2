using QuanLyCuaHangTapHoa.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCuaHangTapHoa.Forms
{
    public partial class frmLoaiSanPham : Form
    {
        // Khởi tạo DbContext để làm việc với CSDL
        QLTHContext db = new QLTHContext();
        bool isAdding = false; // Cờ đánh dấu đang thêm mới hay sửa
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        private void FrmLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetState(); // Khóa các ô nhập khi mới mở form
        }

        // 1. Tải dữ liệu lên Grid
        void LoadData()
        {
            // Lấy danh sách loại sản phẩm, sắp xếp theo ID mới nhất lên đầu
            var list = db.LoaiSanPham
                         .Select(p => new { p.ID, p.TenLoai })
                         .OrderByDescending(p => p.ID)
                         .ToList();
            dgvLoaiSanPham.DataSource = list;

            // Đặt tên cột tiếng Việt cho đẹp
            dgvLoaiSanPham.Columns["ID"].HeaderText = "Mã Loại";
            dgvLoaiSanPham.Columns["TenLoai"].HeaderText = "Tên Loại Sản Phẩm";
            dgvLoaiSanPham.Columns["TenLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // 2. Hàm điều khiển trạng thái các nút (Tránh bấm nhầm)
        void SetEditingMode(bool isEditing)
        {
            txtTenLoai.Enabled = isEditing;
            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;

            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
        }

        void ResetState()
        {
            txtID.Clear();
            txtTenLoai.Clear();
            SetEditingMode(false);
            isAdding = false;
        }
        
        //3 Xử lý nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetState(); // Gọi ResetState trước để dọn dẹp giao diện
            isAdding = true; // SAU ĐÓ mới bật cờ isAdding lên true
            SetEditingMode(true); // Mở khóa các ô nhập liệu
            txtTenLoai.Focus();
        }

        // 4. Xử lý nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần sửa!");
                return;
            }
            isAdding = false;
            SetEditingMode(true);
        }

        // 5. Xử lý nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng nào chưa thông qua txtID
            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần xóa từ danh sách!", "Thông báo");
                return;
            }

            try
            {
                // 2. Tìm đối tượng trong CSDL
                var loai = db.LoaiSanPham.Find(id);

                if (loai != null)
                {
                    // 3. KIỂM TRA RÀNG BUỘC (Quan trọng nhất)
                    // Nếu có sản phẩm nào đang dùng ID này làm khóa ngoại, không được xóa
                    bool hasProduct = db.SanPham.Any(s => s.LoaiSanPhamID == id);
                    if (hasProduct)
                    {
                        MessageBox.Show("Không thể xóa! Loại này đang chứa danh sách các sản phẩm. Hãy xóa các sản phẩm trước.", "Cảnh báo");
                        return;
                    }

                    // 4. Xác nhận lại với người dùng
                    DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa loại: {loai.TenLoai}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        db.LoaiSanPham.Remove(loai);
                        db.SaveChanges(); // Cập nhật xuống SQL

                        MessageBox.Show("Xóa thành công!");

                        // 5. Cập nhật lại giao diện
                        LoadData();
                        ResetState();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
            }
        }

        // 6. Xử lý nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu đầu vào cơ bản
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm!", "Thông báo");
                txtTenLoai.Focus();
                return;
            }

            try
            {
                if (isAdding)
                {
                    // --- TRƯỜNG HỢP THÊM MỚI ---
                    // Không cần quan tâm txtID vì SQL tự sinh ID
                    var loai = new LoaiSanPham
                    {
                        TenLoai = txtTenLoai.Text.Trim()
                    };
                    db.LoaiSanPham.Add(loai);
                }
                else
                {
                    // --- TRƯỜNG HỢP SỬA ---
                    // Chỉ ép kiểu khi chắc chắn txtID có giá trị (lấy từ Grid trước đó)
                    if (int.TryParse(txtID.Text, out int id))
                    {
                        var loaiUpdate = db.LoaiSanPham.Find(id);
                        if (loaiUpdate != null)
                        {
                            loaiUpdate.TenLoai = txtTenLoai.Text.Trim();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã định danh để sửa!");
                        return;
                    }
                }

                // 2. Lưu thay đổi xuống CSDL
                db.SaveChanges();
                MessageBox.Show("Đã lưu dữ liệu thành công!", "Thành công");

                // 3. Cập nhật lại giao diện
                LoadData();
                ResetState(); // Hàm này sẽ xóa trắng TextBox và khóa nút Lưu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi");
            }
        }

        // 7. Click vào Grid để hiện dữ liệu lên TextBox
        private void dgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoaiSanPham.Rows[e.RowIndex];
                // Gán vào TextBox dưới dạng chuỗi (String), không ép kiểu sang Int ở đây
                txtID.Text = row.Cells["ID"].Value?.ToString();
                txtTenLoai.Text = row.Cells["TenLoai"].Value?.ToString();

                SetEditingMode(false); // Khóa các nút cho đến khi bấm "Sửa"
            }
        }

        // 8. Xử lý nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetState();
        }
    }
}
