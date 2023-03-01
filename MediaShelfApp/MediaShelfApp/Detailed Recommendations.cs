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
    public partial class Detailed_Recommendations : Form
    {
        //variable that keeps track of which form called this one (the previous page)
        private Form previousForm;
        
        public Detailed_Recommendations(Form previousForm)
        {
            //record previous page then hide it
            this.previousForm = previousForm;
            this.previousForm.Hide();

            //open current page
            InitializeComponent();
        }

        //a button that returns user to previous page (in this case, the discover page) upon click
        private void lbl_backButton_Click(object sender, EventArgs e)
        {
            Hide();
            previousForm.Show();
            Close();
        }
    }
}
