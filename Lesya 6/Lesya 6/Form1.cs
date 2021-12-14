using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesya_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Bus bus = new Bus(get_random_amount_places(), get_random_bus_number());
            Stop stop = new Stop(create_passengers(get_random_amount_passengers()));
            bus_full.Checked = bus.get_Bus_is_full();
            BusNumberTextBox.Text = bus.get_bus_number().ToString();
            FreePlacesrichTextBox.Text = bus.get_amount_places().ToString();
            amount_passengersTextBox.Text = stop.get_amount_passengers().ToString();
        }

        private void passengers_set_Click(object sender, EventArgs e)
        {
            label1.Text = "Пассажиров не вместилось: ";
            Bus bus = new Bus(Int32.Parse(FreePlacesrichTextBox.Text), Int32.Parse(BusNumberTextBox.Text));
            Stop stop = new Stop(create_passengers(Int32.Parse(amount_passengersTextBox.Text)));

            stop.Bus_stop(bus);

            amount_passengersTextBox.Text = stop.get_amount_passengers().ToString();
            label1.Text += stop.get_amount_extra_passengers(bus.get_amount_places(), stop.find_passengers_for_bus(bus.get_bus_number()).Count).ToString();
            FreePlacesrichTextBox.Text = bus.get_amount_places().ToString();
            bus_full.Checked = bus.get_Bus_is_full();
        }

        private List<Passenger> create_passengers(int amount_passengers)
        {
            Random rnd = new Random();
            List<Passenger> newPassengers = new List<Passenger>();
            for (int i = 0; i < amount_passengers; i++)
            {
                newPassengers.Add(new Passenger(rnd.Next(1, 1)));
            }
            return newPassengers;
        }

        private int get_random_amount_places()
        {
            Random rnd = new Random();
            return rnd.Next(0, 10);
        }

        private int get_random_amount_passengers()
        {
            Random rnd = new Random();
            return rnd.Next(0, 12);
        }

        private int get_random_bus_number()
        {
            Random rnd = new Random();

            return rnd.Next(1, 1);
        }

    }

}
