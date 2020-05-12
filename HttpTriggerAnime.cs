using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using azurefreefunctionapp;

namespace ashleykelham
{
    public static class HttpTriggerAnime
    {
        [FunctionName("HttpTriggerAnime")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            //string name = req.Query["name"];

           List<Anime> output = new List<Anime>(){
               new Anime(){
                   Name = "Attack on Titan",
                   Id = "a1",
                   ImageUrl = "https://www.skinit.com/media/catalog/product/cache/9dbe6a0c16a5b581719a1aa389879cfc/f/n/fnaktn03_206.jpg",
                   Link = "",
                   Description = "A young person with extraordinary potential must gain strength to save the world." 
               },
               new Anime(){
                   Name = "Demon Slayer",
                   Id = "a2",
                   ImageUrl = "https://3.bp.blogspot.com/-TBIMU-SJfhg/XTOD4BzCvJI/AAAAAAAAIoA/vIyb457CZgsmvI2eku1SztpZxA1RS9gMwCKgBGAs/w600-h600-p-k-no-nu/tanjiro-kamado-nezuko-kamado-kimetsu-no-yaiba-uhdpaper.com-4K-151-wp.thumbnail.jpg",
                   Link = "",
                   Description = "A young person with extraordinary potential must gain strength to save the world." 
               },
               new Anime(){
                   Name = "Sword Art Online",
                   Id = "a3",
                   ImageUrl = "https://i.pinimg.com/originals/ea/76/aa/ea76aa8a1c6f7c4f3cda4b03261c9651.jpg",
                   Link = "",
                   Description = "A young person with extraordinary potential must gain strength to save the world." 
               },
               new Anime(){
                   Name = "Record of Grancrest War",
                   Id = "a4",
                   ImageUrl = "https://d2jcw5q7j4vmo4.cloudfront.net/jfwdfg3wtyyIiXXojmtLhQ2KCtKYtXjQ5TLQV8CmMtWgDk1oGLw2wmIYZJwTqLSAlg=w512",
                   Link = "",
                   Description = "A young person with extraordinary potential must gain strength to save the world." 
               },
               new Anime(){
                   Name = "Guilty Crown",
                   Id = "a5",
                   ImageUrl = "https://i1.sndcdn.com/artworks-000108924962-gf5oe6-t500x500.jpg",
                   Link = "",
                   Description = "A young person with extraordinary potential must gain strength to save the world." 
               },
               new Anime(){
                   Name = "Naruto",
                   Id = "a6",
                   ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTgVjuW44QxSQbdj4FHA_RV98vWlF-16519Y2MLYEpkoIunLUmn&usqp=CAU",
                   Link = "",
                   Description = "A young person with extraordinary potential must gain strength to save the world." 
               }
           };

            return new OkObjectResult(output);
        }
    }
}
