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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBalanceEnquiry_Click(object sender, EventArgs e)
        {
            frmBalanceEnquiry frBalEnq = new frmBalanceEnquiry();
            frBalEnq.Visible = true;
            this.Hide();
        }

        private void btnWithdrowal_Click(object sender, EventArgs e)
        {
            frmWithdrowal withdr = new frmWithdrowal();
            withdr.Visible = true;
            this.Hide();
        }

        private void btnExitMainMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLodgement_Click(object sender, EventArgs e)
        {
            frmLodgement lgmnt = new frmLodgement();
            lgmnt.Visible = true;
            this.Hide();
        }

        private void btnChangePIN_Click(object sender, EventArgs e)
        {
            frmChangePIN chang = new frmChangePIN();
            chang.Visible = true;

            this.Hide();
        }
    }
}
