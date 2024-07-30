using Microsoft.EntityFrameworkCore;
using WeatherService.Models;

namespace WeatherService.Context
{
    public class WeatherContext: DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        {
        }

        public DbSet<Models.Weather> Weathers { get; set; }
    }
}
