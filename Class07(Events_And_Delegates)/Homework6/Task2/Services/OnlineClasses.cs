using System;

namespace Task2.Services
{
    // Class OnlineClass 
    public class OnlineClass
    {
        public delegate void UnauthorizedAccessHandler(string userName);
        public event UnauthorizedAccessHandler OnUnauthorizedAccess;

        private string[] restrictedUsers = { "Bob", "Jill", "Alice" };

        public void EnterClass(string userName)
        {
            if (Array.Exists(restrictedUsers, name => name.Equals(userName, StringComparison.OrdinalIgnoreCase)))
            {
                OnUnauthorizedAccess?.Invoke(userName);
            }
            else
            {
                Console.WriteLine($"Welcome {userName}.");
            }
        }
    }
}
