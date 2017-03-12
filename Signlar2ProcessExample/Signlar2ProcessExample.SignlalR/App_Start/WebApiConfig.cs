using System.Web.Http;

namespace Signalr2ProcessExample.SignlalR
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            // Remove the XML formatter.
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
