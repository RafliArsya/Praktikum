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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Login";
            textboxPassword.PasswordChar = '*';
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string uname, pass;
            int logacc;
            bool found=false;
            uname = textboxUname.Text; pass=textboxPassword.Text;
            for (logacc = 0; logacc < bankmgr.UserList.Count; logacc++)
            {
                if (uname == bankmgr.UserList[logacc]._username() && pass == bankmgr.UserList[logacc]._pass())
                {
                    found = true;
                    Option form = new Option(logacc);
                    this.Visible = false;
                    //this.Close();
                    form.FormClosed += new FormClosedEventHandler(form2_FormClosed);
                    form.Text = "Choose a Service";
                    form.ShowDialog();
                    break;
                }
            }
            if (!bankmgr.UserList.Any())
            {
                MessageBox.Show("No Account have created!", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!found)
            {
                MessageBox.Show("User not found or Wrong Password!", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            this.Visible = false;
            form.ShowDialog();
        }

        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }
    }
}
