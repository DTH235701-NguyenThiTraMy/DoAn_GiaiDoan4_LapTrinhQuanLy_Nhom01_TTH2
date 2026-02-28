using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCuaHangTapHoa.Data
{
    public class SanPham
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string TenSanPham { get; set; }

        public decimal DonGia { get; set; }

        public int SoLuong { get; set; }

        [StringLength(50)]
        public string DonViTinh { get; set; }

        public int LoaiSanPhamID { get; set; }

        [ForeignKey("LoaiSanPhamID")]
        public virtual LoaiSanPham LoaiSanPham { get; set; }

        public string? HinhAnh { get; set; }

        public virtual ICollection<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }
    }
}