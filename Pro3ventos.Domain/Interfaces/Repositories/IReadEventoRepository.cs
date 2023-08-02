using Pro3ventos.Domain.DTOs;

namespace Pro3ventos.Domain.Interfaces.Repositories
{
    public interface IReadEventoRepository
    {
        Task<ICollection<EventoDto>> GetEventosAsyn();
        Task<ICollection<EventoDto>> GetEventoNomeAsync(string nome);
        Task<EventoDto> GetIdAsync(Guid id);
    }
}
