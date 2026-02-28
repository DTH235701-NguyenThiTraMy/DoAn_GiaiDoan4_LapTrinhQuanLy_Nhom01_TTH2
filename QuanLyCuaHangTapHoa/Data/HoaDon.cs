using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCuaHangTapHoa.Data
{
    public class HoaDon
    {
        public int ID { get; set; }

        public DateTime NgayLap { get; set; }

        public int NhanVienID { get; set; }
        public virtual NhanVien NhanVien { get; set; }

        // Khách lẻ được phép null
        public int? KhachHangID { get; set; }
        public virtual KhachHang KhachHang { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TongTien { get; set; }

        public string? GhiChu { get; set; }

        public virtual ICollection<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }
    }
}