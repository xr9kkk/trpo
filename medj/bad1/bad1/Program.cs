using bad1.extragoodonefolderforeveryfile;
//Телебоков А. И. Codestyle 18. Кино, музыка, шоубизнес
class program
{
    static void Main()
    {
        List<object> SOMEGOODLISTYEAH = new List<object>
        {
            new movie("ГЛАД ВАЛАКАС", 120),
            new documentary("ЧЕБУРАШКА", 45)
        };
        
        var dUrAtiONZZZZZZZ = SOMEGOODLISTYEAH
            .Select(film => film is movie m ? m.duration : ((documentary)film).duration)
            .ToList();
        Console.WriteLine(dUrAtiONZZZZZZZ.Count != 0 ? dUrAtiONZZZZZZZ.Average() : 0);
        
        SOMEGOODLISTYEAH.Add(new movie("КАКОЙ ТО ФИЛЬМ", 300));
        
        dUrAtiONZZZZZZZ = SOMEGOODLISTYEAH
            .Select(film => film is movie m ? m.duration : ((documentary)film).duration)
            .ToList();
        Console.WriteLine(dUrAtiONZZZZZZZ.Count != 0 ? dUrAtiONZZZZZZZ.Average() : 0);

        verygoodroflplayerWTF p = new verygoodroflplayerWTF();

        foreach (object film in SOMEGOODLISTYEAH)
        {
            p.start(film);
        }
    }
}