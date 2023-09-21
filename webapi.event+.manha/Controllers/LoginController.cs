using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;
using webapi.event_.manha.Repositories;
using webapi.event_.manha.ViewModels;

namespace webapi.event_.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(LoginViewModel usuario)
        {
            try
            {

                Usuario usuarioBuscado = _usuarioRepository.BuscarPorEmailESenha(usuario.Email!, usuario.Senha!);

                if (usuarioBuscado == null)
                {
                    return StatusCode(401, "Email ou Senha invalidos!");
                }



                //Caso encontre o usuario, prossegue oara a criação do token

                //1º definir as informaçãoes(claims) que serão forncedodas no token (PAYLOAD)


                var claims = new[]
                {
                        new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
                        new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email!),
                        new Claim(JwtRegisteredClaimNames.Name, usuarioBuscado.Senha!),
                        new Claim(ClaimTypes.Role, usuarioBuscado.TiposUsuario!.Titulo!),

                    };

                //2º Definira a chave de acesso ao token                             (mais mudar para o nome do seu projeto)

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("projeto-event-webapi-chave-autenticacao"));

                //3º Definir as credencias do token (HEADER)
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //4º Gerar token
                var token = new JwtSecurityToken(
                        //emissor do token (mais mudar para o nome do seu projeto)
                        issuer: "webapi.event+.manha",

                        //destinatário do token (mais mudar para o nome do seu projeto)
                        audience: "webapi.event+.manha",

                        //dados definidos nas Claims(informações)
                        claims: claims,

                        //tempo de expiração do token
                        expires: DateTime.Now.AddMinutes(5),

                        //Credenciais do Token
                        signingCredentials: creds
                        );

                //5º retornar o token criado

                return Ok(new
                {

                    token = new JwtSecurityTokenHandler().WriteToken(token)

                });


            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }

}