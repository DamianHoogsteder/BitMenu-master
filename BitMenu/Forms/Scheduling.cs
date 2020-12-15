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
    public partial class Scheduling : Form
    {
        public Scheduling()
        {
            InitializeComponent();
        }

        private void Scheduling_Load(object sender, EventArgs e)
        {
            comBox_Users.Items.Add("Test");
        }
    }
}
