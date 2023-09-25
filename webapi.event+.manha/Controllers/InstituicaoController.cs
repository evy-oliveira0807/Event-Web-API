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
    public class InstituicaoController : ControllerBase
    {
        private IInstituicaoRepository _instituicaoRepository;

        public InstituicaoController()
        {
            _instituicaoRepository = new InstituicaoRepository();
        }
        [HttpPost]
        public IActionResult Post(Instituicao instituicao) 
        {
            try
            {
                _instituicaoRepository.Cadastrar(instituicao);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


    }
}

