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


        // Marcel's Stuff
        private MovieResult moviesjson;
        private Root booksjson;
        private musicRoot musicjson;
        private gamesRoot gamesjson;



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

        /// <summary>
        /// API CLASSES:
        /// 
        /// The API classes take a JSON file from the API call and assigns it to the associated API class. In each class it stores each result as a C# object, which we can now use and pull the information out of.
        /// All the information gets stored within an array List, which can be pulled using an index value.
        /// 
        /// How the classes work:
        /// 
        /// All API classes have a 'root' class based on the JSON file, which is what is displayed first.
        /// The root class will connect to another class through a list, which allows the JSON parser to get the info that is nested within the JSON file.
        /// EX: bookList.items[i].volumeInfo.description -> bookList is assigned to the Root Class Variable, which pulls from the items list, which pulls from the volumeInfo list, which then gets the description for index i.
        /// Start from the root class, then navigate to the next class with the List of the same name
        /// 
        /// MOST INFORMATION IS NOT USED, ONLY THERE IF NEEDED AT LATER DATE
        /// 
        /// </summary>



        ////// MOVIES API CLASSES //////

        // ANOTHER EXAMPLE ON OBJECT STRUCTURE
        // movieList.results[i].original_title -> movieList (defined obj assinged to moviesRoot),
        // gets results from index [i], which gets C# object from moviesResult "original_title"


        public class moviesResult 
        {   
            // Name of object has to match name of JSON object
            public bool adult { get; set; } // C# object assigned at apiCall function below
            public string backdrop_path { get; set; }
            public List<int> genre_ids { get; set; }
            public int id { get; set; }
            public string original_language { get; set; }
            public string original_title { get; set; }
            public string overview { get; set; }
            public double popularity { get; set; }
            public string poster_path { get; set; }
            public string release_date { get; set; }
            public string title { get; set; }
            public bool video { get; set; }
            public double vote_average { get; set; }
            public int vote_count { get; set; }
        }
               
        public class moviesRoot // ROOT CLASS FOR MOVIES //
        {
            public List<moviesResult> results { get; set; } // ^ above is all info for results
        }




        ////// BOOKS API CLASSES //////

        public class Item
        {
            public string kind { get; set; }
            public string id { get; set; }
            public string etag { get; set; }
            public string selfLink { get; set; }
            public VolumeInfo volumeInfo { get; set; }
            

            // Might not need, let me know if needed
            //public AccessInfo accessInfo { get; set; }
            // public SearchInfo searchInfo { get; set; }
        }

        public class ImageLinks
        {
            public string smallThumbnail { get; set; }
            public string large { get; set; }
            public string thumbnail { get; set; }
        }

        public class ImageLinks
        {
            public string smallThumbnail { get; set; }
            public string thumbnail { get; set; }
        }

        public class VolumeInfo
        {
            public string title { get; set; }
            public List<string> authors { get; set; }
            public string publisher { get; set; }
            public string publishedDate { get; set; }
            public string description { get; set; }            
            public int pageCount { get; set; }
            public string printType { get; set; }
            public List<string> categories { get; set; }
            public double averageRating { get; set; }
            public int ratingsCount { get; set; }
            public string maturityRating { get; set; }
            public bool allowAnonLogging { get; set; }
            public string contentVersion { get; set; }
            public ImageLinks imageLinks { get; set; }
            public string language { get; set; }
            public string previewLink { get; set; }
            public string infoLink { get; set; }
            public string canonicalVolumeLink { get; set; }
            public string subtitle { get; set; }
            public bool? comicsContent { get; set; }
        }

        public class booksRoot // ROOT CLASS FOR BOOKS //
        {
            public string kind { get; set; }
            public int totalItems { get; set; }
            public List<Item> items { get; set; }

        }





        ////// MUSIC API CLASSES //////
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

        public class musicRoot // ROOT CLASS FOR MUSIC //
        {
            public List<Datum> data { get; set; }
            public int total { get; set; }
            public string next { get; set; }
        }




        ////// GAMES API CLASSES //////
        
        public class gamesRoot // ROOT CLASS FOR GAMES // 
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
            //public List<Platform> platforms { get; set; }   // Leave commented
            
            public string released { get; set; }
            public bool tba { get; set; }
            public string background_image { get; set; }
            public double rating { get; set; }
            public int rating_top { get; set; }
            
            public int ratings_count { get; set; }
            public int reviews_text_count { get; set; }
            public int added { get; set; }
            
            public int? metacritic { get; set; }
            public int suggestions_count { get; set; }
            public DateTime updated { get; set; }
            public int id { get; set; }
            public string score { get; set; }
            public object clip { get; set; }           
            public object user_game { get; set; }
            public int reviews_count { get; set; }
            public int community_rating { get; set; }
            public string saturated_color { get; set; }
            public string dominant_color { get; set; }          
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
            public Platform platform { get; set; } // goes to Platform2 (below)
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


        // Users clicks Search button
        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex) // calls API depended on comboBox selection
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


        //////////////////////////
        //  API CALL FUNCTIONS  //
        //////////////////////////
        /// <summary>
        /// 
        /// All API call basically function the same
        /// 
        /// movieAPICall() will have most comments to explain how all API calls work
        /// 
        /// TIP! : To run own API call, go to your browser and copy link from new Uri, ex: https://api.themoviedb.org/3/search/movie?api_key=d076abf5fac2dab8dfeaca89a50f37a2&query=[QUERY] and add query, works for all URIs, helps get
        ///            better understanding of JSON file. Included structure needed for API call in each function.
        /// </summary>



        // MOVIES/TV SHOWS API CALL //
        private void movieAPICall()
        {
            using (var client = new HttpClient()) // allows to connect to HTTP
            {

                string query = searchBox1.Text.ToString(); // user types in Search Box

                // API call for books REPLACE [QUERY] =https://api.themoviedb.org/3/search/movie?api_key=d076abf5fac2dab8dfeaca89a50f37a2&query=[QUERY]

                var endpoint = new Uri("https://api.themoviedb.org/3/search/movie?api_key=d076abf5fac2dab8dfeaca89a50f37a2&query=" + query);
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var movieList = JsonConvert.DeserializeObject<MovieResult>(json);


                dataGridView1.Rows.Clear(); // Clears datagrid view and refreshes
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();

                dataGridView1.Columns.Add("Title", "Title"); //Adds columns to datagrid, to keep alignment with displayed information, add column with name of info
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
                        richTextBox1.AppendText(ex.Message); // Displays error in text box on search results, subject to change
                        break;
                    }
                }
                moviesjson = movieList;
            }
        }

        // BOOKS API CALL //
        private void booksAPICall()
        {
            using (var client = new HttpClient())
            {
                string query = searchBox1.Text.ToString();

                // API call for books REPLACE [QUERY] = https://www.googleapis.com/books/v1/volumes?q=[QUERY]&key=AIzaSyCUcXyqQE19ui4GTICk7wAQPkNPel5ybUQ

                var endpoint = new Uri("https://www.googleapis.com/books/v1/volumes?q=" + query + "&key=AIzaSyCUcXyqQE19ui4GTICk7wAQPkNPel5ybUQ");
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                booksRoot bookList = JsonConvert.DeserializeObject<booksRoot>(json);

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();

                dataGridView1.Columns.Add("Title", "Title");
                dataGridView1.Columns.Add("Overview", "Overview");               
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
                booksjson = bookList;
            }
        }


        private void musicAPICall()
        {
            using (var client = new HttpClient())
            {
                string query = searchBox1.Text.ToString();

                // API call for music REPLACE [QUERY] = https://api.deezer.com/search/track?q=[QUERY]
                var endpoint = new Uri("https://api.deezer.com/search/track?q=" + query); // NO API KEY NEEDED FOR DEEZER
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
                musicjson = musicList;
            }
        }
        
        // GAMES API CALL //
        private void gamesAPICall()
        {
            using (var client = new HttpClient())
            {
                string query = searchBox1.Text.ToString();

                // API call for games REPLACE [QUERY] = https://api.rawg.io/api/games?key=4c2156667b7e46e1b3701085a1150dff&search=[QUERY]
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
                gamesjson = gamesList;
            }
        }

        
        /// END OF API CALLS /// 

        // Search Results Form Loads
        private void SearchResults_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; //pre-sets comboBox to Movies/TV Shows
        }

        private void SearchResults_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void openDetailedItemListingForm(string title, string creator, string genre, string release_date, string description, string mediaImageLink, int mediaType)
        {
            Detailed_Item_Listing_Form window = new Detailed_Item_Listing_Form(title, creator, genre, release_date, description, mediaImageLink, mediaType);
            window.setCaller(this);
            this.Hide();
            window.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = dataGridView1.CurrentRow.Index;
            string title;
            string creator;
            string genre;
            string release_date;
            string description;
            string mediaImageLink;

            switch (comboBox1.SelectedIndex) // calls API depended on comboBox selection
            {
                case 0:
                    //movies

                    title = moviesjson.results[rowIndex].original_title.ToString();
                    creator = "";
                    release_date = moviesjson.results[rowIndex].release_date.ToString();
                    genre = "";
                    description = moviesjson.results[rowIndex].overview.ToString();
                    mediaImageLink = "https://image.tmdb.org/t/p/w500" + moviesjson.results[rowIndex].poster_path.ToString();

                    openDetailedItemListingForm(title, creator, genre, release_date, description, mediaImageLink, 0);

                    break;
                case 1:
                    //books
                    title = booksjson.items[rowIndex].volumeInfo.title.ToString();
                    string author = booksjson.items[rowIndex].volumeInfo.authors[0].ToString();
                    release_date = booksjson.items[rowIndex].volumeInfo.publishedDate.ToString();
                    string publisher = booksjson.items[rowIndex].volumeInfo.publisher.ToString();
                    description = booksjson.items[rowIndex].volumeInfo.description.ToString();
                    mediaImageLink = booksjson.items[rowIndex].volumeInfo.imageLinks.thumbnail;

                    openDetailedItemListingForm(title, author, publisher, release_date, description, mediaImageLink, 1);
                    break;
                case 2:
                    //music
                    title = musicjson.data[rowIndex].title.ToString();
                    string artist = musicjson.data[rowIndex].artist.name.ToString();
                    string album = musicjson.data[rowIndex].album.title;
                    release_date = "";
                    description = "";
                    mediaImageLink = musicjson.data[rowIndex].album.cover_big;

                    openDetailedItemListingForm(title, artist, album, release_date, description, mediaImageLink, 2); ;
                    break;
                case 3:
                    //games

                    title = gamesjson.results[rowIndex].name;
                    string platform = gamesjson.results[rowIndex].parent_platforms[0].platform.name.ToString();
                    genre = gamesjson.results[rowIndex].genres[1].name.ToString();
                    release_date = gamesjson.results[rowIndex].released;
                    description = "";
                    mediaImageLink = gamesjson.results[rowIndex].background_image;


                    openDetailedItemListingForm(title, platform, genre, release_date, description, mediaImageLink, 3);

                    break;
            }
        }
    }
}
