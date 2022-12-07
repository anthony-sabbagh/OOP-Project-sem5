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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnChangePin_Click(object sender, EventArgs e)
        {
            ChangePin f5 =new ChangePin();
            f5.Show();
            this.Close();
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm f5 = new LoginForm();            
            this.Close();
            f5.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositForm DF = new DepositForm();
            DF.Show();
            

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            this.Close();
            WithdrawForm WA = new WithdrawForm();
            WA.Show();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {            
            Dictionary<int, double> X = new Dictionary<int, double>();  
            X = Data.Readdata();
            MessageBox.Show("your balance is: $" + X[1]);                                              
        }

    }

}
