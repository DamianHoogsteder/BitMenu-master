using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitMenu
{
    public partial class Account : Form
    {
        //Properties used to create a Account for prototype sake
        public string getNewPassword { get { return txtb_CreatePassword.Text; } }
        public string getNewUserName { get { return txtb_CreateUsername.Text; } }

        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
        }

        private void btn_AccountCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
