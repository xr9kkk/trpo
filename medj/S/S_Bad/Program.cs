using S_Bad;
//Телебоков А.И. (S)OLID 18.Кино, музыка, шоубизнес
var star = new StarReport { Name = "Джигуржа", Fee = 1000 };
star.Print();
star.SaveToFile("star.txt");