using webapi.event_.manha.Contexts;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;

namespace webapi.event_.manha.Repositories
{
    public class ComentariosEventoRepository : IComentariosEventoRepository
    {
        private readonly EventContext _eventContext;

        public ComentariosEventoRepository()
        {
            _eventContext = new EventContext();
        }
        public void Atualizar(Guid id, ComentariosEvento comentariosEvento)
        {
            throw new NotImplementedException();
        }

        public ComentariosEvento BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ComentariosEvento comentariosEvento)
        {
                _eventContext.ComentariosEvento.Add(comentariosEvento);

                _eventContext.SaveChanges();
            
        }

        public void Deletar(Guid id)
        {
            try
            {
                ComentariosEvento comentarioEventoBuscado = BuscarPorId(id);

                _eventContext.ComentariosEvento.Remove(comentarioEventoBuscado);

                _eventContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ComentariosEvento> Listar(Guid id)
        {

            return _eventContext.ComentariosEvento.ToList();

        }

        
    }
}

