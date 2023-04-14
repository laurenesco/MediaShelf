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
        private void lblRecommendations(object sender, EventArgs e)
        {
            this.Hide();
            Detailed_Recommendations window = new Detailed_Recommendations();
            window.setCaller(this);
            window.Show();
        }
        //Based on your... info
        private void lblBasedOnYourInfo(object sender, EventArgs e)
        {
        }
        //Other titles with TAG
        private void lblOtherTitlesWithTag(object sender, EventArgs e)
        {
        }

        //Recommendation #1 picture
        private void picBox1(object sender, EventArgs e)
        {
        }

        //Recommendation #1 Title 
        private void lblTitle1(object sender, EventArgs e)
        {

        }
        //Recommendation #1 Tag Label
        private void label10_Click(object sender, EventArgs e)
        {

        }
        //Recommendation #1 TAG
        private void btnTag1(object sender, EventArgs e)
        {

        }


        //Recommendation #2 Picture
        private void picBox2(object sender, EventArgs e)
        {

        }

        ////Recommendation #2 Title
        private void lblTitle2(object sender, EventArgs e)
        {

        }

        //Recommendation #2 Tag Label
        private void label11_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #2 TAG
        private void btnTag2(object sender, EventArgs e)
        {

        }


        //Recommendation #3 Picture
        private void picBox3(object sender, EventArgs e)
        {

        }

        //Recommendation #3 Title
        private void lblTitle3(object sender, EventArgs e)
        {

        }

        //Recommendation #3 Tag Label
        private void label16_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #3 TAG
        private void btnTag3(object sender, EventArgs e)
        {

        }

        //Recommendation #4 Picture
        private void picBox4(object sender, EventArgs e)
        {

        }

        //Recommendation #4 Title
        private void lblTitle4(object sender, EventArgs e)
        {

        }

        //Recommendation #4 Tag Label
        private void label6_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #4 TAG
        private void btnTag4(object sender, EventArgs e)
        {

        }

        //Recommendation #5 Picture
        private void picBox5(object sender, EventArgs e)
        {

        }

        //Recommendation #5 Title
        private void lblTitle5(object sender, EventArgs e)
        {

        }

        //Recommendation #5 Tag Label
        private void label18_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #5 TAG
        private void btnTag5(object sender, EventArgs e)
        {

        }


        //Recommendation #6 Picture
        private void picBox6(object sender, EventArgs e)
        {

        }

        //Recommendation #6 Title
        private void lblTitle6(object sender, EventArgs e)
        {

        }

        //Recommendation #6 Tag Label
        private void label20_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #6 TAG
        private void btnTag6(object sender, EventArgs e)
        {

        }

        //See More Recommendations
        // See More button functionality - Hides this form as the caller, opens detailed recommendations form
        private void btnSeeMoreRecommendations(object sender, EventArgs e)
        {
            this.Hide();
            Detailed_Recommendations window = new Detailed_Recommendations();
            window.setCaller(this);
            window.Show();
        }

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
