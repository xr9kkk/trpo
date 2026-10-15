namespace Labs.Lab02.Bad;

// Одна сущность отвечает за данные, расчёт и два способа вывода.
public sealed class RobotReport(string name, decimal baseCost)
{
    public decimal CalculateMaintenanceCost() => baseCost * 1.2m;
    public void Print() => Console.WriteLine($"Обслуживание {name}: {CalculateMaintenanceCost():F2}");
    public void Save(string path) => File.WriteAllText(path, $"{name}: {CalculateMaintenanceCost():F2}");
}
