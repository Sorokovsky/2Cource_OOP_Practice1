namespace Task_5;
public static class Program
{
    public static void Main()
    {
        Address address = new Address();
        Console.Write("Enter a index: "); address.Index = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a Country: "); address.Country = Console.ReadLine();
        Console.Write("Enter a City: "); address.City = Console.ReadLine();
        Console.Write("Enter a Street: "); address.Street = Console.ReadLine();
        Console.Write("Enter a House: "); address.House = Console.ReadLine();
        Console.Write("Enter a Apartment: "); address.Apartment = Console.ReadLine();
        Console.WriteLine("Your address.");
        address.Show();
    }
}