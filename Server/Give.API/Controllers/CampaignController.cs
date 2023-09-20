using Give.API.Shared;
using Give.Service.Dtos;
using Microsoft.AspNetCore.Mvc;
using Give.Service.Abstractions;

namespace Give.API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/campaign")]
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
            return CampaignMapper.Map(await _CampaignService.GetAllNoTrackingAsync(cancellationToken));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            try
            {
                var campaign = await _CampaignService.FindByIdAsync(id, cancellationToken);
                if (campaign == null)
                {
                    return NotFound();
                }
                return Ok(CampaignMapper.Map(campaign));
            }
            catch (Exception ex)
            {
                // Log the exception
                // ...

                // Return a 500 Internal Server Error status code
                return StatusCode(500, "An internal server error occurred.");
            }
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody] CampaignDto campaignDto, CancellationToken cancellationToken)
        {
            if (campaignDto == null)
            {
                return BadRequest("Invalid campaign data");
            }

            try
            {
                await _CampaignService.AddAsync(CampaignMapper.MapPost(campaignDto), cancellationToken);
                // Assuming you have a route for getting the created resource
                return CreatedAtAction(nameof(GetById), new { id = campaignDto.Id }, CampaignMapper.Map(campaignDto));
            }
            catch (Exception)
            {
                return StatusCode(500, "An internal server error occurred.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            var campaign = await _CampaignService.FindByIdAsync(id, cancellationToken);

            if (campaign == null)
            {
                return NotFound();
            }

            try
            {
                _CampaignService.Delete(campaign);

                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500, "An internal server error occurred.");
            }

        }
    }
}
