namespace Labs.Lab04;
public static class Demo
{
    public static void Run(string variant) => Output.Example("4. LSP — метеорологические наблюдения", variant, () =>
    {
        Bad.WeatherJournal[] journals = [new Bad.WeatherJournal(), new Bad.ArchivedWeatherJournal()];
        foreach (var journal in journals)
        {
            try { journal.Add("Москва: +10 °C"); Console.WriteLine($"Записей: {journal.Count}"); }
            catch (InvalidOperationException error) { Console.WriteLine($"Нарушение контракта: {error.Message}"); }
        }
    }, () =>
    {
        Good.IWritableWeatherJournal current = new Good.WeatherJournal();
        current.Add("Москва: +10 °C");
        Good.IReadOnlyWeatherJournal archive = new Good.ArchivedWeatherJournal(["Байкал: −5 °C"]);
        Print(current);
        Print(archive);
    });
    private static void Print(Good.IReadOnlyWeatherJournal journal) =>
        Console.WriteLine($"Записей: {journal.Count}; первая: {journal[0]}");
}
