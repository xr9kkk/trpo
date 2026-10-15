using good1.Models;
using good1.Services;
using good1.Utils;

namespace good1;
//Телебоков А. И. Codestyle 18. Кино, музыка, шоубизнес
class Program
{
    static void Main()
    {
        Player player = new Player();

        player.AddToPlaylist(new Movie("ГЛАД ВАЛАКАС", 120));
        player.AddToPlaylist(new Documentary("ЧЕБУРАШКА", 45));

        double avgBefore = PlayableUtils.CalculateAverageDuration(player.GetPlaylist());
        Console.WriteLine($"{avgBefore}");

        player.AddToPlaylist(new Movie("КАОКЙ ТО ФИЛЬМ", 300));

        double avgAfter = PlayableUtils.CalculateAverageDuration(player.GetPlaylist());
        Console.WriteLine($"{avgAfter}");
        
        player.PlayAll();
    }
    
}