using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Linq;
using azurefreefunctionapp;
using Microsoft.Azure.Documents.Client;

namespace ashleykelham
{
    public static class HttpTriggerAnime
    {
        const string databaseName = "anime";
        const string collectionName = "anime";
        [FunctionName("HttpTriggerAnime")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
              [CosmosDB(
                databaseName: databaseName,
                collectionName: collectionName,
                ConnectionStringSetting = "CosmosDBConnection")] IDocumentClient client,
            ILogger log)
        {
            List<Anime> output = new List<Anime>();
            Uri collectionUri = UriFactory.CreateDocumentCollectionUri(databaseName, collectionName);

          //  log.LogInformation($"Searching for: {searchterm}");

            IDocumentQuery<Anime> query = client.CreateDocumentQuery<Anime>(collectionUri)
                .AsDocumentQuery();

            while (query.HasMoreResults)
            {
                foreach (Anime result in await query.ExecuteNextAsync())
                {
                    output.Add(result);
                }
            }

            return new OkObjectResult(output);
        }
    }
}
