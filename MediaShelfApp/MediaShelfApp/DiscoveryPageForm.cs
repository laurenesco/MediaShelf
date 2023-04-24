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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchResults window = new SearchResults();
            window.setCaller(this);
            window.Show();
        }

        private void lblFavoritesList_Click_1(object sender, EventArgs e)
        {
            ListView window = new ListView("Favorites", this);
            window.Show();
        }

        private void lblWishlist_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Wishlist", this);
            window.Show();
        }

        private void lblTags_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Tags", this);
            window.Show();
        }

        private void lblManualEntries_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Manual Entries", this);
            window.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Books", this);
            window.Show();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Movies", this);
            window.Show();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Games", this);
            window.Show();
        }

        private void btnTVShows_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Movies", this);
            window.Show();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Music", this);
            window.Show();
        }
    }
}
