using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MediaShelfApp
{
    public partial class ListView : Form
    {
        // Instance variables:
        // caller   - form which invoked this form
        // list     - list intended to be viewed
        private MyShelfForm caller = null!;
        private String list = null!;

        //////////////////////
        //  Public methods  //
        //////////////////////
        
        // Constructor
        public ListView()
        {
            InitializeComponent();

            // Initiate Database Connection
            try
            {
                SqlConnection dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db1;Persist Security Info=True;User ID=;Password=");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Set caller method - this variable allows the back button to reopen the calling form
        public void setCaller(MyShelfForm caller)
        {
            this.caller = caller;
        }

        // Set list method - this variable allows the form to display the correct list
        public void setList(String listName)
        {
            this.list = listName;
        }

        //////////////////////
        //  Priate methods  //
        //////////////////////
        
        // Back button functionality - reopens calling form, closes this form
        private void btnNavBack_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }

        // Add Manual Entry button functionality - hides this form as the caller, then opens manual entry form with
        //                                         currently viewed list as the list to be added to
        private void btnNavManualEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manual_Entry_Form window = new Manual_Entry_Form();
            window.setCaller(this);
            window.setList(list);
            window.Show();
        }

        // Item Image button functionality - hides this form as the caller, then opens the detailed item listing form
        //                                   with the seelcted item as the item to be viewed
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detailed_Item_Listing_Form window = new Detailed_Item_Listing_Form();
            window.setCaller(this);
            // window.setItemID(id_of_item_goes_here); // May also need to include API id eventually
            window.Show();
        }
    }
}
