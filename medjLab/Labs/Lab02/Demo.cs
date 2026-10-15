namespace Labs.Lab02;
public static class Demo
{
    public static void Run(string variant)
    {
        string directory = Path.Combine(Environment.CurrentDirectory, "reports");
        Directory.CreateDirectory(directory);
        Output.Example("2. SRP — робототехника", variant, () =>
        {
            var report = new Bad.RobotReport("Сборочный робот", 1000m);
            report.Print();
            report.Save(Path.Combine(directory, "robot-bad.txt"));
        }, () =>
        {
            var robot = new Good.Robot("Сборочный робот", 1000m);
            decimal cost = new Good.MaintenanceCalculator().Calculate(robot);
            Good.IReportPrinter[] printers = [new Good.ConsoleReportPrinter(),
                new Good.FileReportPrinter(Path.Combine(directory, "robot-good.txt"))];
            foreach (var printer in printers) printer.Print(robot, cost);
        });
    }
}
