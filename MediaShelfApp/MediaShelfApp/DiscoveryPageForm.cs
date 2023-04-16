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
            readSettings(); // uncomment to use settings file
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


            foreach (Control c in form.Controls)
            {
                if (c.HasChildren)
                    changeFontSize(c, fs, isDiscoveryForm);

                if (isDiscoveryForm && (c is Button || (c is Label && c.Font.Size <= 12) || c is GroupBox || c is ComboBox))
                    c.Font = new Font(c.Font.FontFamily, fs, c.Font.Style, c.Font.Unit);
                else if (!isDiscoveryForm)
                {
                    if (!(c is Label && c.Font.Size > 12))
                        c.Font = new Font(c.Font.FontFamily, fs, c.Font.Style, c.Font.Unit);
                }
            }
        }

        //utility function - intended use for above function
        private static void changeFontSize(Control control, int fs, bool isDiscoveryForm)
        {
            foreach (Control c in control.Controls)
            {
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

            changeFontSize(this, fontSize, true);
            saveSettings();
        }

        private void btnRecommendations_Click(object sender, EventArgs e)
        {
            Detailed_Recommendations window = new Detailed_Recommendations();
            window.setCaller(this);
            window.Show();
        }
    }
}
