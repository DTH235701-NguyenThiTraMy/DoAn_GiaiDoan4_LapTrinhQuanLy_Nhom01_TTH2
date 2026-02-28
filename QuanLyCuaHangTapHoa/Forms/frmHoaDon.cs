using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTapHoa.Forms
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadSanPham();
        }
        private void LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyCuaHangTapHoa;Integrated Security=True"))
            {
                string query = "SELECT ID, TenKhachHang FROM KhachHang";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboKhachHang.DataSource = dt;
                cboKhachHang.DisplayMember = "TenKhachHang";
                cboKhachHang.ValueMember = "ID";
            }
        }
        private void LoadSanPham()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyCuaHangTapHoa;Integrated Security=True"))
            {
                string query = "SELECT ID, TenSanPham, DonGia FROM SanPham";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboSanPham.DataSource = dt;
                cboSanPham.DisplayMember = "TenSanPham";
                cboSanPham.ValueMember = "ID";
            }
        }
        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem is DataRowView row)
            {
                txtDonGia.Text = row["DonGia"].ToString();
            }
        }
    }
}
