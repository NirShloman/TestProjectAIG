using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAIG.Models.PlacesPredictions
{
    public class GooglePlacesResponses
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}