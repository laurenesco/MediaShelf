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
    public partial class MyShelfForm : Form
    {
        private DiscoveryPageForm caller = null!;

        //////////////////////
        //  Public methods  //
        //////////////////////
        
        // Constructor
        public MyShelfForm()
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

        // Back button functionality - reopens the calling form and closes this form
        private void btnBack_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }

        // Favorites list button functionality - hides this form and opens the list form with the list variable set to favorites
        private void lblNavFavList_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListView window = new ListView();
            window.setCaller(this);
            window.setList("Favorites");
            window.Show();
        }
    }
}
