using Give.DataAccess.Abstractions;
using Give.DataAccess.Repositories;
using Give.Service.Abstractions;
using System.Threading;

namespace Give.Service.Services
{
    public class EntityBaseService<T> : IEntityBaseService<T> where T : class
    {
        private readonly IEntityBaseRepository<T> _entityBaseRepository;

        public EntityBaseService(IEntityBaseRepository<T> entityBaseRepository)
        {
            _entityBaseRepository = entityBaseRepository ?? throw new ArgumentNullException(nameof(entityBaseRepository));
        }
        public async Task<List<T>> GetAllNoTrackingAsync(CancellationToken cancellationToken) => await _entityBaseRepository.GetAllNoTrackingAsync(cancellationToken);

        public async Task<T> FindByIdAsync(int id, CancellationToken cancellationToken) => await _entityBaseRepository.FindByIdAsync(id, cancellationToken);

        public void Delete(T entity) => _entityBaseRepository.Delete(entity);

        public void Update(T entity) => _entityBaseRepository.Update(entity);
    }
}
