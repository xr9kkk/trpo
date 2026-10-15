namespace good1.Interfaces;
//Телебоков А. И. Codestyle 18. Кино, музыка, шоубизнес
public interface IPlayable
{
    string Title { get; }
    int Duration { get; }

    void Play();
}