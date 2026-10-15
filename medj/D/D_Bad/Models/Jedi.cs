namespace D.Models;

public class Jedi(string name)
{
    private string Name { get; } = name;
    private Lightsaber _lightsaber = new Lightsaber();

    public void Fight()
    {
        Console.WriteLine($"Джедай: {Name}");
        _lightsaber.Ignite();
        Console.WriteLine("джедай вступилл в бой");
    }
}