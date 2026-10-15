namespace bad1.extragoodonefolderforeveryfile;
//Телебоков А. И. Codestyle 18. Кино, музыка, шоубизнес
public class verygoodroflplayerWTF
{
    public void start(object film)
    {
        if (film is movie)
        {
            movie m = (movie)film;
            m.play();
        }
        else if (film is documentary)
        {
            documentary d = (documentary)film;
            d.play();
        }
    }
}