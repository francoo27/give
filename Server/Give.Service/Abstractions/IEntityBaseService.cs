namespace Give.Service.Abstractions
{
    public interface IEntityBaseService<T> where T : class
    {
        Task<List<T>> GetAllNoTrackingAsync(CancellationToken cancellationToken);
        Task<T> FindByIdAsync(int id, CancellationToken cancellationToken);
        public Task AddAsync(T entity, CancellationToken cancellationToken);
        void Update(T entity);
        void Delete(T entity);
    }
}
