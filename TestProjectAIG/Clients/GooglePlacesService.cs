using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TestProjectAIG.Models.PlacesPredictions;

namespace TestProjectAIG.Services
{
    public class GooglePlacesService
    {
        private static readonly string _apiKey;

        static GooglePlacesService()
        {
            _apiKey = System.Configuration.ConfigurationSettings.AppSettings["GoogleApiKey"];
        }

        public async Task<List<string>> GetPlaceAutoComplete(string input)
        {
            string url = $"https://maps.googleapis.com/maps/api/place/autocomplete/json?input={Uri.EscapeDataString(input)}&key={_apiKey}&types=geocode";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);
                    var predictionsResponse = JsonConvert.DeserializeObject<GooglePlacesPredictions>(json);
                    var placesList = new List<string>();
                    foreach (var place in predictionsResponse.Predictions)
                    {
                        placesList.Add(place.Description);
                    }
                    return placesList;
                }
                return null;
            }
        }
    }
}