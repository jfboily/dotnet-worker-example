using System.Threading.Tasks;
using WorkerService1.entities;

namespace WorkerService1.services
{
    public interface IWeatherService
    {
        Task<WeatherData> GetWeatherForCity(string city);
    }
}