using webapi.event_.manha.Contexts;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;

namespace webapi.event_.manha.Repositories
{
    public class PresencaEventoRepository : IPresencaEventoRepository
    {
        private object _eventContext;

        public void Atualizar(Guid id, PresencaEvento presencaEvento)
        {
            throw new NotImplementedException();
        }

        public PresencaEvento BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(PresencaEvento presencaEvento)
        {

            _eventContext.PresencaEvento.Add(presencaEvento);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<PresencaEvento> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
