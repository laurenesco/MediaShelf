using Microsoft.Data.SqlClient;
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

            // Initiate Database Connection
            try
            {
                SqlConnection dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db1;Persist Security Info=True;User ID=;Password=");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void Detailed_Recommendations_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
