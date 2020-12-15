using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMenu
{
    public class User
    {
        //Private fields
        private string name;
        private string userName;
        private string password;
        private string profilePicture;
        private Role role;

        //Properties
        public string getName { get { return name; } }
        public string getUserName { get { return userName; } }
        public Role getRole { get { return role; } private set { role = value; } }

        
        //Constructors

        //constructor that has 1 role
        public User(Role role, string Name, string UserName, string Password) 
        {
            this.name = Name;
            this.userName = UserName;
            this.password = Password;
            this.role = role;
        }

        //constructor for logging in
        public User(string UserName, string Password) 
        {
            this.name = "";
            this.userName = UserName;
            this.password = Password;
            this.role = null;
        }
    
        //Methods

        //Check whether the login is succesfull
        public bool UserLogin(string currentUsername, string currentPassword) 
        {
            if (currentUsername == userName && currentPassword == password)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        //Check the role of the user
        public void checkRole(int RoleId) 
        {
            if (RoleId == 2)
            {
                User u = new User("T", "T");
                Dashboard db = new Dashboard(u, this.getRole);
            }
        }
    }
}
