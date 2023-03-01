using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaShelfApp
{
    public partial class DiscoveryPageForm : Form
    {
        public DiscoveryPageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //button6 = search button. NOTE: click search button (NOT See More button) to get to more recommendations
        private void button6_Click(object sender, EventArgs e)
        {
            //creates an instance of detailed recommendations form and displays it to user
            //NOTE: this instance is NOT stored in a variable; purpose is to test functionality of back button in Detailed Recommendations form
            new Detailed_Recommendations(this).Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
