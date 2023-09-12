using Give.DataAccess.Abstractions;
using Give.DataAccess.Repositories;
using Give.Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Give.Service.Services
{
    public class EntityBaseService<T> : IEntityBaseService<T> where T : class
    {
        private readonly IEntityBaseRepository<T> _entityBaseRepository;
        public EntityBaseService(IEntityBaseRepository<T> entityBaseRepository) {
            _entityBaseRepository = entityBaseRepository;
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _entityBaseRepository.GetAllAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _entityBaseRepository.GetById(id);
        }

        public async Task Save()
        {
            throw new NotImplementedException();
        }

        public async Task Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
