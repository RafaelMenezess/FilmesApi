using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace UsuariosApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastroUsuario(CreateUsuarioDto createDto)
        {
            return Ok();
        }
    }
}
