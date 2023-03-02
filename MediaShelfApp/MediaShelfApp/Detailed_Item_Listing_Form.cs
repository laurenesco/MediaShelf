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
    public partial class Detailed_Item_Listing_Form : Form
    {
        // Instance variables:
        // caller   - form which invoked this form
        // itemID   - ID of item intended to be viewed, used for querying 
        private ListView caller = null!;
        private int itemID = 0;

        //////////////////////
        //  Public methods  //
        //////////////////////

        // Constructor
        public Detailed_Item_Listing_Form()
        {
            InitializeComponent();
        }

        // Set caller method - this variable allows the back button to reopen the calling form
        public void setCaller(ListView caller)
        {
            this.caller = caller;
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
            caller.Show();
            this.Close();
        }
    }
}
