using System;

namespace TeacherNotificator.Models
{
    // Class Teacher
    public class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        // the event
        public event Action<string> OnNotificationSent;

        // Method to subscribe to the event
        public void Subscribe(Student student)
        {
            OnNotificationSent += student.GetNotification;
            Console.WriteLine($"{student.Name} subscribed to Professor {Name}'s notifications.");
        }

        // Method to unsubscribe from the event
        public void Unsubscribe(Student student)
        {
            OnNotificationSent -= student.GetNotification;
            Console.WriteLine($"{student.Name} unsubscribed from Professor {Name}'s notifications.");
        }

        // Method to send notifications
        public void SendNotification()
        {
            Console.WriteLine("Sending notifications...");
            string message = $"Notification from Professor {Name}: Class for {Subject} will start at 10 AM.";
            OnNotificationSent?.Invoke(message);
        }
    }
}

