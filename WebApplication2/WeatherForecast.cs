namespace WebApplication2;

public class WeatherForecast
{
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
    public string? TestCommit { get; set; }

    public string IsOverHeat()
    {
        return TemperatureC switch
        {
            >= 100 => "hot",
            >= 50 => "warm",
            _ => "cold"
        };
    }
}
