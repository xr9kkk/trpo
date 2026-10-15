using S_Good.Interfaces;
using S_Good.Models;

namespace S_Good.Services;

public class ConsoleReportPrinter : IReportPrinter
{
    public void Print(Star s, double fee)
    {
        Console.WriteLine($"Отчёт для налоговой {s.Name}: гонорар {fee}");
    }
}