using Give.DataAccess.Abstractions;
using Give.Service.Abstractions;

namespace Give.Service.Services
{
    public class EntityBaseService<T> : IEntityBaseService<T> where T : class
    {
        private readonly IEntityBaseRepository<T> _entityBaseRepository;

        public EntityBaseService(IEntityBaseRepository<T> entityBaseRepository)
        {
            _entityBaseRepository = entityBaseRepository ?? throw new ArgumentNullException(nameof(entityBaseRepository));
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            await _entityBaseRepository.DeleteAsync(id, cancellationToken);
        }

        public async Task<List<T>> ToListAsync(CancellationToken cancellationToken)
        {
            return await _entityBaseRepository.ToListAsync(cancellationToken);
        }

        public async Task<T> FindAsync(int id, CancellationToken cancellationToken)
        {
            return await _entityBaseRepository.FindAsync(id, cancellationToken);
        }

        public async Task<T> UpdateAsync(T obj, CancellationToken cancellationToken)
        {
            return await _entityBaseRepository.UpdateAsync(obj, cancellationToken);
        }
    }
}
