using Microsoft.Extensions.Hosting;

namespace UploadingExcelFile.Data
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
        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}