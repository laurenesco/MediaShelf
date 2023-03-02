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
    public partial class Manual_Entry_Form : Form
    {
        // Instance variables:
        // caller   - form which invoked this form
        // list     - list intended to be added to
        private ListView caller = null!;
        private String list = null!;

        //////////////////////
        //  Public methods  //
        //////////////////////

        // Constructor
        public Manual_Entry_Form()
        {
            InitializeComponent();
        }

        // Set caller method - this variable allows the back button to reopen the calling form
        public void setCaller(ListView caller)
        {
            this.caller = caller;
        }

        // Set list method - this variable allows the form to display the correct list
        public void setList(String listName)
        {
            this.list = listName;
        }

        //////////////////////
        //  Priate methods  //
        //////////////////////

        // Back button functionality - reopens calling form
        private void btnNavBack_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }
    }
}
