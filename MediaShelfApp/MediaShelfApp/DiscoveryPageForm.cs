using Microsoft.Data.SqlClient;
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

namespace MediaShelfApp
{
    public partial class DiscoveryPageForm : Form
    {
        static int fontSize; // to store font size settings

        //////////////////////
        //  Public methods  //
        //////////////////////

        public DiscoveryPageForm()
        {
            InitializeComponent();
            readSettings(); 
        }

        //////////////////////
        //  Static methods  //
        //////////////////////
        /* static functions for use within all forms */

        //changes font size of app
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

            // changes font size of every control in form if needed
            foreach (Control c in form.Controls)
            {
                // if control has child controls, change the font size of those too
                if (c.HasChildren)
                    changeFontSize(c, fs, isDiscoveryForm);

                // if form is discovery form, don't change font size of every control
                if (isDiscoveryForm && (c is Button || (c is Label && c.Font.Size <= 12) || c is GroupBox || c is ComboBox))
                    c.Font = new Font(c.Font.FontFamily, fs, c.Font.Style, c.Font.Unit);
                else if (!isDiscoveryForm) // if form is not discovery form, change font size of every control except titles
                {
                    if (!(c is Label && c.Font.Size > 12))
                        c.Font = new Font(c.Font.FontFamily, fs, c.Font.Style, c.Font.Unit);
                }
            }
        }

        //utility function - intended use for above function; changes font size of child controls in parent control if needed
        private static void changeFontSize(Control control, int fs, bool isDiscoveryForm)
        {
            foreach (Control c in control.Controls)
            {
                // if control has child controls, change the font size of those too
                if (c.HasChildren)
                    changeFontSize(c, fs, isDiscoveryForm);

                // if form is discovery form, change font size of every non-title label in parent control
                if (isDiscoveryForm && c is Label && c.Font.Size <= 12)
                    c.Font = new Font(c.Font.FontFamily, fs, c.Font.Style, c.Font.Unit);
                else if (!isDiscoveryForm)
                {
                    if (!(c is Label && c.Font.Size > 12)) // change font size of every control in parent control except titles
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchResults window = new SearchResults();
            window.setCaller(this);
            window.Show();
        }

        private void lblFavorites_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Favorites", this);
            window.Show();
        }

        // opens wishlist
        private void lblWishlist_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Wishlist", this);
            window.Show();
        }

        // opens manual entries list
        private void lblManualEntries_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Manual Entries", this);
            window.Show();
        }

        // opens manual tags list
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

        // opens/closes settings menu
        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (btnSettings.Text == "Open Settings")
            {
                gbFontSizeSettings.Visible = true;
                btnSettings.Text = "Close Settings";
            }
            else
            {
                gbFontSizeSettings.Visible = false;
                btnSettings.Text = "Open Settings";
            }
        }

        // applies changes to font size and saves
        private void rbFontSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmallFont9.Checked) // if user selected font size 9
                setFontSize(9);
            else if (rbMediumFont10.Checked) // if user selected font size 10
                setFontSize(10);
            else if (rbLargeFont12.Checked) // if user selected font size 12
                setFontSize(12);

            changeFontSize(this, fontSize, true);
            saveSettings();

        private void btnBooks_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Books", this);
            window.Show();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Movies", this);
            window.Show();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Games", this);
            window.Show();
        }

        private void btnTVShows_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Movies", this);
            window.Show();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Music", this);
            window.Show();
        }
    }
}
