using D_Good.Interfaces;

namespace D_Good.Models;
//Телебоков А. И. SOLI(D) 5. Космос и научная фантастика
public class SingleBladeLightsaber : ILightsaber
{
    public void Ignite() => Console.WriteLine("Зажжён световой меч (одиночное лезвие)");
}