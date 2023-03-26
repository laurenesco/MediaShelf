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
        int item_API_ID;
        int item_ID;
        SqlConnection dbConnection;

        //////////////////////
        //  Public methods  //
        //////////////////////
        
        // Constructor
        public Notes_Form(int item_API_ID, int item_ID)
        {
            InitializeComponent();

            // Set variables for the instance of the form
            this.item_API_ID = item_API_ID;
            this.item_ID = item_ID;

            // Populate the form
            LoadForm();

            // Initiate Database Connection
            try
            {
                SqlConnection dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db1;Persist Security Info=True;User ID=mediaalt;Password=wehkun-7jYcnu-zidjaz");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                                            WHERE NOTES_API_ID = @bind1
                                            AND NOTES_ID = @bind2
                                            AND NOTES_NOTE_NUMBER = @bind3";

                // Parameterize query for security
                cmdLoadNote.Parameters.AddWithValue("@bind1", item_API_ID);
                cmdLoadNote.Parameters.AddWithValue("@bind1", item_ID);
                cmdLoadNote.Parameters.AddWithValue("@bind1", notepadID);

                // Execute the insertion query
                SqlDataReader reader = cmdLoadNote.ExecuteReader();

                // Load note text into respesctive notepad
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
        private void UpdateNote(int notepadID)
        {
            // Get the text from the respective notepad
            string noteText = GetNoteText(notepadID);

            if (noteText.IsNullOrEmpty())
            {
                // If the note is empty, delete correspinding entry in database
                // This ensures there are not empty rows taking up space in db until we implement 
                // method to check if a note exists/
                DeleteNote(notepadID);
            } else
            {
                // If the note contains text, save it to database
                SaveNote(notepadID, noteText);
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
                                          NOTES_ITEM_DESC)
                                          VALUES(@bind1, @bind2, @bind3)";

                // Parameterize query for security
                cmdInsertNote.Parameters.AddWithValue("@bind1", item_API_ID);
                cmdInsertNote.Parameters.AddWithValue("@bind1", item_ID);
                cmdInsertNote.Parameters.AddWithValue("@bind1", notepadID);
                cmdInsertNote.Parameters.AddWithValue("@bind1", noteText);

                // Execute the insertion query
                cmdInsertNote.ExecuteNonQuery();

                // Close connection and dispose of the command
                dbConnection.Close();
                cmdInsertNote.Dispose();

                // Confirmation message
                MessageBox.Show("Notes saved!\n", "Confirmation Message", MessageBoxButtons.OK);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Deletes a note from the database 
        private void DeleteNote(int notepadID)
        {
            
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
            } catch (Exception ex)
            {
                // Catch any errors and display error string
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }

        // Save button functionality - saves each note on the form
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            // Iterate through each notepa
            // -- If notepad contains text, save the note
            // -- If notepad is blank, delete respective note
            for (int i = 1; i <= 8; i++)
            {
                UpdateNote(i);
            }
        }
    }
}
