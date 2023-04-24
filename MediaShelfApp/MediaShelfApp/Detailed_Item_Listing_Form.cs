using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaShelfApp
{
    public partial class Detailed_Item_Listing_Form : Form
    {
        // Instance variables:
        // caller   - form which invoked this form
        // itemID   - ID of item intended to be viewed, used for querying 
        private ListView lcaller = null!;
        private SearchResults dcaller = null!;
        private int itemID = 0;


        // Marcel's Stuff
        private string title;
        private string description;
        private string genre;
        private string release_date;
        private string creator;
        private string mediaImageLink;

        private string dbConnectionString = @"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db2;Persist Security Info=True;User ID= mediaalt;Password=wehkun-7jYcnu-zidjaz";

        //////////////////////
        //  Public methods  //
        //////////////////////

        // ============================================================================================================================================================
        // ============================================================================================================================================================

        // Constructors
        public Detailed_Item_Listing_Form()
        {
            InitializeComponent();

            // Initiate Database Connection
            try
            {
                SqlConnection dbConnection = new SqlConnection(dbConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public Detailed_Item_Listing_Form(string title, string creator, string genre, string release_date, string description, string mediaImageLink, int api_type)
        {
            InitializeComponent();


            // Initiate Database Connection
            try
            {
                SqlConnection dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db2;Persist Security Info=True;User ID= mediaalt;Password=wehkun-7jYcnu-zidjaz");
                fillListBox(dbConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.title = title;
            this.creator = creator;
            this.genre = genre;
            this.release_date = release_date;
            this.description = description;
            this.mediaImageLink = mediaImageLink;

            displayData(title, creator, genre, release_date, description, mediaImageLink, api_type);
        }

        // ============================================================================================================================================================
        // ============================================================================================================================================================

        private void fillListBox(SqlConnection dbConnection)
        {
            SqlCommand cmd = dbConnection.CreateCommand();
            dbConnection.Open();
            cmd.CommandText = "SELECT list_name FROM LIST";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cmbAddToList.Items.Add(reader.GetString(0));
            }

            cmbAddToList.Text = "Favorites";

            dbConnection.Close();
        }

        // Set caller method - this variable allows the back button to reopen the calling form
        public void setCaller(ListView lcaller)
        {
            this.lcaller = lcaller;
        }

        public void setCaller(SearchResults dcaller)
        {
            this.dcaller = dcaller;
        }

        // Set itemID method - this variable allows the form to display the correct item
        public void setItemID(int id)
        {
            this.itemID = id;
        }

        ///////////////////////
        //  Private methods  //
        ///////////////////////

        // Back button functionality - reopens calling form, closes this form
        private void btnNavBack_Click(object sender, EventArgs e)
        {
            if (dcaller != null)
            {
                this.Hide();
                dcaller.Show();

            }
            else
            {
                this.Hide();
                lcaller.Show();
            }
        }


        private void displayData(string title, string creator, string genre, string releaseDate, string description, string mediaImageLink, int mediaType)
        {

            switch (mediaType)
            {

                case 0: // Add Movie Data To Detailed Item Listing Form
                    lblTitle.Text = title;
                    lblCreatorTitle.Text = "Runtime:";
                    lblCreatorValue.Text = creator;
                    lblGenreValue.Text = genre;
                    lblReleaseDateValue.Text = releaseDate;
                    txtDescriptionValue.Text = description;

                    pbGameImage.Visible = false;
                    pbBookImage.Visible = false;
                    pbMovieImage.Visible = true;
                    pbMovieImage.ImageLocation = mediaImageLink;
                    pbMovieImage.Size = new System.Drawing.Size(369, 369);
                    break;

                case 1: // Add Book Data To Detailed Item Listing Form
                    lblTitle.Text = title;
                    lblCreatorTitle.Text = "Author:";
                    lblGenreTitle.Text = "Publisher:";
                    lblReleaseDateTitle.Text = "Release Date:";


                    lblTitle.Text = title;
                    lblCreatorValue.Text = creator;
                    lblGenreValue.Text = genre;
                    lblReleaseDateValue.Text = releaseDate;
                    txtDescriptionValue.Text = description;


                    pbMovieImage.Visible = false;
                    pbGameImage.Visible = false;
                    pbBookImage.Visible = true;
                    pbBookImage.ImageLocation = mediaImageLink;
                    break;

                case 2: // Add Music Data To Detailed Item Listing Form
                    lblTitle.Text = title;
                    lblCreatorTitle.Text = "Artist:";
                    lblGenreTitle.Text = "Album:";
                    lblReleaseDateTitle.Text = "Duration:";


                    lblTitle.Text = title;
                    lblCreatorValue.Text = creator;
                    lblGenreValue.Text = genre;
                    lblReleaseDateValue.Text = releaseDate;
                    txtDescriptionValue.Text = description;


                    pbMovieImage.Visible = false;
                    pbGameImage.Visible = false;
                    pbBookImage.Visible = false;
                    pbMusicImage.Visible = true;

                    pbMusicImage.ImageLocation = mediaImageLink;
                    break;

                case 3: // Add Games Data To Detailed Item Listing Form
                    lblCreatorTitle.Text = "Platform:";
                    lblDescriptionTitle.Text = "";

                    lblTitle.Text = title;
                    lblCreatorValue.Text = creator;
                    lblGenreValue.Text = genre;
                    lblReleaseDateValue.Text = releaseDate;
                    txtDescriptionValue.Text = description;

                    pbMovieImage.Visible = false;
                    pbMusicImage.Visible = false;
                    pbBookImage.Visible = false;
                    pbGameImage.Visible = true;
                    pbGameImage.ImageLocation = mediaImageLink;
                    break;

                default:
                    break;
            }


        }
        private void btnFavorite_Click(object sender, EventArgs e)
        {
            int list_index = cmbAddToList.SelectedIndex;
            SqlConnection dbConnect = new SqlConnection(dbConnectionString);

            if (list_index == -1)
            {
                MessageBox.Show("Please select a list to favorite item to.", "Error");
            }
            else
            {

                try
                {
                    dbConnect.Open();
                    SqlCommand cmd = dbConnect.CreateCommand();
                    cmd.CommandText = "INSERT INTO ITEMS VALUES (@item_api,@item_media_type,@item_title,@item_creator,@item_release_date,NULL,@item_description,@item_list_id,@item_genre)";
                    cmd.Parameters.AddWithValue("@item_api", 0);
                    cmd.Parameters.AddWithValue("@item_media_type", 1);
                    cmd.Parameters.AddWithValue("@item_title", lblTitle.Text);
                    cmd.Parameters.AddWithValue("@item_creator", lblCreatorValue.Text);
                    cmd.Parameters.AddWithValue("@item_release_date", lblReleaseDateValue.Text);
                    //cmd.Parameters.AddWithValue("@item_icon", picMediaImage.Image);
                    cmd.Parameters.AddWithValue("@item_description", txtDescriptionValue.Text);
                    cmd.Parameters.AddWithValue("@item_list_id", list_index);
                    cmd.Parameters.AddWithValue("@item_genre", lblGenreValue.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item saved to " + cmbAddToList.Text, "Save Confirmed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                dbConnect.Close();
            }
        }

        private void moveLabelsVerticalPosition(int y)
        {
            Label[] labels = { lblCreatorTitle, lblGenreTitle, lblReleaseDateTitle, lblCreatorValue, lblGenreValue, lblReleaseDateValue };

            foreach (Label currentLabel in labels)
            {
                currentLabel.Location = new Point(currentLabel.Location.X, currentLabel.Location.Y + y);
            }
        }

        private void lblTitle_TextChanged(object sender, EventArgs e)
        {

            // The purpose of this function is to resize elements of the screen if the Title
            // is to large to fit within its control.

            if (lblTitle.Text.Length > 50)
            {
                // IF lblTitle LENGTH IS MORE THAN 50 CHARACTERS IN TITLE SET FONT SIZE TO 16
                lblTitle.Font = new Font("Segoe UI", 16);
            }
            else if (lblTitle.Text.Length > 45 && lblTitle.Text.Length <= 50)
            {
                // IF lblTitle LENGTH is between 45 and 50 CHARACTERS IN TITLE SET FONT SIZE TO 19
                lblTitle.Font = new Font("Segoe UI", 19);
            }
            else if (lblTitle.Text.Length > 20 && lblTitle.Text.Length <= 45)
            {
                // IF lblTitle LENGTH is between 20 and 45 CHARACTERS
                // ADJUST LABEL SPACING AND VALUE LOCATIONS
                lblDescriptionTitle.Location = new Point(lblDescriptionTitle.Location.X, lblDescriptionTitle.Location.Y + 20);
                txtDescriptionValue.Size = new Size(txtDescriptionValue.Size.Width, txtDescriptionValue.Size.Height - 20);
                txtDescriptionValue.Location = new Point(txtDescriptionValue.Location.X, txtDescriptionValue.Location.Y + 20);
                moveLabelsVerticalPosition(30);
            }
            else
            {
                // IF NONE OF THE ABOVE MOVE ALL LABELS UP 30 POINTS
                moveLabelsVerticalPosition(-30);
            }

            txtDescriptionValue.Size = new Size(txtDescriptionValue.Size.Width, txtDescriptionValue.Size.Height);


        }
    }
}
