using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapitre1.Projet
{
    public delegate void LoginEventHandler(string loginName, Boolean status);

    class StatusCheck
    {
        
        public event LoginEventHandler LoginEV;

        public void L(string loginName, string pin)
        {
            if (loginName == "admin" && pin == "admin")
            {
                LoginEV(loginName, true);
                EmployeeForm f3 = new EmployeeForm();
                f3.Show();
            }

            else
            {
                LoginEV(loginName, false);
                ClientForm f4 = new ClientForm();
                f4.Show();
            }

        }
    }
}
