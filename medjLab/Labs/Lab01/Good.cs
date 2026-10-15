namespace Labs.Lab01.Good;

public interface IHealthProcedure
{
    string Name { get; }
    int DurationMinutes { get; }
    void Perform();
}
public sealed class Massage(string name, int durationMinutes) : IHealthProcedure
{
    public string Name { get; } = name;
    public int DurationMinutes { get; } = durationMinutes;
    public void Perform() => Console.WriteLine($"Массаж: {Name}");
}
public sealed class Exercise(string name, int durationMinutes) : IHealthProcedure
{
    public string Name { get; } = name;
    public int DurationMinutes { get; } = durationMinutes;
    public void Perform() => Console.WriteLine($"Гимнастика: {Name}");
}
public sealed class ProcedureSchedule
{
    private readonly List<IHealthProcedure> _procedures = [];
    public IReadOnlyList<IHealthProcedure> Procedures => _procedures.AsReadOnly();
    public void Add(IHealthProcedure procedure) => _procedures.Add(procedure);
    public void PerformAll()
    {
        foreach (var procedure in _procedures) procedure.Perform();
    }
}
public static class ProcedureStatistics
{
    public static double AverageDuration(IEnumerable<IHealthProcedure> procedures) =>
        procedures.Select(p => p.DurationMinutes).DefaultIfEmpty(0).Average();
}
public static class Example
{
    public static void Run()
    {
        var schedule = new ProcedureSchedule();
        schedule.Add(new Massage("Общий", 30));
        schedule.Add(new Exercise("Разминка", 20));
        Console.WriteLine(ProcedureStatistics.AverageDuration(schedule.Procedures));
        schedule.Add(new Massage("Расслабляющий", 40));
        Console.WriteLine(ProcedureStatistics.AverageDuration(schedule.Procedures));
        schedule.PerformAll();
    }
}
