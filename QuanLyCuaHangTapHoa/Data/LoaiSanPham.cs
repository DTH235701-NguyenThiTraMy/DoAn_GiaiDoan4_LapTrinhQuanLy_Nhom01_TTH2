using Microsoft.EntityFrameworkCore.ChangeTracking; // Thư viện hỗ trợ danh sách dữ liệu
using System.Collections.Generic;

namespace QuanLyCuaHangTapHoa.Data // Tên namespace khớp với dự án của bạn [cite: 102]
{
    public class LoaiSanPham
    {
        // Mã loại sản phẩm: Khóa chính tự động tăng [cite: 106]
        public int ID { get; set; }

        // Tên loại sản phẩm (Ví dụ: Đồ gia dụng, Thực phẩm, Nước giải khát...) [cite: 109]
        public string TenLoai { get; set; }

        // Danh sách các sản phẩm thuộc loại này 
        // Sử dụng ObservableCollectionListSource giúp DataGridView tự động cập nhật khi có thay đổi
        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();
    }
}