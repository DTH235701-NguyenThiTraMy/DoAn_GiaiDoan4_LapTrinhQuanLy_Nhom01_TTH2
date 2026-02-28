using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyCuaHangTapHoa.Data
{
    public class NhanVien
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(20)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        // true là Admin (Chủ), false là Nhân viên bán hàng
        public bool QuyenHan { get; set; }

        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}