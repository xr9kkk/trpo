namespace Labs.Lab04.Bad;

public class WeatherJournal
{
    private readonly List<string> _observations = [];
    public virtual void Add(string observation) => _observations.Add(observation);
    public int Count => _observations.Count;
}
public sealed class ArchivedWeatherJournal : WeatherJournal
{
    // Подтип нарушает обещание базового типа принимать наблюдения.
    public override void Add(string observation) =>
        throw new InvalidOperationException("Архивный журнал нельзя изменять.");
}
