namespace Labs.Lab03.Good;

public interface ITransport { void Depart(); }
public sealed class Car : ITransport
{
    public void Depart() => Console.WriteLine("Автомобиль выезжает на дорогу");
}
public sealed class Airplane : ITransport
{
    public void Depart() => Console.WriteLine("Самолёт взлетает");
}
public sealed class Ship : ITransport
{
    public void Depart() => Console.WriteLine("Судно выходит из порта");
}
// Расширение: диспетчер не меняется при добавлении мотоцикла.
public sealed class Motorcycle : ITransport
{
    public void Depart() => Console.WriteLine("Мотоцикл выезжает на дорогу");
}
public sealed class Dispatcher
{
    public void Dispatch(ITransport transport) => transport.Depart();
}
