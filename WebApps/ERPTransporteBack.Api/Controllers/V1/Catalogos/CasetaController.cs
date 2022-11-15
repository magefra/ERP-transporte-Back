using Microsoft.AspNetCore.Mvc;

namespace ERPTransporteBack.Api.Controllers.V1.Catalogos
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasetaController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
