namespace Labs.Lab04.Good;

public interface IReadOnlyWeatherJournal
{
    int Count { get; }
    string this[int index] { get; }
}
public interface IWritableWeatherJournal : IReadOnlyWeatherJournal
{
    void Add(string observation);
}
public sealed class WeatherJournal : IWritableWeatherJournal
{
    private readonly List<string> _observations = [];
    public int Count => _observations.Count;
    public string this[int index] => _observations[index];
    public void Add(string observation) => _observations.Add(observation);
}
public sealed class ArchivedWeatherJournal(IEnumerable<string> observations) : IReadOnlyWeatherJournal
{
    private readonly string[] _observations = observations.ToArray();
    public int Count => _observations.Length;
    public string this[int index] => _observations[index];
}
