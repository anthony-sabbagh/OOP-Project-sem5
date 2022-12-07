using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapitre1.Projet
{
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Transaction T = new Transaction();    
            Dictionary<int, double> A  = new Dictionary<int, double>();
            A = Data.Readdata();

            ClientForm CF = new ClientForm();

            
            double Withdraw;
            double balance;
            balance = A[1];
            Withdraw = Convert.ToDouble(txtWithdrawAmount.Text);
            if (Withdraw <= balance)
            {
                A[1] = T.Withdraw(Withdraw, balance);
                SaveDictionaryFile.savedata(A);
                MessageBox.Show("The $" + Withdraw + " were withdrawn from your account");
                this.Hide();
                CF.Show();
            }
            else
                MessageBox.Show("Your balance is: $" + balance + " you can't withdraw: $" + Withdraw );                      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientForm CF = new ClientForm();
            CF.Show();

        }
    }
}
