namespace Labs.Lab01;
public static class Demo
{
    public static void Run(string variant) => Output.Example("1. Стиль кода — здоровье", variant, Bad.Example.Run, Good.Example.Run);
}
