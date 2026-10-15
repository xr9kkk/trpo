namespace L.Models;
//Телебоков А. И. SO(L)ID Математика (в т.ч. геометрия) и программирование
public class Repository
{
    protected List<string> _commits = new();

    public virtual void Commit(string message) => _commits.Add(message);
    public virtual int Count => _commits.Count;

    public virtual string this[int index] => _commits[index];
}