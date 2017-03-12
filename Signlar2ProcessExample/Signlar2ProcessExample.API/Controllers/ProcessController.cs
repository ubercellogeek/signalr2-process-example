using Signalr2ProcessExample.Models;
using Signalr2ProcessExample.API.Services;
using System.Web.Hosting;
using System.Web.Http;

namespace Signalr2ProcessExample.API.Controllers
{
    [RoutePrefix("process")]
    public class ProcessController : ApiController
    {
        private readonly ProcessService _service;

        public ProcessController()
        {
            _service = new ProcessService();
        }

        [HttpPost]
        [Route("run")]
        public IHttpActionResult Run(ProcessMetadata metadata)
        {
            // Queue the long running action in the background.
            HostingEnvironment.QueueBackgroundWorkItem(x => _service.Run(metadata));
            return Ok();
        }

    }
}
