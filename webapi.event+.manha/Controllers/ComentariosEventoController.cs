using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;
using webapi.event_.manha.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace webapi.event_.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ComentariosEventoController : ControllerBase
    {
        private IComentariosEventoRepository _comentariosEventoRepository;
        public ComentariosEventoController()
        {
            _comentariosEventoRepository = new ComentariosEventoRepository();
        }

        [HttpPost]
        public IActionResult Post(ComentariosEvento comentariosEvento)
        {
            try
            {
                _comentariosEventoRepository.Cadastrar(comentariosEvento);

                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("comentario-evento/{idEvento}")]

        public IActionResult GetByIdEvento(Guid idEvento)
        {
            try
            {
                return Ok(_comentariosEventoRepository.Listar(idEvento));
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }
        
        
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_comentariosEventoRepository.BuscarPorId(id));
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _comentariosEventoRepository.Deletar(id);

                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
    }
}


