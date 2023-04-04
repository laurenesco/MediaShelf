using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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
        // Instance variables 
        // item_API_ID  - API of respective item
        // item_ID      - ID of respective item
        // dbConnection - Database connection object
        private int item_API_ID;
        private int item_ID;
        private SqlConnection dbConnection;

        //////////////////////
        //  Public methods  //
        //////////////////////

        // Constructor
        public Notes_Form(int item_API_ID, int item_ID, string title)
        {
            InitializeComponent();

            // Set variables for the instance of the form
            this.item_API_ID = item_API_ID;
            this.item_ID = item_ID;
            lblTitle.Text = title;

            try
            {
                // Initiate Database Connection
                dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db2;Persist Security Info=True;User ID=mediaalt;Password=wehkun-7jYcnu-zidjaz;");

                // Populate the form
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Initializing Notes Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        ///////////////////////
        //  Private methods  //
        ///////////////////////

        private void LoadForm()
        {
            // Iterate through all notepads and load notes
            for (int i = 1; i <= 8; i++)
            {
                LoadNote(i);
            }
        }

        private void LoadNote(int notepadID)
        {
            try
            {
                // Open database connection and create command 
                dbConnection.Open();
                SqlCommand cmdLoadNote = dbConnection.CreateCommand();

                // Construct insertion query
                cmdLoadNote.CommandText = @"SELECT NOTES_DESC
                                            FROM NOTES
                                            WHERE NOTES_ITEM_API = @bind1
                                            AND NOTES_ITEM_ID = @bind2
                                            AND NOTES_NOTE_NUMBER = @bind3";

                // Parameterize query for security
                cmdLoadNote.Parameters.AddWithValue("@bind1", item_API_ID);
                cmdLoadNote.Parameters.AddWithValue("@bind2", item_ID);
                cmdLoadNote.Parameters.AddWithValue("@bind3", notepadID);

                // Execute the insertion query
                SqlDataReader reader = cmdLoadNote.ExecuteReader();

                // Load note text into respective notepad
                if (reader.Read())
                {
                    // Best way I can think of right now is switch statement to dynamically pick component name
                    switch (notepadID)
                    {
                        case 1:
                            txtNote1.Text = reader[0].ToString();
                            break;
                        case 2:
                            txtNote2.Text = reader[0].ToString();
                            break;
                        case 3:
                            txtNote3.Text = reader[0].ToString();
                            break;
                        case 4:
                            txtNote4.Text = reader[0].ToString();
                            break;
                        case 5:
                            txtNote5.Text = reader[0].ToString();
                            break;
                        case 6:
                            txtNote6.Text = reader[0].ToString();
                            break;
                        case 7:
                            txtNote7.Text = reader[0].ToString();
                            break;
                        case 8:
                            txtNote8.Text = reader[0].ToString();
                            break;
                        default:
                            MessageBox.Show("An error has occured in the switch statement\nin LoadNote().", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }

                // Close connection and dispose of the command
                dbConnection.Close();
                cmdLoadNote.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Loading Notes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Performs the insertion query when called by the save button
        private void ProcessNote(int notepadID, bool dne)
        {
            // Get the text from the respective notepad
            string noteText = GetNoteText(notepadID);

            if (noteText.IsNullOrEmpty())
            {
                // If the note is empty, delete correspinding entry in database
                // This ensures there are not empty rows taking up space in db until we implement 
                // method to check if a note exists/
                DeleteNote(notepadID);
            }
            else if (dne)
            {
                UpdateNote(notepadID, noteText);
            }
            else
            {
                // If the note contains text AND does not exist, save it to database
                SaveNote(notepadID, noteText);
            }
        }

        private void UpdateNote(int notepadID, string noteText)
        {
            try
            {
                // Open database connection and create command 
                dbConnection.Open();
                SqlCommand cmdUpdateNote = dbConnection.CreateCommand();

                // Construct insertion query
                cmdUpdateNote.CommandText = @"UPDATE NOTES 
                                              SET NOTES_DESC = @bind4
                                              WHERE NOTES_ITEM_API = @bind1
                                              AND NOTES_ITEM_ID = @bind2
                                              AND NOTES_NOTE_NUMBER = @bind3";

                // Parameterize query for security
                cmdUpdateNote.Parameters.AddWithValue("@bind1", item_API_ID);
                cmdUpdateNote.Parameters.AddWithValue("@bind2", item_ID);
                cmdUpdateNote.Parameters.AddWithValue("@bind3", notepadID);
                cmdUpdateNote.Parameters.AddWithValue("@bind4", noteText);

                // Execute the insertion query
                cmdUpdateNote.ExecuteNonQuery();

                // Close connection and dispose of the command
                dbConnection.Close();
                cmdUpdateNote.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Updating Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveNote(int notepadID, string noteText)
        {
            try
            {
                // Open database connection and create command 
                dbConnection.Open();
                SqlCommand cmdInsertNote = dbConnection.CreateCommand();

                // Construct insertion query
                cmdInsertNote.CommandText = @"INSERT INTO NOTES
                                          (NOTES_ITEM_API,
                                          NOTES_ITEM_ID,
                                          NOTES_NOTE_NUMBER,
                                          NOTES_DESC)
                                          VALUES(@bind1, @bind2, @bind3, @bind4)";

                // Parameterize query for security
                cmdInsertNote.Parameters.AddWithValue("@bind1", item_API_ID);
                cmdInsertNote.Parameters.AddWithValue("@bind2", item_ID);
                cmdInsertNote.Parameters.AddWithValue("@bind3", notepadID);
                cmdInsertNote.Parameters.AddWithValue("@bind4", noteText);

                // Execute the insertion query
                cmdInsertNote.ExecuteNonQuery();

                // Close connection and dispose of the command
                dbConnection.Close();
                cmdInsertNote.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Deletes a note from the database 
        private void DeleteNote(int notepadID)
        {
            try
            {
                // Open database connection and create command 
                dbConnection.Open();
                SqlCommand cmdDeleteNote = dbConnection.CreateCommand();

                // Construct deletion query
                cmdDeleteNote.CommandText = @"DELETE FROM NOTES
                                              WHERE NOTES_ITEM_API = @bind1
                                              AND NOTES_ITEM_ID = @bind2
                                              AND NOTES_NOTE_NUMBER = @bind3";

                // Parameterize query for security
                cmdDeleteNote.Parameters.AddWithValue("@bind1", item_API_ID);
                cmdDeleteNote.Parameters.AddWithValue("@bind2", item_ID);
                cmdDeleteNote.Parameters.AddWithValue("@bind3", notepadID);

                // Execute the insertion query
                cmdDeleteNote.ExecuteNonQuery();

                // Close connection and dispose of the command
                dbConnection.Close();
                cmdDeleteNote.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Deleting Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Returns the text inside the notepad based on ID passed
        private string GetNoteText(int notepadID)
        {
            try
            {
                // Return text based on which ID is requested
                switch (notepadID)
                {
                    case 1:
                        return txtNote1.Text.ToString().Trim();
                    case 2:
                        return txtNote2.Text.ToString().Trim();
                    case 3:
                        return txtNote3.Text.ToString().Trim();
                    case 4:
                        return txtNote4.Text.ToString().Trim();
                    case 5:
                        return txtNote5.Text.ToString().Trim();
                    case 6:
                        return txtNote6.Text.ToString().Trim();
                    case 7:
                        return txtNote7.Text.ToString().Trim();
                    case 8:
                        return txtNote8.Text.ToString().Trim();
                    default:
                        MessageBox.Show("An error has occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return "Error";
                }
            }
            catch (Exception ex)
            {
                // Catch any errors and display error string
                MessageBox.Show(ex.ToString(), "Error Retrieving Note Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }

        // Save button functionality - saves each note on the form
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            // Array to track if the note currently exists or not
            bool[] exists = new bool[8];

            try
            {
                for (int i = 1; i <= 8; i++)
                {
                    // Open database connection and create command 
                    dbConnection.Open();
                    SqlCommand cmdLoadNote = dbConnection.CreateCommand();

                    // Construct insertion query
                    cmdLoadNote.CommandText = @"SELECT NOTES_DESC
                                            FROM NOTES
                                            WHERE NOTES_ITEM_API = @bind1
                                            AND NOTES_ITEM_ID = @bind2
                                            AND NOTES_NOTE_NUMBER = @bind3";

                    // Parameterize query for security
                    cmdLoadNote.Parameters.AddWithValue("@bind1", item_API_ID);
                    cmdLoadNote.Parameters.AddWithValue("@bind2", item_ID);
                    cmdLoadNote.Parameters.AddWithValue("@bind3", i);

                    // Execute the insertion query
                    SqlDataReader reader = cmdLoadNote.ExecuteReader();

                    // Load note text into respective notepad
                    if (reader.Read())
                    {
                        // Sets array value to true if note exists
                        exists[i - 1] = true;
                    }

                    // Close connection and dispose of the command
                    dbConnection.Close();
                    cmdLoadNote.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 1; i <= 8; i++)
            {
                ProcessNote(i, exists[i - 1]);
            }

            // Confirmation message
            MessageBox.Show("Notes saved!\n", "Confirmation Message", MessageBoxButtons.OK);
        }

        // Back button functionality - closes the form
        private void btnNavBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Notes_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
