using ApsiyonKasif.Repository.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApsionKasif.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IsLoggedController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult IsLogged()
        {
            return Ok();
        }
    }
}
