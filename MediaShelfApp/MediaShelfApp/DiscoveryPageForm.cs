using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            foreach (Control c in form.Controls)
            {
                if (c.HasChildren)
                    changeFontSize(c, fs);
                c.Font = new Font(c.Font.FontFamily, fs, c.Font.Style, c.Font.Unit);
            }
        }

        //utility function - intended use for above function
        private static void changeFontSize(Control control, int fs)
        {
            foreach (Control c in control.Controls)
            {
                if (c.HasChildren)
                    changeFontSize(c, fs);
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

        private void btnNavTempMyShelf_Click(object sender, EventArgs e)
        {
            MyShelfForm window = new MyShelfForm();
            window.setCaller(this);
            window.Show();
        }

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
            System.IO.File.WriteAllText(getSettingsFileLocation(), "fontsize=" + getFontSize());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            setFontSize(10);
            changeFontSize(this, fontSize);
            saveSettings();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            setFontSize(12);
            changeFontSize(this, fontSize);
            saveSettings();
        }
    }
}

