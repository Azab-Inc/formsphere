using backend.Data;
using backend.DTOs;
using backend.Interfaces;
using backend.Services;
using Microsoft.AspNetCore.Mvc;


namespace backend.Controllers
{
    [Route("config")]
    [ApiController]
    public class ConfigController : BaseController
    {
        private readonly IConfigService _configService;
        public ConfigController(IConfigService configService)
        {
            _configService = configService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                // Return the deserialized object
                return Ok(_configService.GetConfig());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("/setup")]
        public IActionResult Post(ConfigDTO configModel)
        {
            try
            {
                _configService.SetConfig(configModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
