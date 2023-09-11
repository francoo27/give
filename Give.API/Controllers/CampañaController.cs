using Give.API.Shared;
using Give.Domain.Models;
using Give.Service.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Give.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Campa�aController : ControllerBase
    {
        private readonly ILogger<Campa�aController> _logger;

        public Campa�aController(ILogger<Campa�aController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCampa�a")]
        public Campa�aDto Get()
        {
            Campa�a campa�a = new(2,DateTime.Now, DateTime.Now,"w","e","qweqwe");
            var campa�aDto = MapperlyMapper.Map(campa�a);
            return campa�aDto;
        }
    }
}