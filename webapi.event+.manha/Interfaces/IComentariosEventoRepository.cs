using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface IComentariosEventoRepository
    {
        void Cadastrar(ComentariosEvento comentariosEvento);
        void Deletar(Guid id);
        List<ComentariosEvento> Listar(Guid id);
        ComentariosEvento BuscarPorId(Guid id);
        void Atualizar(Guid id, ComentariosEvento comentariosEvento);
    }
}
