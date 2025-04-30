namespace TeamManagementSystem.Entities
{
    // Class Manager
    public class Manager : Employee
    {
        public double Salary { get; set; }
        public double Bonus { get; set; }

        // Constructor
        public Manager(string fullName, double salary, double bonus)
            : base(fullName)
        {
            Salary = salary;
            Bonus = bonus;
        }
        // Implementing the CalculateSalary method for Manager
        public override double CalculateSalary()
        {
            return Salary + Bonus;
        }
        // Implementing the DisplayInfo method for Manager
        public override void DisplayInfo()
        {
            Console.WriteLine($"The Manager is: {FullName}");
            Console.WriteLine($"Salary: {CalculateSalary()}$");
        }
    }
}

