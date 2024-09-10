namespace Task_6;
public static class Program
{
    public static void Main()
    {
        string login, name, surname;
        int age;
        Console.Write("Enter a login: "); login = Console.ReadLine();
        Console.Write("Enter a name: "); name = Console.ReadLine();
        Console.Write("Enter a surname: "); surname = Console.ReadLine();
        Console.Write("Enter a age: "); age = Convert.ToInt32(Console.ReadLine());
        User user = new User(login, name, surname, age);
        user.Show();
    }
}