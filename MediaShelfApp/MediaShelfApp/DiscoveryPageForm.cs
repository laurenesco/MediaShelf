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
    public partial class DiscoveryPageForm : Form
    {
        public DiscoveryPageForm()
        {
            InitializeComponent();
        }

        private void btnNavRecs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detailed_Recommendations window = new Detailed_Recommendations();
            window.caller = this;
            window.Show();
        }

        private void btnNavSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchResults window = new SearchResults();
            window.caller = this;
            window.Show();
        }

        private void btnNavMyShelf_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyShelfForm window = new MyShelfForm();
            window.caller = this;
            window.Show();
        }
    }
}
