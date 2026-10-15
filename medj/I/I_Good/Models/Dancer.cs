using I_Good.Interfaces;

namespace I_Good.Models;
//Телебоков А. И. SOL(I)D 18. Кино, музыка, шоубизнес
public class Dancer : IDancer
{
    public void Dance() => Console.WriteLine("Танцор танцует");
}