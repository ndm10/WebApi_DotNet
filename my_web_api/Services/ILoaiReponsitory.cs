using my_web_api.Data;
using my_web_api.Models;

namespace my_web_api.Services
{
    public interface ILoaiReponsitory
    {
        List<LoaiVM> getAll();
        LoaiVM getByID(int id);
        LoaiVM Create(LoaiModel loai);
        void Update(LoaiVM loai);
        void Delete(int id);
    }
}
