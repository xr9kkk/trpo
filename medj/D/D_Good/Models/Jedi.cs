using D_Good.Interfaces;

namespace D_Good.Models;
// Телебоков А. И. SOLI(D) 5. Космос и научная фантастика
public class Jedi
{
    private string Name { get; }
    private ILightsaber _lightsaber;

    public Jedi(string name, ILightsaber lightsaber)
    {
        Name = name;
        _lightsaber = lightsaber;
    }
    
    public void PickUpLightsaber(ILightsaber lightsaber)
    {
        _lightsaber = lightsaber;
        Console.WriteLine($"{Name} взял новый световой меч");
    }

    public void Fight()
    {
        Console.WriteLine($"Джедай: {Name}");
        _lightsaber.Ignite();
        Console.WriteLine("Джедай вступил в бой");
    }
}