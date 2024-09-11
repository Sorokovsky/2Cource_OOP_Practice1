namespace Task_8
{
    internal class Position
    {
        private int _salary, _age;

        public string Name { get; private set; } = string.Empty;
        public int Salary 
        { 
            get 
            { 
                return _salary; 
            } 
            set 
            {
                if (value < 0)
                {
                    _salary = 0;
                }
                else
                {
                    _salary = value;
                }
            } 
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }
            }
        }

        public Position(string name, int salary, int age)
        {
            Age = age;
            Name = name;
            Salary = salary;
        }
    }
}
