using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulat_September_Project
{
    public partial class CreateFlight : Form
    {
        public CreateFlight()
        {
            InitializeComponent();
        }

        public Flight flight { get; set; }
        private void CreateFlight_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateFlight_FormClosing(object sender, FormClosingEventArgs e)
        {

            String ArrivalPlace = textBox1.Text;
            int FlightID = (int)numericUpDown1.Value;
            String AircraftType = comboBox1.Text;
            flight = new Flight(ArrivalPlace, FlightID, AircraftType);

        }
    }
}
