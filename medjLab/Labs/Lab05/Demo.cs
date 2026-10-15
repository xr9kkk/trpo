namespace Labs.Lab05;
public static class Demo
{
    public static void Run(string variant) => Output.Example("5. ISP — мифы и сказки", variant, () =>
    {
        Bad.IMythicalCreature creature = new Bad.Mermaid();
        creature.Swim();
        try { creature.Fly(); }
        catch (NotSupportedException error) { Console.WriteLine($"Лишний метод интерфейса: {error.Message}"); }
        new Bad.Dragon().Fly();
    }, () =>
    {
        Good.ISwimming mermaid = new Good.Mermaid();
        mermaid.Swim();
        Good.IFlying[] flyers = [new Good.Dragon(), new Good.BabaYaga()];
        foreach (var flyer in flyers) flyer.Fly();
        Good.ISpellCaster spellCaster = new Good.BabaYaga();
        spellCaster.CastSpell();
    });
}
