using Give.DataAccess.Abstractions;
using Give.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Give.DataAccess.Repositories
{
    public class CampaignRepository : EntityBaseRepository<Campaign>, ICampaignRepository
    {
        public CampaignRepository(AppDbContext ctx) : base(ctx)
        {
        }
    }
}
