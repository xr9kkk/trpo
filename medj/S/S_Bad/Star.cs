namespace S_Bad;
//Телебоков А.И. (S)OLID 18.Кино, музыка, шоубизнес
class StarReport
{
    public string Name;
    public double Fee;

    public double CalculateFeeWithTax() => Fee * 1.2;

    public void Print() =>
        Console.WriteLine($"Отчёт для налоговой {Name}: гонорар {CalculateFeeWithTax()}");

    public void SaveToFile(string path) =>
        File.WriteAllText(path, $"{Name}:{CalculateFeeWithTax()}");
}