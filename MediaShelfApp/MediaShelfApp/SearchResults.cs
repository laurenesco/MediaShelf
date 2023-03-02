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
    public partial class SearchResults : Form
    {
        // Instance variables:
        // caller       - form which invoked this form
        // searchText   - string to be searched 
        private DiscoveryPageForm caller = null!;
        private String searchText = null!;

        //////////////////////
        //  Public methods  //
        //////////////////////

        // Constructor
        public SearchResults()
        {
            InitializeComponent();
        }

        // Set caller method - this variable allows the back button to reopen the calling form
        public void setCaller(DiscoveryPageForm caller)
        {
            this.caller = caller;
        }

        // Set searchText method - this variable allows the form to display the correct search results
        public void setSearchText(String text)
        {
            this.searchText = text;
        }

        //////////////////////
        //  Priate methods  //
        //////////////////////
        
        // Back button functionality - reopens the calling form and closes this form
        private void btnNavBack_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }
    }
}
