using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace AzureFunctionStorageQueueTriggered
{
    public static class Function2
    {
        [FunctionName("Function2")]
        public static void Run(
            [QueueTrigger("myqueue-items", Connection = "AzureWebJobsStorage")]string myQueueItem,
            [Blob("incontainer/{queueTrigger}", System.IO.FileAccess.Read)]string inputBlob,
            TraceWriter log)
        {
            log.Info("Function2 executing...");
            log.Info($"C# Queue trigger function processed: {myQueueItem}");
            log.Info($"Blob Contents: {inputBlob}");

        }
    }
}
