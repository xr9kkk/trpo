namespace Labs.Lab03;
public static class Demo
{
    public static void Run(string variant) => Output.Example("3. OCP — транспорт", variant, () =>
    {
        var dispatcher = new Bad.Dispatcher();
        foreach (string name in new[] { "Автомобиль", "Самолёт", "Судно", "Мотоцикл" })
            dispatcher.Dispatch(name);
    }, () =>
    {
        var dispatcher = new Good.Dispatcher();
        Good.ITransport[] transports = [new Good.Car(), new Good.Airplane(), new Good.Ship(), new Good.Motorcycle()];
        foreach (var transport in transports) dispatcher.Dispatch(transport);
    });
}
