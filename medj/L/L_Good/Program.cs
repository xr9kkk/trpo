using L_Good.Interfaces;
using L_Good.Models;
//Телебоков А. И. SO(L)ID Математика (в т.ч. геометрия) и программирование
IWritableRepository repository = new Repository();
repository.Commit("initial commit");
repository.Commit("add feature");
Console.WriteLine(repository.Count);

IReadableRepository archivedRepository = new ReadOnlyRepository(
    ["v1.0", "v1.1", "v2.0"]);
Console.WriteLine(archivedRepository.Count);
Console.WriteLine(archivedRepository[0]);