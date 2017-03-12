namespace Signalr2ProcessExample.Models
{
    public class ProcessResult
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public ProcessMetadata Metadata { get; set; }
        public double ExecutionTime { get; set; }
    }
}
