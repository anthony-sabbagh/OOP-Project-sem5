using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace chapitre1.Projet
{  
     class Transaction : Account, IAccount
    {
        
            double withdrawA;
            public double WithdrawA
            {
                get { return withdrawA; }
                set { withdrawA = value; }
            }

            double depositA;
            public double DepositA
            {
                get { return depositA; }
                set { depositA = value; }
            }
                   
            public double Withdraw(double withdrawA, double B)
            {
                
                 B = B - withdrawA;
                 return B;
               
            }

            public double Deposit(double depositA, double B)
             {
                 
               B = B + depositA;
               return B;
             }

               
    }
   
    
}
