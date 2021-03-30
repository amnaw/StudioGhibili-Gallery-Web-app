using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudioGhibili.Services;
using StudioGhibili.Models;

namespace StudioGhibili.Controllers
{
    // The name of the route is the name of the controller /Characters
    [Route("[controller]")]
    [ApiController]
    // Inherentance, ControllerBase: base class
    public class CharactersController : ControllerBase
    {
        // STEP--1-- make a constructor that asks for a service, using services techniges// the same way we asked for logging service
        // BUT: who makes controllers? the controller factory does!
        public CharactersController(JsonCharacterService characterService)
        {
            this.myCharacterService = characterService;
        }
        // STEP--2-- we need to hold our service 
        public JsonCharacterService myCharacterService { get; }

        // STEP--3-- 
        // Identifies an action supporst HTTP GET method
        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return myCharacterService.GetCharacters();
        }
        // STEP--4-- Register this controller in the "startup" class under "ConfigureServices" method, then USE it there too by endpoints.

        
        // New Route
        [Route("Rate")]
        // should be [HttpPatch] "[FromBody]", patch changing a little bit
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string name,
            [FromQuery] int rating)
        {
            // Route Example: https://localhost:44375/characters/Rate?name=San&rating=4

            // preform an action that responds with HTTP responses
            myCharacterService.AddRatings(name, rating);
            return Ok();
        } // Now, our Json file (database) Changed ;)


        // Note: this ApiController returns Json automatically, not like the first Api we did in "StartUp" file that needed to serialaze manually
    }
}
