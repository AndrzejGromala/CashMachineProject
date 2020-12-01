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
    public partial class frmBalanceEnquiry : Form
    {
        public frmBalanceEnquiry()
        {
            InitializeComponent();
            //txtBalanceINBalanceEnquiry.Text = BankClassesBussiness.Account.bal;
            txtBalanceINBalanceEnquiry.Text = Bank.customerAccount.getBalance().ToString();


        }

        private void btnExinINBalanceEnquiry_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackINBalanceEnquiry_Click(object sender, EventArgs e)
        {
            frmMainMenu MM = new frmMainMenu();
            MM.Visible = true;
            this.Close();
        }

        private void txtBalanceINBalanceEnquiry_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmBalanceEnquiry_Load(object sender, EventArgs e)
        {

        }
    }
}
