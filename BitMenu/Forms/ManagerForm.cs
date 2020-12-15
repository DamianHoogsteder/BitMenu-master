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
    public partial class ManagerForm : Form
    {
        private User currentUser;
        public ManagerForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            lbl_AdminName.Text = currentUser.getName;
        }

        private void btn_AccountPage_open_Click(object sender, EventArgs e)
        {
            //Hide the current page
            this.Hide();

            DialogResult dr = new DialogResult();
            //Create a new object of the Account form
            Account f2 = new Account();
            dr = f2.ShowDialog();

            //Check if data has been filled in
            if (dr == DialogResult.OK)
            {
                //Add a new user object with the corrosponding data
               form_Login.getUsers.Add(new User(f2.getNewUserName, f2.getNewPassword));
            }
            this.Show();
        }
    }
}
