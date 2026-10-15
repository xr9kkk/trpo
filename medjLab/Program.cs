using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Action<string>[] labs = [Labs.Lab01.Demo.Run, Labs.Lab02.Demo.Run, Labs.Lab03.Demo.Run,
    Labs.Lab04.Demo.Run, Labs.Lab05.Demo.Run, Labs.Lab06.Demo.Run];
if (args.Length == 0)
{
    Console.WriteLine("1 — стиль кода (здоровье), 2 — SRP (роботы), 3 — OCP (транспорт),");
    Console.WriteLine("4 — LSP (география), 5 — ISP (мифы), 6 — DIP (метеорология).");
    Console.WriteLine("dotnet run --project medjLab -- <1–6|all> [bad|good|both]");
    Console.WriteLine("7 — туризм: условие отсутствует в исходных материалах.");
    return;
}
string variant = args.Length > 1 ? args[1].ToLowerInvariant() : "both";
if (args.Length > 2 || variant is not ("bad" or "good" or "both"))
{
    Console.Error.WriteLine("Допустимые варианты: bad, good, both.");
    Environment.ExitCode = 1;
    return;
}
if (args[0].Equals("all", StringComparison.OrdinalIgnoreCase))
    foreach (var lab in labs) lab(variant);
else if (int.TryParse(args[0], out int number) && number >= 1 && number <= labs.Length)
    labs[number - 1](variant);
else
{
    Console.Error.WriteLine("Укажите номер 1–6 или all.");
    Environment.ExitCode = 1;
}
internal static class Output
{
    public static void Example(string title, string variant, Action bad, Action good)
    {
        Console.WriteLine($"\n{title}");
        if (variant is "bad" or "both") { Console.WriteLine("Bad:"); bad(); }
        if (variant is "good" or "both") { Console.WriteLine("Good:"); good(); }
    }
}
