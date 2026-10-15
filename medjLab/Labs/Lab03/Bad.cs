namespace Labs.Lab03.Bad;

public sealed class Dispatcher
{
    // Каждый новый транспорт требует изменения диспетчера.
    public void Dispatch(string transport)
    {
        if (transport == "Автомобиль") Console.WriteLine("Автомобиль выезжает на дорогу");
        else if (transport == "Самолёт") Console.WriteLine("Самолёт взлетает");
        else if (transport == "Судно") Console.WriteLine("Судно выходит из порта");
        else Console.WriteLine("Неизвестный транспорт");
    }
}
