using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace chapitre1.Projet
{
    public partial class LoginForm : Form
    {
        public string username, pin; 

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm E = new RegisterForm();
            E.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {                                             
                string F = @"C:\Users\Anthony\Desktop\Info.txt";
                List<string> Loginid = File.ReadAllLines(F).ToList();
          
               if(txtUsername.Text != "admin" || txtPin.Text !="admin") 
               {
                   if ((Loginid.Contains(txtUsername.Text) == true) && (Loginid.Contains(txtPin.Text) == true))
                   {
                       int i;
                       i = Loginid.IndexOf(txtUsername.Text);

                       if (Loginid[i+1] == txtPin.Text)
                       {
                           using (TextWriter Hr = new StreamWriter(new FileStream(@"C:\Users\Anthony\Desktop\current.txt", FileMode.Create, FileAccess.Write), new UTF8Encoding()))
                           {
                               Hr.WriteLine(txtUsername.Text);
                               Hr.WriteLine(txtPin.Text);
                           }
                           
                           this.Hide();

                           Projet.StatusCheck E = new Projet.StatusCheck();
                           E.LoginEV += new Projet.LoginEventHandler(LoginEV);
                           E.L(this.txtUsername.Text, this.txtPin.Text);
                       }
                       else
                           MessageBox.Show("Username or pin is wrong!", "Error!");
                   }else 
                       MessageBox.Show("Username or pin is wrong!", "Error!");

               }
               else
               {
                  
                   this.Hide();

                   Projet.StatusCheck E = new Projet.StatusCheck();
                   E.LoginEV += new Projet.LoginEventHandler(LoginEV);
                   E.L(this.txtUsername.Text, this.txtPin.Text);
               }                                                   
            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Username not created please register");
            }
            catch (DirectoryNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }                                
     }

         void LoginEV (string loginName, bool status)
        {
             if(status == true)
             {
                 MessageBox.Show("Login status : Employee", "Success!");
                
             }else
                 MessageBox.Show("Login status : Client", "Success!");
         
        }

         private void LoginForm_Load(object sender, EventArgs e)
         {            
             Data.Readdata();
         }
    }
}