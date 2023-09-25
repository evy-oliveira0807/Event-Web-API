using Microsoft.EntityFrameworkCore;
using webapi.event_.manha.Contexts;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;
using webapi.event_.manha.Repositories;

namespace webapi.event_.manha.Repositories
{
    public class PresencaEventoRepository : IPresencaEventoRepository
    {
        private readonly EventContext _eventContext;

        public PresencaEventoRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, PresencaEvento presencaEvento)
        {
            try
            {
                PresencaEvento presencaEventoEncontrado = _eventContext.PresencaEvento.FirstOrDefault(pe => pe.IdPresencaEvento == id)!;

                if (presencaEventoEncontrado == null)
                {
                    throw new Exception($"A presença de evento com o ID {id} não foi encontrada");
                }

                presencaEventoEncontrado.Situacao = presencaEvento.Situacao;

                _eventContext.PresencaEvento.Update(presencaEventoEncontrado);

                _eventContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public PresencaEvento BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(PresencaEvento presencaEvento)
        {
            try
            {
                _eventContext.PresencaEvento.Add(presencaEvento);

                _eventContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Deletar(Guid id)
        {
            try
            {
                PresencaEvento presencaEventoEncontrado = _eventContext.PresencaEvento.FirstOrDefault(pe => pe.IdPresencaEvento == id)!;

                if (presencaEventoEncontrado == null)
                {
                    throw new Exception($"A presença de evento com o ID {id} não foi encontrada");
                }

                _eventContext.PresencaEvento.Remove(presencaEventoEncontrado);

                _eventContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<PresencaEvento> Listar()
        {
            return _eventContext.PresencaEvento.Include(pe => pe.Usuario).Include(pe => pe.Evento).ToList();
        }
        public List<PresencaEvento> ListarPresencasUser(Guid idUsuario)
        {

            return _eventContext.PresencaEvento.Where(pe => pe.IdUsuario == idUsuario).Include(pe => pe.Usuario).Include(pe => pe.Evento).ToList();
        }
    }
}









