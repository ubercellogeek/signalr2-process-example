using Microsoft.AspNet.SignalR;

namespace Signalr2ProcessExample.SignlalR.Hubs
{
    public class ProcessHub : Hub
    {
        private readonly IHubContext _hubContext;

        public ProcessHub()
        {
            _hubContext = GlobalHost.ConnectionManager.GetHubContext<ProcessHub>();
        }

        public void ProcessComplete(Signalr2ProcessExample.Models.ProcessResult result)
        {
            // Call the client and give them result of the long running process.
            _hubContext.Clients.Client(result.Metadata.ConnectionID).processComplete(result);
        }
    }
}