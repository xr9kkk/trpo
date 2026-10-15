namespace L_Good.Interfaces;
//Телебоков А. И. SO(L)ID Математика (в т.ч. геометрия) и программирование
public interface IWritableRepository : IReadableRepository
{
    void Commit(string message);
}