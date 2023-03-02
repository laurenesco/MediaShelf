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
        //////////////////////
        //  Public methods  //
        //////////////////////

        // Constructor
        public DiscoveryPageForm()
        {
            InitializeComponent();
        }

        //////////////////////
        //  Priate methods  //
        //////////////////////
        
        // See More button functionality - Hides this form as the caller, opens detailed recommendations form
        private void btnNavRecs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detailed_Recommendations window = new Detailed_Recommendations();
            window.setCaller(this);
            window.Show();
        }

        // Search button functionality - Hides this form as the caller, opens new instance of search form
        //                               with search parameter set as text from the search box
        private void btnNavSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchResults window = new SearchResults();
            window.setCaller(this);
            window.setSearchText("Test"); // Text pulled from search box will go here
            window.Show();
        }

        // MyShelf button functionality - Hides this form as the caller, opens new instance of MyShelf form
        private void btnNavMyShelf_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyShelfForm window = new MyShelfForm();
            window.setCaller(this);
            window.Show();
        }
    }
}
