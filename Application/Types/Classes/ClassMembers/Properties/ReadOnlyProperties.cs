using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.ClassMembers.Properties
{
    class RUser
    {
        private string password;

        // Read-only property
        public string CreatedBy { get; } = "Ravi Kumar";

        // Write-only property
        public string Password
        {
            set { password = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Created By: " + CreatedBy);
            Console.WriteLine("Password is stored securely.");
        }
    }
    class ReadOnlyProperties
    {
        /*
         * The read-only property has only a get accessor and it can only be read but not set from outside the class. 
         */
        public static void Example()
        {
            RUser user = new RUser();
            user.Password = "My$ecureP@ss";
            user.ShowInfo();
        }
    }
}
