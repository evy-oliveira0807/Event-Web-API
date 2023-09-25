using Microsoft.AspNetCore.Mvc;
using webapi.event_.manha.Contexts;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;
using webapi.event_.manha.Repositories;

namespace webapi.event_.manha.Repositories
{
    public class InstituicaoRepository : IInstituicaoRepository
    {
        private EventContext _eventContext;

        public InstituicaoRepository()
        {
            _eventContext = new EventContext();
        }
        public void Atualizar(Guid id, Instituicao instituicao)
        {
            throw new NotImplementedException();
        }

        public Instituicao BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Instituicao instituicao)
        {
            _eventContext.Add(instituicao);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Instituicao> Listar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}


