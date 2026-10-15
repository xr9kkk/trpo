namespace Labs.Lab02.Good;

public sealed record Robot(string Name, decimal BaseMaintenanceCost);
public sealed class MaintenanceCalculator
{
    public decimal Calculate(Robot robot) => robot.BaseMaintenanceCost * 1.2m;
}
public interface IReportPrinter
{
    void Print(Robot robot, decimal cost);
}
public sealed class ConsoleReportPrinter : IReportPrinter
{
    public void Print(Robot robot, decimal cost) =>
        Console.WriteLine($"Обслуживание {robot.Name}: {cost:F2}");
}
public sealed class FileReportPrinter(string path) : IReportPrinter
{
    public void Print(Robot robot, decimal cost) =>
        File.WriteAllText(path, $"{robot.Name}: {cost:F2}");
}
