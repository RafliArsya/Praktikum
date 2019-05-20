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
    public partial class Deposit_Form : Form
    {
        public int accnum, formtype, accreceiver;
        public Deposit_Form(int a, int b)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            tbName.Text = bankmgr.UserList[a]._name();
            string strbalance = Convert.ToString(bankmgr.UserList[a]._balance());
            tbBalance.Text = strbalance;
            accnum = a;
            formtype = b;
            textBox1.Visible = false;
            label1.Visible = false;
            textBox1.Text = String.Empty;
            if (formtype == 2)
            {
                textBox1.Visible = true;
                label1.Visible = true;
            }
            if (formtype == 1 || formtype == 2)
            {
                btn10000.Text = "50000";
                btn25000.Text = "100000";
                btn50000.Text = "200000";
                btn100000.Text = "500000";
                btn500000.Text = "1000000";
                btn1000000.Text = strbalance;
                btn10000.Enabled = false;
                btn25000.Enabled = false;
                btn50000.Enabled = false;
                btn100000.Enabled = false;
                btn500000.Enabled = false;
                btn1000000.Enabled = false;
                btn1000000.Visible = true;
                bool btnall = bankmgr.UserList[a]._balance() != 50000 && bankmgr.UserList[a]._balance() != 100000 && bankmgr.UserList[a]._balance() != 200000 && bankmgr.UserList[a]._balance() != 500000 && bankmgr.UserList[a]._balance() != 1000000;
                if (!btnall)
                {
                    btn1000000.Visible = false;
                }
                if (bankmgr.UserList[a]._balance() >= 50000)
                {
                    btn10000.Enabled = true;
                }
                if (bankmgr.UserList[a]._balance() >= 100000)
                {
                    btn25000.Enabled = true;
                }
                if (bankmgr.UserList[a]._balance() >= 200000)
                {
                    btn50000.Enabled = true;
                }
                if (bankmgr.UserList[a]._balance() >= 500000)
                {
                    btn100000.Enabled = true;
                }
                if (bankmgr.UserList[a]._balance() >= 1000000)
                {
                    btn500000.Enabled = true;
                }
                if (bankmgr.UserList[a]._balance() > 0 && btnall)
                {
                    btn1000000.Enabled = true;
                }
            }
        }

        public bool finduser()
        {
            for (int i = 0; i < bankmgr.UserList.Count; i++)
            {
                if (bankmgr.UserList[i]._name() == textBox1.Text && bankmgr.UserList[i]._name() != bankmgr.UserList[accnum]._name())
                {
                    accreceiver = i;
                    return true;
                }

            }
            accreceiver = accnum;
            return false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //bankmgr.UserList[accnum]._deposit(10000);
            if (formtype == 0)
            {
                bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].deposit(10000));
            }else if(formtype == 1)
            {
                bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].withdraw(50000));
            }
            else
            {
                double val = Convert.ToDouble(btn10000.Text);
                if (finduser())
                {
                    bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].withdraw(val));
                    bankmgr.UserList[accreceiver].balance_(bankmgr.UserList[accreceiver].deposit(val));
                    MessageBox.Show("Transaction Success!\nAmount "+val+" has been transfered to " + bankmgr.UserList[accreceiver]._name() + ".", "Money Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found!", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            
            this.Close();
        }
        private void Btn25000_Click(object sender, EventArgs e)
        {
            if(formtype == 0)
            {
                bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].deposit(25000));
            }
            else if (formtype == 1)
            {
                bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].withdraw(100000));
            }
            else
            {
                double val = Convert.ToDouble(btn25000.Text);
                if (finduser())
                {
                    bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].withdraw(val));
                    bankmgr.UserList[accreceiver].balance_(bankmgr.UserList[accreceiver].deposit(val));
                    MessageBox.Show("Transaction Success!\nAmount " + val + " has been transfered to" + bankmgr.UserList[accreceiver]._name() + ".", "Money Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found!", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            this.Close();
        }
        private void Btn50000_Click(object sender, EventArgs e)
        {
            if (formtype == 0)
            {
                bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].deposit(50000));
            }
            else if (formtype == 1)
            {
                bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].withdraw(200000));
            }
            else
            {
                double val = Convert.ToDouble(btn50000.Text);
                if (finduser())
                {
                    bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].withdraw(val));
                    bankmgr.UserList[accreceiver].balance_(bankmgr.UserList[accreceiver].deposit(val));
                    MessageBox.Show("Transaction Success!\nAmount " + val + " has been transfered to" + bankmgr.UserList[accreceiver]._name() + ".", "Money Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found!", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            this.Close();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (formtype == 0)
            {
                bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].deposit(100000));
            }
            else if (formtype == 1)
            {
                bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].withdraw(500000));
            }
            else
            {
                double val = Convert.ToDouble(btn100000.Text);
                if (finduser())
                {
                    bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].withdraw(val));
                    bankmgr.UserList[accreceiver].balance_(bankmgr.UserList[accreceiver].deposit(val));
                    MessageBox.Show("Transaction Success!\nAmount " + val + " has been transfered to" + bankmgr.UserList[accreceiver]._name() + ".", "Money Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found!", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            this.Close();
        }
        private void Btn500000_Click(object sender, EventArgs e)
        {
            if (formtype == 0)
            {
                bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].deposit(500000));
            }
            else if (formtype == 1)
            {
                bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].withdraw(1000000));
            }
            else
            {
                double val = Convert.ToDouble(btn500000.Text);
                if (finduser())
                {
                    bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].withdraw(val));
                    bankmgr.UserList[accreceiver].balance_(bankmgr.UserList[accreceiver].deposit(val));
                    MessageBox.Show("Transaction Success!\nAmount " + val + " has been transfered to" + bankmgr.UserList[accreceiver]._name() + ".", "Money Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found!", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            this.Close();
        }

        private void Btn1000000_Click(object sender, EventArgs e)
        {
            if (formtype == 0)
            {
                bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].deposit(1000000));
            }
            else if (formtype == 1)
            {
                bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].withdraw(bankmgr.UserList[accnum]._balance()));
            }
            else
            {
                double val = Convert.ToDouble(btn1000000.Text);
                if (finduser())
                {
                    bankmgr.UserList[accreceiver].balance_(bankmgr.UserList[accreceiver].deposit(bankmgr.UserList[accnum]._balance()));
                    bankmgr.UserList[accnum].balance_(bankmgr.UserList[accnum].withdraw(bankmgr.UserList[accnum]._balance()));
                    MessageBox.Show("Transaction Success!\nAmount " + val + " has been transfered to" + bankmgr.UserList[accreceiver]._name() + ".", "Money Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found!", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            this.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {   
            this.Close();
        }
    }
}
