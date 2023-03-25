using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
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

        // BOOKS API

        public class BookInfo
        {
            //public string volumeInfo { get; set; }
            public string title { get; set; }
            public string description { get; set; }
        }

        public class BookResult
        {
            public List<BookInfo> volumeInfo { get; set; }
            //public string title { get; set; }
            //public string description { get; set; }


        }

        public class Item
        {
            public string kind { get; set; }
            public string id { get; set; }
            public string etag { get; set; }
            public string selfLink { get; set; }
            public VolumeInfo volumeInfo { get; set; }
            //public SaleInfo saleInfo { get; set; }
            //public AccessInfo accessInfo { get; set; }
           // public SearchInfo searchInfo { get; set; }
        }

        public class VolumeInfo
        {
            public string title { get; set; }
            public string description { get; set; }
        }

        public class Root
        {
            public string kind { get; set; }
            public int totalItems { get; set; }
            public List<Item> items { get; set; }
       
        }

        //Deezer API for MUSIC
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Album
        {
            public int id { get; set; }
            public string title { get; set; }
            public string cover { get; set; }
            public string cover_small { get; set; }
            public string cover_medium { get; set; }
            public string cover_big { get; set; }
            public string cover_xl { get; set; }
            public string md5_image { get; set; }
            public string tracklist { get; set; }
            public string type { get; set; }
        }

        public class Artist
        {
            public int id { get; set; }
            public string name { get; set; }
            public string link { get; set; }
            public string picture { get; set; }
            public string picture_small { get; set; }
            public string picture_medium { get; set; }
            public string picture_big { get; set; }
            public string picture_xl { get; set; }
            public string tracklist { get; set; }
            public string type { get; set; }
        }

        public class Datum
        {
            public object id { get; set; }
            public bool readable { get; set; }
            public string title { get; set; }
            public string title_short { get; set; }
            public string title_version { get; set; }
            public string link { get; set; }
            public int duration { get; set; }
            public int rank { get; set; }
            public bool explicit_lyrics { get; set; }
            public int explicit_content_lyrics { get; set; }
            public int explicit_content_cover { get; set; }
            public string preview { get; set; }
            public string md5_image { get; set; }
            public Artist artist { get; set; }
            public Album album { get; set; }
            public string type { get; set; }
        }

        public class musicRoot
        {
            public List<Datum> data { get; set; }
            public int total { get; set; }
            public string next { get; set; }
        }

        //GAMES API CLASSES
        public class gamesRoot
        {
            public int count { get; set; }
            public string next { get; set; }
            public object previous { get; set; }
            public List<gamesResult> results { get; set; }
            public bool user_platforms { get; set; }
        }
        public class gamesResult
        {
            public string slug { get; set; }
            public string name { get; set; }
            public int playtime { get; set; }
            //public List<Platform> platforms { get; set; }
            //public List<Store> stores { get; set; }
            public string released { get; set; }
            public bool tba { get; set; }
            public string background_image { get; set; }
            public double rating { get; set; }
            public int rating_top { get; set; }
            //public List<Rating> ratings { get; set; }
            public int ratings_count { get; set; }
            public int reviews_text_count { get; set; }
            public int added { get; set; }
            //public AddedByStatus added_by_status { get; set; }
            public int? metacritic { get; set; }
            public int suggestions_count { get; set; }
            public DateTime updated { get; set; }
            public int id { get; set; }
            public string score { get; set; }
            public object clip { get; set; }
            //public List<Tag> tags { get; set; }
            //public EsrbRating esrb_rating { get; set; }
            public object user_game { get; set; }
            public int reviews_count { get; set; }
            public int community_rating { get; set; }
            public string saturated_color { get; set; }
            public string dominant_color { get; set; }
            //public List<ShortScreenshot> short_screenshots { get; set; }
            public List<ParentPlatform> parent_platforms { get; set; }
            public List<Genre> genres { get; set; }
        }

        public class Genre
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }
        public class ParentPlatform
        {
            public Platform platform { get; set; }
        }

        public class Platform
        {
            public Platform2 platform { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class Platform2
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
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
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    movieAPICall();
                    break;
                case 1:                 
                    booksAPICall(); 
                    break;
                case 2:
                    musicAPICall();
                    break;
                case 3:
                    gamesAPICall();
                    break;
            }    
        }
        //change to datagrid


        //////////////////////////
        //  API CALL FUNCTIONS  //
        //////////////////////////
        /// <summary>
        /// 
        /// All API call basically function the same, most code comment will be laid out in first API call
        /// 
        /// </summary>
        



        //Movie API Call
        private void movieAPICall()
        {
            using (var client = new HttpClient())
            {

                string query = searchBox1.Text.ToString();

                // API Key is in code, need to clean up and add as private variables at later date / clean up URI as well

                
                var endpoint = new Uri("https://api.themoviedb.org/3/search/movie?api_key=d076abf5fac2dab8dfeaca89a50f37a2&query=" + query);
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var movieList = JsonConvert.DeserializeObject<MovieResult>(json);

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();

                dataGridView1.Columns.Add("Title", "Title");
                dataGridView1.Columns.Add("Overview", "Overview");

                //Displays Top 10 results, breaks loop if none
                for (int i = 0; i < 10; i++)
                {
                    try
                    {                     
                        dataGridView1.Rows.Add(movieList.results[i].original_title.ToString(), movieList.results[i].overview.ToString());
                          
                    }
                    catch (Exception ex)
                    {
                        richTextBox1.AppendText(ex.Message);
                        break;
                    }
                }

            }
        }

        //Books API Call
        private void booksAPICall()
        {
            using (var client = new HttpClient()) 
            {
                string query = searchBox1.Text.ToString();

                var endpoint = new Uri("https://www.googleapis.com/books/v1/volumes?q=" + query + "&key=AIzaSyCUcXyqQE19ui4GTICk7wAQPkNPel5ybUQ");
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                Root bookList = JsonConvert.DeserializeObject<Root>(json);

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();

                dataGridView1.Columns.Add("Title", "Title");
                dataGridView1.Columns.Add("Overview", "Overview");
                //Displays Top 10 results, breaks loop if none
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        dataGridView1.Rows.Add(bookList.items[i].volumeInfo.title.ToString(), bookList.items[i].volumeInfo.description.ToString());
                                             
                    }
                    catch (Exception ex)
                    {
                        richTextBox1.AppendText(ex.Message); // Leave Just In Case
                        break;
                    }
                }
            }
        }

        private void musicAPICall() 
        {
            using (var client = new HttpClient()) 
            {
                string query = searchBox1.Text.ToString();

                var endpoint = new Uri("https://api.deezer.com/search/track?q=" + query);
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                musicRoot musicList = JsonConvert.DeserializeObject<musicRoot>(json);

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();

                dataGridView1.Columns.Add("Title", "Title");
                dataGridView1.Columns.Add("Artist", "Artist");

                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        dataGridView1.Rows.Add(musicList.data[i].title.ToString(), musicList.data[i].artist.name.ToString());
             
                    }
                    catch (Exception ex)
                    {
                        richTextBox1.AppendText(ex.Message);
                        break;
                    }
                }
            }
        }

        private void gamesAPICall()
        { 
            using (var client = new HttpClient()) 
            {
                string query = searchBox1.Text.ToString();

                var endpoint = new Uri("https://api.rawg.io/api/games?key=4c2156667b7e46e1b3701085a1150dff&search=" + query);
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                gamesRoot gamesList = JsonConvert.DeserializeObject<gamesRoot>(json);

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();

                dataGridView1.Columns.Add("Title", "Title");

                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        dataGridView1.Rows.Add(gamesList.results[i].name.ToString());
                    }
                    catch (Exception ex)
                    {
                        richTextBox1.AppendText(ex.Message);
                        break;
                    }
                }
            } 
        }

        //useless but do not remove it breaks
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchResults_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
