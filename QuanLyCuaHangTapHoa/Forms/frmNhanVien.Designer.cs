namespace QuanLyCuaHangTapHoa.Forms
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cboQuyenHan = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            label5 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            txtDienThoai = new TextBox();
            txtHoVaTen = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label8 = new Label();
            txtTimKiem = new TextBox();
            gbnv = new GroupBox();
            dgvNhanVien = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            gbnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1348, 239);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản Lý", "Nhân Viên" });
            cboQuyenHan.Location = new Point(742, 172);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(325, 40);
            cboQuyenHan.TabIndex = 16;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(742, 115);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(325, 39);
            txtMatKhau.TabIndex = 15;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(742, 59);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(325, 39);
            txtTenDangNhap.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(557, 175);
            label4.Name = "label4";
            label4.Size = new Size(137, 32);
            label4.TabIndex = 13;
            label4.Text = "Quyền hạn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(557, 115);
            label6.Name = "label6";
            label6.Size = new Size(120, 32);
            label6.TabIndex = 12;
            label6.Text = "Mật khẩu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(557, 59);
            label7.Name = "label7";
            label7.Size = new Size(179, 32);
            label7.TabIndex = 11;
            label7.Text = "Tên đăng nhập:";
            // 
            // txtID
            // 
            txtID.Location = new Point(167, 51);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(307, 39);
            txtID.TabIndex = 10;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 51);
            label5.Name = "label5";
            label5.Size = new Size(42, 32);
            label5.TabIndex = 9;
            label5.Text = "ID:";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1159, 178);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 46);
            btnXuat.TabIndex = 8;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1159, 108);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 46);
            btnNhap.TabIndex = 7;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1159, 37);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 46);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(167, 172);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(307, 39);
            txtDienThoai.TabIndex = 4;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(167, 116);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(307, 39);
            txtHoVaTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 172);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 1;
            label2.Text = "Điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 116);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Location = new Point(212, 267);
            panel1.Name = "panel1";
            panel1.Size = new Size(998, 78);
            panel1.TabIndex = 10;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(819, 17);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 46);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(616, 17);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 46);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(414, 17);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(220, 17);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(37, 17);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 374);
            label8.Name = "label8";
            label8.Size = new Size(118, 32);
            label8.TabIndex = 12;
            label8.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(177, 371);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(699, 39);
            txtTimKiem.TabIndex = 13;
            // 
            // gbnv
            // 
            gbnv.Controls.Add(dgvNhanVien);
            gbnv.Location = new Point(12, 448);
            gbnv.Name = "gbnv";
            gbnv.Size = new Size(1358, 497);
            gbnv.TabIndex = 14;
            gbnv.TabStop = false;
            gbnv.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { ID, HoTen, SoDienThoai, TenDangNhap, QuyenHan });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 35);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 82;
            dgvNhanVien.Size = new Size(1352, 459);
            dgvNhanVien.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ và Tên";
            HoTen.MinimumWidth = 10;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Điện Thoại";
            SoDienThoai.MinimumWidth = 10;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.MinimumWidth = 10;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền Hạn";
            QuyenHan.MinimumWidth = 10;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.ReadOnly = true;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 957);
            Controls.Add(gbnv);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            gbnv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtID;
        private Label label5;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private TextBox txtDienThoai;
        private TextBox txtHoVaTen;
        private Label label2;
        private Label label1;
        private ComboBox cboQuyenHan;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label4;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label8;
        private TextBox txtTimKiem;
        private GroupBox gbnv;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
    }
}