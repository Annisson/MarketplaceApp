using System;
using System.Collections.Generic;
using System.Text;

namespace MarketplaceApp
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string name,  string email, string username, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Username = username;
            this.Password = password;
        }

        public string SignUpCheckFields() // kollar att alla fält är ifyllda
        {
            string checkedInfo = "";

            if (Name == "" || Email == "" || Username == "" || Password == "")
            {
                string[] infoMessage = new string[4];
                for (int i = 0; i < infoMessage.Length; i++)
                {
                    if (Name == "")
                    {
                        infoMessage[i] += "\nName";
                    }
                    if (Email == "")
                    {
                        infoMessage[i] += "\nEmail";
                    }
                    if (Username == "")
                    {
                        infoMessage[i] += "\nUsername";
                    }
                    if (Password == "")
                    {
                        infoMessage[i] += "\nPassword";
                    }
                    return "\n" + infoMessage[i];
                }
            }
            return checkedInfo;
        }



    }
}
