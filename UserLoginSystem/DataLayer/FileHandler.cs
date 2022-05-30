using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace UserLoginSystem.DataAccessLayer
{
    class FileHandler
    {
        public FileHandler()
        {

        }

        string filepath = $"{AppContext.BaseDirectory}userLogin.txt"; //used to locate file storing login details 

        public List<string> readData() //Function that read data stored on the txt file
        {
            List<string> data = new List<string>();
            try
            {
                FileStream stream = new FileStream(filepath, FileMode.OpenOrCreate); //Will create file in spesified location if it does not exist or will just open when it does. 
                string text;
                using (StreamReader reader = new StreamReader(stream))
                {
                    while ((text = reader.ReadLine()) != null) 
                    {
                        data.Add(text); 
                    }
                }
                return data; //Returns data from the file as a list 
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void addUser(List<string> newUser) //Function to store a new users details to the text file 
        {
            File.WriteAllLines(filepath, newUser); 
        }
    }
}
