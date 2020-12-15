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

        private void lv_YourTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void btn_AccountPage__Click(object sender, EventArgs e)
        {
            form_Login loginForm = new form_Login();

            loginForm.createAccountSendData();
        }

        private void btn_SchedulingOpen_Click(object sender, EventArgs e)
        {
            pnl_AdminControl.BringToFront();
            pnl_AdminControl.Controls.Clear();
            Scheduling scheduling = new Scheduling();
            scheduling.TopLevel = false;
            pnl_AdminControl.Controls.Add(scheduling);
            scheduling.Show();
        }

        private void btn_YourTeam_Click_1(object sender, EventArgs e)
        {
            lv_YourTeam.Visible = true;

            foreach (User user in form_Login.getUsers)
            {
                ListViewItem itemDay = new ListViewItem(user.getUserName);

                itemDay.SubItems.Add(user.getUserName);
                lv_YourTeam.Items.Add(itemDay);
            }
        }
    }

}