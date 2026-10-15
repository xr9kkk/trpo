namespace bad1.extragoodonefolderforeveryfile;
//Телебоков А. И. Codestyle 18. Кино, музыка, шоубизнес
public class movie
{
    public string title;
    public int duration;

    public movie(string title, int duration)
    {
        this.title = title;
        this.duration = duration;
    }
    
    public void play()
    {
        Console.WriteLine($"Играем тупа пажилой фильм {title}");
    }
}