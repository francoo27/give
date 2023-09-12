using Give.DataAccess.Abstractions;
using Give.Domain.Models;
using Give.Service.Abstractions;

namespace Give.Service.Services
{
    public sealed class CampañaService : EntityBaseService<Campaña>, ICampañaService
    {
        private readonly ICampañaRepository _campañaRepository;
        public CampañaService(ICampañaRepository campañaRepository):base(campañaRepository)
        {
            _campañaRepository = campañaRepository;
        }

    }
}
