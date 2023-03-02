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
    public partial class MyShelfForm : Form
    {
        public DiscoveryPageForm caller = null!;

        //////////////////////
        //  Public methods  //
        //////////////////////
        
        // Constructor
        public MyShelfForm()
        {
            InitializeComponent();
        }

        //////////////////////
        //  Priate methods  //
        //////////////////////
        
        // Back button functionality - reopens the calling form and closes this form
        private void btnBack_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }

        // Favorites list button functionality - hides this form and opens the list form with the list variable set to favorites
        private void lblNavFavList_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListView window = new ListView();
            window.setCaller(this);
            window.setList("Favorites");
            window.Show();
        }
    }
}
