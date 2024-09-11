namespace Task_8
{
    public class Position
    {
        private int _age;
        private double _salary;

        public string Name { get; private set; } = string.Empty;
        public double Garbage { get; private set; } = 0.222;
        public double Salary 
        { 
            get 
            { 
                return _salary * Garbage + Age * Garbage; 
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

        public Position(string name, double salary, int age)
        {
            Age = age;
            Name = name;
            Salary = salary;
        }
    }
}
