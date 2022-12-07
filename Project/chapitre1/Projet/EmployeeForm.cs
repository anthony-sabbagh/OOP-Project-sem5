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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnInportInformation_Click(object sender, EventArgs e)
        {
            
            List<string> Info = File.ReadAllLines(@"C:\Users\Anthony\Desktop\Info.txt").ToList();

            if (Info.Contains(txtClientUserName.Text) == true) 
            {
                if (Info.Contains(txtClientLastName.Text) == true)
                {
                    int j;
                    j = Info.IndexOf(txtClientUserName.Text);
                    int c = Info.Count - 1;
                    if (j-5 >= 0 && j+2 <= c)
                    {                  
                        if (Info[j - 5] == txtClientLastName.Text)
                        {
                            string[] row = new string[6];
    
                            row[0] = Info[j - 5];
                            row[1] = Info[j - 4];
                            row[2] = Info[j - 3];
                            row[3] = Info[j - 2];
                            row[4] = Info[j - 1];
                            row[5] = Info[j + 2];

                            string[] row1 = new string[] { row[0], row[1], row[2], row[3], row[4], row[5]};                           
                            object[] rows = new object[] { row1 };
                            foreach(string[] rowArray in rows)
                            {
                                dataGridInfo.Rows.Add(rowArray);
                            }
                           



                       }
                        else
                            MessageBox.Show("Client doesn't exist or information are wrong");
                    }
                    else
                        MessageBox.Show("Client doesn't exist or information are wrong");
                }
                else
                    MessageBox.Show("Client doesn't exist or information are wrong");
            }
              else
                MessageBox.Show("Client doesn't exist or information are wrong");                 
        } 
     
        private void EmployeeForm_Load(object sender, EventArgs e)
        {           
            DataGridViewCellStyle style = dataGridInfo.ColumnHeadersDefaultCellStyle;

            dataGridInfo.ColumnCount = 6;

            dataGridInfo.Columns[0].Name = "LastName";
            dataGridInfo.Columns[1].Name = "Name";
            dataGridInfo.Columns[2].Name = "Nationality";
            dataGridInfo.Columns[3].Name = "FatherName";
            dataGridInfo.Columns[4].Name = "Date Of Birth";
            dataGridInfo.Columns[5].Name = "Balance";            
        }

        private void btnClearInfo_Click(object sender, EventArgs e)
        {
            if (dataGridInfo.Rows.Count !=0)
            {
                dataGridInfo.Rows.Clear();
            } 
                
            else
                MessageBox.Show("DataGrid is already empty");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm L = new LoginForm();
            L.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            RegisterForm R = new RegisterForm();
            R.Show();
        }
    }
}
