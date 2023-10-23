using Give.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Give.DataAccess.Abstractions
{
    public interface IEntityBaseRepository<T> : IDisposable, IAsyncDisposable 
        where T : class
    {
        public T FindById(int id);
        public void Update(T entity);
        public void Delete(T entity);
        public void DeleteRange(IEnumerable<T> entities);
        public void Save();
        public Task<List<T>> GetAllNoTrackingAsync(CancellationToken cancellationToken = default);
        public Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);
        public Task<T> FindByIdAsync(int id, CancellationToken cancellationToken = default);
        public Task AddAsync(T entity, CancellationToken cancellationToken = default);
        public Task SaveAsync(CancellationToken cancellationToken = default);
    }
}
