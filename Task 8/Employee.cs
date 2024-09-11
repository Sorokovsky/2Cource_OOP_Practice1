namespace Task_8
{
    public class Employee
    {
        public string Name { get; private set; } = string.Empty;
        public string Surname {  get; private set; } = string.Empty;
        public Position Position { get; set; } = null;

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void Show()
        {
            Console.WriteLine("Ім'я: {0}.", Name);
            Console.WriteLine("Прізвище: {0}.", Surname);
            Console.WriteLine("Посада: {0}.", Position.Name);
            Console.WriteLine("Зарплата: {0}.", Position.Salary);
            Console.WriteLine("Податковий збір: {0}.", Position.Garbage);
        }
    }
}
