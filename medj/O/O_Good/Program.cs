using O_Good.Interfaces;
using O_Good.Models;
//Телебоков А.И. S(O)LID 7.Фэнтези XIX-XXI (в т.ч. книги, фильмы и игры)
var geralt = new Geralt();
var monsters = new List<IMonster> { new Drowner(), new Kikimora(), new Striga() };
foreach (var m in monsters) 
    geralt.Attack(m);