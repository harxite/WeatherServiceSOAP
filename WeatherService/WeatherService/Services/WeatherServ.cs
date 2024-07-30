
using Microsoft.EntityFrameworkCore;
using WeatherService.Context;
using WeatherService.Models;

namespace WeatherService.Services
{
    public class WeatherServ : IWeatherServ
    {
        private readonly WeatherContext _context;
        public WeatherServ(WeatherContext context)
        {
            _context = context;
        }
        public async Task<Weather> GetWeatherAsync(string city)
        {
            var weather = await _context.Weathers
                .Where(w => w.City == city)
                .FirstOrDefaultAsync();

            if (weather == null)
                return null;

            return new Weather
            {
                City = weather.City,
                Temperature = weather.Temperature,
                Condition = weather.Condition
            };
        }
    }
}
