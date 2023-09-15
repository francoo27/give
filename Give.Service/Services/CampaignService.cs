using Give.DataAccess.Abstractions;
using Give.Domain.Models;
using Give.Service.Abstractions;

namespace Give.Service.Services
{
    public sealed class CampaignService : EntityBaseService<Campaign>, ICampaignService
    {
        private readonly ICampaignRepository _CampaignRepository;
        public CampaignService(ICampaignRepository CampaignRepository):base(CampaignRepository)
        {
            _CampaignRepository = CampaignRepository ?? throw new ArgumentNullException(nameof(CampaignRepository));
        }

    }
}
