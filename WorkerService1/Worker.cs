using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WorkerService1.services;
using WorkerService1.services.WeatherApiCom;

namespace WorkerService1
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IWeatherService _weatherService;

        public Worker(ILogger<Worker> logger, IWeatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }
        
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    // call the weather service
                    var data = await _weatherService.GetWeatherForCity("Mexico");

                    if (data != null)
                    {
                        _logger.LogInformation("Temperature (Celcius) is {Response}", data.Current.TempC);    
                    }
                    else
                    {
                        _logger.LogError("Oups, WeatherService returned NULL");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
                
                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}
