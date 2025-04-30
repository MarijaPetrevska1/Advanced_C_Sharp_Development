namespace TeamManagementSystem.Entities
{
    // Class Programmer
    public class Programmer : Employee
    {
        public double HourlyPayment { get; set; }
        public int TotalHours { get; set; }

        // Constructor for Programmer

        public Programmer(string fullName, double hourlyPayment, int totalHours)
            : base(fullName)
        {
            HourlyPayment = hourlyPayment;
            TotalHours = totalHours;
        }
        // Implementing the CalculateSalary method for Programmer
        public override double CalculateSalary()
        {
            return HourlyPayment * TotalHours;
        }

        // Implementing the DisplayInfo method for Programmer
        public override void DisplayInfo()
        {
            Console.WriteLine($"The Programmer is: {FullName}");
            Console.WriteLine($"Salary: {CalculateSalary()}$");
        }
    }
}

