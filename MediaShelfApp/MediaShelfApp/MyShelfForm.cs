using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MediaShelfApp
{
    public partial class MyShelfForm : Form
    {
        private DiscoveryPageForm caller = null!;

        //////////////////////
        //  Public methods  //
        //////////////////////

        // Constructor
        public MyShelfForm()
        {
            InitializeComponent();

            // Initiate Database Connection
            try
            {
                SqlConnection dbConnection = new SqlConnection("Server=tcp:media-data-1-sv.database.windows.net,1433;Initial Catalog=media-store-db2;Persist Security Info=False;User ID=mediaalt;Password=wehkun-7jYcnu-zidjaz;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

                dbConnection.Open();
                SqlCommand cmd = dbConnection.CreateCommand();
                cmd.CommandText = "SELECT item_title FROM ITEMS WHERE item_list_id=1";
                SqlDataReader reader = cmd.ExecuteReader();

                var labels = new List<Label> { label4, label6, label8, label10 };
                ArrayList arrayList = new ArrayList();


                int numOfTuples = 0;
                while (reader.Read())
                {
                    arrayList.Add(reader["item_title"].ToString());
                    numOfTuples++;
                }

                int kounter = 0;
                foreach (string str in arrayList)
                {

                    labels[kounter].Text = str;
                    kounter++;
                }

                reader.Close();





                SqlCommand cmd2 = dbConnection.CreateCommand();
                cmd2.CommandText = "SELECT item_icon FROM ITEMS WHERE item_creator='Green Day'";

                SqlDataAdapter adpt = new SqlDataAdapter(cmd2);
                DataSet dataSet = new DataSet();
                adpt.Fill(dataSet, "Image");
                DataRow Row;
                Row = dataSet.Tables["Image"].Rows[0];
                byte[] MyImg = (byte[])Row[0];
                MemoryStream ms = new MemoryStream(MyImg);
                ms.Position = 0;

                Image img = Image.FromStream(ms); //error 

                pictureBox1.BackgroundImage = img;
                pictureBox2.BackgroundImage = img;
                pictureBox3.BackgroundImage = img;
                pictureBox4.BackgroundImage = img;

                //============================



                /*
                foreach (var label in labels)
                {
                    if (counter < numOfRows)
                    {
                        label.Text = arrayList.ToArray()[0].ToString();
                    }
                    counter++;
                }
                */




                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        // Set caller method - this variable allows the back button to reopen the calling form
        public void setCaller(DiscoveryPageForm caller)
        {
            this.caller = caller;
        }

        ///////////////////////
        //  Private methods  //
        ///////////////////////

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
