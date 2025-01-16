using ApsiyonKasif.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApsionKasif.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrictService _districtService;

        public DistrictController(IDistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpGet]
        [Route("GetDistrictDetail")]
        public async Task<IActionResult> GetDistrictDetail([FromQuery] int districtId)
        {
            return Ok(await _districtService.GetDistrictDetailsAsync(districtId));
        }
    }
}
