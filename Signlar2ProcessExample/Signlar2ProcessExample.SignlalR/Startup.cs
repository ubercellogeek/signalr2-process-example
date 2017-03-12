using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(Signalr2ProcessExample.SignlalR.Startup))]
namespace Signalr2ProcessExample.SignlalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/signalr", map =>
            {
                // Ensure that we enable cors for the SignalR route(s). This must take place before we add SignalR to the pipeline.
                map.UseCors(CorsOptions.AllowAll);
                var hubConfiguration = new HubConfiguration
                {
                    // Uncomment the following line for greater information about any errors.
                    // EnableDetailedErrors = true
                    // Other options such as JSONP are also available. See the SignalR docs for more information.
                };

                // Run SignalR in the pipeline. Since we're already running under /signalr, we have no need to call the MapSignalR() method.
                map.RunSignalR(hubConfiguration);
            });
        }
    }
}