using System.ComponentModel.DataAnnotations;

namespace my_web_api.Models
{
    public class LoaiModel
    {
        [Required, MaxLength(50)]
        public String TenLoai { get; set; }
    }
}
