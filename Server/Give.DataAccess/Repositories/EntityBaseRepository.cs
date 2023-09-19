using Give.DataAccess.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Give.DataAccess.Repositories
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T>, IDisposable, IAsyncDisposable where T : class
    {
        private readonly AppDbContext _ctx;
        private DbSet<T> _entity;
        private bool disposedValue;

        public EntityBaseRepository(AppDbContext ctx)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
            _entity = _ctx.Set<T>();
        }

        public void Update(T entity) => _entity.Update(entity);
        public void Delete(T entity) => _entity.Remove(entity);
        public void DeleteRange(IEnumerable<T> entities) => _entity.RemoveRange(entities);
        public void Save() => _ctx.SaveChanges();

        public T FindById(int id) => _entity.Find(id);
        public async Task<List<T>> GetAllNoTrackingAsync(CancellationToken cancellationToken = default) => await _entity.AsNoTracking().ToListAsync(cancellationToken);
        public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default) => await _entity.ToListAsync(cancellationToken);
        public async Task<T> FindByIdAsync(int id, CancellationToken cancellationToken = default) => await _entity.FindAsync(new object[] { id }, cancellationToken);
        public async Task AddAsync(T entity, CancellationToken cancellationToken = default) => await _entity.AddAsync(entity, cancellationToken);
        public async Task SaveAsync(CancellationToken cancellationToken = default) => await _ctx.SaveChangesAsync(cancellationToken);

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore();
            Dispose(disposing: false);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Dispose of managed resources here
                    _ctx.Dispose();
                }

                // Free unmanaged resources (unmanaged objects) and override finalizer if needed

                disposedValue = true;
            }
        }

        private async ValueTask DisposeAsyncCore()
        {
            if (!disposedValue)
            {
                // Dispose of managed resources here asynchronously
                await _ctx.DisposeAsync();
                disposedValue = true;
            }
        }

        ~EntityBaseRepository()
        {
            Dispose(disposing: false);
        }
    }
}
