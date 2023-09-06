using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Data.Requests;
using UsuariosApi.Service;

namespace UsuariosApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private CadastroService _cadastroService;

        public CadastroController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public IActionResult CadastroUsuario(CreateUsuarioDto createDto)
        {
            Result resultado = _cadastroService.CadastraUsuario(createDto);
            if (resultado.IsFailed)
            {
                return StatusCode(500);
            }
            return Ok(resultado.Successes);
        }

        [HttpPost("/ativa")]
        public IActionResult AtivaContaUsuario(AtivaContaRequest request)
        {
            Result restultado = _cadastroService.AtivaContaUsuario(request);
            if (restultado.IsFailed)
            {
                return StatusCode(500);
            }
            return Ok(restultado.Successes);
        }
    }
}
