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
        static int fontSize; // to store settings

        //////////////////////
        //  Public methods  //
        //////////////////////

        public DiscoveryPageForm()
        {
            InitializeComponent();
            //readSettings(); // uncomment to use settings file
        }

        //////////////////////
        //  Static methods  //
        //////////////////////
        /* static functions for use within all forms */

        //use when user changes fontSize
        public static void changeFontSize(Form form, int fs)
        {
            //form.BackgroundImage = null;
            foreach (Control c in form.Controls)
            {
                if (c.HasChildren)
                    changeFontSize(c, fs);

                if (c is Button || (c is Label && c.Font.Size <= 12) || c is GroupBox)
                    c.Font = new Font(c.Font.FontFamily, fs, c.Font.Style, c.Font.Unit);
            }
            //form.BackgroundImage = Properties.Resources.BACKGROUND_WHITE;
        }

        //utility function - intended use for above function
        private static void changeFontSize(Control control, int fs)
        {
            foreach (Control c in control.Controls)
            {
                if (c.HasChildren)
                    changeFontSize(c, fs);

                if (c is Button || (c is Label && c.Font.Size <= 12))
                    c.Font = new Font(c.Font.FontFamily, fs, c.Font.Style, c.Font.Unit);
            }
        }

        public static void setFontSize(int n)
        {
            fontSize = n;
        }

        public static int getFontSize()

        {
            return fontSize;
        }

        ///////////////////////
        //  Private methods  //
        ///////////////////////

        private void btnNavTempSearch_Click(object sender, EventArgs e)
        {
            SearchResults window = new SearchResults();
            window.setCaller(this);
            window.Show();
        }

        /* Favorites List button functionality - Opens the list form with the overloaded constructor setting the list as "Favorites"
         *                                       and the caller as this instance of the Discovery Form (aka "this") */
        private void lblFavoritesList_Click(object sender, EventArgs e)
        {
            ListView window = new ListView("Favorites", this);
            window.Show();
        }

        private void label1_Click(object sender, EventArgs e)
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

            setFontSize(fs);
        }

        // write to settings file
        private void saveSettings()
        {
            System.IO.File.WriteAllText(getSettingsFileLocation(), "fontsize=" + fontSize);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (btnSettings.Text == "Open Settings")
            {
                cmbSettingsSelection.Visible = true;
                btnSettings.Text = "Close Settings";
            }
            else
            {
                cmbSettingsSelection.Visible = false;
                gbFontSizeSettings.Visible = false;
                btnSettings.Text = "Open Settings";
                cmbSettingsSelection.Text = "Choose a setting";
            }
        }

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

        private void rbFontSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmallFont9.Checked)
                setFontSize(9);
            else if (rbMediumFont10.Checked)
                setFontSize(10);
            else if (rbLargeFont12.Checked)
                setFontSize(12);

            changeFontSize(this, fontSize);
            saveSettings();
        }
    }
}
