using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_web_api.Services;

namespace my_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiV2Controller : ControllerBase
    {
        private readonly ILoaiReponsitory _loaiReponsitory;
        public LoaiV2Controller(ILoaiReponsitory loaiReponsitory) {
            _loaiReponsitory = loaiReponsitory;
        }

        [HttpGet]
        public IActionResult GetAll() {
            try {
                return StatusCode(StatusCodes.Status200OK, _loaiReponsitory.getAll);
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var data = _loaiReponsitory.getByID(id);
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return StatusCode(StatusCodes.Status404NotFound);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
