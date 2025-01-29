namespace az_204_api.Records;

public record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    public int TemperatureK => TemperatureC + 273;
}