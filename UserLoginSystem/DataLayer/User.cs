namespace UserLoginSystem.DataLayer
{
    class User
    {
        private string _username;
        private string _password;  

        public User() {} //default constructor

        public User(string username, string password) //constructor with values
        {
            Username = username;
            Password = password;
        }

        //encapsulates values
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
