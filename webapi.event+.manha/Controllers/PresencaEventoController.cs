using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.event_.manha.Controllers;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;
using webapi.event_.manha.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace webapi.event_.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PresencaEventoController : ControllerBase
    {
        private IPresencaEventoRepository _presencaEventoRepository;

        public PresencaEventoController()
        {
            _presencaEventoRepository = new PresencaEventoRepository();
        }
        [HttpPost]
        public IActionResult Post(PresencaEvento presencaEvento)
        {
            try
            {
                _presencaEventoRepository.Cadastrar(presencaEvento);
                return StatusCode(201);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(_presencaEventoRepository.Listar());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetByUser(Guid id)
        {
            try
            {
                return Ok(_presencaEventoRepository.ListarPresencasUser(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, PresencaEvento presencaEvento)
        {
            try
            {
                _presencaEventoRepository.Atualizar(id, presencaEvento);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {

            try
            {
                _presencaEventoRepository.Deletar(id);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }


    }
}

