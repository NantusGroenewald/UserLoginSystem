using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLoginSystem.DataLayer; 

namespace UserLoginSystem.LogicLayer
{
    class RegisterUser
    {
        User user = new User(); //add user object

        public RegisterUser() // default constructor
        {
            
        }

        public string addUser(string username, string password) //Funciton that takes username and password and returns string with comma separated values 
        {
            user.Username = username; 
            user.Password = password;

            string newuser = $"{user.Username}, {user.Password}";

            return newuser; 
        }
    }
}
