using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesya_6
{
    public class Bus
    {   
        bool Bus_is_full;
        int Amount_places;
        int Bus_number;

        public Bus(int Amount_places, int Bus_number)
        {
            this.Amount_places = Amount_places;
            this.Bus_number = Bus_number;
            if (Amount_places == 0)
            {
                Bus_is_full = true;
            }
        }
        public void Passenger_boarding()
        {
            string msg;
            if (!Bus_is_full)
            {
                Amount_places -= 1;
            }
        }
        public int get_amount_places()
        {
            return Amount_places;
        }

        public int get_bus_number()
        {
            return Bus_number;
        }

        private int get_random_amount_places()
        {
            Random rnd = new Random();
            int plc = rnd.Next(0, 5);
            if (plc == 0)
            {
                Bus_is_full = true;
            }
            return plc;
        }
        private int get_random_bus_number()
        {
            Random rnd = new Random();

            return rnd.Next(0, 10);
        }

        public void update_bus_is_full()
        {
            if (Amount_places > 0)
            {
                Bus_is_full = false;
            }
            else
            {
                Bus_is_full = true;

            }
        }
        public void set_bus_amount_places(int Amount_places)
        {
            this.Amount_places = Amount_places;
        }
        public bool get_Bus_is_full()
        {
            return Bus_is_full;
        }
    }
}
