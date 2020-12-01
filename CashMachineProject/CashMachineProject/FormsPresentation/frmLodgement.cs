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
    public partial class frmLodgement : Form
    {
        public frmLodgement()
        {
            InitializeComponent();
        }

        private void txtLodgementAmount_TextChanged(object sender, EventArgs e)
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

        private void btnClearLodgement_Click(object sender, EventArgs e)
        {

        }

        private void btnLodgeINLodgement_Click(object sender, EventArgs e)
        {
            double result = 0;
            if (!double.TryParse(txtLodgementAmount.Text, out result))
            {//after protecting the entry field i need to change the line below with the result so it 
                //doesn't crash
                MessageBox.Show("You need to enter amount");
            }
            //Bank.customerAccount.makeLogdement(double.Parse(txtLodgementAmount.Text));
            Bank.customerAccount.makeLogdement(result);

            //WriteAccountsToFile
            Bank.SaveChangesToFile(@"C:\\Users\\SwDev06\\Desktop\\C#test.txt");
            txtNewBalance.Text = Bank.customerAccount.getBalance().ToString();
            txtLodgementAmount.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
