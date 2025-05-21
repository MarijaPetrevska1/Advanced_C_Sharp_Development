namespace TeacherNotificator.Models
{
    // Class Student 
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        public void GetNotification(string message)
        {
            Console.WriteLine($"{Name}: {message}");
        }
    }
}

