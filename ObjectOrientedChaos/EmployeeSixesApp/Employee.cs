using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSixesApp
{
    class Employee
    {
        private int _empID;
        private string _loginName;
        private string _passWord;
        private int _SSN;
        private string _department;
        private int _securityLevel;

        public int EmpID
        {
            get { return _empID; }
        }

        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }

        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
        }

        public int SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public int SecurityLevel
        {
            get { return _securityLevel; }
        }

        public Boolean Login(string loginName, string password)
        {
            LoginName = loginName;
            PassWord = password;

            // Data normally retrieve from database

            if (loginName == "Smith" & password == "js")
            {
                _empID = 1;
                _securityLevel = 2;
                return true;
            }
            else if (loginName == "Jones" & password == "mj") // loginName == "Jones" & password = "mj"
            {
                _empID = 2;
                _securityLevel = 4;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
