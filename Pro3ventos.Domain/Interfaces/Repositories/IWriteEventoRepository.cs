using Pro3ventos.Domain.Entities;
using Pro3ventos.Domain.Interfaces.Abstractions;

namespace Pro3ventos.Domain.Interfaces.Repositories
{
    public interface IWriteEventoRepository : IUnitOfWork
    {
        Task<Evento> InsertEvento(Evento evento);
    }
}
