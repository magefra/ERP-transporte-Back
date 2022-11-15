using Microsoft.AspNetCore.Mvc;

namespace ERPTransporteBack.Api.Controllers.Catalogos
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalidadController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
