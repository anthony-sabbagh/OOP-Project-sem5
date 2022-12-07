using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapitre1.Projet
{
   sealed class Data 
    {
        public static Dictionary<int, double> Readdata() //to read the balance
        {
            try
            {             
                Stream gi = new FileStream(@"C:\Users\Anthony\Desktop\current.txt", FileMode.Open);
                StreamReader sri = new StreamReader(gi);
                string username, pin;
                username = sri.ReadLine();
                pin = sri.ReadLine();
                gi.Close();
                              
                var BalanceInfo = new Dictionary<int, double>();

                int lines = File.ReadAllLines(@"C:\Users\Anthony\Desktop\Project\Info.txt").Length;
                                
                List<string> Info = File.ReadAllLines(@"C:\Users\Anthony\Desktop\Project\Info.txt").ToList();

                for (int i = 0; i < lines; i++)
                {
                    if ((Info.Contains(username) == true) && (Info.Contains(pin) == true))
                    {
                        int j;
                        j = Info.IndexOf(username);

                        if (Info[j + 1] == pin)
                        {
                            BalanceInfo.Add(1, Convert.ToDouble(Info[j + 2]));
                            return BalanceInfo;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("You don't have an account please register");
                            return null;
                        }
                            
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("You don't have an account please register");
                        return null;
                    }
                    
                }
                return BalanceInfo;

            }
            catch (DirectoryNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
                                                             
        }  
     
    }

}
