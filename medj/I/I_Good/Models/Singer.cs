using I_Good.Interfaces;

namespace I_Good.Models;
//Телебоков А. И. SOL(I)D 18. Кино, музыка, шоубизнес
public class Singer : ISinger
{
    public void Sing() => Console.WriteLine("Певец поёт");
}