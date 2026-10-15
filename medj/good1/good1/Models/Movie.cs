using good1.Interfaces;

namespace good1.Models;
//Телебоков А. И. Codestyle 18. Кино, музыка, шоубизнес
class Movie(string title, int duration) : IPlayable
{
    public string Title { get; } = title;
    public int Duration { get; } = duration;

    public void Play()
    {
        Console.WriteLine($"ИГРАЙ ГАРМОНЬ {Title}");
    }
}