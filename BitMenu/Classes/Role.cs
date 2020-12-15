using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMenu
{
    public class Role
    {
        //private fields
        private int id;
        private string roleName;

        //Properties
        public int getId { get { return id; } }
        public string getRoleName { get { return roleName; } }

        //constructors
        public Role(int Id, string RoleName) 
        {
            this.id = Id;
            this.roleName = RoleName;
        }
    }
}
