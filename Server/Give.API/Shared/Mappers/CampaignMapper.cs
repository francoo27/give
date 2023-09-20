using Give.Domain.Models;
using Give.Service.Dtos;
using Riok.Mapperly.Abstractions;

namespace Give.API.Shared
{
    [Mapper]
    public static partial class CampaignMapper
    {
        public static partial CampaignDto Map(Campaign source);
        public static partial Campaign Map(CampaignDto source);
        public static partial List<CampaignDto> Map(List<Campaign> source);
        public static partial List<Campaign> Map(List<CampaignDto> source);


        [MapperIgnoreSource(nameof(Campaign.CreatedBy))]
        [MapperIgnoreSource(nameof(Campaign.CreatedDate))]
        [MapperIgnoreSource(nameof(Campaign.UpdatedBy))]
        [MapperIgnoreSource(nameof(Campaign.UpdatedDate))]
        public static partial CampaignDto MapGet(Campaign source);

        [MapperIgnoreTarget(nameof(Campaign.Id))]
        [MapperIgnoreTarget(nameof(Campaign.CreatedBy))]
        [MapperIgnoreTarget(nameof(Campaign.CreatedDate))]
        [MapperIgnoreTarget(nameof(Campaign.UpdatedBy))]
        [MapperIgnoreTarget(nameof(Campaign.UpdatedDate))]
        [MapperIgnoreTarget(nameof(Campaign.State))]
        public static partial Campaign MapPost(CampaignDto source);
    }
}
