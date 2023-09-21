using webapi.event_.manha.Contexts;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;

namespace webapi.event_.manha.Repositories
{
    public class TiposEventoRepository : ITiposEventoRepository
    {
        private readonly EventContext _eventContext;

        public TiposEventoRepository()
        {
            _eventContext = new EventContext();
        }
        public void Atualizar(Guid id, TiposEvento tiposEvento)
        {
            throw new NotImplementedException();
        }

        public TiposEvento BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposEvento tiposEvento)
        {
           
           _eventContext.TiposEvento.Add(tiposEvento);
            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TiposEvento> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
