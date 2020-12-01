using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMachineProject.ClassesBussiness
{
    public class Account
    {
        public String AccountNb;
        private double Balance;
        private bool Active;
        private String Account_Name;
        private String Pin;
        private int AttempteRemaining;
        //variable for changing pin
        //public static int intPinIndex;
        //this is just an example of how it can be done the other way
        //public String AccountNb { get { return accountNb; } set { this.accountNb = AccountNb; } }
        //public double Balance { get { return balance; } set { this.balance = Balance; } }
        //public bool Active { get { return active; } set { this.active = Active; } }
        //public String Account_Name{ get { return account_Name; } set { this.account_Name = AccountNb; } }

        //public int PIN { get { return pin; } set { this.PIN = pin; } }

        //setters done like in Java

        //btnEnter_Click()
        //{
        //  }
        

        public void setAttempteRemaining(int attempt)
        {
            this.AttempteRemaining = attempt;
        }
        public void setAccountNb(String AcNb)
        {
            this.AccountNb = AcNb;
        }
        public void setBalance(double Bal)
        {
            this.Balance = Bal;
        }
        public void setActive(bool Act)
        {
            this.Active = Act;
        }
        public void setAccount_Name(String AccName)
        {
            this.Account_Name = AccName;
        }
        public void setPin(string pin)
        {
            this.Pin = pin;
        }

        public static string bal;

        //getters done like in Java
        public int getAttempteRemaining()
        {
            return AttempteRemaining;
        }
        public string getPin()
        {
            return Pin;
        }

        public String getAccountNb()
        {
            return AccountNb;
        }
        public double getBalance()
        {
            return Balance;
        }
        public bool getActive()
        {
            return Active;
        }
        public String getAccount_Name()
        {
            return Account_Name;
        }

       
        //setters and getters for textboxes in changePin form
        string txtPInINRepeatPin;
        string txtRepeatPIN;

        public void settxtPInINRepeatPin(string txtPInINRepeatPin)
        {
            this.txtPInINRepeatPin = txtPInINRepeatPin;
        }
        public void settxtRepeatPIN(string txtRepeatPIN)
        {
            this.txtRepeatPIN = txtRepeatPIN;
        }
        public string gettxtPInINRepeatPin()
        {
            return txtPInINRepeatPin;
        }
        public string gettxtRepeatPIN()
        {
            return txtRepeatPIN;
        }

         //methods
        public bool makewithdrawal(double AmmountTowithdraw)
        {
            if (Balance < AmmountTowithdraw)
                return false;
            else
            {
                Balance = Balance - AmmountTowithdraw;
                return true;
            }

        }

        public void makeLogdement(double AmmountToLodge)
        {
            Balance = Balance + AmmountToLodge;

        }
        
    }
}
