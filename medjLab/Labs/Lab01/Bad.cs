namespace Labs.Lab01.Bad;

// Намеренные нарушения стиля: имена, открытые поля, object, дублирование.
public class medical_procedure(string n, int t)
{
    public string name = n;
    public int time = t;
    public void go() => Console.WriteLine($"Процедура: {name}");
}
public static class Example
{
    public static void Run()
    {
        List<object> DATA = [new medical_procedure("Массаж", 30), new medical_procedure("Гимнастика", 20)];
        Console.WriteLine(DATA.Count == 0 ? 0 : DATA.Average(x => ((medical_procedure)x).time));
        DATA.Add(new medical_procedure("Массаж", 40));
        Console.WriteLine(DATA.Count == 0 ? 0 : DATA.Average(x => ((medical_procedure)x).time));
        foreach (object x in DATA) ((medical_procedure)x).go();
    }
}
