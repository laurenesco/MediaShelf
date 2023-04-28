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
            lblFontSizeSettings = new Label();
            rbLargeFont12 = new RadioButton();
            rbMediumFont10 = new RadioButton();
            rbSmallFont9 = new RadioButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMusic
            // 
            btnMusic.BackColor = Color.Gold;
            btnMusic.BackgroundImage = (Image)resources.GetObject("btnMusic.BackgroundImage");
            btnMusic.BackgroundImageLayout = ImageLayout.Zoom;
            btnMusic.FlatAppearance.BorderColor = Color.Goldenrod;
            btnMusic.FlatAppearance.BorderSize = 7;
            btnMusic.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            btnMusic.FlatStyle = FlatStyle.Flat;
            btnMusic.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMusic.ImageAlign = ContentAlignment.BottomCenter;
            btnMusic.Location = new Point(420, 352);
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
            btnMovies.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMovies.FlatAppearance.BorderSize = 7;
            btnMovies.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnMovies.FlatStyle = FlatStyle.Flat;
            btnMovies.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMovies.Location = new Point(591, 159);
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
            btnTVShows.FlatAppearance.BorderColor = Color.DarkGreen;
            btnTVShows.FlatAppearance.BorderSize = 7;
            btnTVShows.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnTVShows.FlatStyle = FlatStyle.Flat;
            btnTVShows.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTVShows.Location = new Point(768, 352);
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
            btnBooks.FlatAppearance.BorderColor = Color.Firebrick;
            btnBooks.FlatAppearance.BorderSize = 7;
            btnBooks.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBooks.Location = new Point(250, 159);
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
            btnGames.FlatAppearance.BorderColor = Color.DarkViolet;
            btnGames.FlatAppearance.BorderSize = 7;
            btnGames.FlatAppearance.MouseDownBackColor = Color.DarkViolet;
            btnGames.FlatStyle = FlatStyle.Flat;
            btnGames.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGames.ForeColor = SystemColors.ControlText;
            btnGames.Location = new Point(934, 159);
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
            label1.Location = new Point(538, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 60);
            label1.TabIndex = 8;
            label1.Text = "MediaShelf";
            // 
            // lblManualEntries
            // 
            lblManualEntries.BackColor = Color.Transparent;
            lblManualEntries.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblManualEntries.ForeColor = SystemColors.ControlText;
            lblManualEntries.Location = new Point(2, 128);
            lblManualEntries.Margin = new Padding(2, 0, 2, 0);
            lblManualEntries.MinimumSize = new Size(185, 32);
            lblManualEntries.Name = "lblManualEntries";
            lblManualEntries.Size = new Size(185, 32);
            lblManualEntries.TabIndex = 64;
            lblManualEntries.Text = "Manual Entries";
            lblManualEntries.Click += lblManualEntries_Click;
            // 
            // lblWishlist
            // 
            lblWishlist.BackColor = Color.Transparent;
            lblWishlist.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblWishlist.ForeColor = SystemColors.ControlText;
            lblWishlist.Location = new Point(2, 64);
            lblWishlist.Margin = new Padding(2, 0, 2, 0);
            lblWishlist.MinimumSize = new Size(104, 32);
            lblWishlist.Name = "lblWishlist";
            lblWishlist.Size = new Size(104, 32);
            lblWishlist.TabIndex = 63;
            lblWishlist.Text = "Wishlist";
            lblWishlist.Click += lblWishlist_Click;
            // 
            // label22
            // 
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = SystemColors.ControlText;
            label22.Location = new Point(2, 96);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.MinimumSize = new Size(578, 32);
            label22.Name = "label22";
            label22.Size = new Size(578, 32);
            label22.TabIndex = 60;
            label22.Text = "Media that have been Wishlisted will be placed here.\r\n";
            // 
            // label23
            // 
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = SystemColors.ControlText;
            label23.Location = new Point(2, 160);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.MinimumSize = new Size(441, 32);
            label23.Name = "label23";
            label23.Size = new Size(441, 32);
            label23.TabIndex = 59;
            label23.Text = "Your manual entries will be placed here.";
            // 
            // label24
            // 
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.ControlText;
            label24.Location = new Point(2, 32);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.MinimumSize = new Size(564, 32);
            label24.Name = "label24";
            label24.Size = new Size(564, 32);
            label24.TabIndex = 58;
            label24.Text = "Media that have been favorited will be placed here.";
            // 
            // lblFavoritesList
            // 
            lblFavoritesList.BackColor = Color.Transparent;
            lblFavoritesList.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFavoritesList.ForeColor = SystemColors.ControlText;
            lblFavoritesList.Location = new Point(2, 0);
            lblFavoritesList.Margin = new Padding(2, 0, 2, 0);
            lblFavoritesList.MinimumSize = new Size(117, 32);
            lblFavoritesList.Name = "lblFavoritesList";
            lblFavoritesList.Size = new Size(117, 32);
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
            btnSearch.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(15, 14);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 45);
            btnSearch.TabIndex = 65;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblTags
            // 
            lblTags.BackColor = Color.Transparent;
            lblTags.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTags.ForeColor = SystemColors.ControlText;
            lblTags.Location = new Point(2, 192);
            lblTags.Margin = new Padding(2, 0, 2, 0);
            lblTags.MinimumSize = new Size(67, 32);
            lblTags.Name = "lblTags";
            lblTags.Size = new Size(67, 32);
            lblTags.TabIndex = 66;
            lblTags.Text = "Tags";
            lblTags.Click += lblTags_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(2, 224);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.MinimumSize = new Size(207, 32);
            label3.Name = "label3";
            label3.Size = new Size(207, 32);
            label3.TabIndex = 67;
            label3.Text = "Manage your tags";
            // 
            // lblFontSizeSettings
            // 
            lblFontSizeSettings.BackColor = Color.Transparent;
            lblFontSizeSettings.Font = new Font("Ebrima", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblFontSizeSettings.ForeColor = SystemColors.ControlText;
            lblFontSizeSettings.Location = new Point(1061, 9);
            lblFontSizeSettings.Margin = new Padding(2, 0, 2, 0);
            lblFontSizeSettings.Name = "lblFontSizeSettings";
            lblFontSizeSettings.Size = new Size(283, 44);
            lblFontSizeSettings.TabIndex = 71;
            lblFontSizeSettings.Text = "Font Size Settings";
            // 
            // rbLargeFont12
            // 
            rbLargeFont12.BackColor = Color.Transparent;
            rbLargeFont12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbLargeFont12.Location = new Point(1253, 56);
            rbLargeFont12.Name = "rbLargeFont12";
            rbLargeFont12.Size = new Size(97, 36);
            rbLargeFont12.TabIndex = 70;
            rbLargeFont12.Text = "Large";
            rbLargeFont12.UseVisualStyleBackColor = false;
            rbLargeFont12.CheckedChanged += rbFontSettings_CheckedChanged;
            // 
            // rbMediumFont10
            // 
            rbMediumFont10.BackColor = Color.Transparent;
            rbMediumFont10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbMediumFont10.Location = new Point(1137, 56);
            rbMediumFont10.Name = "rbMediumFont10";
            rbMediumFont10.Size = new Size(110, 32);
            rbMediumFont10.TabIndex = 69;
            rbMediumFont10.Text = "Medium";
            rbMediumFont10.UseVisualStyleBackColor = false;
            rbMediumFont10.CheckedChanged += rbFontSettings_CheckedChanged;
            // 
            // rbSmallFont9
            // 
            rbSmallFont9.BackColor = Color.Transparent;
            rbSmallFont9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbSmallFont9.Location = new Point(1051, 56);
            rbSmallFont9.Name = "rbSmallFont9";
            rbSmallFont9.Size = new Size(80, 29);
            rbSmallFont9.TabIndex = 68;
            rbSmallFont9.Tag = "";
            rbSmallFont9.Text = "Small";
            rbSmallFont9.UseVisualStyleBackColor = false;
            rbSmallFont9.CheckedChanged += rbFontSettings_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(lblFavoritesList);
            flowLayoutPanel1.Controls.Add(label24);
            flowLayoutPanel1.Controls.Add(lblWishlist);
            flowLayoutPanel1.Controls.Add(label22);
            flowLayoutPanel1.Controls.Add(lblManualEntries);
            flowLayoutPanel1.Controls.Add(label23);
            flowLayoutPanel1.Controls.Add(lblTags);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(367, 639);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(582, 256);
            flowLayoutPanel1.TabIndex = 72;
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
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblFontSizeSettings);
            Controls.Add(rbSmallFont9);
            Controls.Add(rbMediumFont10);
            Controls.Add(rbLargeFont12);
            Controls.Add(btnSearch);
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
            flowLayoutPanel1.ResumeLayout(false);
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
        private Label lblFontSizeSettings;
        private RadioButton rbLargeFont12;
        private RadioButton rbMediumFont10;
        private RadioButton rbSmallFont9;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}