using Give.Domain.Models;
using Give.Service.Dtos;
using Riok.Mapperly.Abstractions;
using System;

namespace Give.API.Shared
{
    [Mapper]
    public static  partial class MapperlyMapper
    {
        [MapDerivedType<Campaña, CampañaDto>]
        public static partial EntityBaseDto Map(EntityBase source);
        public static partial CampañaDto Map(Campaña campañaDto);
        public static partial List<CampañaDto> Map(List<Campaña> campañaDto);
        //public partial EntityBase Map(EntityBaseDto entityBase);
    }
}
