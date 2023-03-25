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
            PopulateSortComboBox();
            PopulateListInfo(list);
            PopulateDataTable("");
        }

        // Retrieves items from the selected list and fills the data grid
        public void PopulateDataTable(String s)
        {
            // Format search
            String search = "%" + s + "%";
            String parameter = "";
            
            // Set search parameter
            switch(cmbSortByParameter.Text)
            {
                case "Title":
                    parameter = "ITEM_TITLE";
                    break;
                case "Genre":
                    parameter = "ITEM_GENRE";
                    break;
                case "Creator":
                    parameter = "ITEM_CREATOR";
                    break;
                default:
                    MessageBox.Show("Error in sorting function", "Sorting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            // Create data container
            DataTable results = new DataTable();

            // Try query
            try
            {
                // Open connection
                dbConnection.Open();
                SqlCommand cmdGetListItems = dbConnection.CreateCommand();

                // Construct select query
                cmdGetListItems.CommandText = @"SELECT ITEM_TITLE,
                                               ITEM_CREATOR,
                                               ITEM_GENRE
                                               FROM ITEMS
                                               JOIN LIST ON ITEM_LIST_ID = LIST_ID
                                               WHERE LIST_NAME = @bind1";

                // If search box is not empty, add this condition to the query
                if (search != "%%")
                {
                    cmdGetListItems.CommandText += " AND " + parameter + " LIKE @bind2";
                    cmdGetListItems.Parameters.AddWithValue("@bind2", search);
                }
                                               

                // Parameterize the variables for system security
                cmdGetListItems.Parameters.AddWithValue("@bind1", list);

                // Execute and read the data
                SqlDataReader reader = cmdGetListItems.ExecuteReader();
                results.Load(reader);

                // Configure table
                dgvResults.DataSource = results;
                dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvResults.Columns[0].HeaderText = "Title";
                dgvResults.Columns[1].HeaderText = "Artist";
                dgvResults.Columns[2].HeaderText = "Genre";

                // Close resources
                reader.Close();
                results.Dispose();
                cmdGetListItems.Dispose();
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                // Display any potential errors
                MessageBox.Show(ex.ToString());
            }
        }

        ///////////////////////
        //  Private methods  //
        ///////////////////////
        
        private void PopulateSortComboBox()
        {
            cmbSortByParameter.Items.Add("Title");
            cmbSortByParameter.Items.Add("Creator");
            cmbSortByParameter.Items.Add("Genre");
            cmbSortByParameter.SelectedIndex = 0;
        }

        // Retrieves information about list that was selected and fills in basic form elements
        private void PopulateListInfo(String list)
        {
            // Try query
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
                    lblDescriptionText.Text = reader[0].ToString();
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
            Manual_Entry_Form window = new Manual_Entry_Form(list, this);
            window.Show();
        }

        // Search box functionality - Refreshes box upon typing
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String search = txtSearch.Text.ToString();
            PopulateDataTable(search);
        }

        // Delete entry functionality - Deletes selected item from list
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String title = dgvResults.Rows[dgvResults.CurrentCell.RowIndex].Cells[0].Value.ToString();
            String creator = dgvResults.Rows[dgvResults.CurrentCell.RowIndex].Cells[1].Value.ToString();

            var areYouSure = MessageBox.Show("Are you sure you want to delete " + title + "?", "Deletion Warning", MessageBoxButtons.YesNoCancel);

            if (areYouSure == DialogResult.Yes)
            {
                DeleteItem(title, creator);
            }
        }

        private void DeleteItem (String title, String creator)
        {
            try
            {
                // Open database connection
                dbConnection.Open();
                SqlCommand cmdDeleteItem = dbConnection.CreateCommand();

                // Construct deletion query
                cmdDeleteItem.CommandText = @"DELETE FROM ITEMS
                                             WHERE ITEM_TITLE = @bind1
                                             AND ITEM_CREATOR = @bind2";

                // Parameterize the variables for system security
                cmdDeleteItem.Parameters.AddWithValue("@bind1", title);
                cmdDeleteItem.Parameters.AddWithValue("@bind2", creator);

                // Execute query
                cmdDeleteItem.ExecuteNonQuery();

                // Dispose of resources
                cmdDeleteItem.Dispose();
                dbConnection.Close();

                // Confirmation & Refresh
                PopulateDataTable("");
                MessageBox.Show(title + " has been deleted from your " + list + " list", "Deletion Successful", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                // Display error if caught
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
