using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.ClassMembers.Properties
{
    class WUser
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
    class WriteOnlyProperties
    {
        /*
         * The write-only property has only a set accessor and it can be set but not read
         */
        public static void Example()
        {
            WUser user = new WUser();
            user.Password = "My$ecureP@ss";
            user.ShowInfo();
        }
    }
}
