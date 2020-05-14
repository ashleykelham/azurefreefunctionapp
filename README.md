# Azure free full stack app demo: API
This is a .net core Azure function built as part of the [Medium article](https://medium.com/@ashley.kelham/developing-a-startup-on-azure-for-under-1-407c3b290d36). The articles explains the infrastrcuture setup.

This API returns a collection of basic information about Anime.

### Requirements
* Dotnet core 3.1
* Azure Subscription
* [VSCode](https://code.visualstudio.com/) 
* [Azure Function Core Tools VSCode plugin](https://docs.microsoft.com/en-us/azure/azure-functions/functions-run-local?tabs=windows%2Ccsharp%2Cbash)

### Run locally
In your local.settings.json in the *values* object speciy *CosmosDBConnection* e.g.

```
  "Values": {
    "AzureWebJobsStorage": "",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet",
    "CosmosDBConnection": "your-cosmosdb-connection-string"
  }
```

Follow the Medium article on how to setup the Cosmos Db database.

Once comleted press Start Debugging (F5) in VSCode. If you haven't alredy installed Azure Function Core Tools you will be promted to do so.

This will run the function in the emulator and you can call the function at GET http://localhost:7071/api/httptriggeranime

### How to deploy
Follow the Medium article to deploy all the dependancies. You will need to add in *CosmosDBConnection* app setting to the Function App in Azure with your Cosmos Db connection string as the value.

* Go to the *Azure* tab in VSCode.
* In the *FUNCTIONS* section select 'Deploy to function app'
* Follow the onscreen instructions to select the subscription and function app to deploy it to.
* Once complete you will be able to call your function dependant on your apps name e.g. GET https://*yourapp*.azurewebsites.net/api/httptriggeranime
