using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    public class Admin
    {
        private String username;
        private String password;

        public Admin(String adminUsername, String adminPassword)
        {
            username = adminUsername;
            password = adminPassword;
        }

        public String getName()
        {
            return username;
        }

        public void setPassword(String adminPassword)
        {
            password = adminPassword;
        }

        public String getPassword()
        {
            return password;
        }
    }
}
