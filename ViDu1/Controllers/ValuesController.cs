using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ViDu1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("cv_dt")]
        public IActionResult tinh_chuvi_dientich_duongkinh(double rr) // rr là bán kính
        {
            if (rr <= 0)
                return BadRequest("Bán kính phải dương");

            double cv = 3.14 * 2 * rr;
            double dt = 3.14 * rr * rr;
            double dk = 2 * rr;

            var json_str = new { dien_tich = dt, chu_vi = cv, duong_kinh = dk };
            return Ok(json_str);
        }
    }
}
