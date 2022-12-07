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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username, pin;
            try
            {
                Stream s = new FileStream(@"C:\Users\Anthony\Desktop\current.txt", FileMode.Open);
                StreamReader sr = new StreamReader(s);
                username = sr.ReadLine();
                pin = sr.ReadLine();
                s.Close();


                if (txtCurrentPin.Text == pin)
                {
                    if (txtNewPin.Text != "")
                    {
                        if (chbNotRobot.CheckState == CheckState.Checked)
                        {
                                FileStream W = new FileStream(@"C:\Users\Anthony\Desktop\current.txt", FileMode.Create, FileAccess.Write);
                                StreamWriter sw = new StreamWriter(W);
                                sw.WriteLine(username + "\n" + txtNewPin.Text);
                                sw.Close();

                                int lines = File.ReadAllLines(@"C:\Users\Anthony\Desktop\Info.txt").Length;
                                
                                List<string> Info = File.ReadAllLines(@"C:\Users\Anthony\Desktop\Info.txt").ToList();

                                for (int i = 0; i < lines; i++)
                                {
                                    if ((Info.Contains(username) == true) && (Info.Contains(pin) == true))
                                    {
                                        int j;
                                        j = Info.IndexOf(username);

                                        if (Info[j + 1] == pin)
                                        {
                                            Info[j + 1] = txtNewPin.Text;
                                            File.WriteAllLines(@"C:\Users\Anthony\Desktop\Info.txt", Info);
                                            this.Close();
                                            
                                            System.Windows.Forms.MessageBox.Show("Pin changed successfully!");                                          
                                            LoginForm f1 = new LoginForm();
                                            f1.Show();
                                            break;    
                                        }
                                        else
                                        {
                                            System.Windows.Forms.MessageBox.Show("You don't have an account please register");

                                        }

                                    }
                                    else
                                    {
                                        System.Windows.Forms.MessageBox.Show("You don't have an account please register");

                                    }
                                }
                                
                        }
                        else
                            System.Windows.Forms.MessageBox.Show("Please check checkbox!");
                    }
                    else
                        System.Windows.Forms.MessageBox.Show("Please enter a new pin!");
                }
                else
                        System.Windows.Forms.MessageBox.Show("Current Pin is wrong!");
            }

            catch (FileNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
           LoginForm LG = new LoginForm();
           LG.Show();
        }
    }
}
