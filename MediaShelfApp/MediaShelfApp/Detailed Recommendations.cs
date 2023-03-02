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
        private DiscoveryPageForm caller = null!;

        //////////////////////
        //  Public methods  //
        //////////////////////

        // Constructor
        public Detailed_Recommendations()
        {
            InitializeComponent();
        }

        // Set caller method - this variable allows the back button to reopen the calling form
        public void setCaller(DiscoveryPageForm caller)
        {
            this.caller = caller;
        }

        ///////////////////////
        //  Private methods  //
        ///////////////////////
        private void btnBack_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }
    }
}
