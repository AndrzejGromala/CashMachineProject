using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CashMachineProject.ClassesBussiness
{
   public static class FileOperations
    {
        //METHOD FOR VALIDATING THE ACCOUNT AND PIN under Enter button
        public static List<Account> listOfAccounts = new List<Account>();
        public static List<Account> ReadingAccounts(string filepath)
        {
            List<Account> listOfAccounts = new List<Account>();
            

            String[] AllAccountData = File.ReadAllLines(filepath);

            for(int i = 0; i<AllAccountData.Length; i++)
            {
                Account tempAcc = new Account();//this has to be inside because outside it only populates 
                //everything with the last line which is the last array
                String[] AccountParameter = AllAccountData[i].Split('|');
                tempAcc.setAccountNb(AccountParameter[0]);
                tempAcc.setBalance(double.Parse(AccountParameter[1]));
                tempAcc.setActive(bool.Parse(AccountParameter[2]));
                tempAcc.setAccount_Name(AccountParameter[3]);
                tempAcc.setPin(AccountParameter[4]);
                tempAcc.setAttempteRemaining(int.Parse(AccountParameter[5]));
                listOfAccounts.Add(tempAcc);
            }
            return listOfAccounts;
        }
        public static List<Account> AccountShow()
        {
            List<Account> file = new List<Account>();

            file = FileOperations.ReadingAccounts("C:\\Users\\Andrzej\\Desktop\\C#test.txt");

            return file;

        }

        //Write to File method from Costa's project
        public static void WriteAccountsToFile(string filePath, List<Account> listOfAccounts)
        {// Create method to read from text file.

            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor. 
                StreamWriter sw = new StreamWriter(filePath);// No need to create file C# does it for you. 
                string line;
                for (int i = 0; i < listOfAccounts.Count; i++)
                {
                    line = listOfAccounts[i].getAccountNb().ToString();
                    sw.Write(line + "|");

                    line = listOfAccounts[i].getBalance().ToString();
                    sw.Write(line + "|");

                    line = listOfAccounts[i].getActive().ToString();
                    sw.Write(line + "|");

                    line = listOfAccounts[i].getAccount_Name();
                    sw.Write(line + "|");

                    line = listOfAccounts[i].getPin();
                    sw.Write(line + "|");

                    line = listOfAccounts[i].getAttempteRemaining().ToString();
                    sw.WriteLine(line);

                }// comma and true after file path allows for multiple entires of text.

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }



        }
       



        //public static void PinChange()
        //{
        //    Account getPinChange = new Account();
        //    List<Account> forPinChange = new List<Account>();
        //    forPinChange = AccountShow();
        //    for (int i = 0; i < forPinChange.Count; i++)
        //    {
        //        if (i == Account.intPinIndex)
        //        {

        //            //getPinChange.gettxtPInINRepeatPin() == (getPinChange.gettxtRepeatPIN())
        //            getPinChange.setPin(Account.intPinIndex);

        //        }
        //        else
        //            MessageBox.Show("Not Successfull");

        //    }
        //}
    }
}
