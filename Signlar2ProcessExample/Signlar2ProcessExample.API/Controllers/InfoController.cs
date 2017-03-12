using System.Web.Http;

namespace Signalr2ProcessExample.API.Controllers
{
    [RoutePrefix("")]
    public class InfoController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Info()
        {
            return Ok(new { Name = "Signalr2ProcessExample.API ", Version = "v1.0" });
        }
    }
}
