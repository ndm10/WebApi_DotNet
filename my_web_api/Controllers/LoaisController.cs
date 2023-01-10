using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_web_api.Data;
using my_web_api.Models;

namespace my_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaisController : ControllerBase
    {
        private readonly MyDBContext _context;

        public LoaisController(MyDBContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var dsLoai = _context.Loai.ToList();
            return Ok(dsLoai);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var loai = _context.Loai.SingleOrDefault(l => l.MaLoai == id);
            if(loai == null){
                return NotFound();
            }
            else
            {
                return Ok(loai);
            }
        }

        [HttpPost]
        public IActionResult CreateLoai(LoaiModel model)
        {
            try
            {
                var loai = new Loai
                {
                    TenLoai = model.TenLoai
                };
                _context.Add(loai);
                _context.SaveChanges();
                return Ok(loai);
            }catch(Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpPut("{id}")]
        public IActionResult UpdateById(int id, LoaiModel model)
        {
            var loai = _context.Loai.SingleOrDefault(l => l.MaLoai == id);
            if (loai == null)
            {
                return NotFound();
            }
            else
            {
                loai.TenLoai = model.TenLoai;
                return NoContent();
            }
        }
    }
}
