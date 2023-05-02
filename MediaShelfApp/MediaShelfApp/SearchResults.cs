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
using System.Security.Policy;
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
        private moviesRoot moviesjson;
        private booksRoot booksjson;
        private musicRoot musicjson;
        private gamesRoot gamesjson;
        private gameDetailsRoot gameDetailsjson;


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

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class BelongsToCollection
        {
            public int id { get; set; }
            public string name { get; set; }
            public string poster_path { get; set; }
            public string backdrop_path { get; set; }
        }

        public class MovieGenre
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class ProductionCompany
        {
            public int id { get; set; }
            public string logo_path { get; set; }
            public string name { get; set; }
            public string origin_country { get; set; }
        }

        public class ProductionCountry
        {
            public string iso_3166_1 { get; set; }
            public string name { get; set; }
        }

        public class DetailedMoviesRoot
        {
            public bool adult { get; set; }
            public string backdrop_path { get; set; }
            public BelongsToCollection belongs_to_collection { get; set; }
            public int budget { get; set; }
            public List<MovieGenre> genres { get; set; }
            public string homepage { get; set; }
            public int id { get; set; }
            public string imdb_id { get; set; }
            public string original_language { get; set; }
            public string original_title { get; set; }
            public string overview { get; set; }
            public double popularity { get; set; }
            public string poster_path { get; set; }
            public List<ProductionCompany> production_companies { get; set; }
            public List<ProductionCountry> production_countries { get; set; }
            public string release_date { get; set; }
            public int revenue { get; set; }
            public int runtime { get; set; }
            public List<SpokenLanguage> spoken_languages { get; set; }
            public string status { get; set; }
            public string tagline { get; set; }
            public string title { get; set; }
            public bool video { get; set; }
            public double vote_average { get; set; }
            public int vote_count { get; set; }
        }

        public class SpokenLanguage
        {
            public string english_name { get; set; }
            public string iso_639_1 { get; set; }
            public string name { get; set; }
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

        public class musicReleaseDate
        {
            public string release_date { get; set; }
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

        // GAME DETAILS API CLASS HELPER //
        public class gameDetailsRoot
        {
            public int id { get; set; }
            public string slug { get; set; }
            public string name { get; set; }
            public string name_original { get; set; }
            public string description { get; set; }
            public object metacritic { get; set; }
            public List<object> metacritic_platforms { get; set; }
            public string released { get; set; }
            public bool tba { get; set; }
            public DateTime updated { get; set; }
            public string background_image { get; set; }
            public string background_image_additional { get; set; }
            public string website { get; set; }
            public double rating { get; set; }
            public int rating_top { get; set; }
            public int added { get; set; }
            public int playtime { get; set; }
            public int screenshots_count { get; set; }
            public int movies_count { get; set; }
            public int creators_count { get; set; }
            public int achievements_count { get; set; }
            public int parent_achievements_count { get; set; }
            public string reddit_url { get; set; }
            public string reddit_name { get; set; }
            public string reddit_description { get; set; }
            public string reddit_logo { get; set; }
            public int reddit_count { get; set; }
            public int twitch_count { get; set; }
            public int youtube_count { get; set; }
            public int reviews_text_count { get; set; }
            public int ratings_count { get; set; }
            public int suggestions_count { get; set; }
            public List<object> alternative_names { get; set; }
            public string metacritic_url { get; set; }
            public int parents_count { get; set; }
            public int additions_count { get; set; }
            public int game_series_count { get; set; }
            public object user_game { get; set; }
            public int reviews_count { get; set; }
            public string saturated_color { get; set; }
            public string dominant_color { get; set; }
            public List<ParentPlatform> parent_platforms { get; set; }
            public List<Platform> platforms { get; set; }
            public List<object> stores { get; set; }
            public List<Genre> genres { get; set; }
            public List<Publisher> publishers { get; set; }
            public object esrb_rating { get; set; }
            public object clip { get; set; }
            public string description_raw { get; set; }
        }

        public class gameDetailsHelper
        {
            public List<string> descriptions { get; set; }
        }
        //////////////////////
        //  Private methods  //
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

                var endpoint = new Uri("https://api.themoviedb.org/3/search/movie?api_key=d076abf5fac2dab8dfeaca89a50f37a2&query=" + query); // endpoint = HTTP URL for API call
                var result = client.GetAsync(endpoint).Result; // checks API status to get successful API call, Code 200 for most API = successful API call
                var json = result.Content.ReadAsStringAsync().Result; // Confirms successful API call then pulls the JSON 
                moviesRoot movieList = JsonConvert.DeserializeObject<moviesRoot>(json); // ROOT CLASS VARIABLE  //Parses JSON and assigns it as a C# object to assigned rootClass

                dataGridView1.Rows.Clear(); // Clears datagrid view and refreshes
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();

                dataGridView1.Columns.Add("Title", "Title"); //Adds columns to datagrid, to keep alignment with displayed information, add column with name of info
                dataGridView1.Columns.Add("Overview", "Overview");

                //Displays Top 20 results, breaks loop if none
                for (int i = 0; i < 20; i++)
                {
                    try
                    {
                        if (movieList.results[i].original_title == null)
                        {
                            movieList.results[i].original_title = "No title provided.";
                        }

                        if (movieList.results[i].overview == null || movieList.results[i].overview == "")
                        {
                            movieList.results[i].overview = "No description provided.";
                        }

                        dataGridView1.Rows.Add(movieList.results[i].original_title.ToString(), movieList.results[i].overview.ToString()); // DISPLAYS information on datagrid, must add columns above to display info correctly/formatted correctly

                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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

                var endpoint = new Uri("https://www.googleapis.com/books/v1/volumes?q=" + query + "&key=AIzaSyCUcXyqQE19ui4GTICk7wAQPkNPel5ybUQ&maxResults=20");
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                booksRoot bookList = JsonConvert.DeserializeObject<booksRoot>(json);

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();

                dataGridView1.Columns.Add("Title", "Title");
                dataGridView1.Columns.Add("Overview", "Overview");


                for (int i = 0; i < 20; i++)
                {
                    try
                    {
                        if (bookList.items[i].volumeInfo.title == null)
                        {
                            bookList.items[i].volumeInfo.title = "No title provided.";
                        }

                        if (bookList.items[i].volumeInfo.description == null)
                        {
                            bookList.items[i].volumeInfo.description = "No description provided";
                        }

                        dataGridView1.Rows.Add(bookList.items[i].volumeInfo.title.ToString(), bookList.items[i].volumeInfo.description.ToString());

                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }
                }
                booksjson = bookList;
            }
        }

        // MUSIC API CALL //
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

                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("Title", "Title");
                dataGridView1.Columns.Add("Artist", "Artist");

                for (int i = 0; i < 20; i++)
                {
                    try
                    {

                        if (musicList.data[i].title == null)
                        {
                            musicList.data[i].title = "No title provided.";
                        }

                        if (musicList.data[i].artist.name == null)
                        {
                            musicList.data[i].artist.name = "No description provided.";
                        }

                        dataGridView1.Rows.Add(musicList.data[i].id.ToString(),musicList.data[i].title.ToString(), musicList.data[i].artist.name.ToString());
                        dataGridView1.Columns["Id"].Visible = false;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
                dataGridView1.Columns.Add("Overview", "Overview");

                for (int i = 0; i < 20; i++)
                {
                    try
                    {
                        // Another API call to pull game overview
                        int gameID = gamesList.results[i].id; // gets ID of current game and sends it to query specific game
                        var ep = new Uri("https://api.rawg.io/api/games/" + gameID + "?key=4c2156667b7e46e1b3701085a1150dff");
                        var res = client.GetAsync(ep).Result;
                        var gameJson = res.Content.ReadAsStringAsync().Result;
                        gameDetailsRoot gameDetail = JsonConvert.DeserializeObject<gameDetailsRoot>(gameJson);

                        //string description = gameDetail.description;



                        if (gamesList.results[i].name == null)
                        {
                            gamesList.results[i].name = "No title provided.";
                        }

                        if (gameDetail.description == null)
                        {
                            gameDetail.description = "No description provided.";
                        }


                        dataGridView1.Rows.Add(gamesList.results[i].name.ToString(), gameDetail.description_raw.ToString());
                        gameDetailsjson = gameDetail;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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

        private void openDetailedItemListingForm(string title, string creator, string genre, string release_date, string description, string mediaImageLink, int mediaType, int movieID)
        {
            Detailed_Item_Listing_Form window = new Detailed_Item_Listing_Form(title, creator, genre, release_date, description, mediaImageLink, mediaType, movieID);
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
            int movieID = 0;

            try
            {
                switch (comboBox1.SelectedIndex) // calls API depended on comboBox selection
                {
                    case 0: //movies

                        // ALL IF ELSE STATEMENTS CHECK IF VALUE IS NULL, IF NULL IS TRUE PROVIDE STRING "N/A"


                        int movieid = moviesjson.results[rowIndex].id;
                        DetailedMoviesRoot movieCompleteList;


                        using (var client = new HttpClient()) // allows to connect to HTTP
                        {
                            var endpoint = new Uri("https://api.themoviedb.org/3/movie/" + movieid + "?api_key=d076abf5fac2dab8dfeaca89a50f37a2&language=en-US"); // endpoint = HTTP URL for API call
                            var result = client.GetAsync(endpoint).Result; // checks API status to get successful API call, Code 200 for most API = successful API call
                            var json = result.Content.ReadAsStringAsync().Result; // Confirms successful API call then pulls the JSON 
                            movieCompleteList = JsonConvert.DeserializeObject<DetailedMoviesRoot>(json); // ROOT CLASS VARIABLE  //Parses JSON and assigns it as a C# object to assigned rootClass
                        }



                        if (moviesjson.results[rowIndex].original_title == null)
                        {
                            title = "No title provided.";
                        }
                        else
                        {
                            title = movieCompleteList.original_title.ToString();
                        }

                        if (movieCompleteList.runtime == null)
                        {
                            creator = "No Runtime Provided";
                        }
                        else
                        {
                            creator = movieCompleteList.runtime.ToString() + " Minutes";
                        }

                        if (movieCompleteList.release_date == null)
                        {
                            release_date = "N/A";
                        }
                        else
                        {
                            release_date = movieCompleteList.release_date.ToString();
                        }

                        if (movieCompleteList.genres == null)
                        {
                            genre = "No Genre Provided";
                        }
                        else
                        {
                            genre = movieCompleteList.genres[0].name.ToString();
                        }


                        if (movieCompleteList.overview == null)
                        {
                            description = "N/A";
                        }
                        else
                        {
                            description = movieCompleteList.overview.ToString();
                        }

                        if (movieCompleteList.poster_path == null)
                        {
                            mediaImageLink = "";
                        }
                        else
                        {
                            mediaImageLink = "https://image.tmdb.org/t/p/w500" + movieCompleteList.poster_path.ToString();
                        }
                        movieID = moviesjson.results[rowIndex].id;
                        openDetailedItemListingForm(title, creator, genre, release_date, description, mediaImageLink, 0, movieID);

                        break;


                    case 1:
                        //books
                        string author;
                        string publisher;

                        if (booksjson.items[rowIndex].volumeInfo.title == null)
                        {
                            title = "N/A";
                        }
                        else
                        {
                            title = booksjson.items[rowIndex].volumeInfo.title.ToString();
                        }


                        if (booksjson.items[rowIndex].volumeInfo.authors == null)
                        {
                            author = "No Author Provided.";
                        }
                        else
                        {
                            author = booksjson.items[rowIndex].volumeInfo.authors[0].ToString();
                        }

                        if (booksjson.items[rowIndex].volumeInfo.publishedDate == null)
                        {
                            release_date = "No Publish Date Provided.";
                        }
                        else
                        {
                            release_date = booksjson.items[rowIndex].volumeInfo.publishedDate.ToString();
                        }

                        if (booksjson.items[rowIndex].volumeInfo.publisher == null)
                        {
                            publisher = "No Publisher Provided.";
                        }
                        else
                        {
                            publisher = booksjson.items[rowIndex].volumeInfo.publisher.ToString();
                        }

                        if (booksjson.items[rowIndex].volumeInfo.description == null)
                        {
                            description = "No Description Provided.";
                        }
                        else
                        {
                            description = booksjson.items[rowIndex].volumeInfo.description.ToString();
                        }

                        if (booksjson.items[rowIndex].volumeInfo.imageLinks == null)
                        {
                            mediaImageLink = "";
                        }
                        else
                        {
                            mediaImageLink = booksjson.items[rowIndex].volumeInfo.imageLinks.thumbnail;
                        }

                        openDetailedItemListingForm(title, author, publisher, release_date, description, mediaImageLink, 1, 0);
                        break;


                    case 2:
                        //music
                        string artist;
                        string album;
                        string music_release_date;

                        string music_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();


                        // Query for song release date
                        using (var client = new HttpClient())
                        {
                            
                            var equery = new Uri("https://api.deezer.com/track/" + music_id); // NO API KEY NEEDED FOR DEEZER
                            var eresult = client.GetAsync(equery).Result;
                            var ejson = eresult.Content.ReadAsStringAsync().Result;

                            musicReleaseDate musicItem = JsonConvert.DeserializeObject<musicReleaseDate>(ejson);

                            music_release_date = musicItem.release_date;
                        }


                        if (musicjson.data[rowIndex].title == null)
                        {
                            title = "N/A";
                        }
                        else
                        {
                            title = musicjson.data[rowIndex].title.ToString();
                        }


                        if (musicjson.data[rowIndex].artist.name == null)
                        {
                            artist = "N/A";
                        }
                        else
                        {
                            artist = musicjson.data[rowIndex].artist.name.ToString();
                        }


                        
                        if (musicjson.data[rowIndex].album.title == null)
                        {
                            album = "N/A";
                        }
                        else
                        {
                            album = musicjson.data[rowIndex].album.title;
                        }



                        if (musicjson.data[rowIndex].duration == null)
                        {
                            release_date = "No Release Date Provided.";
                        }
                        else
                        {
                            release_date = music_release_date;
                        }

                        description = "";

                        if (musicjson.data[rowIndex].album.cover_big == null)
                        {
                            mediaImageLink = "N/A";
                        }
                        else
                        {
                            mediaImageLink = musicjson.data[rowIndex].album.cover_big;
                        }
                        openDetailedItemListingForm(title, artist, album, release_date, description, mediaImageLink, 2, 0);
                        break;


                    case 3:
                        //games

                        if (gamesjson.results[rowIndex].name == null)
                        {
                            title = "N/A";
                        }
                        else
                        {
                            title = gamesjson.results[rowIndex].name.ToString();
                        }

                        string platform;
                        if (gamesjson.results[rowIndex].parent_platforms[0].platform.name == null || gamesjson.results[rowIndex].parent_platforms.Count == 0)
                        {
                            platform = "N/A";
                        }
                        else
                        {
                            platform = gamesjson.results[rowIndex].parent_platforms[0].platform.name.ToString();
                        }

                        if (gamesjson.results[rowIndex].genres == null || gamesjson.results[rowIndex].genres.Count == 0)
                        {
                            genre = "N/A";
                        }
                        else
                        {
                            genre = gamesjson.results[rowIndex].genres[0].name.ToString();
                        }

                        if (gamesjson.results[rowIndex].released == null)
                        {
                            release_date = "N/A";
                        }
                        else
                        {
                            release_date = gamesjson.results[rowIndex].released;
                        }

                        if (gameDetailsjson.description == null)
                        {
                            description = "N/A";
                        }
                        else
                        {
                            description = gameDetailsjson.description_raw;
                        }

                        if (gamesjson.results[rowIndex].background_image == null)
                        {
                            mediaImageLink = "N/A";
                        }
                        else
                        {
                            mediaImageLink = gamesjson.results[rowIndex].background_image;
                        }


                        openDetailedItemListingForm(title, platform, genre, release_date, description, mediaImageLink, 3, 0);

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                button2.PerformClick();
                e.Handled = true;
            }

        }
    }
}