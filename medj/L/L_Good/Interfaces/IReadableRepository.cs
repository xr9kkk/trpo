namespace L_Good.Interfaces;
//Телебоков А. И. SO(L)ID Математика (в т.ч. геометрия) и программирование
public interface IReadableRepository
{
    int Count { get; }
    string this[int index] { get; }
}