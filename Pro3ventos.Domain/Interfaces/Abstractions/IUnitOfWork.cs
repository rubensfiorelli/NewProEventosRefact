namespace Pro3ventos.Domain.Interfaces.Abstractions
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
        Task Rollback();

    }
}
