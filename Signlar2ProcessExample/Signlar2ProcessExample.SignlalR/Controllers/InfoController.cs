using System.Web.Http;

namespace Signalr2ProcessExample.SignlalR.Controllers
{
    [RoutePrefix("")]
    public class InfoController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Info()
        {
            return Ok(new { Name = "Signalr2ProcessExample.SignalR ", Version = "v1.0" });
        }
    }
}
