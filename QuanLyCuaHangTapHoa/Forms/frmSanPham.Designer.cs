namespace QuanLyCuaHangTapHoa.Forms
{
    partial class frmSanPham
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            picHinhAnh = new PictureBox();
            txtDVT = new TextBox();
            cboLoaiSanPham = new ComboBox();
            txtTenSP = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            dgvSanPham = new DataGridView();
            label7 = new Label();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            numSoLuong = new NumericUpDown();
            numDonGia = new NumericUpDown();
            label8 = new Label();
            btnDoiAnh = new Button();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(txtDVT);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1285, 314);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // picHinhAnh
            // 
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(1034, 38);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(173, 191);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 12;
            picHinhAnh.TabStop = false;
            // 
            // txtDVT
            // 
            txtDVT.Location = new Point(733, 49);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(274, 39);
            txtDVT.TabIndex = 9;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(209, 189);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(309, 40);
            cboLoaiSanPham.TabIndex = 8;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(209, 118);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(309, 39);
            txtTenSP.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(209, 49);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(309, 39);
            txtID.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(567, 192);
            label6.Name = "label6";
            label6.Size = new Size(115, 32);
            label6.TabIndex = 5;
            label6.Text = "Số lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(567, 124);
            label5.Name = "label5";
            label5.Size = new Size(103, 32);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(567, 49);
            label4.Name = "label4";
            label4.Size = new Size(138, 32);
            label4.TabIndex = 3;
            label4.Text = "Đơn vị tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 192);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 2;
            label3.Text = "Phân loại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 119);
            label2.Name = "label2";
            label2.Size = new Size(168, 32);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 49);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Location = new Point(18, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(1287, 78);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(819, 17);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 46);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
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
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dgvSanPham);
            groupBox2.Location = new Point(15, 572);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1293, 438);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai, TenSanPham, DonViTinh, DonGia, SoLuong, HinhAnh });
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(3, 35);
            dgvSanPham.MultiSelect = false;
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersWidth = 82;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(1287, 400);
            dgvSanPham.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(-1, 527);
            label7.Name = "label7";
            label7.Size = new Size(118, 32);
            label7.TabIndex = 7;
            label7.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTimKiem.Location = new Point(123, 524);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(391, 39);
            txtTimKiem.TabIndex = 8;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(551, 520);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(150, 46);
            btnTim.TabIndex = 9;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(733, 190);
            numSoLuong.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(240, 39);
            numSoLuong.TabIndex = 13;
            numSoLuong.ThousandsSeparator = true;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(733, 122);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(240, 39);
            numDonGia.TabIndex = 14;
            numDonGia.ThousandsSeparator = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 252);
            label8.Name = "label8";
            label8.Size = new Size(0, 32);
            label8.TabIndex = 15;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(1046, 252);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(150, 46);
            btnDoiAnh.TabIndex = 16;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "Mã SP";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Loại Hàng";
            TenLoai.MinimumWidth = 10;
            TenLoai.Name = "TenLoai";
            TenLoai.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.MinimumWidth = 10;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // DonViTinh
            // 
            DonViTinh.DataPropertyName = "DonViTinh";
            DonViTinh.HeaderText = "ĐVT";
            DonViTinh.MinimumWidth = 10;
            DonViTinh.Name = "DonViTinh";
            DonViTinh.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F);
            DonGia.DefaultCellStyle = dataGridViewCellStyle1;
            DonGia.HeaderText = "Đơn Giá";
            DonGia.MinimumWidth = 10;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 10;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình Ảnh";
            HinhAnh.MinimumWidth = 10;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 1022);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sản Phẩm";
            WindowState = FormWindowState.Maximized;
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDVT;
        private ComboBox cboLoaiSanPham;
        private TextBox txtTenSP;
        private TextBox txtID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox2;
        private DataGridView dgvSanPham;
        private Label label7;
        private TextBox txtTimKiem;
        private Button btnTim;
        private PictureBox picHinhAnh;
        private NumericUpDown numSoLuong;
        private Button btnDoiAnh;
        private Label label8;
        private NumericUpDown numDonGia;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewImageColumn HinhAnh;
    }
}