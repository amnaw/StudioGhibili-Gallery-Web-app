using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using StudioGhibili.Models;
using StudioGhibili.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// This file  is the sibling if index.cshtml and we just seperated them

namespace StudioGhibili.Pages
{
               // this is one pageModel
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> mylogger;
        // We asked for Service 
        public JsonCharacterService myCharacterService;

        // Hold our Characters, its public, so Index Pages knows about Characters
        public IEnumerable<Character> Characters { get; private set; }

        // Constructer, have logger as an arg of type ILogger
        // Logging is a Service made available to me by Asp.net

        // We'll add Another Service which is JsonCharacterService
        // By adding this Service I'm telling, I NEED this service go and get it, 
        // and the system already knows abot it since i registered the service is Startup Class
        public IndexModel(ILogger<IndexModel> logger, JsonCharacterService characterService)
        {
            mylogger = logger;
            myCharacterService = characterService;
        }

        //***** let's hold the current time to display it
        public string Time { get; set; }


        // This Methos id a Handler to GET request to this page, returns its html page
        // When someone GET this page what should we do
        public void OnGet()
        {
            Characters = myCharacterService.GetCharacters();
            Time =  DateTime.Now.ToShortTimeString();
        }
    }
}
