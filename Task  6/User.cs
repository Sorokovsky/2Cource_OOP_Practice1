namespace Task_6
{
    internal class User
    {
        private int _age;

        public string Login { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public DateTime CreatedAt { get; init; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value < 1)
                {
                    _age = 1;
                }
                else
                {
                    _age = value;
                }
            }
        }

        public User(string login, string name, string surname, int age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            CreatedAt = DateTime.Now;
        }

        public void Show()
        {
            Console.WriteLine("Login: {0}.", Login);
            Console.WriteLine("Name: {0}.", Name);
            Console.WriteLine("Surname: {0}.", Surname);
            Console.WriteLine("Age: {0}.", Age);
            Console.WriteLine("Created at: {0}.", CreatedAt);
        }
    }
}
