using webapi.event_.manha.Controllers;
using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface IInstituicaoRepository
    {
        void Cadastrar(Instituicao instituicao);
        void Deletar(Guid id);
        List<Instituicao> Listar(Guid id);
        Instituicao BuscarPorId(Guid id);
        void Atualizar(Guid id, Instituicao instituicao);
     
    }
}
