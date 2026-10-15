namespace L.Models;
//Телебоков А. И. SO(L)ID Математика (в т.ч. геометрия) и программирование
public class ArchivedRepository : Repository
{
    public override void Commit(string message) =>
        throw new InvalidOperationException("архивный репозиторий коммиты запрещены");
}