using Give.Domain.Models;
using Give.Service.Dtos;
using Riok.Mapperly.Abstractions;
using System.Collections.Generic;

namespace Give.API.Shared
{
    [Mapper]
    public static partial class MapperlyMapper
    {
        public static partial CampaignDto Map(Campaign source);
        public static partial Campaign Map(CampaignDto source);
        public static partial List<CampaignDto> Map(List<Campaign> source);
        public static partial List<Campaign> Map(List<CampaignDto> source);
    }
}
