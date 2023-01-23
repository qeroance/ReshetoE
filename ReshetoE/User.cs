using System;
using System.Text;
using System.Data.Entity;

namespace ReshetoE
{
    class User
    {
        public string Login { get; }
        public string Password { get; }
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
