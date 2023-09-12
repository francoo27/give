using Give.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Give.DataAccess.Abstractions
{
    public interface IEntityBaseRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetById(int id);
        Task Update(T obj);
        Task Delete(int id);
        Task Save();
    }
}
