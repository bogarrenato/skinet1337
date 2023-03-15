namespace API;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    //We have to think that a string can be nullable or have to write explicitly = ""
    public string Summary { get; set; }
}
