using Microsoft.Data.SqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        /*
         *  to maybe be added later
            private int colorSelection;
            private float fontSizeSelection;
        */

        //////////////////////
        //  Public methods  //
        //////////////////////

        // Constructor
        public Manual_Entry_Form(string list, ListView caller)
        {
            InitializeComponent();

            this.list = list;
            this.caller = caller;

            if (list == "Tags")
            {
                TagElements();
            }

            // Initiate Database Connection
            dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db2;Persist Security Info=True;User ID=mediaalt;Password=wehkun-7jYcnu-zidjaz");
        }

        ///////////////////////
        //  Private methods  //
        ///////////////////////


        private void TagElements()
        {
            foreach (Control c in this.Controls)
            {
                c.Visible = false;
            }

            this.btnBackButton.Visible = true;
            this.btnAddButton.Visible = true;
            this.lblTagName.Visible = true;
            this.txtTagName.Visible = true;
            this.lblAddTag.Visible = true;
        }

        //refreshes Manual Entry Form
        private void ClearFields()
        {
            txtCreator.Clear();
            dtpReleaseDate.Value = DateTime.Today;
            txtTitle.Clear();
            txtTags.Clear();
            txtCreator.Clear();
            txtDescriptionText.Clear();
            picboxImage.BackColor = Color.White;
            picboxImage.BackgroundImage = MediaShelfApp.Properties.Resources.uploadImagePrompt;
            picboxImage.Image = null;
        }

        //adds user-made manual entry to database
        private void SaveManualEntry()
        {
            try
            {
                // Declaring all form variables that may be used in the query (to later be validated)
                String title = txtTitle.Text;
                String creator = txtCreator.Text;
                String genre = txtTags.Text;
                String description = txtDescriptionText.Text;
                DateTime releaseDate = dtpReleaseDate.Value;
                int listID = getListID(list);
                Byte[]? icon;

                //gets byte[] of uploaded image, if available
                if (picboxImage.Image != null)
                {
                    FileStream iconFile = new FileStream(picboxImage.ImageLocation, FileMode.Open, FileAccess.Read);
                    icon = new Byte[iconFile.Length];
                    iconFile.Read(icon, 0, Convert.ToInt32(iconFile.Length));
                    iconFile.Close();
                }
                else
                    icon = null;

                // Open connection and create command
                dbConnection.Open();
                SqlCommand cmdInsertMedia = dbConnection.CreateCommand();

                // Construct insertion query when user uploads an image
                if (icon != null)
                    cmdInsertMedia.CommandText = @"INSERT INTO ITEMS 
                                                   (ITEM_API,
                                                   ITEM_MEDIA_TYPE,
                                                   ITEM_TITLE,
                                                   ITEM_CREATOR,   
                                                   ITEM_RELEASE_DATE,
                                                   ITEM_ICON,
                                                   ITEM_DESCRIPTION,
                                                   ITEM_LIST_ID,
                                                   ITEM_GENRE)
                                                   VALUES(@api, @type, @title, @creator, @date, @icon, @desc, @list, @genre)";
                else //construct insertion query when user doesn't upload an image
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
                if (icon != null)
                    cmdInsertMedia.Parameters.AddWithValue("@icon", icon);
                cmdInsertMedia.Parameters.AddWithValue("@desc", description);
                cmdInsertMedia.Parameters.AddWithValue("@list", listID);
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

        private int getListID(String name)
        {
            int ID = 0;

            // Try query
            try
            {
                // Open database connection
                dbConnection.Open();
                SqlCommand cmdGetListInfo = dbConnection.CreateCommand();

                // Construct insertion query
                cmdGetListInfo.CommandText = @"SELECT LIST_ID
                                               FROM LIST
                                               WHERE LIST_NAME = @bind1";

                // Parameterize the variables for system security
                cmdGetListInfo.Parameters.AddWithValue("@bind1", list);

                // Execute and read the data
                SqlDataReader reader = cmdGetListInfo.ExecuteReader();

                // Assign result to ID variable
                if (reader.Read())
                {
                    ID = Convert.ToInt32(reader[0]);
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

            return ID;
        }

        //enables user to upload an image for manual entry
        private void picboxImage_Click(object sender, EventArgs e)
        {
            string imagePath = "";

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;

                picboxImage.ImageLocation = imagePath;
                picboxImage.BackgroundImage = null;
                picboxImage.BackColor = Color.Transparent;
            }
        }

        // Save a tag 
        private void SaveTag()
        {
            try
            {
                string tagName = txtTagName.Text;

                // Open connection and create command
                dbConnection.Open();
                SqlCommand cmdInsertTag = dbConnection.CreateCommand();

                // Construct insertion query 
                cmdInsertTag.CommandText = @"INSERT INTO TAG 
                                                (TAG_NAME)
                                                VALUES(@bind1)";

                cmdInsertTag.Parameters.AddWithValue("@bind1", tagName);

                // Execute the insertion query
                cmdInsertTag.ExecuteNonQuery();

                // Close connection and dispose of the command
                dbConnection.Close();
                cmdInsertTag.Dispose();

                // Confirmation message
                MessageBox.Show("Tag created!\n", "Confirmation Message", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Add button functionality - saves user-made manual entry
        private void btnAddButton_Click(object sender, EventArgs e)
        {
            if (list == "Tags")
            {
                SaveTag();
            }
            else
            {
                // Instance variable: isEmpty - bool representing whether title field is empty
                bool isEmpty = true;

                //checks that title text field isn't empty/full of white-space
                foreach (char c in txtTitle.Text)
                {
                    if (c != ' ')
                    {
                        isEmpty = false;
                        break;
                    }
                }

                //if title field is empty, informs user to correct that; else, proceeds to save manual entry
                if (isEmpty)
                {
                    MessageBox.Show("Title field cannot be empty. Please enter a title.");
                }
                else
                {
                    SaveManualEntry();
                    this.ClearFields();
                }
            }
        }

        // Back button functionality - reopens calling form with refreshed data grid
        private void btnNavBack_Click(object sender, EventArgs e)
        {
            if (list == "Tags")
            {
                caller.PopulateTagsTable("");
            }
            else
            {
                caller.PopulateDataTable("");
            }
            caller.Show();
            this.Close();
        }
    }
}
