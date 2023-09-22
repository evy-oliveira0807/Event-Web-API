﻿using webapi.event_.manha.Contexts;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;

namespace webapi.event_.manha.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly EventContext _eventContext;
        public EventoRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, Evento evento)
        {

            Evento eventoBuscado = _eventContext.Evento.Find(id)!;

            if (eventoBuscado != null)
            {
                eventoBuscado.Descricao = evento.Descricao;
            }

            _eventContext.Evento.Update(eventoBuscado!);


            _eventContext.SaveChanges();
        }

    

    public Evento BuscarPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Cadastra(Evento evento)
    {
            _eventContext.Evento.Add(evento);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
    {
            Evento eventoBuscado = _eventContext.Evento.Find(id)!;

            _eventContext.Evento.Remove(eventoBuscado);

            _eventContext.SaveChanges();
        }

        public List<Evento> Listar(Guid id)
    {
            return _eventContext.Evento.ToList();
        }

        public object? Listar()
        {
            throw new NotImplementedException();
        }
    }
}


