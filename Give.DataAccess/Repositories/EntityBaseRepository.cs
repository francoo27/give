using Give.DataAccess.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Give.DataAccess.Repositories
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class
    {
        private readonly AppDbContext _ctx;
        private DbSet<T> entity;

        public EntityBaseRepository(AppDbContext ctx)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
            entity = _ctx.Set<T>();
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var entityToDelete = await FindAsync(id, cancellationToken);
            if (entityToDelete != null)
            {
                entity.Remove(entityToDelete);
                await _ctx.SaveChangesAsync(cancellationToken);
            }
        }

        public async Task<List<T>> ToListAsync(CancellationToken cancellationToken = default)
        {
            return await entity.ToListAsync(cancellationToken);
        }

        public async Task<T> FindAsync(int id, CancellationToken cancellationToken = default)
        {
            return await entity.FindAsync(new object[] { id }, cancellationToken);
        }

        public async Task<T> UpdateAsync(T obj, CancellationToken cancellationToken = default)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            entity.Update(obj);
            await _ctx.SaveChangesAsync(cancellationToken);
            return obj;
        }
    }
}
