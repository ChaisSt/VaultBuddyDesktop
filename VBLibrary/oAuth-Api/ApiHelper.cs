using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

//This class sends requests to the API and sends the response back to the class that called it
namespace VBLibrary
{
    public class ApiHelper
    {
        static string key = Secret.APIKey;
        static string host = "https://www.bungie.net/platform/";
        static string uri = "";

        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Add("X-API-Key", key);
        }

        public static void CreateUri(string path, string input)
        {
            uri = host + path + input;
        }

        public static async Task<dynamic> Search(HttpClient ApiClient)
        {
            HttpResponseMessage response = ApiClient.GetAsync(uri).Result;

            string content = await response.Content.ReadAsStringAsync();
            var item = JsonConvert.DeserializeObject(content);

            return item;
        }
    }
}

