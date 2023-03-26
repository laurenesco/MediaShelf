using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MediaShelfApp
{
    public partial class Notes_Form : Form

    {        
        //////////////////////
        //  Public methods  //
        //////////////////////
        
        // Constructor
        public Notes_Form()
        {
            InitializeComponent();

            // Initiate Database Connection
            try
            {
                SqlConnection dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db1;Persist Security Info=True;User ID=mediaalt;Password=wehkun-7jYcnu-zidjaz");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        ///////////////////////
        //  Private methods  //
        ///////////////////////
        

    }
}
