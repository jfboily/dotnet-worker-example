using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Authentication;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WorkerService1.entities;

namespace WorkerService1.services.WeatherApiCom
{
    public class WeatherApiCom : IWeatherService
    {
        private readonly HttpClient _client = new HttpClient();
        private readonly string _apiKey;
        private readonly string _baseUrl;

        public WeatherApiCom(IConfiguration config)
        {
            var apiConfig = config.GetSection("WeatherApi.com");
            _apiKey = apiConfig["ApiKey"];
            _baseUrl = $"{apiConfig["baseUrl"]}?key={_apiKey}";
        }
 
        public async Task<WeatherData> GetWeatherForCity(string city)
        {
            var data = await _client.GetFromJsonAsync<WeatherData>(
                $"{_baseUrl}&q={city}&aqi=no", new JsonSerializerOptions {IncludeFields = true});

            return data;
        }
    }
}