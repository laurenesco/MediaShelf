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
        // oldNotes[]   - the notes currently saved in database
        // txtChanged[] - to keep track of edits made to notes by user

        private int item_API_ID;
        private int item_ID;
        private SqlConnection dbConnection;
        string[] oldNotes = new string[4];
        bool[] txtChanged = new bool[4];

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
        
        // fills out the form with information relating to the selected item in list view
        private void LoadForm()
        {
            // Iterate through all notepads and load notes
            for (int i = 1; i <= 4; i++)
            {
                LoadNote(i);
            }
            setOldNotes();
            fillCmbTags();
        }

        // retrieves the note from database and displays it to user
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

        // determines the right sql query to perform when called by the save button
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

        // edits a note in database
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

        // adds a note to database
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
                    default:
                        MessageBox.Show("An error has occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return "Error";
                }
            } catch (Exception ex)
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
            bool[] exists = new bool[4];

            try
            {
                for (int i = 1; i <= 4; i++)
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
                        exists[i-1] = true;
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

            for (int i = 1; i <= 4; i++)
            {
                ProcessNote(i, exists[i - 1]);
            }

            // Confirmation message
            MessageBox.Show("Notes saved!\n", "Confirmation Message", MessageBoxButtons.OK);

            //update oldNotes[]
            setOldNotes();
        }

        // Back button functionality - closes the form
        private void btnNavBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // determines whether button to add a tag to the selected item should be visible
        private void cmbAddTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if user has any tag selected for adding in combo box/drop-down, show the add tag button
            if (cmbAddTags.SelectedIndex != 0)
                btnAddTag.Visible = true;
            else
                btnAddTag.Visible = false;
        }

        // determines whether button to delete a tag from the selected item should be visible
        private void cmbDeleteTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if user has any tag selected for deleting in combo box/drop-down, show the delete tag button
            if (cmbDeleteTags.SelectedIndex != 0)
                btnDeleteTag.Visible = true;
            else
                btnDeleteTag.Visible = false;
        }

        //finds a tag's number in the database from its name
        private int findTagNo(string tagName)
        {
            int tagNum = -1; // default value and value returned if tag hasn't been assigned a number

            dbConnection.Open();
            
            // gets all tags that have been assigned a number in database and stores values in reader
            SqlCommand cmdFindTagNo = dbConnection.CreateCommand();
            cmdFindTagNo.CommandText = @"SELECT * FROM TAG";
            SqlDataReader reader = cmdFindTagNo.ExecuteReader();

            // while there are values in reader, search for tag in values
            while (reader.Read()) 
            {
                // if tag is found, get its number
                if (reader[1].ToString().ToUpper().Equals(tagName))
                {
                    tagNum = (int)reader[0];
                    break;
                }
            }

            // end query and close connection to database
            reader.Close();
            cmdFindTagNo.Dispose();
            dbConnection.Close();

            return tagNum;
        }

        // adds a tag to an item
        private void btnAddTag_Click(object sender, EventArgs e)
        {
            string tagToAdd = cmbAddTags.Items[cmbAddTags.SelectedIndex] + "";
            int tagNum = findTagNo(tagToAdd);

            dbConnection.Open();

            // if tag hasn't already been assigned a number in database, do that
            if (tagNum == -1)
            {
                SqlCommand cmdAddTagNo = dbConnection.CreateCommand();
                cmdAddTagNo.CommandText = @"INSERT INTO TAG (TAG_NAME) VALUES (@name)";
                cmdAddTagNo.Parameters.AddWithValue("@name", tagToAdd.ToLower());
                cmdAddTagNo.ExecuteNonQuery();
                cmdAddTagNo.Dispose();

                cmdAddTagNo.Dispose();

                // close connection so app won't have 2 connections to database open later
                dbConnection.Close();

                // get the tag's newly assigned number
                tagNum = findTagNo(tagToAdd);

                // reopen connection for the following interactions with database
                dbConnection.Open();
            }

            // add tag to item in database
            SqlCommand cmdAddItemToTag = dbConnection.CreateCommand();
            cmdAddItemToTag.CommandText = @"INSERT INTO ITEM_TAGS (ITEM_TAG_ID, ITEM_TAG_API, ITEM_TAG_NO) VALUES (@id, @api, @num)";
            cmdAddItemToTag.Parameters.AddWithValue("@id", item_ID);
            cmdAddItemToTag.Parameters.AddWithValue("@api", item_API_ID);
            cmdAddItemToTag.Parameters.AddWithValue("@num", tagNum);
            cmdAddItemToTag.ExecuteNonQuery();

            cmdAddItemToTag.Dispose();
            dbConnection.Close();

            // show that tag was added
            AddTag(tagToAdd);

            // transfer tag from something that can be added to something that can be deleted
            UpdateCmbTags(tagToAdd, true);
        }

        // deletes a tag from an item
        private void btnDeleteTag_Click(object sender, EventArgs e)
        {
            string tagToDelete = cmbDeleteTags.Items[cmbDeleteTags.SelectedIndex] + "";
            int tagNum = findTagNo(tagToDelete);

            dbConnection.Open();

            // check if tag was added to item during item's creation in database
            SqlCommand cmdGetTagDesc = dbConnection.CreateCommand();
            cmdGetTagDesc.CommandText = @"SELECT ITEM_TAG_NO FROM ITEM_TAGS WHERE ITEM_TAG_ID = @id AND ITEM_TAG_NO = @num";
            cmdGetTagDesc.Parameters.AddWithValue("@id", item_ID);
            cmdGetTagDesc.Parameters.AddWithValue("@num", tagNum);
            SqlDataReader reader = cmdGetTagDesc.ExecuteReader();

            SqlCommand cmdDeleteTagFromItem;

            // if tag was added after item's creation
            if (reader.Read())
            {
                reader.Close();

                // delete tag from item in database
                cmdDeleteTagFromItem = dbConnection.CreateCommand();
                cmdDeleteTagFromItem.CommandText = @"DELETE FROM ITEM_TAGS WHERE ITEM_TAG_NO = @num AND ITEM_TAG_ID = @id";
                cmdDeleteTagFromItem.Parameters.AddWithValue("@num", tagNum);
                cmdDeleteTagFromItem.Parameters.AddWithValue("@id", item_ID);
                cmdDeleteTagFromItem.ExecuteNonQuery();
            }
            else // if tag was added during item's creation
            {
                reader.Close();

                string oldDesc = ""; // to store the tags added during item's creation (the way it's stored in database)
                string newDesc = ""; // to store the tags added during item's creation that'll remain after tag is deleted (the way it's stored in database)
                List<String> oldTags = new List<String>(); // to store the tags added during item's creation

                //get the tags added during item's creation
                cmdGetTagDesc.CommandText = @"SELECT ITEM_GENRE FROM ITEMS WHERE ITEM_ID = @id";
                reader = cmdGetTagDesc.ExecuteReader();

                // get value for oldDesc
                if (reader.Read())
                {
                    if (!reader[0].ToString().IsNullOrEmpty())
                        oldDesc += reader[0].ToString().ToUpper();
                }
                reader.Close();

                // get values of oldTags
                oldTags.AddRange(oldDesc.Split(','));

                // check that tag to delete actually has been added to item
                if (!oldTags.Contains(tagToDelete))
                    ;//error if not

                // get value of newDesc
                newDesc = oldDesc.Replace(tagToDelete, "");

                //clean up any extra commas from newDesc
                newDesc = newDesc.Replace(",,", ",").Trim();
                if (newDesc[0] == ',')
                    newDesc = newDesc.Substring(1);
                if (newDesc[newDesc.Length - 1] == ',')
                    newDesc = newDesc.Remove(newDesc.Length - 1);

                // update item so that tag has been removed
                cmdDeleteTagFromItem = dbConnection.CreateCommand();
                cmdDeleteTagFromItem.CommandText = @"UPDATE ITEMS SET ITEM_GENRE = @newDesc WHERE ITEM_ID = @id";
                cmdDeleteTagFromItem.Parameters.AddWithValue("@newDesc", newDesc);
                cmdDeleteTagFromItem.Parameters.AddWithValue("@id", item_ID);
                cmdDeleteTagFromItem.ExecuteNonQuery();
            }

            // cleanup
            cmdGetTagDesc.Dispose();
            cmdDeleteTagFromItem.Dispose();
            dbConnection.Close();

            // show that tag was deleted
            RemoveTag(tagToDelete);

            // transfer tag from something that can be deleted to something that can be added
            UpdateCmbTags(tagToDelete, false);
        }

        // fills in the contents of the combo boxes/drop-downs for adding and deleting tags
        private void fillCmbTags()
        {
            // Local variables
            // addTags          - list of tags that can be added to item
            // deleteTags       - list of tags that can be deleted from item
            // results          - stores values from sql select query
            // currentItemTags  - list of tags item currently has
            List<String> addTags = new List<String>();
            List<String> deleteTags = new List<String>();
            string[] results;
            List<String> currentItemTags = loadCurrentTags(item_ID);

            //case-neutralize current tags for comparision operations
            for (int i = 0; i < currentItemTags.Count; i++)
                currentItemTags[i] = currentItemTags[i].ToUpper();

            dbConnection.Open();

            // get any tags in database that were initialized with an item
            SqlCommand cmdGetTagInfo = dbConnection.CreateCommand();
            cmdGetTagInfo.CommandText = @"SELECT ITEM_GENRE FROM ITEMS WHERE NOT (ITEM_GENRE IS NULL OR ITEM_GENRE = ' ')";
            SqlDataReader reader = cmdGetTagInfo.ExecuteReader();

            while (reader.Read())
            {
                // arrange tags in an array
                results = reader[0].ToString().Split(',');

                //place tag from results in the appropriate combo box based on whether item currently has tag
                foreach (string s in results)
                {
                    string tag = s.Trim().ToUpper();
                    bool itemHasTag = currentItemTags.Contains(tag);

                    if (!itemHasTag && !addTags.Contains(tag))
                        addTags.Add(tag);
                    else if (item_API_ID == 0 && itemHasTag && !deleteTags.Contains(tag))
                        deleteTags.Add(tag);
                }
            }
            reader.Close();

            //get any tags in database that were added to an item after its initialization
            cmdGetTagInfo.CommandText = @"SELECT TAG_NAME FROM TAG";
            reader = cmdGetTagInfo.ExecuteReader();

            //place above tags in the appropriate combo box based on whether item currently has tag
            while (reader.Read())
            {
                string tag = reader[0].ToString().Trim().ToUpper();
                bool itemHasTag = currentItemTags.Contains(tag);

                if (!itemHasTag && !addTags.Contains(tag))
                    addTags.Add(tag);
                else if (itemHasTag && !deleteTags.Contains(tag))
                    deleteTags.Add(tag);
            }

            reader.Close();
            dbConnection.Close();

            cmbAddTags.Items.AddRange(addTags.ToArray());
            cmbDeleteTags.Items.AddRange(deleteTags.ToArray());

            foreach (string s in new string[] { "MOVIE", "TV SHOW", "BOOK", "GAME", "MUSIC" })
            {
                if (!cmbAddTags.Items.Contains(s) && !cmbDeleteTags.Items.Contains(s))
                    cmbAddTags.Items.Add(s);
            }

            cmbAddTags.SelectedIndex = 0;
            cmbDeleteTags.SelectedIndex = 0;
        }

        // retrieve all tags linked to item from database
        private List<String> loadCurrentTags(int item_ID)
        {
            List<String> tags = new List<String>();
            string[] results;

            dbConnection.Open();

            SqlCommand cmdGetTagInfo = dbConnection.CreateCommand();
            cmdGetTagInfo.CommandText = @"SELECT ITEM_GENRE FROM ITEMS WHERE ITEM_ID = @id";
            cmdGetTagInfo.Parameters.AddWithValue("@id", item_ID);
            SqlDataReader reader = cmdGetTagInfo.ExecuteReader();

            if (reader.Read() && !reader[0].ToString().IsNullOrEmpty())
            {
                results = reader[0].ToString().Split(',');

                foreach (string s in results)
                    tags.Add(s.Trim());
            }

            reader.Close();

            cmdGetTagInfo.CommandText = @"SELECT TAG.TAG_NAME FROM ITEM_TAGS 
                                          JOIN TAG ON ITEM_TAGS.ITEM_TAG_NO = TAG.TAG_NO
                                          WHERE ITEM_TAG_ID = @id";
            reader = cmdGetTagInfo.ExecuteReader();

            while (reader.Read())
                tags.Add(reader[0].ToString().Trim());

            reader.Close();
            cmdGetTagInfo.Dispose();
            dbConnection.Close();

            for (int i = 0; i < tags.Count; i++)
                AddTag(tags[i], i);

            return tags;
        }

        // add specified tag to area in form that shows all of an item's current tags
        private void AddTag(string tagText, int tagTab = -1)
        {
            Label tag = new Label();
            tag.AutoSize = true;
            tag.BackColor = Color.Linen;
            tag.BorderStyle = BorderStyle.FixedSingle;
            tag.Font = new Font("Ebrima", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tag.Padding = new Padding(4);
            tag.Text = tagText;
            if (tagTab != -1)
                tag.TabIndex = tagTab;
            else
            {
                if (flpTags.HasChildren)
                    tag.TabIndex = flpTags.Controls.Count;
                else
                    tag.TabIndex = 0;
            }

            flpTags.Controls.Add(tag);
        }

        // remove specified tag from area in form that shows all of an item's current tags
        private void RemoveTag(string tagText)
        {
            int i = 0;

            // find the index of specified tag
            while (flpTags.Controls[i].Text.ToUpper() != tagText.ToUpper())
                i++;

            flpTags.Controls.RemoveAt(i);
        }

        // removes a tag from one option (either add or delete) and transfers it to the other option
        private void UpdateCmbTags(string tag, bool tagAdded)
        {
            if (tagAdded)
            {
                cmbAddTags.Items.Remove(tag);
                cmbDeleteTags.Items.Add(tag);

                cmbAddTags.SelectedIndex = 0;
            }
            else
            {
                cmbAddTags.Items.Add(tag);
                cmbDeleteTags.Items.Remove(tag);

                cmbDeleteTags.SelectedIndex = 0;
            }
        }

        // retrieves the notes currently saved in database; if new notes were saved, also disables save note button
        private void setOldNotes()
        {
            btnAddNote.Enabled = false;

            for (int i = 0; i < 4; i++)
                oldNotes[i] = GetNoteText(i + 1);
        }

        // determines whether save button should be enabled by if any of the notes are different than the ones saved in the database
        private void textChanged()
        {
            for (int i = 0; i < 4; i++)
            {
                if (txtChanged[i])
                {
                    btnAddNote.Enabled = true;
                    break;
                }
                if (i == 3)
                    btnAddNote.Enabled = false;
            }
        }

        // txtNote1-txtNote4_TextChanged: track whether notes written in form are different than its counterparts in database

        private void txtNote1_TextChanged(object sender, EventArgs e)
        {
            if (txtNote1.Text == oldNotes[0])
                txtChanged[0] = false;
            else
                txtChanged[0] = true;

            textChanged();
        }

        private void txtNote2_TextChanged(object sender, EventArgs e)
        {
            if (txtNote2.Text == oldNotes[1])
                txtChanged[1] = false;
            else
                txtChanged[1] = true;

            textChanged();
        }

        private void txtNote3_TextChanged(object sender, EventArgs e)
        {
            if (txtNote3.Text == oldNotes[2])
                txtChanged[2] = false;
            else
                txtChanged[2] = true;

            textChanged();
        }

        private void txtNote4_TextChanged(object sender, EventArgs e)
        {
            if (txtNote4.Text == oldNotes[3])
                txtChanged[3] = false;
            else
                txtChanged[3] = true;

            textChanged();
        }
    }
}
