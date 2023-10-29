namespace PersonsInfo
{
    public class Person
    {
        private int age = 0;
        private decimal salary = 0;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0) age = 0;
                else age = value;
            }
        }
        public decimal Salary 
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:F2} leva.";
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30) percentage /= 2;
            Salary *= 1 + (percentage / 100);
        }

    }
}
