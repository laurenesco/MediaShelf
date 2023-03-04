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
    public partial class Manual_Entry_Form : Form
    {
        // Instance variables:
        // caller   - form which invoked this form
        // list     - list intended to be added to
        private ListView caller = null!;
        private String list = null!;

        //////////////////////
        //  Public methods  //
        //////////////////////

        // Constructor
        public Manual_Entry_Form()
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
        public void setCaller(ListView caller)
        {
            this.caller = caller;
        }

        // Set list method - this variable allows the form to display the correct list
        public void setList(String listName)
        {
            this.list = listName;
        }

        ///////////////////////
        //  Private methods  //
        ///////////////////////

        // Back button functionality - reopens calling form
        private void btnNavBack_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Manual_Entry_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
