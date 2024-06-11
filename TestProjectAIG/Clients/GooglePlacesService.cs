using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Linq;

namespace TestProjectAIG.Services
{
    public class GooglePlacesService
    {
        private readonly string _apiKey;

        [Obsolete]
        public GooglePlacesService()
        {
            _apiKey = System.Configuration.ConfigurationSettings.AppSettings["GoogleApiKey"];
        }

        public async Task<string[]> GetPlaceAutoComplete(string input)
        {
            string url = $"https://maps.googleapis.com/maps/api/place/autocomplete/json?input={Uri.EscapeDataString(input)}&key={_apiKey}&types=geocode";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);
                    JArray predictions = (JArray)data["predictions"];
                    string[] results = new string[predictions.Count];
                    for (int i = 0; i < predictions.Count; i++)
                    {
                        results[i] = predictions[i]["description"].ToString();
                    }
                    return results;
                }
                return null;
            }
        }
    }
}