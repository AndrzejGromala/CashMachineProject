using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CashMachineProject.ClassesBussiness;

namespace CashMachineProject.FormsPresentation
{
    public partial class frmLogin : Form
    {
       // public int attempts = 2;
        public bool validPIN = false;
        bool blnHasFocus = false;
        //List<Account> listOfAllAccounts = new List<Account>(); //this had to be moved here because there was 
        //a problem with the list being loded each time the enter got pressed
        //this way it only loads ones when the application is loaded
        //Account acc;
        //internal static readonly object listOfAccounts;


        //LIST OF ACCOUNTS
        //List<ClassesBussiness.Account> listOfAccounts = new List<ClassesBussiness.Account>();
        //ClassesBussiness.Account acc1 = new ClassesBussiness.Account();
        //ClassesBussiness.Account acc2 = new ClassesBussiness.Account();
        //ClassesBussiness.Account acc3 = new ClassesBussiness.Account();
        //ClassesBussiness.Account acc4 = new ClassesBussiness.Account();

        //string[] testAccount = { "1111","2222","3333" };
        public frmLogin()
        {
            InitializeComponent();

            Bank.LoadAccounts("C:\\Users\\SwDev06\\Desktop\\C#test.txt");
            //listOfAllAccounts = FileOperations.ReadingAccounts();

            //txtPIN.ReadOnly = true;
            //setting the values
            //acc1


            //acc1.setAccountNb("11111111");
            //acc1.setBalance(3000);
            //acc1.setPin("1111");
            //acc1.setActive(true);
            //acc1.setAccount_Name("Current");
            //listOfAccounts.Add(acc1);

            ////acc2
            //acc2.setAccountNb("22222222");
            //acc2.setBalance(1000);
            //acc2.setPin("2222");
            //acc2.setActive(true);
            //acc2.setAccount_Name("Savings");
            //listOfAccounts.Add(acc2);

            ////acc3
            //acc3.setAccountNb("33333333");
            //acc3.setBalance(340);
            //acc3.setPin("3333");
            //acc3.setActive(true);
            //acc3.setAccount_Name("Current");
            //listOfAccounts.Add(acc3);

            ////acc4
            //acc4.setAccountNb("44444444");
            //acc4.setBalance(3456);
            //acc4.setPin("4444");
            //acc4.setActive(true);
            //acc4.setAccount_Name("Savings");
            //listOfAccounts.Add(acc4);

        }
            private void updateDisplay(String btnText) //updating the text fields, old style kept in changePinForm
        {
            if (blnHasFocus == false)
                txtAccountNumber.Text = txtAccountNumber.Text + btnText;

            else
                txtPIN.Text = txtPIN.Text + btnText;

        }


    
        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            //if (txtAccountNumber.TextLength == 8)
            //{


            //}
        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {
            //txtPIN.Focus();
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            updateDisplay("3");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //DEREK'S VERSION OF THE CODE WITH MY IMPROVEMENTS OF THE EMPTY FIELD       
            //List<ClassesBussiness.Account> my = new List<ClassesBussiness.Account>();
            int accountFound = 0;


            if (Bank.SearchForAccount(txtAccountNumber.Text)) {

                if (Bank.customerAccount.getAttempteRemaining() == 0)
                    MessageBox.Show("Blocked");
                else if (Bank.customerAccount.getPin() != txtPIN.Text && Bank.customerAccount.getAttempteRemaining() > 0) { 


                    Bank.customerAccount.setAttempteRemaining(Bank.customerAccount.getAttempteRemaining() - 1);
                    Bank.SaveChangesToFile(@"C:\\Users\\SwDev06\\Desktop\\C#test.txt");
                    MessageBox.Show("Wrong Pin. You have " + Bank.customerAccount.getAttempteRemaining() + " attempts left.");
                    //Bank.SaveChangesToFile("C:\\Users\\SwDev06\\Desktop\\C#test.txt");
               }
               else
                {
                    Bank.customerAccount.setAttempteRemaining(3);
                    Bank.SaveChangesToFile(@"C:\\Users\\SwDev06\\Desktop\\C#test.txt");
                    frmMainMenu frmMain = new frmMainMenu();
                    frmMain.Visible = true;
                    this.Visible = false;


                }
            }
            else
                MessageBox.Show("Invalid Account Number");







            /*



            while (accountFound == 0) //this part sorted out the shit with the account numb but still 
                //needs the validation of the length and the type of input
            {
                if (txtAccountNumber.Text.Length == 0)
                {
                    txtAccountNumber.ForeColor = Color.Red;
                    txtAccountNumber.Text = "Enter Account Number";
                    accountFound = 1;
                }
                else
                {
                    for (int i = 0; i < listOfAllAccounts.Count; i++)
                    {

                        if (listOfAllAccounts[i].getAccountNb() == txtAccountNumber.Text)
                        {
                            acc = listOfAllAccounts[i];
                            accountFound = 1;
                        }

                    }
                    if (acc != null && accountFound != 0)
                    {
                        //need to add account validation here
                        int PinLength = 0;
                        while (PinLength == 0)
                        {
                            if (txtPIN.Text.Length == 0)
                            {
                                txtPIN.ForeColor = Color.Red;
                                txtPIN.Text = "Enter PIN.";
                                
                                PinLength = 1; //this cancelled the loop and it started from the top if 
                                               //it was empty again
                                               //MessageBox.Show("Please enter PIN."); 
                            }
                            else
                            {
                                PinLength = 1; //it changed to one co so it can check the pin againg and if 
                                               //empty it will go to the upper lines again
                                if (PinLength != 0)
                                {

                                    if (acc.getPin() == txtPIN.Text)
                                    {

                                        Account.bal = acc.getBalance().ToString();
                                       
                                        frmMainMenu frmMain = new frmMainMenu();
                                        frmMain.Visible = true;
                                        this.Visible = false;
                                    }
                                    else
                                    {

                                        acc.setAttempteRemaining(acc.getAttempteRemaining() - 1);
                                        Bank.SaveChangesToFile(@"C:\\Users\\SwDev06\\Desktop\\C#test.txt");
                                        MessageBox.Show("Wrong Pin. You have " + acc.getAttempteRemaining() + " attempts left.");
                                        //Bank.SaveChangesToFile("C:\\Users\\SwDev06\\Desktop\\C#test.txt");
                                    }
                                }

                            }
                        }
                    }


                    if (acc.getAttempteRemaining() == 0)
                    {
                        MessageBox.Show("Your account is blocked. Contact your bank.");
                        Application.Exit();
                    }

                }
            }
            



            // MY CODE BELOW
            /* bool validPIN = false;
             List<ClassesBussiness.Account> my = new List<ClassesBussiness.Account>();
             my = ClassesBussiness.FileOperations.AccountShow();

             //List<ClassesBussiness.Account> my1 = new List<ClassesBussiness.Account>();

             if (txtAccountNumber.Text.Length == 0)
                 MessageBox.Show("Pleas enter Account Number");

             else
             {
                 if (attempts == -1)
                 {
                     MessageBox.Show("Account Blocked");
                     Application.Exit();
                 }
                 else
                 {
                     //Search for account and matching pin
                     for (int i = 0; i < my.Count; i++)
                     {
                         if (my[i].getAccountNb().Equals(txtAccountNumber.Text) &&
                                 my[i].getPin().Equals(txtPIN.Text))
                         {
                             //txtPIN.ReadOnly = false;
                             validPIN = true;
                             ClassesBussiness.Account.intPinIndex = i; 
                             ClassesBussiness.Account.bal = my[i].getBalance().ToString();
                             frmMainMenu frmMain = new frmMainMenu();
                             frmMain.Visible = true;
                             this.Visible = false;

                         }
                     }


                     if (txtPIN.Text.Length == 0)
                         MessageBox.Show("Pleas enter PIN");

                     else if (!validPIN)
                     {
                         MessageBox.Show("Invalid pin " + attempts + "left");
                         attempts--;
                     }
                 }
             } */ //END OF MY CODE

            
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            updateDisplay("1");
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            updateDisplay("2");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            updateDisplay("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            updateDisplay("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            updateDisplay("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            updateDisplay("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            updateDisplay("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            updateDisplay("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            updateDisplay("0");
        }

        private void txtAccountNumber_Leave(object sender, EventArgs e)
        {

        }

        private void txtAccountNumber_MouseClick(object sender, MouseEventArgs e)
        {
            txtAccountNumber.Focus();
        }

        private void txtAccountNumber_Enter(object sender, EventArgs e)
        {
            blnHasFocus = false;
        }

        private void txtPIN_Enter(object sender, EventArgs e)
        {
            blnHasFocus = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (blnHasFocus == false)
            {
                if (txtAccountNumber.Text.Length >= 1)
                    txtAccountNumber.Text = txtAccountNumber.Text.Remove(txtAccountNumber.Text.Length - 1, 1);
            }
            else
            {
                if (txtPIN.Text.Length >= 1)
                    txtPIN.Text = txtPIN.Text.Remove(txtPIN.Text.Length - 1, 1);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPIN.Text = "";
            txtAccountNumber.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPIN_Click(object sender, EventArgs e)
        {
            txtPIN.Text = "";
            txtPIN.ForeColor = Color.Green;
        }

        private void txtAccountNumber_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Text = "";
            txtAccountNumber.ForeColor = Color.Green;
        }
    }
}
