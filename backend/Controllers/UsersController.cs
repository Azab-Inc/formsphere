using backend.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("users")]
    [ApiController]
    public class UsersController : BaseController
    {
        public UsersController()
        {
        }

        [HttpGet, Authorize]
        public ActionResult<string> Get()
        {
            return "Users";
        }
    }
}
