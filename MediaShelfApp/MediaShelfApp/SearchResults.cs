using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
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
        public void setCaller(DiscoveryPageForm caller)
        {
            this.caller = caller;
        }

        // Set searchText method - this variable allows the form to display the correct search results
        public void setSearchText(String text)
        {
            this.searchText = text;
        }

        // What API parses for
        public class MovieInfo
        {
            public string original_title { get; set; }
            public string overview { get; set; }
        }

        // Separates the results in JSON and puts it into a list format
        public class MovieResult
        {
            public List<MovieInfo> results { get; set; }
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                string query = searchBox1.Text.ToString();

                // API Key is in code, need to clean up and add as private variables at later date / clean up URI as well
                var endpoint = new Uri("https://api.themoviedb.org/3/search/movie?api_key=d076abf5fac2dab8dfeaca89a50f37a2&query=" + query);
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var movieList = JsonConvert.DeserializeObject<MovieResult>(json);

                richTextBox1.Clear();

                //Displays Top 10 results, breaks loop if none
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        richTextBox1.AppendText("Title: " + movieList.results[i].original_title.ToString() + "\n"
                            + "Overview: " + movieList.results[i].overview.ToString() + "\n\n");
                    }
                    catch
                    {
                        break;
                    }
                }

            }
        }
    }
}
