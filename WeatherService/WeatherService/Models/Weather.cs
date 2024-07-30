namespace WeatherService.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public string City { get; set; }
        public decimal Temperature { get; set; }
        public string Condition { get; set; }
    }

}
