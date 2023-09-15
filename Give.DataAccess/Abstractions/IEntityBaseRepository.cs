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
        Task<List<T>> ToListAsync(CancellationToken cancellationToken);
        Task<T> FindAsync(int id, CancellationToken cancellationToken);
        Task<T> UpdateAsync(T obj, CancellationToken cancellationToken);
        Task DeleteAsync(int id, CancellationToken cancellationToken);
    }
}
