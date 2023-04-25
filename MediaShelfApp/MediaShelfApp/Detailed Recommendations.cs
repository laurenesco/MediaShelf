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
using static MediaShelfApp.SearchResults;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MediaShelfApp
{
    public partial class Detailed_Recommendations : Form
    {
        private DiscoveryPageForm caller = null!;
        private Detailed_Item_Listing_Form icaller = null!;
        private SearchResults dcaller = null!;

        private Root moviesjson;

        private bool isMovie;
        private int movieID;


        //////////////////////
        //  Public methods  //
        //////////////////////

        // Constructor
        public Detailed_Recommendations()
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
        public Detailed_Recommendations(int movieID)
        {
            InitializeComponent();

            this.movieID = movieID;

        }

        // API CLASS //
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Result
        {
            public bool adult { get; set; }
            public string backdrop_path { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public string original_language { get; set; }
            public string original_title { get; set; }
            public string overview { get; set; }
            public string poster_path { get; set; }
            public string media_type { get; set; }
            public List<int> genre_ids { get; set; }
            public double popularity { get; set; }
            public string release_date { get; set; }
            public bool video { get; set; }
            public double vote_average { get; set; }
            public int vote_count { get; set; }
        }

        public class Root
        {
            public int page { get; set; }
            public List<Result> results { get; set; }
            public int total_pages { get; set; }
            public int total_results { get; set; }
        }

        // Set caller method - this variable allows the back button to reopen the calling form
        public void setCaller(DiscoveryPageForm caller)
        {
            this.caller = caller;
        }
        public void setCaller(Detailed_Item_Listing_Form icaller)
        {
            this.icaller = icaller;
        }
        public void setPrevCaller(SearchResults obj)
        {
            this.dcaller = obj;
        }

        ///////////////////////
        //  Private methods  //
        ///////////////////////
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (caller != null)
            {
                caller.Show();
                this.Close();
            }
            else
            {
                this.Hide();
                dcaller.Show();
            }
        }

        private void Detailed_Recommendations_Load(object sender, EventArgs e)
        {

            movieAPICall();
        }

        private void movieAPICall()
        {
            using (var client = new HttpClient())
            {
                // CALLS RECOMMENDATIONS USING TMDB API
                var endpoint = new Uri("https://api.themoviedb.org/3/movie/" + movieID + "/recommendations?api_key=d076abf5fac2dab8dfeaca89a50f37a2&language=en-US&page=1");
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                Root movieRec = JsonConvert.DeserializeObject<Root>(json);

                dgvResults.Rows.Clear();
                dgvResults.Columns.Clear();
                dgvResults.Refresh();

                dgvResults.Columns.Add("Title", "Title");
                dgvResults.Columns.Add("Overview", "Overview");

                // DISPLAYS THE TOP 5 RECOMMENDATIONS
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        if (movieRec.results[0].original_title == null)
                        {
                            movieRec.results[0].original_title = "NO RESULTS RETURNED";
                        }

                        if (movieRec.results[i].original_title == null)
                        {
                            movieRec.results[i].original_title = "No title provided.";
                        }

                        if (movieRec.results[i].overview == null || movieRec.results[i].overview == "")
                        {
                            movieRec.results[i].overview = "No description provided.";
                        }

                        dgvResults.Rows.Add(movieRec.results[i].original_title.ToString(), movieRec.results[i].overview.ToString()); // DISPLAYS information on datagrid, must add columns above to display info correctly/formatted correctly

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
                this.moviesjson = movieRec;
            }
        }


        private void openDetailedItemListingForm(string title, string creator, string genre, string release_date, string description, string mediaImageLink, int mediaType, int movieID)
        {
            Detailed_Item_Listing_Form window = new Detailed_Item_Listing_Form(title, creator, genre, release_date, description, mediaImageLink, mediaType, movieID);
            window.setRecCaller(this);
            window.setCaller(dcaller);
            this.Hide();
            window.Show();
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = dgvResults.CurrentRow.Index;
            string title;
            string creator;
            string genre;
            string release_date;
            string description;
            string mediaImageLink;
            int movieID = moviesjson.results[rowIndex].id;

            try
            {

                // ALL IF ELSE STATEMENTS CHECK IF VALUE IS NULL, IF NULL IS TRUE PROVIDE STRING "N/A"

                if (moviesjson.results[rowIndex].original_title == null)
                {
                    title = "No title provided.";
                }
                else
                {
                    title = moviesjson.results[rowIndex].original_title.ToString();
                }

                creator = "";

                if (moviesjson.results[rowIndex].release_date == null)
                {
                    release_date = "N/A";
                }
                else
                {
                    release_date = moviesjson.results[rowIndex].release_date.ToString();
                }
                genre = "";

                if (moviesjson.results[rowIndex].overview == null)
                {
                    description = "N/A";
                }
                else
                {
                    description = moviesjson.results[rowIndex].overview.ToString();
                }

                if (moviesjson.results[rowIndex].poster_path == null)
                {
                    mediaImageLink = "";
                }
                else
                {
                    mediaImageLink = "https://image.tmdb.org/t/p/w500" + moviesjson.results[rowIndex].poster_path.ToString();
                }

                movieID = moviesjson.results[rowIndex].id;
                openDetailedItemListingForm(title, creator, genre, release_date, description, mediaImageLink, 0, movieID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
