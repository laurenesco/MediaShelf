﻿using System;
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
    public partial class MyShelfForm : Form
    {
        public MyShelfForm()
        {
            InitializeComponent();
            // Initiate Database Connection
            /*
            SqlConnection dbConnection = new SqlConnection(@"Data Source=media-data-1-sv.database.windows.net;Initial Catalog=media-store-db1;Persist Security Info=True;User ID=;Password=");
            dbConnection.Open();
            SqlCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM API;";
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                MessageBox.Show(rd["api_name"].ToString());
            }
            dbConnection.Close();
            */
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
