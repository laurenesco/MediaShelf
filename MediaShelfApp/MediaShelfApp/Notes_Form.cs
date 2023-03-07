using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MediaShelfApp
{
    public partial class Notes_Form : Form

    {
        
        SqlConnection dbConnection;


        //////////////////////
        //  Public methods  //
        //////////////////////
        public Notes_Form()
        {
            InitializeComponent();

            // Initiate Database Connection
            try
            {
                dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db1;Persist Security Info=True;User ID=;Password=");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        ///////////////////////
        //  Private methods  //
        ///////////////////////
        private void Notes_Form_Load(object sender, EventArgs e)
        {
            // Add button function - to add notes


        }

        private void NotesText1_TextChanged(object sender, EventArgs e)
        {
            //check if note 1 is empty
            bool isEmpty = true;

            //check note 1 is not empty
            foreach (char c in NotesText1.Text)
            {
                if (c != ' ')
                {
                    isEmpty = false;
                    break;
                }
            }

            //add note 1 to database
            string NotesDescription = NotesText1.Text;

            //open connection
            dbConnection.Open();
            SqlCommand cmdCreateNote = dbConnection.CreateCommand();

            cmdCreateNote.CommandText = @"INSERT INTO NOTES (notes_item_id, notes_item_api, notes_desc) VALUES(@noteItem, @noteAPI, @noteDesc)";

            // Parameterize for security
            cmdCreateNote.Parameters.AddWithValue("@noteItem", 1); // 1 because it is note 1
            cmdCreateNote.Parameters.AddWithValue("@noteAPI", 0); // notes are made by the user so no API associated with it
            cmdCreateNote.Parameters.AddWithValue("@noteDesc", NotesDescription);

            // Execute the insertion query
            cmdCreateNote.ExecuteNonQuery();

            //close connection and dispose of the command
            dbConnection.Close();
            cmdCreateNote.Dispose();

        }

        private void NotesText2_TextChanged(object sender, EventArgs e)
        {
            //check if note 2 is empty
            bool isEmpty = true;

            //check note 2 is not empty
            foreach (char c in NotesText2.Text)
            {
                if (c != ' ')
                {
                    isEmpty = false;
                    break;
                }
            }

            //add note 2 to database
            string NotesDescription = NotesText2.Text;

            //open connection
            dbConnection.Open();
            SqlCommand cmdCreateNote = dbConnection.CreateCommand();

            cmdCreateNote.CommandText = @"INSERT INTO NOTES (notes_item_id, notes_item_api, notes_desc) VALUES(@noteItem, @noteAPI, @noteDesc)";

            // Parameterize for security
            cmdCreateNote.Parameters.AddWithValue("@noteItem", 2); // 2 because it is note 2
            cmdCreateNote.Parameters.AddWithValue("@noteAPI", 0); // notes are made by the user so no API associated with it
            cmdCreateNote.Parameters.AddWithValue("@noteDesc", NotesDescription);

            // Execute the insertion query
            cmdCreateNote.ExecuteNonQuery();

            //close connection and dispose of the command
            dbConnection.Close();
            cmdCreateNote.Dispose();

        }

        private void NotesText3_TextChanged(object sender, EventArgs e)
        {
            //check if note 3 is empty
            bool isEmpty = true;

            //check note 3 is not empty
            foreach (char c in NotesText3.Text)
            {
                if (c != ' ')
                {
                    isEmpty = false;
                    break;
                }
            }

            //add note 3 to database
            string NotesDescription = NotesText3.Text;

            //open connection
            dbConnection.Open();
            SqlCommand cmdCreateNote = dbConnection.CreateCommand();

            cmdCreateNote.CommandText = @"INSERT INTO NOTES (notes_item_id, notes_item_api, notes_desc) VALUES(@noteItem, @noteAPI, @noteDesc)";

            // Parameterize for security
            cmdCreateNote.Parameters.AddWithValue("@noteItem", 3); // 3 because it is note 3
            cmdCreateNote.Parameters.AddWithValue("@noteAPI", 0); // notes are made by the user so no API associated with it
            cmdCreateNote.Parameters.AddWithValue("@noteDesc", NotesDescription);

            // Execute the insertion query
            cmdCreateNote.ExecuteNonQuery();

            //close connection and dispose of the command
            dbConnection.Close();
            cmdCreateNote.Dispose();

        }
        private void NotesText4_TextChanged(object sender, EventArgs e)
        {
            //check if note 4 is empty
            bool isEmpty = true;

            //check note 4 is not empty
            foreach (char c in NotesText4.Text)
            {
                if (c != ' ')
                {
                    isEmpty = false;
                    break;
                }
            }

            //add note 4 to database
            string NotesDescription = NotesText4.Text;

            //open connection
            dbConnection.Open();
            SqlCommand cmdCreateNote = dbConnection.CreateCommand();

            cmdCreateNote.CommandText = @"INSERT INTO NOTES (notes_item_id, notes_item_api, notes_desc) VALUES(@noteItem, @noteAPI, @noteDesc)";

            // Parameterize for security
            cmdCreateNote.Parameters.AddWithValue("@noteItem", 4); // 4 because it is note 4
            cmdCreateNote.Parameters.AddWithValue("@noteAPI", 0); // notes are made by the user so no API associated with it
            cmdCreateNote.Parameters.AddWithValue("@noteDesc", NotesDescription);

            // Execute the insertion query
            cmdCreateNote.ExecuteNonQuery();

            //close connection and dispose of the command
            dbConnection.Close();
            cmdCreateNote.Dispose();

        }

        private void NotesText5_TextChanged(object sender, EventArgs e)
        {
            //check if note 5 is empty
            bool isEmpty = true;

            //check note 5 is not empty
            foreach (char c in NotesText5.Text)
            {
                if (c != ' ')
                {
                    isEmpty = false;
                    break;
                }
            }

            //add note 5 to database
            string NotesDescription = NotesText5.Text;

            //open connection
            dbConnection.Open();
            SqlCommand cmdCreateNote = dbConnection.CreateCommand();

            cmdCreateNote.CommandText = @"INSERT INTO NOTES (notes_item_id, notes_item_api, notes_desc) VALUES(@noteItem, @noteAPI, @noteDesc)";

            // Parameterize for security
            cmdCreateNote.Parameters.AddWithValue("@noteItem", 5); // 5 because it is note 5
            cmdCreateNote.Parameters.AddWithValue("@noteAPI", 0); // notes are made by the user so no API associated with it
            cmdCreateNote.Parameters.AddWithValue("@noteDesc", NotesDescription);

            // Execute the insertion query
            cmdCreateNote.ExecuteNonQuery();

            //close connection and dispose of the command
            dbConnection.Close();
            cmdCreateNote.Dispose();

        }

        private void NotesText6_TextChanged(object sender, EventArgs e)
        {
            //check if note 6 is empty
            bool isEmpty = true;

            //check note 6 is not empty
            foreach (char c in NotesText6.Text)
            {
                if (c != ' ')
                {
                    isEmpty = false;
                    break;
                }
            }

            //add note 6 to database
            string NotesDescription = NotesText6.Text;

            //open connection
            dbConnection.Open();
            SqlCommand cmdCreateNote = dbConnection.CreateCommand();

            cmdCreateNote.CommandText = @"INSERT INTO NOTES (notes_item_id, notes_item_api, notes_desc) VALUES(@noteItem, @noteAPI, @noteDesc)";

            // Parameterize for security
            cmdCreateNote.Parameters.AddWithValue("@noteItem", 6); // 6 because it is note 6
            cmdCreateNote.Parameters.AddWithValue("@noteAPI", 0); // notes are made by the user so no API associated with it
            cmdCreateNote.Parameters.AddWithValue("@noteDesc", NotesDescription);

            // Execute the insertion query
            cmdCreateNote.ExecuteNonQuery();

            //close connection and dispose of the command
            dbConnection.Close();
            cmdCreateNote.Dispose();

        }

        private void NotesText7_TextChanged(object sender, EventArgs e)
        {
            //check if note 7 is empty
            bool isEmpty = true;

            //check note 7 is not empty
            foreach (char c in NotesText7.Text)
            {
                if (c != ' ')
                {
                    isEmpty = false;
                    break;
                }
            }

            //add note 7 to database
            string NotesDescription = NotesText7.Text;

            //open connection
            dbConnection.Open();
            SqlCommand cmdCreateNote = dbConnection.CreateCommand();

            cmdCreateNote.CommandText = @"INSERT INTO NOTES (notes_item_id, notes_item_api, notes_desc) VALUES(@noteItem, @noteAPI, @noteDesc)";

            // Parameterize for security
            cmdCreateNote.Parameters.AddWithValue("@noteItem", 7); // 7 because it is note 7
            cmdCreateNote.Parameters.AddWithValue("@noteAPI", 0); // notes are made by the user so no API associated with it
            cmdCreateNote.Parameters.AddWithValue("@noteDesc", NotesDescription);

            // Execute the insertion query
            cmdCreateNote.ExecuteNonQuery();

            //close connection and dispose of the command
            dbConnection.Close();
            cmdCreateNote.Dispose();

        }

        private void NotesText8_TextChanged(object sender, EventArgs e)
        {
            //check if note 8 is empty
            bool isEmpty = true;

            //check note 8 is not empty
            foreach (char c in NotesText8.Text)
            {
                if (c != ' ')
                {
                    isEmpty = false;
                    break;
                }
            }

            //add note 8 to database
            string NotesDescription = NotesText8.Text;

            //open connection
            dbConnection.Open();
            SqlCommand cmdCreateNote = dbConnection.CreateCommand();

            cmdCreateNote.CommandText = @"INSERT INTO NOTES (notes_item_id, notes_item_api, notes_desc) VALUES(@noteItem, @noteAPI, @noteDesc)";

            // Parameterize for security
            cmdCreateNote.Parameters.AddWithValue("@noteItem", 8); // 8 because it is note 8
            cmdCreateNote.Parameters.AddWithValue("@noteAPI", 0); // notes are made by the user so no API associated with it
            cmdCreateNote.Parameters.AddWithValue("@noteDesc", NotesDescription);

            // Execute the insertion query
            cmdCreateNote.ExecuteNonQuery();

            //close connection and dispose of the command
            dbConnection.Close();
            cmdCreateNote.Dispose();

        }
    }
}
