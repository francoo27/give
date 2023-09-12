using Give.DataAccess.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Give.DataAccess.Repositories
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class
    {
        internal readonly AppDbContext _ctx;
        private DbSet<T>? entity;
        private ICampañaRepository campañaRepository;

        public EntityBaseRepository(AppDbContext ctx) {
            _ctx = ctx;
            entity = _ctx.Set<T>();
        }

        public EntityBaseRepository(ICampañaRepository campañaRepository)
        {
            this.campañaRepository = campañaRepository;
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await entity.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Save()
        {
            throw new NotImplementedException();
        }

        public Task Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}