using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MediaShelfApp.SearchResults;

namespace MediaShelfApp
{
    public partial class DiscoveryPageForm : Form
    {
        static int fontSize; // to store settings
        /*
        private string title;
        private string genre;
        private string mediaImageLink;
        */

        //////////////////////
        //  Public methods  //
        //////////////////////

        public DiscoveryPageForm()//string title, string creator, string genre, string release_date, string description, string mediaImageLink, int api_type)
        {
            InitializeComponent();
            readSettings(); // uncomment to use settings file

            // Initiate Database Connection
            try
            {
                SqlConnection dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db2;Persist Security Info=True;User ID= mediaalt;Password=wehkun-7jYcnu-zidjaz");
                dbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            /*
            this.title = title;
            this.genre = genre;
            this.mediaImageLink = mediaImageLink;

            displayData(title, genre, mediaImageLink, api_type);
            */
        }

        //////////////////////
        //  Static methods  //
        //////////////////////
        /* static functions for use within all forms */

        //use when user changes fontSize
        public static void changeFontSize(Form form, int fs, bool isDiscoveryForm = false)
        {
            /*
             * If the form whose font size is being changed is the Discovery Form, 
             * then this function only changes the non-title labels and buttons.
             * Else, the only thing the function DOESN'T change are title labels (any label whose size > 12).
             * 
             * To control re-sizing of controls (for all forms), either 
             * 1.) min/max controller size was set maually (so autosize is still set to true). 
             *     The size to set is determined by its size when its font size is maxed (12).
             * or 2.) autosize was set to false.
             * 
             * To maintain positioning after auto re-sizing, some controls were put in flow layout panels.
             * 
             */

            // for every control in the form, change the font size if needed
            foreach (Control c in form.Controls)
            {
                //if the current control contains child controls, change the font size of those too
                if (c.HasChildren)
                    changeFontSize(c, fs, isDiscoveryForm);
                
                // if the current form is the Discovery Form, change font size of only certain controls in form
                if (isDiscoveryForm && (c is Button || (c is Label && c.Font.Size <= 12) || c is GroupBox || c is ComboBox))
                    c.Font = new Font(c.Font.FontFamily, fs, c.Font.Style, c.Font.Unit);
                else if (!isDiscoveryForm) // else change font size of every control in form except titles
                {
                    if (!(c is Label && c.Font.Size > 12))
                        c.Font = new Font(c.Font.FontFamily, fs, c.Font.Style, c.Font.Unit);
                }
            }
        }

        //utility function - intended use for above function; used when user changes font size
        private static void changeFontSize(Control control, int fs, bool isDiscoveryForm)
        {
            // for every child control in the parent control, change its font size
            foreach (Control c in control.Controls)
            {
                //if the current control contains child controls, change the font size of those too
                if (c.HasChildren)
                    changeFontSize(c, fs, isDiscoveryForm);

                if (isDiscoveryForm && c is Label && c.Font.Size <= 12)
                    c.Font = new Font(c.Font.FontFamily, fs, c.Font.Style, c.Font.Unit);
                else if (!isDiscoveryForm)
                {
                    if (!(c is Label && c.Font.Size > 12))
                        c.Font = new Font(c.Font.FontFamily, fs, c.Font.Style, c.Font.Unit);
                }
            }
        }

        // modifier method for variable fontSize
        public static void setFontSize(int n)
        {
            fontSize = n;
        }
        // accessor method for variable fontSize
        public static int getFontSize()

        {
            return fontSize;
        }

        ///////////////////////
        //  Private methods  //
        ///////////////////////

        /*
        private void displayData(string title, string genre, string mediaImageLink, int mediaType)
        {

            switch (mediaType)
            {

                case 0:

                    label4.Text = title;
                    label5.Text = title;
                    label17.Text = title;
                    label12.Text = title;
                    label19.Text = title;
                    label21.Text = title;

                    //lblGenreValue.Text = genre;


                    pbRec1.ImageLocation = mediaImageLink;
                    pbRec1.Size = new System.Drawing.Size(104, 106);

                    break;
                case 1:

                    // Modify Labels on Form for Books
                    label4.Text = title;
                    label5.Text = title;
                    label17.Text = title;
                    label12.Text = title;
                    label19.Text = title;
                    label21.Text = title;
                    //lblGenreTitle.Text = "Publisher:";


                    label4.Text = title;
                    label5.Text = title;
                    label17.Text = title;
                    label12.Text = title;
                    label19.Text = title;
                    label21.Text = title;
                    //lblGenreValue.Text = genre;


                    pbRec1.ImageLocation = mediaImageLink;
                    pbRec1.Size = new System.Drawing.Size(104, 106);

                    break;
                case 2:
                    // Modify Labels on Form for Books
                    label4.Text = title;
                    label5.Text = title;
                    label17.Text = title;
                    label12.Text = title;
                    label19.Text = title;
                    label21.Text = title;
                    //lblGenreTitle.Text = "Album:";


                    label4.Text = title;
                    label5.Text = title;
                    label17.Text = title;
                    label12.Text = title;
                    label19.Text = title;
                    label21.Text = title;
                    //lblGenreValue.Text = genre;


                    pbRec1.ImageLocation = mediaImageLink;
                    pbRec1.Size = new System.Drawing.Size(104, 106);
                    break;
                case 3:

                    label4.Text = title;
                    label5.Text = title;
                    label17.Text = title;
                    label12.Text = title;
                    label19.Text = title;
                    label21.Text = title;
                    //lblGenreValue.Text = genre;


                    pbRec1.ImageLocation = mediaImageLink;
                    pbRec1.Size = new System.Drawing.Size(104, 106);
                    break;
                default:
                    break;

            }
        }
        */

        private void DiscoveryPageForm_Load(object sender, EventArgs e)
        {
        }

        //Media Shelf Title
        private void lblMediaShelf_Click(object sender, EventArgs e)
        {
        }

        //Music Square
        private void btnMusic_Click(object sender, EventArgs e)
        {
            //SearchResults window = new SearchResults("Music", this);
            //window.Show();
        }

        //Movies Square
        private void btnMovies_Click(object sender, EventArgs e)
        {
            //SearchResults window = new SearchResults("Movies", this);
            //window.Show();
        }

        //Shows Square
        private void btnTVShows_Click(object sender, EventArgs e)
        {
            //SearchResults window = new SearchResults("Shows", this);
            //window.Show();
        }

        //Book Square
        private void btnBooks_Click(object sender, EventArgs e)
        {
            //SearchResults window = new SearchResults("Books", this);
            //window.Show();
        }

        //Games square
        private void btnGames_Click(object sender, EventArgs e)
        {
            //SearchResults window = new SearchResults("Games", this);
            //window.Show();
        }

        //Search Bar
        // Search button functionality - Hides this form as the caller, opens new instance of search form
        //                               with search parameter set as text from the search box
        private void btnSearchBar_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchResults window = new SearchResults();
            window.setCaller(this);
            window.setSearchText("Test"); // Text pulled from search box will go here
            window.Show();
        }

        //==================================================================
        //Recommendations Header
        //==================================================================

        //Based on your... info
        private void lblRecBasedOn_Click(object sender, EventArgs e)
        {
        }

        //Other titles with TAG
        private void lblRecOtherTitles_Click(object sender, EventArgs e)
        {
        }

        //Recommendation #1 picture
        private void pbRec1_Click(object sender, EventArgs e)
        {
        }

        //Recommendation #1 Title 
        private void lblRecTitle1_Click(object sender, EventArgs e)
        {

        }
        //Recommendation #1 Genre Label
        private void lblRecGenre1_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #2 Picture
        private void pbRec2_Click(object sender, EventArgs e)
        {

        }

        ////Recommendation #2 Title
        private void lblRecTitle2_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #2 Genre Label
        private void lblRecGenre2_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #3 Picture
        private void pbRec3_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #3 Title
        private void lblRecTitle3_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #3 Genre Label
        private void lblRecGenre3_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #4 Picture
        private void pbRec4_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #4 Title
        private void lblRecTitle4_Click(object sender, EventArgs e)
        {
        }

        //Recommendation #4 Genre Label
        private void lblRecGenre4_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #5 Picture
        private void pbRec5_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #5 Title
        private void lblRecTitle5_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #5 Genre Label
        private void lblRecGenre5_Click(object sender, EventArgs e)
        {

        }


        //Recommendation #6 Picture
        private void pbRec6_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #6 Title
        private void lblRecTitle6_Click(object sender, EventArgs e)
        {

        }

        //Recommendation #6 Genre Label
        private void lblRecGenre6_Click(object sender, EventArgs e)
        {

        }

        //See More Recommendations
        // See More button functionality - Hides this form as the caller, opens detailed recommendations form
        private void btnRecommendations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detailed_Recommendations window = new Detailed_Recommendations();
            window.setCaller(this);
            window.Show();
        }

        //==========================================================================
        //List Header
        //==========================================================================

        private void lblListHeader(object sender, EventArgs e)
        {
            //ListView window = new ListView();
            //window.Show();
        }

        //Favorites List
        /* Favorites List button functionality - Opens the list form with the overloaded constructor setting the list as "Favorites"
         *                                       and the caller as this instance of the Discovery Form (aka "this") */
        private void lblFavorites_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Favorites", this);
            window.Show();
        }

        //Favorites List Description
        private void lblFavoritesDescription(object sender, EventArgs e)
        {
        }

        // shows items in user's wishlist
        private void lblWishlist_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Wishlist", this);
            window.Show();
        }

        // shows items that user has made
        private void lblManualEntries_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Manual Entries", this);
            window.Show();
        }

        // shows tags that user has made
        private void lblManualTags_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Tags", this);
            window.Show();
        }

        // enables access for developers to settings file without setting path themselves
        private string getSettingsFileLocation()
        {
            string path = "";
            path += Environment.CurrentDirectory;
            path = path.Substring(0, path.LastIndexOf("bin"));
            path += "\\Resources\\settings.txt";

            return path;
        }

        // read from settings file
        private void readSettings()
        {
            string path = getSettingsFileLocation();

            string settings = System.IO.File.ReadAllText(path);

            int fs = int.Parse(Regex.Match(settings, @"\d+").Value);

            if (fs == 9)
                rbSmallFont9.Checked = true;
            else if (fs == 10)
                rbMediumFont10.Checked = true;
            else if (fs == 12)
                rbLargeFont12.Checked = true;
        }

        // write to settings file
        private void saveSettings()
        {
            System.IO.File.WriteAllText(getSettingsFileLocation(), "fontsize=" + fontSize);
        }

        // opens/closes whole settings menu
        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (btnSettings.Text == "Open Settings")
            {
                //cmbSettingsSelection.Visible = true;
                gbFontSizeSettings.Visible = true;
                btnSettings.Text = "Close Settings";
            }
            else
            {
                //cmbSettingsSelection.Visible = false;
                gbFontSizeSettings.Visible = false;
                btnSettings.Text = "Open Settings";
                cmbSettingsSelection.Text = "Choose a setting";
            }
        }

        // opens settings type part of settings menu
        private void cmbSettingsSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSettingsSelection.SelectedIndex == 0)
            {
                gbFontSizeSettings.Visible = true;
            }
            else
            {
                gbFontSizeSettings.Visible = false;
            }
        }

        // changes current font size to new selection
        private void rbFontSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmallFont9.Checked) //font size 9 was selected
                setFontSize(9); //new font size = 9
            else if (rbMediumFont10.Checked) //font size 10 was selected
                setFontSize(10); //new font size = 10
            else if (rbLargeFont12.Checked) //font size 12 was selected
                setFontSize(12); //new font size = 12

            changeFontSize(this, fontSize, true); // change font size to new selection
            saveSettings(); // save current font size in settings file
        }

        //Withlist Decription
        private void lblWishlistDescription(object sender, EventArgs e)
        {

        }

        //Manual Tags Description
        private void lblManualTagsDesc_Click(object sender, EventArgs e)
        {

        }


        //List #3
        private void lblList3_Click(object sender, EventArgs e)
        {

        }

        //List #3 Description
        private void lblList3Desc_Click(object sender, EventArgs e)
        {
        }
    }
}
