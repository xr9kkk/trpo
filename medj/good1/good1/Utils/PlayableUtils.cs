using good1.Interfaces;

namespace good1.Utils;
//Телебоков А. И. Codestyle 18. Кино, музыка, шоубизнес
public static class PlayableUtils
{
    public static double CalculateAverageDuration(IEnumerable<IPlayable> playables)
    {
        var playablesList = playables.ToList();
        return playablesList.Count != 0 ? playablesList.Average(p => p.Duration) : 0;
    }
}