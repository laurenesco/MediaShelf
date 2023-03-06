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
        private String list = null!;

        SqlConnection dbConnection;

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
                dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db1;Persist Security Info=True;User ID=mediaalt;Password=wehkun-7jYcnu-zidjaz");
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
                saveManualEntry();
                this.Close();
            }
        }

        // Back button functionality - reopens calling form
        private void btnNavBack_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }
        
        //adds user-made manual entry to database
        private void saveManualEntry()
        {
            /* Instance variables:
             * mediaIDval - value for media_id in database
             * apiIDval   - value for api_id in database
             * listIDval  - value for list_id in database
             * da         - the sql data adapter being used to make sql commands from c#
             */

            int mediaIDval,apiIDval,listIDval = 0;
            SqlDataAdapter da = new SqlDataAdapter();

            dbConnection.Open();

            var test = new SqlCommand("SELECT MIN(media_id) FROM MEDIA_TYPE", dbConnection).ExecuteScalar();
            //MessageBox.Show("pass 0"); - for debugging

            //checks if user has previous manual entries; current assumption: first item in database is a manual entry
            if(test != DBNull.Value)
            {
                mediaIDval = (int)test - 1;
                apiIDval = (int)(new SqlCommand("SELECT MIN(api_id) FROM API", dbConnection).ExecuteScalar()) - 1;
                listIDval = (int)(new SqlCommand("SELECT MIN(list_id) FROM LIST", dbConnection).ExecuteScalar()) - 1;
            }
            else
            {
                mediaIDval = apiIDval = listIDval = 0;
            }

            //to satisfy media_id foreign key constraint in database
            da.InsertCommand = new SqlCommand("INSERT INTO MEDIA_TYPE VALUES(@media_id,@media_name)", dbConnection);
            da.InsertCommand.Parameters.Add("@media_id", SqlDbType.Int).Value = mediaIDval;
            da.InsertCommand.Parameters.Add("@media_name", SqlDbType.NVarChar, 50).Value = ME_type.Text;

            da.InsertCommand.ExecuteNonQuery();

            //MessageBox.Show("pass 1"); - for debugging

            //to satisfy api_id foreign key constraint in database
            da.InsertCommand = new SqlCommand("INSERT INTO API VALUES(@api_id,@api_key,@api_name)", dbConnection);
            da.InsertCommand.Parameters.Add("@api_id", SqlDbType.Int).Value = apiIDval;
            da.InsertCommand.Parameters.Add("@api_key", SqlDbType.NVarChar, 200).Value = "";
            da.InsertCommand.Parameters.Add("@api_name", SqlDbType.NVarChar, 50).Value = "";

            da.InsertCommand.ExecuteNonQuery();

            //MessageBox.Show("pass 2"); - for debugging


            //stores manual entry made in program in database
            da.InsertCommand = new SqlCommand("INSERT INTO ITEMS VALUES(@item_id,@item_api,@item_media_type,@item_title,@item_creator,@item_release_date,@item_icon,@item_description,@item_list_id,@item_genre)", dbConnection);
            da.InsertCommand.Parameters.Add("@item_id", SqlDbType.Int).Value = new Random().Next() * 1000 + 1;
            da.InsertCommand.Parameters.Add("@item_api", SqlDbType.Int).Value = 0;
            da.InsertCommand.Parameters.Add("@item_media_type", SqlDbType.Int).Value = 0;
            da.InsertCommand.Parameters.Add("@item_title", SqlDbType.NVarChar, 200).Value = ME_title.Text;
            da.InsertCommand.Parameters.Add("@item_creator", SqlDbType.NVarChar, 100).Value = ME_creator.Text;
            da.InsertCommand.Parameters.Add("@item_release_date", SqlDbType.Date).Value = ME_date.Value;
            da.InsertCommand.Parameters.Add("@item_icon", SqlDbType.Image).Value = Array.Empty<byte>();
            da.InsertCommand.Parameters.Add("@item_description", SqlDbType.NVarChar, 1000).Value = ME_description.Text;
            da.InsertCommand.Parameters.Add("@item_list_id", SqlDbType.Int).Value = 3;
            da.InsertCommand.Parameters.Add("@item_genre", SqlDbType.NVarChar, 50).Value = ME_genre.Text;

            da.InsertCommand.ExecuteNonQuery();

            //MessageBox.Show("pass 3"); - for debugging

            //to satisfy list_id foreign key constraint; currently having issues
            da.InsertCommand = new SqlCommand("INSERT INTO LIST VALUES(@list_id,@list_name,@list_description)", dbConnection);
            da.InsertCommand.Parameters.Add("@list_id", SqlDbType.Int).Value = listIDval;
            da.InsertCommand.Parameters.Add("@list_name", SqlDbType.NVarChar, 25).Value = "Manual Entries";
            da.InsertCommand.Parameters.Add("@list_description", SqlDbType.NVarChar, 280).Value = "";

            da.InsertCommand.ExecuteNonQuery();

            dbConnection.Close();

            MessageBox.Show("Completed");
        }
    }
}
