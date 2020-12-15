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
    public partial class Dashboard : Form
    {
        //private variable that is used as an object of User
        private User currentUser;
        private Role currentRole;

        //Initialisation Constructor that recieves the user data from the login
        public Dashboard(User currentUser, Role role)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            if (currentUser.getRole == form_Login.getRoleManager)
            {
                pnl_Dashboard.Controls.Clear();
                ManagerForm mf = new ManagerForm(currentUser);
                mf.TopLevel = false;
                pnl_Dashboard.Controls.Add(mf);
                mf.Show();
            }
            else 
            {
            }
        }

        //initialize the dash board
        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        //Go back to login
        private void MenuBtn_Uitloggen_Click(object sender, EventArgs e)
        {
            this.Hide();

            DialogResult dr = DialogResult.OK;
            form_Login formLogin = new form_Login();
            dr = formLogin.ShowDialog();
        }

        //Open Rooster panel
        private void MenuBtn_Rooster_Click(object sender, EventArgs e)
        {
            pnl_Dashboard.Controls.Clear();
            RoosterForm rooster = new RoosterForm();
            rooster.TopLevel = false;
            pnl_Dashboard.Controls.Add(rooster);
            rooster.Show();
        }

        //Open YourBitmenu panel
        private void MenuBtn_UBitmenu_Click(object sender, EventArgs e)
        {
            pnl_Dashboard.Controls.Clear();
            UBitmenu homescherm = new UBitmenu(currentUser);
            homescherm.TopLevel = false;
            pnl_Dashboard.Controls.Add(homescherm);
            homescherm.Show();
        }

        private void pb_headerLogo_Click(object sender, EventArgs e)
        {
            if (currentUser.getRole == form_Login.getRoleManager)
            {
                pnl_Dashboard.Controls.Clear();
                ManagerForm mf = new ManagerForm(currentUser);
                mf.TopLevel = false;
                pnl_Dashboard.Controls.Add(mf);
                mf.Show();
            }
            else
            {
            }
        }
    }
}
