using I_Good.Interfaces;

namespace I_Good.Models;

public class MusicalStar : ISinger, IDancer, IActor
{
    public void Act()   => Console.WriteLine("Звезда мюзикла играет драматическую роль");
    public void Sing()  => Console.WriteLine("Звезда мюзикла исполняет вокальную партию");
    public void Dance() => Console.WriteLine("Звезда мюзикла танцует в массовой сцене");
}