using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface IEventoRepository
    {
        void Cadastra(Evento evento);
        void Deletar(Guid id);
        List<Evento> Listar(Guid id);
        Evento BuscarPorId(Guid id);
        void Atualizar(Guid id, Evento evento);
        
    }
}
