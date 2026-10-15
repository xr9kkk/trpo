using S_Good.Interfaces;
using S_Good.Models;

namespace S_Good.Services;

public class FileReportPrinter(string path) : IReportPrinter
{
    public void Print(Star s, double fee) =>
        File.WriteAllText(path, $"{s.Name}:{fee}");
    
}