public static class Program
{
    public static void Main()
    {
        
    }

    public static int ChooseOperation()
    {
        Console.WriteLine("Choose operation.");
        Console.WriteLine("0-Exit.");
        Console.WriteLine("1-Create triangle.");
        int operation = Convert.ToInt32(Console.ReadLine());
        return operation;
    }
}