using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCuaHangTapHoa.Data
{
    public class HoaDon_ChiTiet
    {
        public int ID { get; set; }

        public int HoaDonID { get; set; }
        public virtual HoaDon HoaDon { get; set; }

        public int SanPhamID { get; set; }
        public virtual SanPham SanPham { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DonGia { get; set; } // Giá tại thời điểm bán

        [Column(TypeName = "decimal(18,2)")]
        public decimal ThanhTien { get; set; }
    }
}