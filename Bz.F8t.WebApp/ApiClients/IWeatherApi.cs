using Refit;
using static Bz.F8t.WebApp.Pages.Weather;

namespace Bz.F8t.WebApp.ApiClients;

public interface IWeatherApi
{
    [Get("/sample-data/weather.json")]
    Task<WeatherForecast[]> GetWeatherForecasts();
}

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public string? Summary { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
