namespace TeamManagementSystem.Entities
{
    // Abstract class Employee
    public abstract class Employee
    {
        public string FullName { get; set; }

        public Employee(string fullName)
        {
            FullName = fullName;
        }

        // Abstract methods CalculateSalary() and DisplayInfo()
        public abstract double CalculateSalary();
        public abstract void DisplayInfo();
    }
}

