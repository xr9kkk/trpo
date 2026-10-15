using I.Interfaces;
//Телебоков А. И. SOL(I)D 18. Кино, музыка, шоубизнес
namespace I.Models;

public class Actor : IStar
{
    public void Act() => Console.WriteLine("Актер играет роль");
    public void Sing() => throw new NotImplementedException();
    public void Dance() => throw new NotImplementedException();
}