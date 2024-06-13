using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace ServerApp.Data
{
    
    public class WeatherForecastService
    {
        private IWebHostEnvironment _hostEnvironment;
        public WeatherForecastService(IWebHostEnvironment environment)
        {
            _hostEnvironment = environment;
        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public string GetPath(string filename)
        {
            string path = Path.Combine(_hostEnvironment.WebRootPath, filename);
            return path;
        }
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
