using Give.API.Shared;
using Give.Domain.Models;
using Give.Service.Dtos;
using Microsoft.AspNetCore.Mvc;
using Give.Service.Abstractions;
using Give.Service.Services;

namespace Give.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampañaController : ControllerBase
    {
        private readonly ILogger<CampañaController> _logger;
        private readonly ICampañaService _campañaService;

        public CampañaController(ILogger<CampañaController> logger, ICampañaService campañaService)
        {
            _logger = logger;
            _campañaService = campañaService;
        }

        [HttpGet(Name = "GetCampañas")]
        public async Task<List<CampañaDto>> GetCampañas()
        {
            Campaña campaña = new(2,DateTime.Now, DateTime.Now,"w","e","qweqwe");
            var campañas = await _campañaService.GetAllAsync();
            var campañasDto = MapperlyMapper.Map(campañas);
            return campañasDto;
        }
    }
}