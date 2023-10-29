namespace PersonsInfo
{
    public class Person
    {
        private string firstName = null;
        private string lastName = null;
        private int age = 0;
        private decimal salary = 0;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                if (value.Length < 3) throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                else firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName ;
            }
            private set
            {
                if (value.Length < 3) throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                else firstName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0) throw new ArgumentException("Age cannot be zero or a negative integer!");
                else age = value;
            }
        }
        public decimal Salary 
        {
            get
            {
                return salary;
            }
            private set
            {
                if (value < 650m) throw new ArgumentException("Salary cannot be less than 650 leva!");
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
