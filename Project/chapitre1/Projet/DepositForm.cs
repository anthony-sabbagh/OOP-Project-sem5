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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Transaction T = new Transaction();
            Dictionary<int, double> A  = new Dictionary<int, double>();
            A = Data.Readdata();

            ClientForm CF = new ClientForm();

            double balance;
            double Deposit;
            balance = A[1];
            Deposit = Convert.ToDouble(txtDepositAmount.Text);
            A[1] = T.Deposit(Deposit,balance);
            SaveDictionaryFile.savedata(A);
            MessageBox.Show("The $" + Deposit + " were deposit to your account");
            this.Hide();
            CF.Show();   
                     
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientForm CF = new ClientForm();
            CF.Show();

        }
    }
}
