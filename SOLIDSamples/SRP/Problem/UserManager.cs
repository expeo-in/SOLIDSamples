using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.SRP.Problem
{
    internal class UserManager
    {
        public bool AuthenticateUser(string username, string password)
        {
            Console.WriteLine("Authenticate user");
            return true;
        }

        public void UpdateUserProfile(string userid, string address)
        {
            Console.WriteLine("Update User");
        }

        public void SendEmail(string email, string message)
        {
            Console.WriteLine("Email user");
        }
    }
}
