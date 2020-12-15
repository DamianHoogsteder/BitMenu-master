using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMenu
{
    public class Rooster
    {
        //private fields
        private DateTime timeslot;
        private int currentDay;
        private string currentMonth;
        private int roosterID;

        //properties
        public DateTime getTimeSlot { get { return timeslot; } set { timeslot = value; } }
        public int getCurrentDay { get { return currentDay; } }
        public string getCurrentMonth { get { return currentMonth; } }

        //constructors
        public Rooster(int CurrentDay, string CurrentMonth) 
        {
            this.currentDay = CurrentDay;
            this.currentMonth = CurrentMonth;
        }

        //methods

    }
}
