using backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("forms")]
    [ApiController]
    public class FormsController : BaseController
    {
        public FormsController()
        {

        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "I just shat myself";
        }
    }
}
