using System.ServiceModel;
using System.Threading.Tasks;
using WeatherService.Models;

[ServiceContract]
public interface IWeatherServ
{
    [OperationContract]
    Task<Weather> GetWeatherAsync(string city);
}