# Azure free full stack app demo: API
This is a .net core Azure function built as part of the [Medium article]().

This API returns a collection of basic information about Anime.

### Requirements
* Dotnet core 3.1
* Azure Subscription
* [VSCode](https://code.visualstudio.com/) 
* [Azure Function Core Tools VSCode plugin](https://docs.microsoft.com/en-us/azure/azure-functions/functions-run-local?tabs=windows%2Ccsharp%2Cbash)

### Run locally
Press Start Debugging (F5) in VSCode. If you haven't alredy installed Azure Function Core Tools you will be promted to do so.

This will deploy then be able to all the function at GET http://localhost:7071/api/HttpTriggerAnime

### How to deploy
* Go to the *Azure* tab in VSCode.
* In the *FUNCTIONS* section select 'Deploy to function app'
* Follow the onscreen instructions to select the subscription and function app to deploy it to.
* Once complete you will be able to call your function dependant on your apps name e.g. GET https://*yourapp*.azurewebsites.net/api/httptriggeranime
