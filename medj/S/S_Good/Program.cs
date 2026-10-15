using S_Good.Interfaces;
using S_Good.Models;
using S_Good.Services;
//Телебоков А.И. (S)OLID 18.Кино, музыка, шоубизнес
var star = new Star { Name = "Актер", Fee = 1000 };
var calc = new FeeCalculator();
double fee = calc.Calculate(star);

IReportPrinter consolePrinter = new ConsoleReportPrinter();
consolePrinter.Print(star, fee);
IReportPrinter filePrinter = new FileReportPrinter("file.txt");
filePrinter.Print(star, fee);
Console.WriteLine("Файл сохранён.");