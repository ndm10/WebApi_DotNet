using Microsoft.EntityFrameworkCore;

namespace my_web_api.Data
{
    public class MyDBContext: DbContext
    {
        public MyDBContext(DbContextOptions options): base(options) { }

        #region DbSet
        public DbSet<HangHoa> HangHoas { get; set;}
        public DbSet<Loai> Loai { get; set;}
        #endregion 
    }
}
