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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            label1 = new Label();
            button6 = new Button();
            label9 = new Label();
            label13 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.Goldenrod;
            button1.FlatAppearance.BorderSize = 7;
            button1.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(318, 318);
            button1.Name = "button1";
            button1.Size = new Size(167, 167);
            button1.TabIndex = 0;
            button1.Text = "Music";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnMusic;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 7;
            button2.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(489, 124);
            button2.Name = "button2";
            button2.Size = new Size(167, 154);
            button2.TabIndex = 1;
            button2.Text = "Movies";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnMovies;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderColor = Color.DarkGreen;
            button3.FlatAppearance.BorderSize = 7;
            button3.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(665, 318);
            button3.Name = "button3";
            button3.Size = new Size(167, 167);
            button3.TabIndex = 2;
            button3.Text = "TV Shows";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnTVShows;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderColor = Color.Firebrick;
            button4.FlatAppearance.BorderSize = 7;
            button4.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(148, 124);
            button4.Name = "button4";
            button4.Size = new Size(167, 154);
            button4.TabIndex = 3;
            button4.Text = "Books";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnBooks;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkOrchid;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatAppearance.BorderColor = Color.DarkViolet;
            button7.FlatAppearance.BorderSize = 7;
            button7.FlatAppearance.MouseDownBackColor = Color.DarkViolet;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlText;
            button7.Location = new Point(831, 124);
            button7.Name = "button7";
            button7.Size = new Size(167, 154);
            button7.TabIndex = 6;
            button7.Text = "Games";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnGames;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ebrima", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(460, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 60);
            label1.TabIndex = 8;
            label1.Text = "MediaShelf";
            label1.Click += lblTopName;
            // 
            // button6
            // 
            button6.BackColor = Color.LightGray;
            button6.Font = new Font("Ebrima", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(23, 27);
            button6.Name = "button6";
            button6.Size = new Size(130, 30);
            button6.TabIndex = 9;
            button6.Text = "Search Bar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnSearchBar;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(151, 708);
            label9.Name = "label9";
            label9.Size = new Size(154, 28);
            label9.TabIndex = 64;
            label9.Text = "Manual Entries";
            label9.Click += label9_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(151, 659);
            label13.Name = "label13";
            label13.Size = new Size(88, 28);
            label13.TabIndex = 63;
            label13.Text = "Wishlist";
            label13.Click += lblWishlistList;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = SystemColors.ControlText;
            label22.Location = new Point(151, 687);
            label22.Name = "label22";
            label22.Size = new Size(523, 25);
            label22.TabIndex = 60;
            label22.Text = "Description: Media that have been Wishlisted will be placed here.\r\n";
            label22.Click += lblWishlistDescription;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = SystemColors.ControlText;
            label23.Location = new Point(151, 736);
            label23.Name = "label23";
            label23.Size = new Size(423, 25);
            label23.TabIndex = 59;
            label23.Text = "Description: Your manual entries will be placed here.";
            label23.Click += label23_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.ControlText;
            label24.Location = new Point(151, 636);
            label24.Name = "label24";
            label24.Size = new Size(513, 75);
            label24.TabIndex = 58;
            label24.Text = "Description: Media that have been favorited will be placed here.\r\n\r\n\r\n";
            label24.Click += lblFavoritesDescription;
            // 
            // lblFavoritesList
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label25.ForeColor = SystemColors.ControlText;
            label25.Location = new Point(151, 608);
            label25.Name = "label25";
            label25.Size = new Size(98, 28);
            label25.TabIndex = 57;
            label25.Text = "Favorites";
            label25.Click += lblFavoritesList;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Ebrima", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label26.ForeColor = SystemColors.ControlText;
            label26.Location = new Point(545, 569);
            label26.Name = "label26";
            label26.Size = new Size(80, 41);
            label26.TabIndex = 56;
            label26.Text = "Lists";
            label26.Click += lblListHeader;

            // 
            // btnNavTempSearch
            // 
            this.btnNavTempSearch.Location = new System.Drawing.Point(12, 12);
            this.btnNavTempSearch.Name = "btnNavTempSearch";
            this.btnNavTempSearch.Size = new System.Drawing.Size(94, 29);
            this.btnNavTempSearch.TabIndex = 67;
            this.btnNavTempSearch.Text = "Search";
            this.btnNavTempSearch.UseVisualStyleBackColor = true;
            this.btnNavTempSearch.Click += new System.EventHandler(this.btnNavTempSearch_Click);

            // 
            // DiscoveryPageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1246, 752);
            Controls.Add(label9);
            Controls.Add(label13);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnNavTempSearch);
            Name = "DiscoveryPageForm";
            Text = "DiscoveryPageForm";
            Load += DiscoveryPageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button7;
        private Label label1;
        private Button button6;
        private Label label9;
        private Label label13;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label lblFavoritesList;
        private Label label26;
        private Button btnNavTempSearch;
        private Button btnNavTempMyShelf;
    }
}