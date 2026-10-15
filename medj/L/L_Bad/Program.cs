using L.Models;
//Телебоков А. И. SO(L)ID Математика (в т.ч. геометрия) и программирование

Repository repository = new Repository();
repository.Commit("initial commit");
repository.Commit("add feature");
Console.WriteLine(repository.Count);

Repository archivedRepository = new ArchivedRepository();
archivedRepository.Commit("initial commit");
Console.WriteLine(archivedRepository.Count);