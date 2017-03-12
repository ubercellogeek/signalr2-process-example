using Microsoft.AspNet.SignalR.Client;
using Signalr2ProcessExample.Models;
using System.Configuration;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Signalr2ProcessExample.API.Services
{
    public class ProcessService
    {
        public async Task Run(ProcessMetadata metadata)
        {
            var result = new ProcessResult();
            result.Metadata = metadata;

            Stopwatch stw = new Stopwatch();
            stw.Start();

            // Simulate some long running process.
            await Task.Delay((metadata.ProcessDuration * 1000));
            stw.Stop();

            result.ExecutionTime = stw.Elapsed.TotalMilliseconds;
            result.IsSuccessful = true;
            result.Message = "The process ran successfully!";
            
            // Send result to SignlalR to pass on to the client.
            using(var hubConnection = new HubConnection(ConfigurationManager.AppSettings["SignalRURL"]))
            {
                IHubProxy testHubProxy = hubConnection.CreateHubProxy(ConfigurationManager.AppSettings["SignalRHubName"]);
                await hubConnection.Start();
                await testHubProxy.Invoke("ProcessComplete", result);
            }
        }
    }
}