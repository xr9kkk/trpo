using I.Interfaces;
//Телебоков А. И. SOL(I)D 18. Кино, музыка, шоубизнес
namespace I.Models;

public class Singer:IStar
{
    public void Act() => throw new NotImplementedException();
    public void Sing() => Console.WriteLine("Певец поёть");
    public void Dance() => throw new NotImplementedException();
}