using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyCuaHangTapHoa.Data
{
    public class KhachHang
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(10)]
        public string SoDienThoai { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        // Liên kết với hóa đơn: Một khách hàng có thể có nhiều hóa đơn
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}