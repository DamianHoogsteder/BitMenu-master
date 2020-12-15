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
    public partial class RoosterForm : Form
    {
        public RoosterForm()
        {
            InitializeComponent();
        }

        private void RoosterForm_Load(object sender, EventArgs e)
        {
            List<Rooster> roosterlst = new List<Rooster>();

            roosterlst.Add(new Rooster(11, "Nov"));
            roosterlst.Add(new Rooster(12, "Nov"));
            roosterlst.Add(new Rooster(13, "Nov"));
            roosterlst.Add(new Rooster(14, "Nov"));
            roosterlst.Add(new Rooster(15, "Nov"));
            roosterlst.Add(new Rooster(16, "Nov"));
            roosterlst.Add(new Rooster(17, "Nov"));
            roosterlst.Add(new Rooster(18, "Nov"));

            foreach (Rooster rooster in roosterlst)
            {
                ListViewItem itemMonth = new ListViewItem(rooster.getCurrentMonth);
                ListViewItem itemDay = new ListViewItem(rooster.getCurrentDay.ToString());


                itemDay.SubItems.Add(rooster.getCurrentDay.ToString());
                lv_Rooster.Items.Add(itemDay);

                itemMonth.SubItems.Add(rooster.getCurrentMonth);
                lv_Rooster.Items.Add(itemMonth);

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lv_Rooster.Clear();

        }
    }
}
