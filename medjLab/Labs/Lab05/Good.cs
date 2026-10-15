namespace Labs.Lab05.Good;

public interface IFlying { void Fly(); }
public interface ISwimming { void Swim(); }
public interface ISpellCaster { void CastSpell(); }
public sealed class Mermaid : ISwimming
{
    public void Swim() => Console.WriteLine("Русалка плывёт");
}
public sealed class Dragon : IFlying
{
    public void Fly() => Console.WriteLine("Дракон летит");
}
public sealed class BabaYaga : IFlying, ISpellCaster
{
    public void Fly() => Console.WriteLine("Баба-яга летит в ступе");
    public void CastSpell() => Console.WriteLine("Баба-яга произносит заклинание");
}
