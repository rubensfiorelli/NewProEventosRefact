using Pro3ventos.Data.Input.DataContext;
using Pro3ventos.Domain.DTOs;
using Pro3ventos.Domain.Interfaces.Repositories;

namespace Pro3ventos.Data.Output.Repositories
{
    public class ReadEventoRepository : IReadEventoRepository
    {

        private readonly ApplicationDbContext _context;

        public ReadEventoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<ICollection<EventoDto>> GetEventoNomeAsync(string nome)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<EventoDto>> GetEventosAsyn()
        {
            throw new NotImplementedException();
        }

        public Task<EventoDto> GetIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
