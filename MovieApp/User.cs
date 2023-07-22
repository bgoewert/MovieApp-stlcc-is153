
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;

namespace MovieApp
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        private readonly List<Movie> listFavorites = new List<Movie>();
        public List<Movie> Favorites { get => listFavorites; }

        public User(string username, string password) {
            Username = username;
            Password = password;
        }

        public static User? Login(string username, string password)
        {
            return UserList.Users.FirstOrDefault(user => (user.Username == username && user.Password == password));
        }

        public static bool VerifyUsername(string username)
        {
            if (UserList.Users.Any(user => user.Username == username))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerifyPassword(string password)
        {
            if (UserList.Users.Any(user => user.Password == password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal static class UserList
    {
        private static List<User> userList = new List<User>() {
            new User("admin", "admin"),
            new User("test", "test")
        };

        public static List<User> Users { get => userList; }
    }
}
