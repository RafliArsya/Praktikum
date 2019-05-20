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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbUname.Text) && !String.IsNullOrWhiteSpace(tbName.Text) && !String.IsNullOrWhiteSpace(tbPassword.Text) && !String.IsNullOrWhiteSpace(tbBalance.Text))
            {
                double strbalance = Convert.ToDouble(tbBalance.Text);
                bool taken = false, valid = false;
                if (tbUname.Text.Length < 6)
                {
                    MessageBox.Show("Username atleast has 6 Characters");
                    tbUname.Focus();
                }else if(tbName.Text.Length < 5)
                {
                    MessageBox.Show("Username atleast has 5 Characters");
                    tbName.Focus();
                }
                else if (tbPassword.Text.Length < 6)
                {
                    MessageBox.Show("Username atleast has 4 Characters");
                    tbPassword.Focus();
                }
                else
                {
                    valid = true;
                }
                for (int i = 0; i < bankmgr.UserList.Count; i++)
                {
                    if (tbUname.Text == bankmgr.UserList[i]._username() || tbName.Text == bankmgr.UserList[i]._name())
                    {
                        taken = true;
                        MessageBox.Show("Username or Nickname has been taken!", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                if (!taken && valid)
                {
                    bankmgr account = new bankmgr(tbUname.Text, tbName.Text, tbPassword.Text, strbalance);
                    bankmgr.AddUserToList(account);
                    MessageBox.Show("Hello "+account._name() + ", your registration is successful!", "Account Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill the data!", "Account Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
