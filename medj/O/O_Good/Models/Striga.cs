using O_Good.Interfaces;

namespace O_Good.Models;
//Телебоков А.И. S(O)LID 7.Фэнтези XIX-XXI (в т.ч. книги, фильмы и игры)
class Striga : IMonster
{
    public void FightWithGeralt() => 
        Console.WriteLine("Геральт читает заклинание против стрыги");
    
}