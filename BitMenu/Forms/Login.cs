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
    public partial class form_Login : Form
    { 
        public form_Login()
        {
            InitializeComponent();
        }

        //private fields
        private static Role roleChef = new Role(1, "Chef");
        private static Role roleManager = new Role(2, "Manager");
        private static Role roleTest = new Role(3, "Test");
        private static List<User> users = new List<User>();

        //Properties 
        public static Role getRoleManager { get { return roleManager; } }
        public static Role getRoleChef { get { return roleManager; } }
        public static Role getRoleTest { get { return roleManager; } }
        public static List<User> getUsers { get { return users; } }

        private void btn_LogIN_Click(object sender, EventArgs e)
        {
            //Add object to our user list
            users.Add(new User(roleTest, "TestNaam", "Zephtos", "aap"));
            users.Add(new User(roleChef, "Naam", "Test", "Test"));
            users.Add(new User(roleManager,"Damian", "Admin", "Admin"));

            //Loop through the users 
            foreach (User user in users) 
            { 
                //If the userLogin method is true open the dashboard
                if (user.UserLogin(txtb_usernameInput.Text, txtb_passwordInput.Text) == true)
                    {
                        //Hide the current page
                        this.Hide();

                        //create a new Dashboard and give the user to the constructor (Will be set as the currentUser)
                        Dashboard dash = new Dashboard(user, user.getRole);
                        dash.ShowDialog();
                        this.Close();
                }
            }
            MessageBox.Show("Login failed, please try again.");
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
                users.Add(new User(f2.getNewUserName, f2.getNewPassword));
            }
            this.Show();
        }

        private void form_Login_Load(object sender, EventArgs e)
        {
            //load the form
        }
    }
}
