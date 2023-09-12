using Give.DataAccess.Abstractions;
using Give.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Give.DataAccess.Repositories
{
    public class CampañaRepository : EntityBaseRepository<Campaña>, ICampañaRepository
    {
        public CampañaRepository(AppDbContext ctx) : base(ctx)
        {
        }

        public async Task<List<Campaña>> GetAllCampañasAsync()
        {
            return await _ctx.Campaña.ToListAsync();
        }

        public Task<Campaña> GetCampañaById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
