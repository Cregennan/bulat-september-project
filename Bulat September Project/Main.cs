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
        FlightManager Manager = new FlightManager();
        
        public Main()
        {
            InitializeComponent();
        }

        
        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
       
        private void СоздатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CreateFlight createFlight = new CreateFlight();

                if (createFlight.ShowDialog(this) == DialogResult.OK)
                {
                    Flight f = createFlight.flight;
                    Manager.AddFlight(f);
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
