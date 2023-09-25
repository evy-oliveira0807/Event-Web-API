using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface IPresencaEventoRepository
    {
        void Cadastrar(PresencaEvento presencaEvento);
        void Deletar(Guid id);
        List<PresencaEvento> Listar();
        PresencaEvento BuscarPorId(Guid id);
        void Atualizar(Guid id, PresencaEvento presencaEvento);

        List<PresencaEvento> ListarPresencasUser(Guid idUsuario);
    }
}
