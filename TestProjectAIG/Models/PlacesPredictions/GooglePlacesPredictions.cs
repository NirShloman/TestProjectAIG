using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAIG.Models.PlacesPredictions
{
    public class GooglePlacesPredictions
    {
        [JsonProperty("predictions")]
        public List<GooglePlacesResponses> Predictions { get; set; }
    }
}