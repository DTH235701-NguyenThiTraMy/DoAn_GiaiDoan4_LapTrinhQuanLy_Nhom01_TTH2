namespace QuanLyCuaHangTapHoa.Forms
{
    partial class frmLoaiSanPham
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
            panel1 = new Panel();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtTenLoai = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvLoaiSanPham = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(txtTenLoai);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1034, 224);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Location = new Point(0, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 78);
            panel1.TabIndex = 4;
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
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(565, 49);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(449, 39);
            txtTenLoai.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(78, 53);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(200, 39);
            txtID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 56);
            label2.Name = "label2";
            label2.Size = new Size(213, 32);
            label2.TabIndex = 1;
            label2.Text = "Tên loại sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 56);
            label1.Name = "label1";
            label1.Size = new Size(42, 32);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvLoaiSanPham);
            groupBox2.Location = new Point(12, 266);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1034, 418);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // dgvLoaiSanPham
            // 
            dgvLoaiSanPham.AllowUserToAddRows = false;
            dgvLoaiSanPham.AllowUserToDeleteRows = false;
            dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiSanPham.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai });
            dgvLoaiSanPham.Dock = DockStyle.Fill;
            dgvLoaiSanPham.Location = new Point(3, 35);
            dgvLoaiSanPham.MultiSelect = false;
            dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            dgvLoaiSanPham.ReadOnly = true;
            dgvLoaiSanPham.RowHeadersWidth = 82;
            dgvLoaiSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiSanPham.Size = new Size(1028, 380);
            dgvLoaiSanPham.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Tên Loại";
            TenLoai.MinimumWidth = 10;
            TenLoai.Name = "TenLoai";
            TenLoai.ReadOnly = true;
            // 
            // frmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 696);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmLoaiSanPham";
            Text = "frmLoaiSanPham";
            WindowState = FormWindowState.Maximized;
            Load += FrmLoaiSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtTenLoai;
        private TextBox txtID;
        private GroupBox groupBox2;
        private DataGridView dgvLoaiSanPham;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
    }
}