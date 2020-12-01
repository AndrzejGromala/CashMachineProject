using CashMachineProject.ClassesBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMachineProject.FormsPresentation
{
    public partial class frmWithdrowal : Form
    {
        public frmWithdrowal()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btnExitINWithdrowal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackINWithdraw_Click(object sender, EventArgs e)
        {
            frmMainMenu MM = new frmMainMenu();
            MM.Visible = true;
            this.Hide();
        }

        private void btnClearINWithdrowal_Click(object sender, EventArgs e)
        {
            txtWidrawalAmount.Text = "";
        }

        private void btnWithdrawInWithdrawal_Click(object sender, EventArgs e)
        {
            double result = 0;
            if (!double.TryParse(txtWidrawalAmount.Text, out result))
            {
                MessageBox.Show("You need to enter amount");
                Bank.customerAccount.makewithdrawal(result);
            }
            else if (Bank.customerAccount.makewithdrawal(double.Parse(txtWidrawalAmount.Text)) == false)
            {
                MessageBox.Show("Insuffient Funds");
            }
            else
            {
                Bank.SaveChangesToFile(@"C:\\Users\\SwDev06\\Desktop\\C#test.txt");
                txtWidrawalAmount.Text = Bank.customerAccount.getBalance().ToString();
                txtNewBalWithdrow.Text = Bank.customerAccount.getBalance().ToString();

            }
            txtWidrawalAmount.Clear();
        }

        private void txtWidrawalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewBalWithdrow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
