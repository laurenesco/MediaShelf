using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
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
        private Form caller;
        public String list = "";
        private SqlConnection dbConnection;

        //////////////////////
        //  Public methods  //
        //////////////////////

        // Constructor
        public ListView(String list, Form caller)
        {
            InitializeComponent();
            this.list = list;
            this.caller = caller;

            // Initiate Database Connection String
            dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db2;Persist Security Info=True;User ID=mediaalt;Password=wehkun-7jYcnu-zidjaz");

            // Populate form

            if (list == "Tags")
            {
                TagElements();
                PopulateSortComboBox(2);
                PopulateTagsTable("");
            }
            else
            {
                PopulateSortComboBox(1);
                PopulateListInfo(list);
                PopulateDataTable("");
            }
        }

        // Populates the datagridview if the user wants to view tags instead of a list
        public void PopulateTagsTable(String s)
        {
            // Format search
            String search = "%" + s + "%";
            String parameter = "";

            // Set search parameter
            switch (cmbSortTags.Text)
            {
                case "Tag Name":
                    parameter = "TAG_NAME";
                    break;
                case "Items with Tag":
                    parameter = "ROW_COUNT";
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
                // Open database connection
                dbConnection.Open();
                SqlCommand cmdGetTagInfo = dbConnection.CreateCommand();

                // Construct insertion query
                cmdGetTagInfo.CommandText = @"SELECT UPPER(LEFT(TAG_NAME, 1)) +
                                              LOWER(RIGHT(TAG_NAME, LEN(TAG_NAME) - 1)),
                                                  (SELECT COUNT(*)
                                                   FROM ITEM_TAGS
                                                   WHERE ITEM_TAG_NO = TAG_NO) AS ROW_COUNT
                                               FROM TAG";

                // If search box is not empty, add this condition to the query
                if (search != "%%")
                {
                    cmdGetTagInfo.CommandText += " WHERE " + parameter + " LIKE @bind1";
                    cmdGetTagInfo.Parameters.AddWithValue("@bind1", search);
                }

                // Execute and read the data
                SqlDataReader reader = cmdGetTagInfo.ExecuteReader();
                results.Load(reader);

                dgvResults.DataSource = results;
                dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvResults.Columns[0].HeaderText = "Tag";
                dgvResults.Columns[1].HeaderText = "Items with this Tag";


                // Close resources
                reader.Close();
                cmdGetTagInfo.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            dbConnection.Close();
        }

        // Retrieves items from the selected list and fills the data grid
        public void PopulateDataTable(String s)
        {
            // Format search
            String search = "%" + s + "%";
            String parameter = "";

            // Set search parameter
            switch (cmbListSort.Text)
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
                case "Tags":
                    parameter = "TAG_DESC";
                    break;
                default:
                    MessageBox.Show("Error in sorting switch statement", "Sorting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmdGetListItems.CommandText = @"SELECT ITEM_ID,ITEM_TITLE,
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
                dgvResults.Columns[0].HeaderText = "Item_id";
                dgvResults.Columns[1].HeaderText = "Title";
                dgvResults.Columns[2].HeaderText = "Artist";
                dgvResults.Columns[3].HeaderText = "Genre";
                dgvResults.Columns[0].Visible = false;

                // Close resources
                reader.Close();
                results.Dispose();
                cmdGetListItems.Dispose();

            }
            catch (Exception ex)
            {
                // Display any potential errors
                MessageBox.Show(ex.ToString(), "Error in PopulateDataTable()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dbConnection.Close();
        }

        ///////////////////////
        //  Private methods  //
        ///////////////////////

        // Set list items to non-visible, set tags items to visible
        private void TagElements()
        {
            // Hide elements specific to list items
            this.btnDeleteListItem.Visible = false;
            this.btnNavManualListItem.Visible = false;
            this.btnNotes.Visible = false;
            this.cmbListSort.Visible = false;
            this.txtListSearch.Visible = false;

            // Show elements specific to tags
            this.btnDeleteTag.Visible = true;
            this.btnAddTag.Visible = true;
            this.cmbSortTags.Visible = true;
            this.txtTagsSearch.Visible = true;
            this.lblListName.Text = "Tags";
            this.lblDescriptionText.Text = "Manage Your Tags";
        }

        // Populate the combobox for the list or tag version of the page for sorting
        private void PopulateSortComboBox(int type)
        {
            if (type == 1)
            {
                cmbListSort.Items.Add("Title");
                cmbListSort.Items.Add("Creator");
                cmbListSort.Items.Add("Genre");
                cmbListSort.Items.Add("Tags");
                cmbListSort.SelectedIndex = 0;
            }
            else if (type == 2)
            {
                cmbSortTags.Items.Add("Tag Name");
                // cmbSortTags.Items.Add("Items with Tag");
                cmbSortTags.SelectedIndex = 0;
            }
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            dbConnection.Close();
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
            String search = txtListSearch.Text.ToString();
            PopulateDataTable(search);
        }

        // Delete entry functionality - Deletes selected item from list
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string title = dgvResults.Rows[dgvResults.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string creator = dgvResults.Rows[dgvResults.CurrentCell.RowIndex].Cells[2].Value.ToString();

            var areYouSure = MessageBox.Show("Are you sure you want to delete " + title + "?", "Deletion Warning", MessageBoxButtons.YesNoCancel);

            if (areYouSure == DialogResult.Yes)
            {
                int[] id = GetItemID(title, creator);
                DeleteItem(id[0], id[1]);
                DeleteNotes(id[0], id[1]);

                // Confirmation
                MessageBox.Show(title + " has been deleted from your " + list + " list", "Deletion Successful", MessageBoxButtons.OK);
            }

            // Refresh
            PopulateDataTable("");
        }

        // Deletes the specified item from the current list
        private void DeleteItem(int id, int api)
        {
            try
            {
                // Open database connection
                dbConnection.Open();
                SqlCommand cmdDeleteItem = dbConnection.CreateCommand();

                // Construct deletion query
                cmdDeleteItem.CommandText = @"DELETE FROM ITEMS
                                             WHERE ITEM_ID = @bind1
                                             AND ITEM_API = @bind2";

                // Parameterize the variables for system security
                cmdDeleteItem.Parameters.AddWithValue("@bind1", id);
                cmdDeleteItem.Parameters.AddWithValue("@bind2", api);

                // Execute query
                cmdDeleteItem.ExecuteNonQuery();

                // Dispose of resources
                cmdDeleteItem.Dispose();

            }
            catch (Exception ex)
            {
                // Display error if caught
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dbConnection.Close();
        }

        // Deletes all notes associated with an item
        private void DeleteNotes(int id, int api)
        {
            try
            {
                // Open database connection
                dbConnection.Open();
                SqlCommand cmdDeleteItem = dbConnection.CreateCommand();

                // Construct deletion query
                cmdDeleteItem.CommandText = @"DELETE FROM  NOTES
                                             WHERE NOTES_ITEM_ID = @bind1
                                             AND NOTES_ITEM_API = @bind2";

                // Parameterize the variables for system security
                cmdDeleteItem.Parameters.AddWithValue("@bind1", id);
                cmdDeleteItem.Parameters.AddWithValue("@bind2", api);

                // Execute query
                cmdDeleteItem.ExecuteNonQuery();

                // Dispose of resources
                cmdDeleteItem.Dispose();
            }
            catch (Exception ex)
            {
                // Display error if caught
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dbConnection.Close();
        }

        // Notes button functionality - Opens notes form populated with the notes of the selected item
        private void btnNotes_Click(object sender, EventArgs e)
        {
            // Declare variables
            string title = dgvResults.Rows[dgvResults.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string creator = dgvResults.Rows[dgvResults.CurrentCell.RowIndex].Cells[2].Value.ToString();
            int[] IDs = new int[2];

            // Run query to retrieve the ID's necessary to open notes form
            try
            {
                // Open database connection
                dbConnection.Open();
                SqlCommand cmdGetIDs = dbConnection.CreateCommand();

                // Construct deletion query
                cmdGetIDs.CommandText = @"SELECT ITEM_ID,
                                          ITEM_API
                                          FROM ITEMS
                                          WHERE ITEM_TITLE = @bind1
                                          AND ITEM_CREATOR = @bind2";

                // Parameterize the variables for system security
                cmdGetIDs.Parameters.AddWithValue("@bind1", title);
                cmdGetIDs.Parameters.AddWithValue("@bind2", creator);

                // Execute query
                SqlDataReader reader = cmdGetIDs.ExecuteReader();

                if (reader.Read())
                {
                    IDs[0] = Convert.ToInt32(reader[1]);
                    IDs[1] = Convert.ToInt32(reader[0]);
                }

                // Dispose of resources
                cmdGetIDs.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error loading notes form.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dbConnection.Close();

            // Open notes form
            Notes_Form window = new Notes_Form(IDs[0], IDs[1], title);
            window.Show();
        }

        // Returns the items ID and API ID (primary key) from title and creator
        private int[] GetItemID(string title, string creator)
        {
            int[] item = { 0, 0 };
            try
            {
                // Open database connection
                dbConnection.Open();
                SqlCommand cmdGetID = dbConnection.CreateCommand();

                // Construct deletion query
                cmdGetID.CommandText = @"SELECT ITEM_ID,
                                         ITEM_API
                                         FROM ITEMS
                                         WHERE ITEM_CREATOR = @bind2
                                         AND ITEM_TITLE = @bind1";

                // Parameterize the variables for system security
                cmdGetID.Parameters.AddWithValue("@bind1", title);
                cmdGetID.Parameters.AddWithValue("@bind2", creator);

                // Execute query
                SqlDataReader reader = cmdGetID.ExecuteReader();

                if (reader.Read())
                {
                    item[0] = Convert.ToInt32(reader[0]);
                    item[1] = Convert.ToInt32(reader[1]);
                    dbConnection.Close();
                    return item;
                }

                // Dispose of resources
                cmdGetID.Dispose();

                // Confirmation & Refresh
                PopulateDataTable("");
                MessageBox.Show(title + " has been deleted from your " + list + " list", "Deletion Successful", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                // Display error if caught
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dbConnection.Close();
            return item;
        }

        // Search the datagridview when tags are loaded, not lists
        private void txtTagsSearch_TextChanged(object sender, EventArgs e)
        {
            String search = txtTagsSearch.Text.ToString();
            PopulateTagsTable(search);
        }

        // Add tag button functionality, opens tag version of manual entry form
        private void btnAddTag_Click(object sender, EventArgs e)
        {
            Manual_Entry_Form window = new Manual_Entry_Form(list, this);
            window.Show();
        }

        // Delete tag button functionality, deletes the selected tag
        private void btnDeleteTag_Click(object sender, EventArgs e)
        {
            string tagName = dgvResults.Rows[dgvResults.CurrentCell.RowIndex].Cells[0].Value.ToString();

            var areYouSure = MessageBox.Show("Are you sure you want to delete the tag " + tagName + "?", "Deletion Warning", MessageBoxButtons.YesNoCancel);

            if (areYouSure == DialogResult.Yes)
            {
                // Retrieve the ID and delete the tag
                int id = GetTagID(tagName);
                DeleteTag(id);

                // Confirmation
                MessageBox.Show(tagName + " has been deleted!", "Deletion Successful", MessageBoxButtons.OK);
            }

            // Refresh
            PopulateTagsTable("");
        }

        private void DeleteTag(int ID)
        {
            try
            {
                // Open database connection
                dbConnection.Open();
                SqlCommand cmdDeleteTag = dbConnection.CreateCommand();

                // Construct deletion query
                cmdDeleteTag.CommandText = @"DELETE FROM TAG
                                             WHERE TAG_NO = @bind1";

                // Parameterize the variables for system security
                cmdDeleteTag.Parameters.AddWithValue("@bind1", ID);

                // Execute query
                cmdDeleteTag.ExecuteNonQuery();

                // Dispose of resources
                cmdDeleteTag.Dispose();
            }
            catch (Exception ex)
            {
                // Display error if caught
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dbConnection.Close();
        }

        // Retrieve the tag ID for accurate deletion
        private int GetTagID(string tagName)
        {
            // Try query
            try
            {
                // Open database connection
                dbConnection.Open();
                SqlCommand cmdGetTagID = dbConnection.CreateCommand();

                // Construct insertion query
                cmdGetTagID.CommandText = @"SELECT TAG_NO
                                            FROM TAG
                                            WHERE TAG_NAME = @bind1";

                // Parameterize for security purposes
                cmdGetTagID.Parameters.AddWithValue("@bind1", tagName);

                // Execute
                SqlDataReader reader = cmdGetTagID.ExecuteReader();

                if (reader.Read())
                {
                    // Close resources
                    int id = Convert.ToInt32(reader[0]);
                    reader.Close();
                    cmdGetTagID.Dispose();
                    dbConnection.Close();

                    // Return ID                   
                    return id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            dbConnection.Close();
            return 0;
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.list != "Tags")
            {
                string item_id = dgvResults.CurrentRow.Cells[0].Value.ToString();
                Detailed_Item_Listing_Form window = new Detailed_Item_Listing_Form(item_id);
                window.setCaller(this);
                this.Hide();
                window.Show();
            }
        }
    }
}
