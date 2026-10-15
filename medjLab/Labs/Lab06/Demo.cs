namespace Labs.Lab06;
public static class Demo
{
    public static void Run(string variant) => Output.Example("6. DIP — метеорология и водные ресурсы", variant,
        () => new Bad.WeatherStation().Report(), () =>
        {
            var station = new Good.WeatherStation(new Good.GroundThermometer());
            station.Report();
            station.ReplaceSensor(new Good.BuoySensor());
            station.Report();
            station.ReplaceSensor(new Good.MountainSensor());
            station.Report();
        });
}
