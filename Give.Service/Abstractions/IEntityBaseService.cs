using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Give.Service.Abstractions
{
    public interface IEntityBaseService<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetById(int id);
        Task Update(T obj);
        Task Delete(int id);
        Task Save();
    }
}
