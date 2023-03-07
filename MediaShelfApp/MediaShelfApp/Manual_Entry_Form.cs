using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaShelfApp
{
    public partial class Manual_Entry_Form : Form
    {
        // Instance variables:
        // caller       - form which invoked this form
        // list         - list intended to be added to
        // dbConnection - connection to sql database being used in program

        private ListView caller = null!;
        private String list = "";
        private SqlConnection dbConnection;

        //////////////////////
        //  Public methods  //
        //////////////////////

        // Constructor
        public Manual_Entry_Form(string list, ListView caller)
        {
            InitializeComponent();
            this.list = list;
            this.caller = caller;

            // Initiate Database Connection
            dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db2;Persist Security Info=True;User ID=mediaalt;Password=wehkun-7jYcnu-zidjaz");
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

        // Add button functionality - saves user-made manual entry
        private void ME_addButton_Click(object sender, EventArgs e)
        {
            // Instance variable: isEmpty - bool representing whether title field is empty
            bool isEmpty = true;
            
            //checks that title text field isn't empty/full of white-space
            foreach (char c in ME_title.Text)
            {
                if (c != ' ')
                {
                    isEmpty = false;
                    break;
                }
            }

            //if title field is empty, informs user to correct that; else, proceeds to save manual entry
            if(isEmpty)
            {
                MessageBox.Show("Title field cannot be empty. Please enter a title.");
            }
            else
            {
                SaveManualEntry();
                this.ClearFields();
            }
        }

        private void ClearFields()
        {
            ME_creator.Clear();
            ME_date.Value = DateTime.Today;
            ME_title.Clear();
            ME_genre.Clear();
            ME_type.Clear();
            ME_creator.Clear();
            ME_description.Clear();
        }

        // Back button functionality - reopens calling form with refreshed data grid
        private void btnNavBack_Click(object sender, EventArgs e)
        {
            caller.PopulateDataTable();
            caller.Show();
            this.Close();
        }
        
        //adds user-made manual entry to database
        private void SaveManualEntry()
        {
            try
            {
                // Declaring all form variables that may be used in the query (to later be validated)
                String title = ME_title.Text;
                String creator = ME_creator.Text;
                String genre = ME_genre.Text; 
                String description = ME_description.Text;
                DateTime releaseDate = ME_date.Value;

                // Open connection and create command
                dbConnection.Open();
                SqlCommand cmdInsertMedia = dbConnection.CreateCommand();

                // Construct insertion query
                cmdInsertMedia.CommandText = @"INSERT INTO ITEMS 
                                               (ITEM_API,
                                               ITEM_MEDIA_TYPE,
                                               ITEM_TITLE,
                                               ITEM_CREATOR,   
                                               ITEM_RELEASE_DATE,
                                               ITEM_DESCRIPTION,
                                               ITEM_LIST_ID,
                                               ITEM_GENRE)
                                               VALUES(@api, @type, @title, @creator, @date, @desc, @list, @genre)";

                // Parameterize the variables for system security
                cmdInsertMedia.Parameters.AddWithValue("@api", 0); // API ID 0 signifies manual entry - No API affiliation
                cmdInsertMedia.Parameters.AddWithValue("@type", 0); // TYPE 0 signifies manual entry - No media type affiliation
                cmdInsertMedia.Parameters.AddWithValue("@title", title);
                cmdInsertMedia.Parameters.AddWithValue("@creator", creator);
                cmdInsertMedia.Parameters.AddWithValue("@date", releaseDate);
                cmdInsertMedia.Parameters.AddWithValue("@desc", description);
                cmdInsertMedia.Parameters.AddWithValue("@list", 0); // LIST ID 0 signifies manual entry - No list affiliation
                cmdInsertMedia.Parameters.AddWithValue("@genre", genre);


                // Execute the insertion query
                cmdInsertMedia.ExecuteNonQuery();

                // Close connection and dispose of the command
                dbConnection.Close();
                cmdInsertMedia.Dispose();

                // Confirmation message
                MessageBox.Show("Item created!\n", "Confirmation Message", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
    }
}
