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

        private void btnNavTempMyShelf_Click(object sender, EventArgs e)
        {
            MyShelfForm window = new MyShelfForm();
            window.setCaller(this);
            window.Show();
        }

        private void btnNavTempSearch_Click(object sender, EventArgs e)
        {
            SearchResults window = new SearchResults();
            window.setCaller(this);
            window.Show();
        }

        /* Favorites List button functionality - Opens the list form with the overloaded constructor setting the list as "Favorites"
         *                                       and the caller as this instance of the Discovery Form (aka "this") */
        private void lblFavoritesList_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Favorites", this);
            window.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Tags", this);
            window.Show();
        }

        private void DiscoveryPageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
