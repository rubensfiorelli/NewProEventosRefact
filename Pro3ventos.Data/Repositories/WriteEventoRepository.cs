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


        public async Task<Evento> InsertEvento(Evento evento)
        {
            try
            {
                using (_context)
                {
                    _context.Eventos.Add(evento);

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return evento;

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
