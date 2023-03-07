using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MediaShelfApp
{
    public partial class ListView : Form
    {
        // Instance variables:
        // caller   - form which invoked this form
        // list     - list intended to be viewed
        private MyShelfForm caller;
        public String list = "";
        private SqlConnection dbConnection;

        //////////////////////
        //  Public methods  //
        //////////////////////
        
        // Constructor
        public ListView(String list, MyShelfForm caller)
        {
            InitializeComponent();
            this.list = list;
            this.caller = caller;            

            // Initiate Database Connection String
            dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db2;Persist Security Info=True;User ID=mediaalt;Password=wehkun-7jYcnu-zidjaz");

            // Populate form
            PopulateListInfo(list);
            PopulateDataTable();
        }

        // Retrieves items from the selected list and fills the data grid
        public void PopulateDataTable()
        {
            // Create data container
            DataTable results = new DataTable();

            // Retrieve Items from list
            try
            {
                dbConnection.Open();
                SqlCommand cmdGetListItems = dbConnection.CreateCommand();

                // Construct insertion query
                cmdGetListItems.CommandText = @"SELECT ITEM_TITLE,
                                               ITEM_ICON
                                               FROM ITEMS
                                               JOIN LIST ON ITEM_LIST_ID = LIST_ID
                                               WHERE LIST_NAME = @bind1";

                // Parameterize the variables for system security
                cmdGetListItems.Parameters.AddWithValue("@bind1", list);

                // Execute and read the data
                SqlDataReader reader = cmdGetListItems.ExecuteReader();
                results.Load(reader);

                // Configure table
                dgvResults.DataSource = results;
                dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvResults.Columns[0].HeaderText = "Title";
                dgvResults.Columns[1].HeaderText = "Icon";

                // Close resources
                reader.Close();
                results.Dispose();
                cmdGetListItems.Dispose();
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        ///////////////////////
        //  Private methods  //
        ///////////////////////

        // Retrieves information about list that was selected and fills in basic form elements
        private void PopulateListInfo(String list)
        {
            // Retrieve list information
            try
            {
                // Set basic form elements
                lblListName.Text = list;

                // Open database connection
                dbConnection.Open();
                SqlCommand cmdGetListInfo = dbConnection.CreateCommand();

                // Construct insertion query
                cmdGetListInfo.CommandText = @"SELECT LIST_DESCRIPTION
                                               FROM LIST
                                               WHERE LIST_NAME = @bind1";

                // Parameterize the variables for system security
                cmdGetListInfo.Parameters.AddWithValue("@bind1", list);

                // Execute and read the data
                SqlDataReader reader = cmdGetListInfo.ExecuteReader();

                if (reader.Read())
                {
                    lblDescription.Text = reader[0].ToString();
                }

                // Close resources
                reader.Close();
                cmdGetListInfo.Dispose();
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Back button functionality - reopens calling form, closes this form
        private void btnNavBack_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }

        // Add Manual Entry button functionality - hides this form as the caller, then opens manual entry form with
        //                                         currently viewed list as the list to be added to
        private void btnNavManualEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manual_Entry_Form window = new Manual_Entry_Form(list, this);
            window.Show();
        }

        // Item Image button functionality - hides this form as the caller, then opens the detailed item listing form
        //                                   with the seelcted item as the item to be viewed
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detailed_Item_Listing_Form window = new Detailed_Item_Listing_Form();
            window.setCaller(this);
            // window.setItemID(id_of_item_goes_here); // May also need to include API id eventually
            window.Show();
        }

    }
}
