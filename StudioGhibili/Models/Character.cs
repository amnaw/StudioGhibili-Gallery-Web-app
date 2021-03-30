using System;
using System.Collections.Generic;
using System.Linq;
//provides functionality for serializing to and deserializing from JSON
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudioGhibili.Models
{
    [Serializable] // Objects of this type can be serialized.
    public class Character
    {
        public string name { get; set; }

        //JsonPropertyAttribute to change the names of properties when they are serialized to JSON.
        [JsonPropertyName("img")] 

        // to make properties fast, write prop TAB TAB
        public string image { get; set; }
        public string movie { get; set; }
        public int year { get; set; }
        public string descripition { get; set; }

        public int[] Ratings { get; set; }


        public override string ToString() => JsonSerializer.Serialize<Character>(this);

       
        
    }
}
