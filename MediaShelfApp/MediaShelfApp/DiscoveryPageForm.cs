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
        public DiscoveryPageForm()
        {
            InitializeComponent();

            // Initiate Database Connection
            try
            {
                SqlConnection dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db2;Persist Security Info=True;User ID= mediaalt;Password=wehkun-7jYcnu-zidjaz");
                dbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

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
    }
}
