### To run locally

Create a file named local.settings.json in the AzureFunctionStorageQueueTriggered directory.  

It should look something like below:
```json
{
    "IsEncrypted": false,
    "Values": {
        "AzureWebJobsStorage": "<YOUR CONNECTION STRING>",
        "AzureWebJobsDashboard": "<YOUR CONNECTION STRING>"
    }
}
```
