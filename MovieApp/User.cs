
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;

namespace MovieApp
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }


        /*
         * Define the favorites list.
         * This only stores the movie title, which can then later be used to reference a key from the MovieList if needed.
         */
        private readonly List<Movie> listFavorites = new List<Movie>();
        public List<Movie> Favorites { get => listFavorites; }

        /*
         * Define the user list.
         */
        private static List<User> userList = new List<User>() {
            new User("admin", "admin"),
            new User("test", "test")
        };
        internal static List<User> UserList { get => userList; }

        public User(string username, string password) {
            Username = username;
            Password = password;
        }

        public static User? Login(string username, string password)
        {
            return UserList.FirstOrDefault(user => (user.Username == username && user.Password == password));
        }

        public static bool VerifyUsername(string username)
        {
            if (UserList.Any(user => user.Username == username))
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
            if (UserList.Any(user => user.Password == password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
