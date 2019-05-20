using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankOM
{
    public partial class Option : Form
    {
        public int index_;
        bool logout=false;

        public Option(int a)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            load(a);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public void load(int a)
        {
            index_ = a;
            tbName.Text = bankmgr.UserList[a]._name();
            string strbalance = Convert.ToString(bankmgr.UserList[a]._balance());
            tbBalance.Text = strbalance;
        }
        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            Deposit_Form form = new Deposit_Form(index_, 0);
            form.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            form.Text = "Deposit";

            this.Visible = false;
            form.ShowDialog();
        }
        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            Deposit_Form form = new Deposit_Form(index_, 1);
            form.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            form.Text = "Withdraw";

            this.Visible = false;
            form.ShowDialog();
        }
        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            Deposit_Form form = new Deposit_Form(index_, 2);
            form.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            form.Text = "Transfer";

            this.Visible = false;
            form.ShowDialog();
        }
        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            load(index_);
            this.Visible = true;
        }
        
        private void Option_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logout)
            {
                Application.Exit();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }
    }
}
