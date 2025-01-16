using ApsiyonKasif.Core.DTOs.RequestDto;
using ApsiyonKasif.Core.Entities;
using ApsiyonKasif.Core.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApsionKasif.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //[Authorize]
    public class AdvertController : ControllerBase
    {
        private readonly IAdvertService _advertService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AdvertController(IAdvertService advertService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _advertService = advertService;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost]
        public async Task<IActionResult> Advert(CreateAdvertDto advertDto)
        {
            var advert = _mapper.Map<Advert>(advertDto);
            await _advertService.AddAsync(advert);
            return Ok("Added");
        }

        [HttpGet]
        [Route("AdvertFilter")]
        public async Task<IActionResult> AdvertFilter([FromQuery] AdvertFilterDto filter)
        {
            return Ok(await _advertService.AdvertFilter(filter));
        }

        [HttpGet]
        [Route("AdvertDetail")]
        public async Task<IActionResult> AdvertDetail(int advertId)
        {
            return Ok(await _advertService.AdvertDetail(advertId));
        }
    }
}
