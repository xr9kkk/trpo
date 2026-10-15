using L_Good.Interfaces;

namespace L_Good.Models;
//Телебоков А. И. SO(L)ID Математика (в т.ч. геометрия) и программирование
public class Repository : IWritableRepository
{
    private List<string> _commits;

    public Repository(IEnumerable<string> commits)
    {
        _commits = commits.ToList();
    }

    public Repository()
    {
        _commits = [];
    }

    public virtual void Commit(string message) => _commits.Add(message);
    public virtual int Count => _commits.Count;
    public string this[int index] => _commits[index];
}