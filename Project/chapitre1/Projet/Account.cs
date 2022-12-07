using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapitre1.Projet
{
    
      abstract class  Account 
    {
        long accountNumber;

        
        public long AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

              
    }
}
