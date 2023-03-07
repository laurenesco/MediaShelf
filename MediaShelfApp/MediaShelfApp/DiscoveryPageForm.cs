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
        }
        private void DiscoveryPageForm_Load(object sender, EventArgs e)
        {

        }

        //Name Label
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyShelfForm window = new MyShelfForm();
            window.setCaller(this);
            window.Show();
        }

        //Music Square
        private void button1_Click(object sender, EventArgs e)
        {
        }

        //Movies Square
        private void button2_Click(object sender, EventArgs e)
        {
        }

        //Shows Square
        private void button3_Click(object sender, EventArgs e)
        {
        }

        //Book Square
        private void button4_Click(object sender, EventArgs e)
        {

        }

        //Games square
        private void button7_Click(object sender, EventArgs e)
        {
        }

        //MyShelf Square
        // MyShelf button functionality - Hides this form as the caller, opens new instance of MyShelf form
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyShelfForm window = new MyShelfForm();
            window.setCaller(this);
            window.Show();
        }


        //Search Bar
        // Search button functionality - Hides this form as the caller, opens new instance of search form
        //                               with search parameter set as text from the search box
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchResults window = new SearchResults();
            window.setCaller(this);
            window.setSearchText("Test"); // Text pulled from search box will go here
            window.Show();
        }


        //==================================================================
        //Recommendations Header
        private void Recommendations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detailed_Recommendations window = new Detailed_Recommendations();
            window.setCaller(this);
            window.Show();
        }
        //Based on your... info
        private void label2_Click(object sender, EventArgs e)
        {
        }
        //Other titles with TAG
        private void label3_Click(object sender, EventArgs e)
        {
        }

        //Recommendation #1 picture
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        //Recommendation #1 Title 
        private void label4_Click(object sender, EventArgs e)
        {

        }
        //Recommendation #1 Tag Label
        private void label10_Click(object sender, EventArgs e)
        {

        }
        //Recommendation #1 TAG
        private void button8_Click(object sender, EventArgs e)
        {

        }


        //Recommendation #2 Picture
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        ////Recommendation #2 Title
        private void label5_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #2 Tag Label
        private void label11_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #2 TAG
        private void button15_Click(object sender, EventArgs e)
        {

        }


        //Recommendation #3 Picture
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #3 Title
        private void label17_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #3 Tag Label
        private void label16_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #3 TAG
        private void button9_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #4 Picture
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        //Recommendation #4 Title
        private void label12_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #4 Tag Label
        private void label6_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #4 TAG
        private void button10_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #5 Picture
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #5 Title
        private void label19_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #5 Tag Label
        private void label18_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #5 TAG
        private void button16_Click(object sender, EventArgs e)
        {

        }


        //Recommendation #6 Picture
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #6 Title
        private void label21_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #6 Tag Label
        private void label20_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #6 TAG
        private void button17_Click(object sender, EventArgs e)
        {

        }

        //See More Recommendations
        // See More button functionality - Hides this form as the caller, opens detailed recommendations form

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detailed_Recommendations window = new Detailed_Recommendations();
            window.setCaller(this);
            window.Show();
        }

        //==========================================================================
        //List Header
        private void label26_Click(object sender, EventArgs e)
        {

        }

        //Favorites List
        private void label25_Click(object sender, EventArgs e)
        {
            
        }
        //Favorites List Description
        private void label24_Click(object sender, EventArgs e)
        {

        }

        //Wishlist List 
        private void label13_Click(object sender, EventArgs e)
        {

        }

        //Withlist Decription
        private void label22_Click(object sender, EventArgs e)
        {

        }

        //List #1
        private void label9_Click(object sender, EventArgs e)
        {

        }
        //List #1 Description
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

        //Scrollbar
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
