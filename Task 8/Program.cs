namespace Task_8;
public static class Program
{
    public static void Main()
    {
        Employee employee = EnterEmployee();
        employee.Position = EnterPosition();
        employee.Show();
    }

    public static Position EnterPosition()
    {
        Console.Write("Введіть назву посади: "); string name = Console.ReadLine();
        Console.Write("Введіть зарплату: "); double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть стаж в роках: "); int age = Convert.ToInt32(Console.ReadLine());
        return new Position(name, salary, age);
    }

    public static Employee EnterEmployee()
    {
        Console.Write("Введіть ім'я: "); string name = Console.ReadLine();
        Console.Write("Введіть прізвище: "); string surname = Console.ReadLine();
        return new Employee(name, surname);
    }
}