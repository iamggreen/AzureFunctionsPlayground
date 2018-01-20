using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace AzureFunctionStorageQueueTriggered
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run(
            [QueueTrigger("myqueue-items", Connection = "AzureWebJobsStorage")]string myQueueItem, 
            [Blob("incontainer/{queueTrigger}", System.IO.FileAccess.Read)]string inputBlob, 
            TraceWriter log)
        {
            log.Info("Function1 executing...");
            log.Info($"C# Queue trigger function processed: {myQueueItem}");
            log.Info($"Blob Contents: {inputBlob}");

        }
    }
}
