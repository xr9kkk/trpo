using I.Interfaces;

namespace I.Models;

public class MusicalStar : IStar
{
    public void Act()   => Console.WriteLine("Звезда мюзикла играет драматическую роль");
    public void Sing()  => Console.WriteLine("Звезда мюзикла исполняет вокальную партию");
    public void Dance() => Console.WriteLine("Звезда мюзикла танцует в массовой сцене");
}