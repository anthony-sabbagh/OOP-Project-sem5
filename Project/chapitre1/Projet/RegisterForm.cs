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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtLastName.Text != "" && txtName.Text != "" && txtNationality.Text != "" && txtFatherName.Text != "" && txtDateOfBirth.Text != "" && txtUserName.Text != "" && txtPin.Text != "" && txtDeposit.Text != "")
                {                                       
                    List<string> Loginid = File.ReadAllLines(@"C:\Users\Anthony\Desktop\Info.txt").ToList();

                    if (Loginid.Contains(txtUserName.Text) == false)
                    {

                        double u;
                        bool result = double.TryParse(txtDeposit.Text, out u);

                        if (result == true)
                        {                            
                            if(txtName.Text !=  txtUserName.Text )
                            {
                                if (txtLastName.Text != txtUserName.Text)
                                {
                                    if (txtFatherName.Text != txtUserName.Text)
                                    {
                                        if (txtNationality.Text != txtUserName.Text)
                                        {
                                            if(txtDateOfBirth.Text != txtUserName.Text)
                                            {
                                                string P = @"C:\Users\Anthony\Desktop\Info.txt";
                                                List<string> Info = File.ReadAllLines(P).ToList();
                                                Info.Add(txtLastName.Text + "\n" + txtName.Text + "\n" + txtNationality.Text + "\n" + txtFatherName.Text + "\n" + txtDateOfBirth.Text + "\n" + txtUserName.Text + "\n" + txtPin.Text + "\n" + txtDeposit.Text);
                                                File.WriteAllLines(P, Info);
                                                MessageBox.Show("Account created");
                                                this.Close();
                                                LoginForm LG = new LoginForm();
                                                LG.Show();
                                            }
                                            else
                                                MessageBox.Show("Username should be different form Date of birth");
                                           
                                        }else
                                            MessageBox.Show("Username should be different form Nationality");
                                        
                                    }
                                    else
                                        MessageBox.Show("Username should be different form LastName");
                                }
                                else
                                    MessageBox.Show("Username should be different form LastName");
                            }
                            else
                                MessageBox.Show("Username should be different form Name");
                            

                        }
                        else
                            MessageBox.Show("Balance should be a number");

                    }
                    else
                        MessageBox.Show("Username not available");
                    
                }else
                    MessageBox.Show("Please fill all the information");
                

            }
            catch (DirectoryNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);              
            }
            catch (FileLoadException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDateOfBirth.Clear();
            txtLastName.Clear();
            txtName.Clear();
            txtNationality.Clear();
            txtFatherName.Clear();
            txtDateOfBirth.Clear();
            txtUserName.Clear();
            txtPin.Clear();
            txtDeposit.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm LG = new LoginForm();
            LG.Show();
        }
    }
}
