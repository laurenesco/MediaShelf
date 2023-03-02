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
    public partial class Detailed_Recommendations : Form
    {
        public DiscoveryPageForm caller = null!;
        public Detailed_Recommendations()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }
    }
}
