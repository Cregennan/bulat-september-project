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
    public partial class Main : Form
    {
        public FlightManager Manager = new FlightManager();
        
        public Main()
        {
            InitializeComponent();
        }
        private void UpdateFlightData()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            foreach (Flight f in Manager.FlightSchedule)
            {
                textBox1.AppendText(f.ArrivalPoint + Environment.NewLine);
                textBox2.AppendText(f.FlightID + Environment.NewLine);
                textBox3.AppendText(f.AircraftType + Environment.NewLine);
            }
        }
        
        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
       
        private void СоздатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                CreateFlight createFlight = new CreateFlight();
                DialogResult d = createFlight.ShowDialog(this);

                if (d == DialogResult.OK)
                {
                    Flight f = createFlight.flight;
                    if (f.ArrivalPoint == "" || !( f.AircraftType == "Пассажирский" || f.AircraftType == "Грузовой" || f.AircraftType == "Военный"  ))
                    {
                        throw new Exception("Проверьте правильность заполнения данных");
                    }
                    Manager.AddFlight(f);

                }
                UpdateFlightData();
                createFlight.flight = null; 
            }

            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                создатьToolStripMenuItem.PerformClick();
            }
            
        }

        public void Main_Load(object sender, EventArgs e)
        {

        }

        private void НайтиРейсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.ShowDialog(this);
            
        }

        private void УдалитьРейсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove r = new Remove();
            r.ShowDialog(this);
            UpdateFlightData();
        }

        private void ИзменитьРейсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.ShowDialog(this);
            UpdateFlightData();
        }
    }
}
