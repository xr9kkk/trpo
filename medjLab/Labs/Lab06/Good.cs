namespace Labs.Lab06.Good;

public interface ITemperatureSensor
{
    decimal ReadTemperature();
}
// Фиксированные учебные показания, а не обращение к реальным приборам.
public sealed class GroundThermometer : ITemperatureSensor
{
    public decimal ReadTemperature() => 12m;
}
public sealed class BuoySensor : ITemperatureSensor
{
    public decimal ReadTemperature() => 8m;
}
public sealed class MountainSensor : ITemperatureSensor
{
    public decimal ReadTemperature() => -3m;
}
public sealed class WeatherStation(ITemperatureSensor sensor)
{
    private ITemperatureSensor _sensor = sensor;
    public void ReplaceSensor(ITemperatureSensor sensor) => _sensor = sensor;
    public void Report() => Console.WriteLine($"Температура: {_sensor.ReadTemperature()} °C");
}
