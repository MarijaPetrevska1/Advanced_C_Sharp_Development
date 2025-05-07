using System.Collections.Generic;
using System.Linq;
using Task1.Models;

namespace Task1.Helpers
{
    public static class UserDatabase
    {
        private static List<User> Users = new List<User>
        {
            new User(1, "Marija", 26),
            new User(2, "Bob", 30),
            new User(3, "Ivana", 24),
            new User(4, "Diana", 22),
            new User(5, "Jovan", 21),
            new User(6, "Fiona", 30),
            new User(7, "George", 29),
            new User(8, "Hanna", 26),
            new User(9, "Ivan", 31),
            new User(10, "Julia", 22)
        };

        // Search by Id
        public static List<User> Search(int id)
        {
            return Users.Where(user => user.Id == id).ToList();
        }

        // Search by Name
        public static List<User> Search(string name)
        {
            return Users.Where(user => user.Name.ToLower() == name.ToLower()).ToList();
        }

        // Search by Age
        public static List<User> SearchByAge(int age)
        {
            return Users.Where(user => user.Age == age).ToList();
        }
    }
}
