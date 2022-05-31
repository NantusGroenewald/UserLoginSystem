using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UserLoginSystem.DataLayer; 

namespace UserLoginSystem.LogicLayer
{
    class CheckLogin
    {
        public CheckLogin() { } // default constructor

        public void checkLogin(string username, string password, List<string> usernames) //function to check
        {
            try
            {
                List<User> users = new List<User>(); // list of users with obj user

                foreach (var name in usernames) //loop through 
                {
                    string[] entries = name.Split(','); //split values at , and add to array 
                    users.Add(new User(entries[0], entries[1].Trim())); //add to list of users with properties of user class 
                }

                var user = users.Where(x => x.Username == username && x.Password == password).FirstOrDefault(); //check if provided username and password are the same as in the list
                if(user == null) //check if none of the values matched 
                {
                    throw new Exception("Login Failed"); //Display an error that login failed 
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Login Successful", "Success", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information); //show that login was a success 
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

    }
}
