using System.ComponentModel.DataAnnotations; 

namespace NguyenThanhTung_1921050664_KiemTra.Models 
{
    public class CA2
    {
        [Key] 
        public int IdCA2 { get; set; } 

        [Display(Name = "Giá trị Số")] 
        public double GiaTriSo { get; set; }

        [Display(Name = "Hoàn Thành")]
        public bool HoanThanh { get; set; }

        [Required(ErrorMessage = "Quá trình không được để trống")] 
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Quá trình phải từ 5 đến 200 ký tự")]
        [Display(Name = "Mô tả Quá Trình")]
        public string LamQuaTrinh { get; set; }
    }
}
