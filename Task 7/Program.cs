namespace Task_7;
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a curse of uah to usa: "); double usd = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a curse of uah to eur: "); double eur = Convert.ToDouble(Console.ReadLine());
        Converter converter = new Converter(usd, eur, 1);
        Console.Write("Enter a how much have esa: "); double howUsd = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("{0}usd -> {1}uah", howUsd, converter.FromUSD(howUsd));
        Console.Write("Enter a how much have eur: "); double howEur = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("{0}eur -> {1}uah", howEur, converter.FromUSD(howEur));
        Console.Write("Enter a how much have uah: "); double howUah = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("{0}uah -> {1}eur", howUah, converter.ToEUR(howUah));
        Console.WriteLine("{0}uah -> {1}esd", howUah, converter.ToUSD(howUah));
    }
}