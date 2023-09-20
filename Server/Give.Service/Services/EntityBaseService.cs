using Give.DataAccess.Abstractions;
using Give.Service.Abstractions;
using Microsoft.EntityFrameworkCore;

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

        public async Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            await _entityBaseRepository.AddAsync(entity, cancellationToken);
            _entityBaseRepository.Save();
        }

        public void Delete(T entity)
        {
            _entityBaseRepository.Delete(entity);
            _entityBaseRepository.Save();
        }

        public void Update(T entity)
        {
            _entityBaseRepository.Update(entity);
            _entityBaseRepository.Save();
        }
    }
}
