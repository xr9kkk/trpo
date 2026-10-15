namespace Labs.Lab05.Bad;

public interface IMythicalCreature
{
    void Fly();
    void Swim();
    void CastSpell();
}
public sealed class Mermaid : IMythicalCreature
{
    public void Fly() => throw new NotSupportedException("Русалка не летает.");
    public void Swim() => Console.WriteLine("Русалка плывёт");
    public void CastSpell() => throw new NotSupportedException("Эта русалка не колдует.");
}
public sealed class Dragon : IMythicalCreature
{
    public void Fly() => Console.WriteLine("Дракон летит");
    public void Swim() => throw new NotSupportedException("Этот дракон не плавает.");
    public void CastSpell() => throw new NotSupportedException("Этот дракон не колдует.");
}
