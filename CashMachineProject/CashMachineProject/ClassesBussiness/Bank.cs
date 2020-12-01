using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CashMachineProject.ClassesBussiness
{
    public class Bank
    {
        FormsPresentation.frmLogin frml = new FormsPresentation.frmLogin();
        public static List<Account> listOfAccounts = new List<Account>();
        public static Account customerAccount; // changes from Costa's project 
        public static bool AccountFound;
        public static int AccountIndexList;

        //setters and getters from Costa's Project
        public Account CustomerAccount
        {
            get
            {
                return customerAccount;
            }

            set
            {
                customerAccount = value;
            }
        }

        public bool AccountFound1
        {
            get
            {
                return AccountFound;
            }

            set
            {
                AccountFound = value;
            }
        }

        public int accountIndexList
        {
            get
            {
                return AccountIndexList;
            }

            set
            {
                AccountIndexList = value;
            }
        }

        public List<Account> ListOfAccounts
        {
            get
            {
                return listOfAccounts;
            }

            set
            {
                listOfAccounts = value;
            }
        }


        //+Bank()
        //+ Bank(string filepath)
        //+ bool SearchForAccount(string AccountNb)
        //+ CheckPin(strin PIN)
        //+LoadAccounts(string filepath)
        //+SaveChangesToFile()

        public static void LoadAccounts(string filepath)
        {
            listOfAccounts = FileOperations.ReadingAccounts("C:\\Users\\Andrzej\\Desktop\\C#test.txt");
        }

        public static  bool SearchForAccount(string AccountNb)
        {
            bool Found = false;
            for (int i = 0; i < listOfAccounts.Count; i++)
            {
                if (AccountNb == listOfAccounts[i].getAccountNb()) //don't need my validation because only the 
                    //valid Account will allow the code to go further
                {
                    customerAccount = listOfAccounts[i];
                    AccountIndexList = i; //the position of account list
                    Found = true;
                    i = listOfAccounts.Count; //stoping searching
                }
            }
            return Found;
        }
        public static void SaveChangesToFile(string filePath)
        {

            FileOperations.WriteAccountsToFile(filePath, listOfAccounts);


        }

       
    }
}
