# signalr2-process-example


A simple example of how to employ Signalr2 to notify clients after a long-running asynchronous process completes.


## Solution Layout

* SignalR2ProcessExample.API
  * This project is the "processing" API by which clients can start a non-blocking, long running process.
* SignalR2ProcessExample.SignalR
  * The project responsible for hosting the SignalR server and allowing the process API to send notifications back to the client after the long running process completes.
* SignalR2ProcessExample.Models
  * Just a container for shared objects used in both API and SignalR projects.
* SignalR2ProcessExample.Web
  * A simple UI to demonstrate the client's ability to start a long running process on the API and get back a result of that process asynchronously once it completes.


## Notes

You should be able to just build the solution and run it. There has been some additional work done to ensure that both the API and SignalR projects are setup to allow for CORS. Should you want to get these projects setup in a hosted IIS environment, you should be good to go. If you decide to deploy these examples into their own hosted IIS sites using anonymous authentication, ensure that the identity is set to use the "Application pool identity."

## Useful Links

[SignalR](https://www.asp.net/signalr)

[Background Worker](https://msdn.microsoft.com/en-us/library/dn636893(v=vs.110).aspx)

[SignalR Example](https://docs.microsoft.com/en-us/aspnet/signalr/overview/getting-started/tutorial-getting-started-with-signalr)






