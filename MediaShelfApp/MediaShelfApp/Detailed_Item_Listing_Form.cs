﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;

namespace MediaShelfApp
{
    public partial class Detailed_Item_Listing_Form : Form
    {
        // Instance variables:
        // caller   - form which invoked this form
        // itemID   - ID of item intended to be viewed, used for querying 
        private ListView lcaller = null!;
        private SearchResults dcaller = null!;
        private Detailed_Recommendations reccaller = null!;
        private int itemID = 0;


        // Marcel's Stuff
        private string title;
        private string description;
        private string genre;
        private string release_date;
        private string creator;
        private string mediaImageLink;

        // for recommendations form
        private int movieID;
        private bool isMovie = false;

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

        public Detailed_Item_Listing_Form(string item_id)
        {
            InitializeComponent();

            string title;
            string creator;
            string genre;
            string releaseDate;
            string description;
            string mediaImageLink;
            int api_id;


            // Lookup item in sql db via item_id
            SqlConnection conn = new SqlConnection(dbConnectionString);
            conn.Open();


            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM ITEMS WHERE item_id=" + item_id;
            SqlDataReader rd = cmd.ExecuteReader();

            rd.Read();

            if (rd["item_title"].ToString() != null)
            {
                title = rd["item_title"].ToString();
            }
            else
            {
                title = "No Title Provided.";
            }

            // Creator
            if (rd["item_creator"].ToString() != "")
            {
                creator = rd["item_creator"].ToString();
            }
            else
            {
                creator = "No Creator Provided.";
            }

            // Genre
            if (rd["item_genre"].ToString() != "")
            {
                genre = rd["item_genre"].ToString();
            }
            else
            {
                genre = "No Genre Provided.";
            }

            if (rd["item_release_date"].ToString() != "")
            {
                releaseDate = rd["item_release_date"].ToString();
            }
            else
            {
                releaseDate = "No Release Date.";
            }

            if (rd["item_description"].ToString() != "")
            {
                description = rd["item_description"].ToString();
            }
            else
            {
                description = "No Description Provided.";
            }

            // Get API ID
            api_id = int.Parse(rd["item_api"].ToString());

            rd.Dispose();
            conn.Close();

            // Create a DB Flag that hides image when image is not present

            displayData(title, creator, genre, releaseDate, description, "", api_id, 1);
        }

        public Detailed_Item_Listing_Form(string title, string creator, string genre, string release_date, string description, string mediaImageLink, int api_type, int movieID)
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
            this.movieID = movieID; // recommendations form

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
        public void setRecCaller(Detailed_Recommendations reccaller)
        {

            this.reccaller = reccaller;
            if (reccaller != null)
            {
                btnRecommendations.Visible = false;
            }
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
        public static void ScaleImage(string imageUrl, PictureBox pictureBox, int width, int height)
        {
            try
            {
                // Download the image from the URL
                using (WebClient client = new WebClient())
                {
                    using (Stream stream = client.OpenRead(imageUrl))
                    {
                        if (stream != null)
                        {
                            // Load the image from the stream
                            Image originalImage = Image.FromStream(stream);

                            // Scale the image to the desired size
                            Image scaledImage = ScaleImageToSize(originalImage, width, height);

                            // Set the scaled image to the PictureBox
                            pictureBox.Image = scaledImage;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private static Image ScaleImageToSize(Image image, int maxWidth, int maxHeight)
        {
            int newWidth;
            int newHeight;

            // Calculate the new dimensions while preserving the aspect ratio
            if (image.Width > maxWidth || image.Height > maxHeight)
            {
                double aspectRatio = (double)image.Width / image.Height;

                if (image.Width > maxWidth)
                {
                    newWidth = maxWidth;
                    newHeight = (int)(newWidth / aspectRatio);
                }
                else
                {
                    newHeight = maxHeight;
                    newWidth = (int)(newHeight * aspectRatio);
                }
            }
            else
            {
                newWidth = image.Width;
                newHeight = image.Height;
            }

            // Create a new bitmap with the scaled dimensions
            Bitmap scaledBitmap = new Bitmap(newWidth, newHeight);

            // Draw the original image onto the scaled bitmap
            using (Graphics graphics = Graphics.FromImage(scaledBitmap))
            {
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return scaledBitmap;
        }
        private void displayData(string title, string creator, string genre, string releaseDate, string description, string mediaImageLink, int mediaType, int db_flag = 0)
        {
            if (db_flag == 1)
            {
                btnFavorite.Visible = false;
                btnRecommendations.Visible = false;
                cmbAddToList.Visible = false;
            }
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

                    if (db_flag == 0)
                    {
                        ScaleImage(mediaImageLink, pbMovieImage, 250, 250);
                    }

                    this.isMovie = true;

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

                    if (db_flag == 0)
                    {
                        pbBookImage.ImageLocation = mediaImageLink;
                    }

                    break;

                case 2: // Add Music Data To Detailed Item Listing Form
                    lblTitle.Text = title;
                    lblCreatorTitle.Text = "Artist:";
                    lblGenreTitle.Text = "Album:";
                    lblReleaseDateTitle.Text = "Release Date:";


                    lblTitle.Text = title;
                    lblCreatorValue.Text = creator;
                    lblGenreValue.Text = genre;
                    lblReleaseDateValue.Text = releaseDate;
                    lblDescriptionTitle.Visible = false;
                    txtDescriptionValue.Visible = false;


                    pbMovieImage.Visible = false;
                    pbGameImage.Visible = false;
                    pbBookImage.Visible = false;
                    pbMusicImage.Visible = true;

                    if (db_flag == 0)
                    {
                        pbMusicImage.ImageLocation = mediaImageLink;
                    }

                    break;
                case 3:
                case 4:
                    // Add Games Data To Detailed Item Listing Form
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


                    if (db_flag == 0)
                    {
                        pbGameImage.ImageLocation = mediaImageLink;
                    }

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

                // Assign API ID
                System.Int32 api_id = 0;
                switch (lblCreatorTitle.Text)
                {
                    case "Runtime:":
                        api_id = 1;
                        break;
                    case "Author:":
                        api_id = 2;
                        break;
                    case "Artist:":
                        api_id = 3;
                        break;
                    case "Platform:":
                        api_id = 4;
                        break;
                    default:
                        break;
                }

                try
                {
                    dbConnect.Open();
                    SqlCommand cmd = dbConnect.CreateCommand();
                    cmd.CommandText = "INSERT INTO ITEMS VALUES (@item_api,@item_media_type,@item_title,@item_creator,@item_release_date,@image_data,@item_description,@item_list_id,@item_genre)";
                    cmd.Parameters.AddWithValue("@item_api", api_id);
                    cmd.Parameters.AddWithValue("@item_media_type", 1);
                    cmd.Parameters.AddWithValue("@item_title", lblTitle.Text);
                    cmd.Parameters.AddWithValue("@item_creator", lblCreatorValue.Text);
                    cmd.Parameters.AddWithValue("@item_release_date", lblReleaseDateValue.Text);
                    cmd.Parameters.AddWithValue("@item_description", txtDescriptionValue.Text);
                    cmd.Parameters.AddWithValue("@item_list_id", list_index);
                    cmd.Parameters.AddWithValue("@item_genre", lblGenreValue.Text);

                    byte[] imageData = null;

                    switch (api_id)
                    {
                        case 1:
                            imageData = PrepareImageForDatabase(pbMovieImage);
                            break;
                        case 2:
                            imageData = PrepareImageForDatabase(pbBookImage);
                            break;
                        case 3:
                            imageData = PrepareImageForDatabase(pbMusicImage);
                            break;
                        case 4:
                            imageData = PrepareImageForDatabase(pbGameImage);
                            break;
                        default:
                            break;
                    }
                    // Save Media Image
                    cmd.Parameters.AddWithValue("@image_data", imageData);

                    // Execute DB Write
                    cmd.ExecuteNonQuery();

                    // Show Confirmation Message
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
        private void openRecommendationsForm()
        {

            Detailed_Recommendations window = new Detailed_Recommendations(movieID);
            window.setCaller(this);
            window.setPrevCaller(dcaller);
            this.Hide();
            window.Show();

        }
        private void btnRecommendations_Click(object sender, EventArgs e)
        {
            openRecommendationsForm();
        }
        private void Detailed_Item_Listing_Form_Load(object sender, EventArgs e)
        {
            if (isMovie == false)
            {
                btnRecommendations.Visible = false;
            }
        }
        public byte[] PrepareImageForDatabase(PictureBox pictureBox)
        {

            // Retrieve the image from the picture box
            Image image = pictureBox.Image;

            byte[] imageData;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = ms.ToArray();
            }
            return imageData;
        }

    }
}
