using L_Good.Interfaces;

namespace L_Good.Models;

//Телебоков А. И. SO(L)ID Математика (в т.ч. геометрия) и программирование
public class ReadOnlyRepository : IReadableRepository
{
    private readonly List<string> _commits;

    public ReadOnlyRepository(IEnumerable<string> commits)
    {
        _commits = new List<string>(commits);
    }

    public int Count => _commits.Count;
    public string this[int index] => _commits[index];
}