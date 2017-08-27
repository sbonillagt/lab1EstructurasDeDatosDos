using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_ED2_2001516
{
    class Utilities
    {
        string txtUser = ""; // Variable que entra como usuario
        string txtPassword = ""; // variable que entra como contrasena
        User objUser = new User();
        List<User> listUsers = new List<User>();

        public void initializingVariables()
        { 
            User admin = new User();
            admin.user = "1234";
            admin.password = "1234";
            listUsers.Add(admin);
        }

        public bool chekUserAndPassword(string iUser, string iPassword)
        {
            User userVariable =new User();
            userVariable.user = iUser;
            userVariable.password = iPassword;
            if (listUsers.Exists(User=> User.user== iUser && User.password==iPassword ))
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
