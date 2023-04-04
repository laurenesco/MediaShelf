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

        /*
         * to maybe be added later
         * load methods might be simplified later
         
        //enables access for developers to settings file without setting path themselves; might be able to add to Resources.resx
        public string getSettingsFileLocation()
        {
            string path = "";
            path += Environment.CurrentDirectory;
            path = path.Substring(0, path.LastIndexOf("bin"));
            path += "\\Resources\\settings.txt";

            return path;
        }

        //get colorSelection method - this variable determines which color scheme should be used throughout app
        public int getColorSelection()
        {
            return colorSelection;
        }
        //get fontSizeSelection method - this variable determines which font size should be used throughout app
        public float getFontSizeSelection()
        {
            return fontSizeSelection;
        }
        //reads info (what color and font size to use) contained in settings file and updates variables colorSelection and fontSizeSelection
        public void readSettings()
        {
            string path = getSettingsFileLocation();

            string[] settings = System.IO.File.ReadAllLines(path);

            colorSelection = int.Parse(Regex.Match(settings[0], @"\d+").Value);
            fontSizeSelection = float.Parse(Regex.Match(settings[1], @"\d+").Value);
        }
        //updates info (what color and font size to use) in settings file
        public void saveSettings()
        {
            string path = getSettingsFileLocation();

            string[] settings = new string[2];

            settings[0] = "color=" + colorSelection;
            settings[1] = "fontsize=" + fontSizeSelection;

            System.IO.File.WriteAllLines(path, settings);
        }
        //set method for colorSelection - assumed use in MyShelfForm
        public void setColorSelection(int c)
        {
            colorSelection = c;
        }
        //set method for fontSizeSelection - assumed use in MyShelfForm
        public void setFontSizeSelection(float f) 
        {
            fontSizeSelection = f;
        }
        \*
         *  FOR DEVELOPERS:
         *  if user were to select a setting, this is what it might look like:
            public void radioButtonChecked()
            {
                ____Selection = #;
                saveSettings();
            }
        *\

        //sets colors of controllers in Manual Entry Form if color option in settings is 1 (colorSelection = 1) - EXAMPLE
        public void loadColorSelection1()
        {
            //
            // btnBackButton
            //
            this.btnBackButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            //
            // btnAddButton
            //
            this.btnAddButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // Manual_Entry_Form
            // 
            this.BackColor = System.Drawing.Color.White;
        }
        //sets colors of controllers in Manual Entry Form if color option in settings is 2 (colorSelection = 2) EXAMPLE
        public void loadColorSelection2()
        {
            //
            // btnBackButton
            //
            this.btnBackButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            //
            // btnAddButton
            //
            this.btnAddButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // Manual_Entry_Form
            // 
            this.BackColor = System.Drawing.Color.White;
        }
        //sets colors of controllers in Manual Entry Form if color option in settings is 3 (colorSelection = 3) - EXAMPLE
        public void loadColorSelection3()
        {
            //
            // btnBackButton
            //
            this.btnBackButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            //
            // btnAddButton
            //
            this.btnAddButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // Manual_Entry_Form
            // 
            this.BackColor = System.Drawing.Color.White;
        }
        //sets fonts and locations of controllers in Manual Entry Form if font size in settings is 9 (fontSizeSelection = 9F)
        public void loadFontSize9()
        {
            // 
            // btnBackButton
            // 
            this.btnBackButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // lblManualEntry
            // 
            this.lblManualEntry.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManualEntry.Location = new System.Drawing.Point(441, 24);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(418, 115);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(474, 113);
            // 
            // lblCreator
            // 
            this.lblCreator.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreator.Location = new System.Drawing.Point(392, 155);
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(412, 195);
            // 
            // lblTags
            // 
            this.lblTags.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTags.Location = new System.Drawing.Point(360, 235);
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReleaseDate.Location = new System.Drawing.Point(349, 277);
            // 
            // txtCreator
            // 
            this.txtCreator.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCreator.Location = new System.Drawing.Point(474, 153);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtType.Location = new System.Drawing.Point(474, 193);
            // 
            // txtTags
            // 
            this.txtTags.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTags.Location = new System.Drawing.Point(474, 233);
            // 
            // dateReleaseDate
            // 
            this.dateReleaseDate.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateReleaseDate.Location = new System.Drawing.Point(474, 273);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(51, 336);
            // 
            // txtDescriptionText
            // 
            this.txtDescriptionText.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescriptionText.Location = new System.Drawing.Point(58, 365);
            // 
            // btnAddButton
            // 
            this.btnAddButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
        //sets fonts and locations of controllers in Manual Entry Form if font size in settings is 10 (fontSizeSelection = 10F)
        public void loadFontSize10()
        {
            // 
            // btnBackButton
            // 
            this.btnBackButton.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // lblManualEntry
            // 
            this.lblManualEntry.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManualEntry.Location = new System.Drawing.Point(441, 24);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(417, 104);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(474, 103);
            // 
            // lblCreator
            // 
            this.lblCreator.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreator.Location = new System.Drawing.Point(389, 145);
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(412, 189);
            // 
            // lblTags
            // 
            this.lblTags.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTags.Location = new System.Drawing.Point(355, 231);
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReleaseDate.Location = new System.Drawing.Point(344, 275);
            // 
            // txtCreator
            // 
            this.txtCreator.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCreator.Location = new System.Drawing.Point(474, 146);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtType.Location = new System.Drawing.Point(474, 189);
            // 
            // txtTags
            // 
            this.txtTags.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTags.Location = new System.Drawing.Point(474, 232);
            // 
            // dateReleaseDate
            // 
            this.dateReleaseDate.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateReleaseDate.Location = new System.Drawing.Point(474, 275);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(51, 336);
            // 
            // txtDescriptionText
            // 
            this.txtDescriptionText.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescriptionText.Location = new System.Drawing.Point(58, 365);
            // 
            // btnAddButton
            // 
            this.btnAddButton.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
        //sets fonts and locations of controllers in Manual Entry Form if font size in settings is 12 (fontSizeSelection = 12F)
        public void loadFontSize12()
        {
            // 
            // btnBackButton
            // 
            this.btnBackButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // lblManualEntry
            // 
            this.lblManualEntry.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManualEntry.Location = new System.Drawing.Point(441, 24);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(407, 91);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(474, 90);
            // 
            // lblCreator
            // 
            this.lblCreator.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreator.Location = new System.Drawing.Point(374, 139);
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(400, 188);
            // 
            // lblTags
            // 
            this.lblTags.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTags.Location = new System.Drawing.Point(330, 235);
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReleaseDate.Location = new System.Drawing.Point(314, 286);
            // 
            // txtCreator
            // 
            this.txtCreator.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCreator.Location = new System.Drawing.Point(474, 138);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtType.Location = new System.Drawing.Point(474, 186);
            // 
            // txtTags
            // 
            this.txtTags.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTags.Location = new System.Drawing.Point(474, 234);
            // 
            // dateReleaseDate
            // 
            this.dateReleaseDate.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateReleaseDate.Location = new System.Drawing.Point(474, 282);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(51, 336);
            // 
            // txtDescriptionText
            // 
            this.txtDescriptionText.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescriptionText.Location = new System.Drawing.Point(58, 372);
            // 
            // btnAddButton
            // 
            this.btnAddButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
        */

        ///////////////////////
        //  Private methods  //
        ///////////////////////

        // Add button functionality - saves user-made manual entry
        private void ME_addButton_Click(object sender, EventArgs e)
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

        // Back button functionality - reopens calling form with refreshed data grid
        private void btnNavBack_Click(object sender, EventArgs e)
        {
            caller.PopulateDataTable("");
            caller.Show();
            this.Close();
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

        private void Manual_Entry_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
