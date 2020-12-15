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
    public partial class UBitmenu : Form
    {

        private User currentUser;
        public UBitmenu(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void UBitmenu_Load(object sender, EventArgs e)
        {
            //Shows the username of the current user in the dashboard
            lbl_DashboardName.Text = currentUser.getUserName;

            //Makes the  picture box for the user profile pic a circle
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pb_UserPF.Width - 3, pb_UserPF.Height - 3);
            Region rg = new Region(gp);
            pb_UserPF.Region = rg;

            lbl_currentDay.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_Dashboard_forward_Click(object sender, EventArgs e)
        {
            if (lbl_currentDay.Text == DateTime.Now.ToShortDateString())
            {
                lbl_currentDay.Text = DateTime.Now.AddDays(1).ToShortDateString();
            }
            else if (lbl_currentDay.Text != DateTime.Now.ToShortDateString())
            {
                lbl_currentDay.Text = DateTime.Now.AddDays(-1).ToShortDateString();
            }
        }

        private void btn_Dashboard_back_Click(object sender, EventArgs e)
        {
            if (lbl_currentDay.Text == DateTime.Now.ToShortDateString())
            {
                lbl_currentDay.Text = DateTime.Now.AddDays(-1).ToShortDateString();
            }
            else if (lbl_currentDay.Text != DateTime.Now.ToShortDateString())
            {
            }

        }
    }
}
