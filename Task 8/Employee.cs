namespace Task_8
{
    internal class Employee
    {
        public string Name { get; private set; } = string.Empty;
        public string Surname {  get; private set; } = string.Empty;
        public Position position { get; set; } = null;

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
