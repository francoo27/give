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
    public class Campa�aController : ControllerBase
    {
        private readonly ILogger<Campa�aController> _logger;
        private readonly ICampa�aService _campa�aService;

        public Campa�aController(ILogger<Campa�aController> logger, ICampa�aService campa�aService)
        {
            _logger = logger;
            _campa�aService = campa�aService;
        }

        [HttpGet(Name = "GetCampa�as")]
        public async Task<List<Campa�aDto>> GetCampa�as()
        {
            Campa�a campa�a = new(2,DateTime.Now, DateTime.Now,"w","e","qweqwe");
            var campa�as = await _campa�aService.GetAllAsync();
            var campa�asDto = MapperlyMapper.Map(campa�as);
            return campa�asDto;
        }
    }
}