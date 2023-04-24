using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MediaShelfApp.SearchResults;

namespace MediaShelfApp
{
    public partial class DiscoveryPageForm : Form
    {
        /*
        private string title;
        private string genre;
        private string mediaImageLink;
        */

        public DiscoveryPageForm()//string title, string creator, string genre, string release_date, string description, string mediaImageLink, int api_type)
        {
            InitializeComponent();

            // Initiate Database Connection
            try
            {
                SqlConnection dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db1;Persist Security Info=True;User ID=;Password=");
                dbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            /*
            this.title = title;
            this.genre = genre;
            this.mediaImageLink = mediaImageLink;

            displayData(title, genre, mediaImageLink, api_type);
            */


        }


        /*
        public DiscoveryPageForm()
        {
        }

        private void displayData(string title, string genre, string mediaImageLink, int mediaType)
        {

            switch (mediaType)
            {

                case 0:

                    label4.Text = title;
                    label5.Text = title;
                    label17.Text = title;
                    label12.Text = title;
                    label19.Text = title;
                    label21.Text = title;

                    //lblGenreValue.Text = genre;


                    pictureBox1.ImageLocation = mediaImageLink;
                    pictureBox1.Size = new System.Drawing.Size(104, 106);

                    break;
                case 1:

                    // Modify Labels on Form for Books
                    label4.Text = title;
                    label5.Text = title;
                    label17.Text = title;
                    label12.Text = title;
                    label19.Text = title;
                    label21.Text = title;
                    //lblGenreTitle.Text = "Publisher:";


                    label4.Text = title;
                    label5.Text = title;
                    label17.Text = title;
                    label12.Text = title;
                    label19.Text = title;
                    label21.Text = title;
                    //lblGenreValue.Text = genre;


                    pictureBox1.ImageLocation = mediaImageLink;
                    pictureBox1.Size = new System.Drawing.Size(104, 106);

                    break;
                case 2:
                    // Modify Labels on Form for Books
                    label4.Text = title;
                    label5.Text = title;
                    label17.Text = title;
                    label12.Text = title;
                    label19.Text = title;
                    label21.Text = title;
                    //lblGenreTitle.Text = "Album:";


                    label4.Text = title;
                    label5.Text = title;
                    label17.Text = title;
                    label12.Text = title;
                    label19.Text = title;
                    label21.Text = title;
                    //lblGenreValue.Text = genre;


                    pictureBox1.ImageLocation = mediaImageLink;
                    pictureBox1.Size = new System.Drawing.Size(104, 106);
                    break;
                case 3:

                    label4.Text = title;
                    label5.Text = title;
                    label17.Text = title;
                    label12.Text = title;
                    label19.Text = title;
                    label21.Text = title;
                    //lblGenreValue.Text = genre;


                    pictureBox1.ImageLocation = mediaImageLink;
                    pictureBox1.Size = new System.Drawing.Size(104, 106);
                    break;
                default:
                    break;

            }
        }
        */





        private void DiscoveryPageForm_Load(object sender, EventArgs e)
        {

        }

        //Media Shelf Title
        private void lblTopName(object sender, EventArgs e)
        {
        }

        //Music Square
        private void btnMusic(object sender, EventArgs e)
        {
            //SearchResults window = new SearchResults("Music", this);
            //window.Show();
        }

        //Movies Square
        private void btnMovies(object sender, EventArgs e)
        {
            //SearchResults window = new SearchResults("Movies", this);
            //window.Show();
        }

        //Shows Square
        private void btnTVShows(object sender, EventArgs e)
        {
            //SearchResults window = new SearchResults("Shows", this);
            //window.Show();
        }

        //Book Square
        private void btnBooks(object sender, EventArgs e)
        {
            //SearchResults window = new SearchResults("Books", this);
            //window.Show();
        }

        //Games square
        private void btnGames(object sender, EventArgs e)
        {
            //SearchResults window = new SearchResults("Games", this);
            //window.Show();
        }

        //Search Bar
        // Search button functionality - Hides this form as the caller, opens new instance of search form
        //                               with search parameter set as text from the search box
        private void btnSearchBar(object sender, EventArgs e)
        {
            this.Hide();
            SearchResults window = new SearchResults();
            window.setCaller(this);
            window.setSearchText("Test"); // Text pulled from search box will go here
            window.Show();
        }


        //==================================================================
        //Recommendations Header
        
        //Based on your... info
        
        //Other titles with TAG
        

        //Recommendation #1 picture
        

        //Recommendation #1 Title 
        
        //Recommendation #1 Tag Label
        
        //Recommendation #1 TAG


        //Recommendation #2 Picture


        ////Recommendation #2 Title


        //Recommendation #2 Tag Label


        //Recommendation #2 TAG


        //Recommendation #3 Picture


        //Recommendation #3 Title


        //Recommendation #3 Tag Label
 

        //Recommendation #3 TAG
       

        //Recommendation #4 Picture
       

        //Recommendation #4 Title
        

        //Recommendation #4 Tag Label
        

        //Recommendation #4 TAG
        

        //Recommendation #5 Picture
       

        //Recommendation #5 Title
       

        //Recommendation #5 Tag Label
        

        //Recommendation #5 TAG
       


        //Recommendation #6 Picture
       

        //Recommendation #6 Title
        

        //Recommendation #6 Tag Label
        

        //Recommendation #6 TAG
        

        //See More Recommendations
        // See More button functionality - Hides this form as the caller, opens detailed recommendations form
     

        //==========================================================================
        //List Header
        private void lblListHeader(object sender, EventArgs e)
        {
            //ListView window = new ListView();
            //window.Show();
        }

        //Favorites List
        private void lblFavoritesList(object sender, EventArgs e)
        {
            ListView window = new ListView("Favorites", this);
            window.Show();
        }
        //Favorites List Description
        private void lblFavoritesDescription(object sender, EventArgs e)
        {

        }

        //Wishlist List 
        private void lblWishlistList(object sender, EventArgs e)
        {
            ListView window = new ListView("Wishlist", this);
            window.Show();
        }

        //Withlist Decription
        private void lblWishlistDescription(object sender, EventArgs e)
        {

        }

        //Manual Entries List
        private void label9_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Manual Entries", this);
            window.Show();
        }

        //Manual Entries Description
        private void label23_Click(object sender, EventArgs e)
        {

        }

        //List #2
        private void label8_Click(object sender, EventArgs e)
        {

        }

        //List #2 Description
        private void label15_Click(object sender, EventArgs e)
        {

        }


        //List #3
        private void label7_Click(object sender, EventArgs e)
        {

        }

        //List #3 Description
        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
