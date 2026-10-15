namespace bad1.extragoodonefolderforeveryfile;
//Телебоков А. И. Codestyle 18. Кино, музыка, шоубизнес
class documentary
{
    public string title;
    public int duration;

    public documentary(string title, int duration)
    {
        this.title = title;
        this.duration = duration;
    }

    public void play()
    {
        Console.WriteLine($"играем тупа какой то документальный {title}");
    }
}