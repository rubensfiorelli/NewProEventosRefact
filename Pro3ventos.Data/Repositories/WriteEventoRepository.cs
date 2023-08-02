using Pro3ventos.Data.Input.DataContext;
using Pro3ventos.Domain.Entities;
using Pro3ventos.Domain.Interfaces.Repositories;

namespace Pro3ventos.Data.Input.Repositories
{
    public class WriteEventoRepository : IWriteEventoRepository
    {
        private readonly ApplicationDbContext _context;

        public WriteEventoRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public Task<Evento> InsertEvento(Evento evento)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public Task Rollback()
        {
            return Task.CompletedTask;
        }
    }
}
