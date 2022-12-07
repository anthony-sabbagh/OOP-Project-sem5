using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapitre1.Projet
{
    sealed class SaveDictionaryFile //to save the new balance
    {
        public static void savedata( Dictionary<int, double> F)
        {


            try
            {                
                Stream sd = new FileStream(@"C:\Users\Anthony\Desktop\current.txt", FileMode.Open);
                StreamReader sdi = new StreamReader(sd);
                string username, pin;
                username = sdi.ReadLine();
                pin = sdi.ReadLine();
                sd.Close();

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
                            double P = F[1];                            
                            Info[j + 2] = P.ToString();
                            File.WriteAllLines(@"C:\Users\Anthony\Desktop\Info.txt", Info);                          

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
            catch (DirectoryNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                
            }

        }
    }
}
