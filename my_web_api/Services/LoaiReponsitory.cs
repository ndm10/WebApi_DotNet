using Microsoft.EntityFrameworkCore;
using my_web_api.Data;
using my_web_api.Models;

namespace my_web_api.Services
{
    public class LoaiReponsitory : ILoaiReponsitory
    {
        private readonly MyDBContext _context;

        public LoaiReponsitory(MyDBContext context)
        {
            _context = context;
        }
        public LoaiVM Create(LoaiModel loai)
        {
            var data = new Loai()
            {
                TenLoai = loai.TenLoai
            };
            _context.Loai.Add(data);
            _context.SaveChanges();
            return new LoaiVM()
            {
                TenLoai = data.TenLoai,
                MaLoai = data.MaLoai,
            };
        }

        public void Delete(int id)
        {
            var data = _context.Loai.SingleOrDefault(x => x.MaLoai == id);
            if (data != null)
                _context.Loai.Remove(data);
            _context.SaveChanges();
        }

        public List<LoaiVM> getAll()
        {
            var data = _context.Loai.Select(x => new LoaiVM
            {
                MaLoai = x.MaLoai,
                TenLoai = x.TenLoai,
            });
            return data.ToList();
        }

        public LoaiVM getByID(int id)
        {
            var data = _context.Loai.SingleOrDefault(x => x.MaLoai == id);
            if (data != null)
            {
                return new LoaiVM()
                {
                    MaLoai = data.MaLoai,
                    TenLoai = data.TenLoai,
                };
            }
            return null;

        }

        public void Update(LoaiVM loai)
        {
            var data = _context.Loai.SingleOrDefault(x => x.MaLoai == loai.MaLoai);
            if (data != null)
            {
                data.TenLoai = loai.TenLoai;
            }
            _context.SaveChanges(); 


        }
    }
}
