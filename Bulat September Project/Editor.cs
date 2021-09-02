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
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = (int)((EditForm)Owner).numericUpDown1.Value;
            Flight f = ((Main)((EditForm)Owner).Owner).Manager.GetFlight(a);
            if (f == null)
            {
                throw new Exception("Рейс с данным номером не найден");
            }
            ((Main)((EditForm)Owner).Owner).Manager.EditFlight(f.FlightID, new Flight(textBox1.Text, Int32.Parse(textBox2.Text), comboBox1.Text));
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            try
            {
                int a = (int)((EditForm)Owner).numericUpDown1.Value;
                Flight f = ((Main)((EditForm)Owner).Owner).Manager.GetFlight(a);
                if (f == null)
                {
                    throw new Exception("Рейс с данным номером не найден");
                }
                textBox1.Text = f.ArrivalPoint;
                textBox2.Text = f.FlightID.ToString();
                int i = 0;
                switch(f.AircraftType){
                    case "Пассажирский":
                        i = 0;
                        break;
                    case "Грузовой":
                        i = 0;
                        break;
                    case "Военный":
                        i = 0;
                        break;
                }
                comboBox1.SelectedIndex = i;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
