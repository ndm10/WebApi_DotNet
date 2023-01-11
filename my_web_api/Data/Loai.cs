using System.ComponentModel.DataAnnotations;

namespace my_web_api.Data
{
    public class Loai
    {
        [Key]
        public int MaLoai { get; set; }
        [Required,MaxLength(50)]
        public String TenLoai { get; set; }


        public virtual ICollection<HangHoa> HangHoas { get; set; }
    }
}
