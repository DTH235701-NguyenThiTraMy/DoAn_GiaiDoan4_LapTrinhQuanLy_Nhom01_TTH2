namespace QuanLyCuaHangTapHoa.Forms
{
    partial class frmHoaDon
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
            dtpNgayLap = new DateTimePicker();
            cboKhachHang = new ComboBox();
            txtGhiChu = new TextBox();
            txtNhanVien = new TextBox();
            txtMaHD = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            numSoLuong = new NumericUpDown();
            txtDonGia = new TextBox();
            cboSanPham = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            lblTongTien = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            dgvChiTiet = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayLap);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(txtNhanVien);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1262, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Location = new Point(720, 43);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(400, 39);
            dtpNgayLap.TabIndex = 9;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(720, 117);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(334, 40);
            cboKhachHang.TabIndex = 8;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(205, 172);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(915, 78);
            txtGhiChu.TabIndex = 7;
            // 
            // txtNhanVien
            // 
            txtNhanVien.Location = new Point(205, 110);
            txtNhanVien.Name = "txtNhanVien";
            txtNhanVien.ReadOnly = true;
            txtNhanVien.Size = new Size(242, 39);
            txtNhanVien.TabIndex = 6;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(205, 45);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.ReadOnly = true;
            txtMaHD.Size = new Size(242, 39);
            txtMaHD.TabIndex = 5;
            txtMaHD.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 172);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 4;
            label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(546, 117);
            label4.Name = "label4";
            label4.Size = new Size(145, 32);
            label4.TabIndex = 3;
            label4.Text = "Khách hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 110);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 2;
            label3.Text = "Nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 43);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 1;
            label2.Text = "Ngày lập:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 43);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            label1.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(numSoLuong);
            panel1.Controls.Add(txtDonGia);
            panel1.Controls.Add(cboSanPham);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 285);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 115);
            panel1.TabIndex = 1;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(945, 36);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(175, 39);
            numSoLuong.TabIndex = 5;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(589, 36);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(200, 39);
            txtDonGia.TabIndex = 4;
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(189, 31);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(242, 40);
            cboSanPham.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(824, 39);
            label8.Name = "label8";
            label8.Size = new Size(115, 32);
            label8.TabIndex = 2;
            label8.Text = "Số lượng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(480, 39);
            label7.Name = "label7";
            label7.Size = new Size(103, 32);
            label7.TabIndex = 1;
            label7.Text = "Đơn giá:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 39);
            label6.Name = "label6";
            label6.Size = new Size(126, 32);
            label6.TabIndex = 0;
            label6.Text = "Sản phẩm:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnHuy);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(lblTongTien);
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 798);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 117);
            panel2.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(824, 43);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(611, 43);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 46);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(408, 43);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 46);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(205, 43);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(161, 13);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(41, 32);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "0đ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(15, 13);
            label9.Name = "label9";
            label9.Size = new Size(131, 32);
            label9.TabIndex = 0;
            label9.Text = "Tổng tiền:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvChiTiet);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 400);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1262, 398);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách chi tiết";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { ID, TenSanPham, DonGia, SoLuong, ThanhTien });
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.Location = new Point(3, 35);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersWidth = 82;
            dgvChiTiet.Size = new Size(1256, 360);
            dgvChiTiet.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.MinimumWidth = 10;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn Giá";
            DonGia.MinimumWidth = 10;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 10;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 10;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 915);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "frmHoaDon";
            Text = "Hóa đơn";
            Load += frmHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpNgayLap;
        private ComboBox cboKhachHang;
        private TextBox txtGhiChu;
        private TextBox txtNhanVien;
        private TextBox txtMaHD;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private NumericUpDown numSoLuong;
        private TextBox txtDonGia;
        private ComboBox cboSanPham;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel2;
        private Label lblTongTien;
        private Label label9;
        private GroupBox groupBox2;
        private DataGridView dgvChiTiet;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn ThanhTien;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnThem;
    }
}