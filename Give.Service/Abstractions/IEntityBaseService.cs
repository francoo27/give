namespace Give.Service.Abstractions
{
    public interface IEntityBaseService<T> where T : class
    {
        Task<List<T>> ToListAsync(CancellationToken cancellationToken);
        Task<T> FindAsync(int id, CancellationToken cancellationToken);
        Task<T> UpdateAsync(T obj, CancellationToken cancellationToken);
        Task DeleteAsync(int id, CancellationToken cancellationToken);
    }
}
