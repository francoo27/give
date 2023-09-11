using Give.API.Shared;
using Give.Domain.Models;
using Give.Service.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Give.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampañaController : ControllerBase
    {
        private readonly ILogger<CampañaController> _logger;

        public CampañaController(ILogger<CampañaController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCampaña")]
        public CampañaDto Get()
        {
            Campaña campaña = new(2,DateTime.Now, DateTime.Now,"w","e","qweqwe");
            var campañaDto = MapperlyMapper.Map(campaña);
            return campañaDto;
        }
    }
}