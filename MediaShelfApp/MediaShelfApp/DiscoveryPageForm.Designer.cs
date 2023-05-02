namespace MediaShelfApp
{
    partial class DiscoveryPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscoveryPageForm));
            btnMusic = new Button();
            btnMovies = new Button();
            btnTVShows = new Button();
            btnBooks = new Button();
            btnGames = new Button();
            label1 = new Label();
            lblManualEntries = new Label();
            lblWishlist = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            lblFavoritesList = new Label();
            label26 = new Label();
            btnSearch = new Button();
            lblTags = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnMusic
            // 
            btnMusic.BackColor = Color.Gold;
            btnMusic.BackgroundImage = (Image)resources.GetObject("btnMusic.BackgroundImage");
            btnMusic.BackgroundImageLayout = ImageLayout.Zoom;
            btnMusic.Cursor = Cursors.Hand;
            btnMusic.FlatAppearance.BorderColor = Color.Goldenrod;
            btnMusic.FlatAppearance.BorderSize = 7;
            btnMusic.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            btnMusic.FlatStyle = FlatStyle.Flat;
            btnMusic.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMusic.ImageAlign = ContentAlignment.BottomCenter;
            btnMusic.Location = new Point(412, 352);
            btnMusic.Margin = new Padding(2);
            btnMusic.Name = "btnMusic";
            btnMusic.Size = new Size(168, 168);
            btnMusic.TabIndex = 0;
            btnMusic.Text = "Music";
            btnMusic.TextAlign = ContentAlignment.BottomCenter;
            btnMusic.UseVisualStyleBackColor = false;
            btnMusic.Click += btnMusic_Click;
            // 
            // btnMovies
            // 
            btnMovies.BackColor = Color.DodgerBlue;
            btnMovies.BackgroundImage = (Image)resources.GetObject("btnMovies.BackgroundImage");
            btnMovies.BackgroundImageLayout = ImageLayout.Zoom;
            btnMovies.Cursor = Cursors.Hand;
            btnMovies.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMovies.FlatAppearance.BorderSize = 7;
            btnMovies.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnMovies.FlatStyle = FlatStyle.Flat;
            btnMovies.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMovies.Location = new Point(594, 159);
            btnMovies.Margin = new Padding(2);
            btnMovies.Name = "btnMovies";
            btnMovies.Size = new Size(168, 154);
            btnMovies.TabIndex = 1;
            btnMovies.Text = "Movies";
            btnMovies.TextAlign = ContentAlignment.BottomCenter;
            btnMovies.UseVisualStyleBackColor = false;
            btnMovies.Click += btnMovies_Click;
            // 
            // btnTVShows
            // 
            btnTVShows.BackColor = Color.ForestGreen;
            btnTVShows.BackgroundImage = (Image)resources.GetObject("btnTVShows.BackgroundImage");
            btnTVShows.BackgroundImageLayout = ImageLayout.Stretch;
            btnTVShows.Cursor = Cursors.Hand;
            btnTVShows.FlatAppearance.BorderColor = Color.DarkGreen;
            btnTVShows.FlatAppearance.BorderSize = 7;
            btnTVShows.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnTVShows.FlatStyle = FlatStyle.Flat;
            btnTVShows.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTVShows.Location = new Point(776, 352);
            btnTVShows.Margin = new Padding(2);
            btnTVShows.Name = "btnTVShows";
            btnTVShows.Size = new Size(168, 168);
            btnTVShows.TabIndex = 2;
            btnTVShows.Text = "TV Shows";
            btnTVShows.TextAlign = ContentAlignment.BottomCenter;
            btnTVShows.UseVisualStyleBackColor = false;
            btnTVShows.Click += btnTVShows_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.Red;
            btnBooks.BackgroundImage = (Image)resources.GetObject("btnBooks.BackgroundImage");
            btnBooks.BackgroundImageLayout = ImageLayout.Zoom;
            btnBooks.Cursor = Cursors.Hand;
            btnBooks.FlatAppearance.BorderColor = Color.Firebrick;
            btnBooks.FlatAppearance.BorderSize = 7;
            btnBooks.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBooks.Location = new Point(235, 159);
            btnBooks.Margin = new Padding(2);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(168, 154);
            btnBooks.TabIndex = 3;
            btnBooks.Text = "Books";
            btnBooks.TextAlign = ContentAlignment.BottomCenter;
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnGames
            // 
            btnGames.BackColor = Color.DarkOrchid;
            btnGames.BackgroundImage = (Image)resources.GetObject("btnGames.BackgroundImage");
            btnGames.BackgroundImageLayout = ImageLayout.Zoom;
            btnGames.Cursor = Cursors.Hand;
            btnGames.FlatAppearance.BorderColor = Color.DarkViolet;
            btnGames.FlatAppearance.BorderSize = 7;
            btnGames.FlatAppearance.MouseDownBackColor = Color.DarkViolet;
            btnGames.FlatStyle = FlatStyle.Flat;
            btnGames.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGames.ForeColor = SystemColors.ControlText;
            btnGames.Location = new Point(953, 159);
            btnGames.Margin = new Padding(2);
            btnGames.Name = "btnGames";
            btnGames.Size = new Size(168, 154);
            btnGames.TabIndex = 6;
            btnGames.Text = "Games";
            btnGames.TextAlign = ContentAlignment.BottomCenter;
            btnGames.UseVisualStyleBackColor = false;
            btnGames.Click += btnGames_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ebrima", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(542, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 60);
            label1.TabIndex = 8;
            label1.Text = "MediaShelf";
            // 
            // lblManualEntries
            // 
            lblManualEntries.AutoSize = true;
            lblManualEntries.BackColor = Color.Transparent;
            lblManualEntries.Cursor = Cursors.Hand;
            lblManualEntries.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblManualEntries.ForeColor = SystemColors.ControlText;
            lblManualEntries.Location = new Point(458, 774);
            lblManualEntries.Margin = new Padding(2, 0, 2, 0);
            lblManualEntries.Name = "lblManualEntries";
            lblManualEntries.Size = new Size(154, 28);
            lblManualEntries.TabIndex = 64;
            lblManualEntries.Text = "Manual Entries";
            lblManualEntries.Click += lblManualEntries_Click;
            // 
            // lblWishlist
            // 
            lblWishlist.AutoSize = true;
            lblWishlist.BackColor = Color.Transparent;
            lblWishlist.Cursor = Cursors.Hand;
            lblWishlist.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblWishlist.ForeColor = SystemColors.ControlText;
            lblWishlist.Location = new Point(460, 716);
            lblWishlist.Margin = new Padding(2, 0, 2, 0);
            lblWishlist.Name = "lblWishlist";
            lblWishlist.Size = new Size(88, 28);
            lblWishlist.TabIndex = 63;
            lblWishlist.Text = "Wishlist";
            lblWishlist.Click += lblWishlist_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = SystemColors.ControlText;
            label22.Location = new Point(458, 744);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(424, 25);
            label22.TabIndex = 60;
            label22.Text = "Media that have been Wishlisted will be placed here.\r\n";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = SystemColors.ControlText;
            label23.Location = new Point(458, 797);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(324, 25);
            label23.TabIndex = 59;
            label23.Text = "Your manual entries will be placed here.";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.ControlText;
            label24.Location = new Point(458, 689);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(414, 75);
            label24.TabIndex = 58;
            label24.Text = "Media that have been favorited will be placed here.\r\n\r\n\r\n";
            // 
            // lblFavoritesList
            // 
            lblFavoritesList.AutoSize = true;
            lblFavoritesList.BackColor = Color.Transparent;
            lblFavoritesList.Cursor = Cursors.Hand;
            lblFavoritesList.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblFavoritesList.ForeColor = SystemColors.ControlText;
            lblFavoritesList.Location = new Point(458, 661);
            lblFavoritesList.Margin = new Padding(2, 0, 2, 0);
            lblFavoritesList.Name = "lblFavoritesList";
            lblFavoritesList.Size = new Size(98, 28);
            lblFavoritesList.TabIndex = 57;
            lblFavoritesList.Text = "Favorites";
            lblFavoritesList.Click += lblFavoritesList_Click_1;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Ebrima", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = SystemColors.ControlText;
            label26.Location = new Point(628, 595);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(80, 41);
            label26.TabIndex = 56;
            label26.Text = "Lists";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(15, 14);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 36);
            btnSearch.TabIndex = 65;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblTags
            // 
            lblTags.AutoSize = true;
            lblTags.BackColor = Color.Transparent;
            lblTags.Cursor = Cursors.Hand;
            lblTags.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTags.ForeColor = SystemColors.ControlText;
            lblTags.Location = new Point(460, 824);
            lblTags.Margin = new Padding(2, 0, 2, 0);
            lblTags.Name = "lblTags";
            lblTags.Size = new Size(56, 28);
            lblTags.TabIndex = 66;
            lblTags.Text = "Tags";
            lblTags.Click += lblTags_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(461, 851);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 67;
            label3.Text = "Manage your tags";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(549, 633);
            label2.Name = "label2";
            label2.Size = new Size(241, 3);
            label2.TabIndex = 68;
            label2.Text = resources.GetString("label2.Text");
            // 
            // DiscoveryPageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1355, 951);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblTags);
            Controls.Add(btnSearch);
            Controls.Add(lblManualEntries);
            Controls.Add(lblWishlist);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(lblFavoritesList);
            Controls.Add(label26);
            Controls.Add(label1);
            Controls.Add(btnGames);
            Controls.Add(btnBooks);
            Controls.Add(btnTVShows);
            Controls.Add(btnMovies);
            Controls.Add(btnMusic);
            Margin = new Padding(2);
            Name = "DiscoveryPageForm";
            Text = "DiscoveryPageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMusic;
        private Button btnMovies;
        private Button btnTVShows;
        private Button btnBooks;
        private Button btnGames;
        private Label label1;
        private Label lblManualEntries;
        private Label lblWishlist;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label lblFavoritesList;
        private Label label26;
        private Button btnNavTempSearch;
        private Button btnNavTempMyShelf;
        private Button btnSearch;
        private Label lblTags;
        private Label label3;
        private Label label2;
    }
}