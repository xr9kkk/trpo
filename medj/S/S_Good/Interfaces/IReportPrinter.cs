using S_Good.Models;

namespace S_Good.Interfaces;

public interface IReportPrinter
{
    void Print(Star s, double fee);
}