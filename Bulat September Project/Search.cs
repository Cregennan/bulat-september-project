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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        public int flightID;
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            flightID = (int)numericUpDown1.Value;
            SearchResult sr = new SearchResult();
            sr.ShowDialog(this);
        }
    }
}
