namespace Labs.Lab06.Bad;

public sealed class GroundThermometer
{
    public decimal ReadTemperature() => 12m;
}
public sealed class WeatherStation
{
    // Станция сама создаёт конкретный датчик: заменить его без изменения класса нельзя.
    private readonly GroundThermometer _thermometer = new();
    public void Report() => Console.WriteLine($"Температура: {_thermometer.ReadTemperature()} °C");
}
