namespace QuanLyCuaHangTapHoa.Forms
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            mnuMain = new MenuStrip();
            mnuHoaDon = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuLoaiSanPham = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            mnuNghiepVu = new ToolStripMenuItem();
            bánHàngToolStripMenuItem1 = new ToolStripMenuItem();
            nhậpKhoToolStripMenuItem = new ToolStripMenuItem();
            mnuThongKe = new ToolStripMenuItem();
            doanhThuToolStripMenuItem1 = new ToolStripMenuItem();
            cảnhBáoHàngSắpHếtToolStripMenuItem = new ToolStripMenuItem();
            stsMain = new StatusStrip();
            lblUser = new ToolStripStatusLabel();
            lblSpace = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            tmrClock = new System.Windows.Forms.Timer(components);
            pnContent = new Panel();
            mnuMain.SuspendLayout();
            stsMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.ImageScalingSize = new Size(32, 32);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuHoaDon, mnuHeThong, mnuDanhMuc, mnuNghiepVu, mnuThongKe });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(800, 40);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(126, 36);
            mnuHoaDon.Text = "Hóa đơn";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuNhanVien, mnuExit });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(135, 36);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(362, 44);
            mnuDangNhap.Text = "Đăng nhập";
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(362, 44);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(362, 44);
            mnuNhanVien.Text = "Quản lý người dùng";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(362, 44);
            mnuExit.Text = "Thoát";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuDanhMuc
            // 
            mnuDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuLoaiSanPham, sảnPhẩmToolStripMenuItem, kháchHàngToolStripMenuItem });
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Size = new Size(144, 36);
            mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuLoaiSanPham
            // 
            mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            mnuLoaiSanPham.Size = new Size(301, 44);
            mnuLoaiSanPham.Text = "Loại sản phẩm";
            mnuLoaiSanPham.Click += mnuLoaiSanPham_Click;
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(301, 44);
            sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            sảnPhẩmToolStripMenuItem.Click += sảnPhẩmToolStripMenuItem_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(301, 44);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // mnuNghiepVu
            // 
            mnuNghiepVu.DropDownItems.AddRange(new ToolStripItem[] { bánHàngToolStripMenuItem1, nhậpKhoToolStripMenuItem });
            mnuNghiepVu.Name = "mnuNghiepVu";
            mnuNghiepVu.Size = new Size(146, 36);
            mnuNghiepVu.Text = "Nghiệp vụ";
            // 
            // bánHàngToolStripMenuItem1
            // 
            bánHàngToolStripMenuItem1.Name = "bánHàngToolStripMenuItem1";
            bánHàngToolStripMenuItem1.Size = new Size(252, 44);
            bánHàngToolStripMenuItem1.Text = "Bán hàng";
            // 
            // nhậpKhoToolStripMenuItem
            // 
            nhậpKhoToolStripMenuItem.Name = "nhậpKhoToolStripMenuItem";
            nhậpKhoToolStripMenuItem.Size = new Size(252, 44);
            nhậpKhoToolStripMenuItem.Text = "Nhập kho";
            // 
            // mnuThongKe
            // 
            mnuThongKe.DropDownItems.AddRange(new ToolStripItem[] { doanhThuToolStripMenuItem1, cảnhBáoHàngSắpHếtToolStripMenuItem });
            mnuThongKe.Name = "mnuThongKe";
            mnuThongKe.Size = new Size(135, 36);
            mnuThongKe.Text = "Thống kê";
            // 
            // doanhThuToolStripMenuItem1
            // 
            doanhThuToolStripMenuItem1.Name = "doanhThuToolStripMenuItem1";
            doanhThuToolStripMenuItem1.Size = new Size(395, 44);
            doanhThuToolStripMenuItem1.Text = "Doanh thu";
            // 
            // cảnhBáoHàngSắpHếtToolStripMenuItem
            // 
            cảnhBáoHàngSắpHếtToolStripMenuItem.Name = "cảnhBáoHàngSắpHếtToolStripMenuItem";
            cảnhBáoHàngSắpHếtToolStripMenuItem.Size = new Size(395, 44);
            cảnhBáoHàngSắpHếtToolStripMenuItem.Text = "Cảnh báo hàng sắp hết";
            // 
            // stsMain
            // 
            stsMain.ImageScalingSize = new Size(32, 32);
            stsMain.Items.AddRange(new ToolStripItem[] { lblUser, lblSpace, lblTime });
            stsMain.Location = new Point(0, 408);
            stsMain.Name = "stsMain";
            stsMain.Size = new Size(800, 42);
            stsMain.TabIndex = 2;
            stsMain.Text = "statusStrip1";
            // 
            // lblUser
            // 
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(225, 32);
            lblUser.Text = "Người dùng: Admin";
            // 
            // lblSpace
            // 
            lblSpace.Name = "lblSpace";
            lblSpace.Size = new Size(458, 32);
            lblSpace.Spring = true;
            // 
            // lblTime
            // 
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(102, 32);
            lblTime.Text = "00:00:00";
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // pnContent
            // 
            pnContent.Dock = DockStyle.Fill;
            pnContent.Location = new Point(0, 40);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(800, 368);
            pnContent.TabIndex = 4;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnContent);
            Controls.Add(stsMain);
            Controls.Add(mnuMain);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Name = "frmMain";
            Text = "Hệ thống quản lý cửa hàng tạp hóa";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            stsMain.ResumeLayout(false);
            stsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuLoaiSanPham;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem mnuThongKe;
        private ToolStripMenuItem mnuNghiepVu;
        private StatusStrip stsMain;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem bánHàngToolStripMenuItem1;
        private ToolStripMenuItem nhậpKhoToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem1;
        private ToolStripMenuItem cảnhBáoHàngSắpHếtToolStripMenuItem;
        private ToolStripStatusLabel lblUser;
        private ToolStripStatusLabel lblSpace;
        private ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer tmrClock;
        private Panel pnContent;
        private ToolStripMenuItem mnuHoaDon;
    }
}