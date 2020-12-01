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
    public partial class frmChangePIN : Form
    {
        bool blnHasFocus = false;

        
        

        public frmChangePIN()
        {
            InitializeComponent();
        }

        private void txtPInINRepeatPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClearINChangePin_Click(object sender, EventArgs e)
        {
            txtPInINRepeatPin.Text = "";
            txtRepeatPIN.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!blnHasFocus)
                txtPInINRepeatPin.Text = txtPInINRepeatPin.Text + "1";
            else
                txtRepeatPIN.Text = txtRepeatPIN.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!blnHasFocus)
                txtPInINRepeatPin.Text = txtPInINRepeatPin.Text + "2";
            else
                txtRepeatPIN.Text = txtRepeatPIN.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!blnHasFocus)
                txtPInINRepeatPin.Text = txtPInINRepeatPin.Text + "3";
            else
                txtRepeatPIN.Text = txtRepeatPIN.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!blnHasFocus)
                txtPInINRepeatPin.Text = txtPInINRepeatPin.Text + "4";
            else
                txtRepeatPIN.Text = txtRepeatPIN.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!blnHasFocus)
                txtPInINRepeatPin.Text = txtPInINRepeatPin.Text + "5";
            else
                txtRepeatPIN.Text = txtRepeatPIN.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!blnHasFocus)
                txtPInINRepeatPin.Text = txtPInINRepeatPin.Text + "6";
            else
                txtRepeatPIN.Text = txtRepeatPIN.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!blnHasFocus)
                txtPInINRepeatPin.Text = txtPInINRepeatPin.Text + "7";
            else
                txtRepeatPIN.Text = txtRepeatPIN.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!blnHasFocus)
                txtPInINRepeatPin.Text = txtPInINRepeatPin.Text + "8";
            else
                txtRepeatPIN.Text = txtRepeatPIN.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!blnHasFocus)
                txtPInINRepeatPin.Text = txtPInINRepeatPin.Text + "9";
            else
                txtRepeatPIN.Text = txtRepeatPIN.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (!blnHasFocus)
                txtPInINRepeatPin.Text = txtPInINRepeatPin.Text + "0";
            else
                txtRepeatPIN.Text = txtRepeatPIN.Text + "0";
        }

        private void txtPInINRepeatPin_Enter(object sender, EventArgs e)
        {
            blnHasFocus = false;
        }

        private void txtRepeatPIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRepeatPIN_Enter(object sender, EventArgs e)
        {
            blnHasFocus = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (blnHasFocus == false)
            {
                if (txtPInINRepeatPin.Text.Length >= 1)
                    txtPInINRepeatPin.Text = txtPInINRepeatPin.Text.Remove(txtPInINRepeatPin.Text.Length - 1, 1);
            }
            else
            {
                if (txtRepeatPIN.Text.Length >= 1)
                    txtRepeatPIN.Text = txtRepeatPIN.Text.Remove(txtRepeatPIN.Text.Length - 1, 1);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (Bank.customerAccount.getPin() == txtOldPIN.Text)
            {

                if (txtPInINRepeatPin.Text.Length != 4 || txtRepeatPIN.Text.Length != 4)
                    MessageBox.Show("New PIN must be 4 digits");
                else if (txtPInINRepeatPin.Text != txtRepeatPIN.Text)
                    MessageBox.Show("New PIN and Confirm PIN must be the same");

                else if (! int.TryParse(txtPInINRepeatPin.Text,out result) && int.TryParse(txtRepeatPIN.Text,out result))
                    MessageBox.Show("PIN must be numeric");

                else
                {
                    Bank.customerAccount.setPin(txtPInINRepeatPin.Text);
                    Bank.SaveChangesToFile(@"C:\\Users\\SwDev06\\Desktop\\C#test.txt");
                    MessageBox.Show("PIN change sucessfully");
                  
                }
            }
            else
            {
                MessageBox.Show("Must enter original PIN");
                txtOldPIN.Clear();

            }


           
            frmMainMenu frmMain = new frmMainMenu();
            frmMain.Visible = true;
            this.Hide();
        }

        private void txtPInINRepeatPin_Click(object sender, EventArgs e)
        {

        }

        private void txtOldPIN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
