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

namespace MediaShelfApp
{
    public partial class DiscoveryPageForm : Form
    {
        public DiscoveryPageForm()
        {
            InitializeComponent();
        }

        //Search Bar Button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchResults window = new SearchResults();
            window.setCaller(this);
            window.Show();
        }

        //Favorites List
        private void lblFavoritesList_Click_1(object sender, EventArgs e)
        {
            ListView window = new ListView("Favorites", this);
            window.Show();
        }

        //Wishlist List
        private void lblWishlist_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Wishlist", this);
            window.Show();
        }

        //Tags List
        private void lblTags_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Tags", this);
            window.Show();
        }

        //Manual Entries List
        private void lblManualEntries_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Manual Entries", this);
            window.Show();
        }

        //Books Button
        private void btnBooks_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Books", this);
            window.Show();
        }

        //Movies Button
        private void btnMovies_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Movies", this);
            window.Show();
        }

        //Games Button
        private void btnGames_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Games", this);
            window.Show();
        }

        //TV Shows Button
        private void btnTVShows_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("TV Shows", this);
            window.Show();
        }

        //Music Button
        private void btnMusic_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Music", this);
            window.Show();
        }
    }
}
