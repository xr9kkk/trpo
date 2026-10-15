using S_Good.Models;
//Телебоков А.И. (S)OLID 18.Кино, музыка, шоубизнес
namespace S_Good.Services;

class FeeCalculator
{
    public double Calculate(Star s) => s.Fee * 1.2;
}