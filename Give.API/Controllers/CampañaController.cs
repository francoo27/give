using Give.API.Shared;
using Give.Domain.Models;
using Give.Service.Dtos;
using Microsoft.AspNetCore.Mvc;
using Give.Service.Abstractions;
using System.Threading;
using System.Threading.Tasks;

namespace Give.API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CampaignController : ControllerBase
    {
        private readonly ILogger<CampaignController> _logger;
        private readonly ICampaignService _CampaignService;

        public CampaignController(ILogger<CampaignController> logger, ICampaignService CampaignService)
        {
            _logger = logger;
            _CampaignService = CampaignService;
        }

        [HttpGet("")]
        public async Task<List<CampaignDto>> Get(CancellationToken cancellationToken)
        {
            return MapperlyMapper.Map(await _CampaignService.ToListAsync(cancellationToken));
        }

        [HttpGet("{id}")]
        public async Task<CampaignDto> GetById(int id, CancellationToken cancellationToken)
        {
            return MapperlyMapper.Map(await _CampaignService.FindAsync(id, cancellationToken));
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody] CampaignDto campaignDto, CancellationToken cancellationToken)
        {
            if (campaignDto == null)
            {
                return BadRequest("Invalid campaign data");
            }

            var createdCampaign = await _CampaignService.UpdateAsync(MapperlyMapper.Map(campaignDto), cancellationToken);

            // Assuming you have a route for getting the created resource
            return CreatedAtAction(nameof(GetById), new { id = createdCampaign.Id }, MapperlyMapper.Map(createdCampaign));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            var campaign = await _CampaignService.FindAsync(id, cancellationToken);

            if (campaign == null)
            {
                return NotFound();
            }

            await _CampaignService.DeleteAsync(id, cancellationToken);

            return NoContent();
        }
    }
}
