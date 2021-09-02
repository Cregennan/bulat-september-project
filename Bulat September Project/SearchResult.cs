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
    public partial class SearchResult : Form
    {
        public SearchResult()
        {
            InitializeComponent();
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {
            
            try
            {
                int a = ((Search)Owner).flightID;
                Main m = new Main();
                Flight f = ((Main)((Search)Owner).Owner).Manager.GetFlight(a);
                textBox1.Text = f.ArrivalPoint;
                textBox2.Text = f.FlightID.ToString();
                textBox3.Text = f.AircraftType;

            } catch(Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           



        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
