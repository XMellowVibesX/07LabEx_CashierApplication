using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    abstract class UserAccount
    {
        private string fullName;
        protected string userName, userPassword;

        public UserAccount(string fullName, string userName, string userPassword)
        {
            this.fullName = fullName;
            this.userName = userName;
            this.userPassword = userPassword;
        }

        public abstract bool validateLogin(string userName, string userPassword);
        public string getFullName() { return this.fullName; }
    }

    class Cashier : UserAccount
    {
        
        private string department;
        public Cashier(string fullName, string department, string userName, string userPassword) : base(fullName, userName, userPassword)
        {
            this.department = department;
        }

        public override bool validateLogin(string userName, string userPassword)
        {
            return this.userName == userName && this.userPassword == userPassword;
        }

        public string getDepartment() { return this.department; }


    }
}
