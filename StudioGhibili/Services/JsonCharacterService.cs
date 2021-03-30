using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using StudioGhibili.Models;
using Microsoft.AspNetCore.Hosting;

namespace StudioGhibili.Services
{
    // This Service's job is to give us an Enumerable(list) of Characters
    public class JsonCharacterService
    {
        // Constructor,         // Web App is hosted,   // We pass this argument and Keeping it here *
                               // WebHostEnv. will know how files Located
        public JsonCharacterService(IWebHostEnvironment webHostEnvironment)
        {
            // IWebHostEnvironment is a Service given to our Service ;)
            // This webHostEnv just handed to me by Asp.net
            myWebHostEnvironment = webHostEnvironment;
        }

        // here * the arg we passed earlier
        public IWebHostEnvironment myWebHostEnvironment { get; }

        private string JsonFileName
        {
            // Path from system.IO   //Combine and make the path for me, this path is out of 3 parts
            get { return Path.Combine(myWebHostEnvironment.WebRootPath, "data", "Characters.json"); }
        }

        // Here we are retreiving the Characters // IEnumerable is Greatgrand Father of list and more general
        public IEnumerable<Character> GetCharacters()
        {
            // 1 Open File 
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                // Since this fun returns any kind of  IEnumerable, I can return list, collection, arr of Character
                                                              // 2 and Read it
                return JsonSerializer.Deserialize<Character[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        // Optional Options, do not care about upper/lower case
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        // Another function that changes the database
        public void AddRatings(string characterName, int rating)
        {
            // first, to see which character we will updating, we need to retreive them
            // by calling the previous func
            IEnumerable<Character> AllCharacters = GetCharacters();

            // LINQ,, SQL kind of thing. where keyword, so here we are grabbing the object by somthing special like ID
            var query = AllCharacters.First(x => x.name == characterName) ;
            if(query.Ratings == null)
            {
                //if there is no rating at all, then initilaze one
                query.Ratings = new int[] { rating };
            }
            else
            {
                // if there are already rating values in Array[], then
                // convert it to List, easier to Add
                var AllRatings = query.Ratings.ToList();
                AllRatings.Add(rating);
                // Back to Array
                query.Ratings = AllRatings.ToArray();
            }

            // Now we need to Open the json to write the changes,
            // so we need to serialze back, the AllCharacters Objects to Json,
            // cuz AllCharacters objects are now changed !
                                                     // our var, its convient way to locate the file
            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                // Define Json Writer
                // Utf8JsonWriter. Serialaze Any lang ;)
                var MyJsonWriter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = true,
                    Indented = true,
                });
                JsonSerializer.Serialize<IEnumerable<Character>>(
                    MyJsonWriter,
                    // Serialize these please, they're of type <IEnumerable<Character>>
                    AllCharacters);

            }// Note: u can make func or class to handle this complexity of Serialazining / Deserialazining
        }
        // Now, tell the controller about this new method(How to call it) and make Weby things ;)
    }
}

// Now Don't Forget to Register this Service into Startup class
