namespace O_Bad;
//Телебоков А.И. S(O)LID 7.Фэнтези XIX-XXI (в т.ч. книги, фильмы и игры)
class Geralt
{
    public void Attack(string monster)
    {
        if (monster == "Утопец")
            Console.WriteLine("Геральт бьёт серебряным мечом утопца");
        else if (monster == "Кикимора")
            Console.WriteLine("Геральт ставит ловушку на кикиморц");
        else if (monster == "Стрыга")
            Console.WriteLine("Геральт читает заклинание против стрыги");
        else
            Console.WriteLine("Неизвестный монстр");
    }
}