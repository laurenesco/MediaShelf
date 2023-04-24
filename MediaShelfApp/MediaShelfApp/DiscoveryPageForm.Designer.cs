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
            Recommendations = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            label11 = new Label();
            button8 = new Button();
            button6 = new Button();
            button14 = new Button();
            pictureBox2 = new PictureBox();
            button15 = new Button();
            button9 = new Button();
            pictureBox3 = new PictureBox();
            label16 = new Label();
            label17 = new Label();
            button10 = new Button();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            label12 = new Label();
            button16 = new Button();
            pictureBox5 = new PictureBox();
            label18 = new Label();
            label19 = new Label();
            button17 = new Button();
            pictureBox6 = new PictureBox();
            label20 = new Label();
            label21 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(396, 221);
            button1.Name = "button1";
            button1.Size = new Size(110, 110);
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
            button2.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(569, 92);
            button2.Name = "button2";
            button2.Size = new Size(110, 110);
            button2.TabIndex = 1;
            button2.Text = "Movies";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnMovies;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSeaGreen;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(738, 221);
            button3.Name = "button3";
            button3.Size = new Size(110, 110);
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
            button4.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(217, 92);
            button4.Name = "button4";
            button4.Size = new Size(110, 110);
            button4.TabIndex = 3;
            button4.Text = "Books";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnBooks;
            // 
            // button7
            // 
            button7.BackColor = Color.MediumPurple;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlText;
            button7.Location = new Point(903, 92);
            button7.Name = "button7";
            button7.Size = new Size(110, 110);
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
            label1.Location = new Point(501, 14);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(92, 963);
            label7.Name = "label7";
            label7.Size = new Size(75, 28);
            label7.TabIndex = 66;
            label7.Text = "List #3";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(92, 910);
            label8.Name = "label8";
            label8.Size = new Size(75, 28);
            label8.TabIndex = 65;
            label8.Text = "List #2";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(92, 861);
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
            label13.Location = new Point(92, 812);
            label13.Name = "label13";
            label13.Size = new Size(88, 28);
            label13.TabIndex = 63;
            label13.Text = "Wishlist";
            label13.Click += lblWishlistList;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ControlText;
            label14.Location = new Point(92, 991);
            label14.Name = "label14";
            label14.Size = new Size(106, 25);
            label14.TabIndex = 62;
            label14.Text = "Description:";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ControlText;
            label15.Location = new Point(92, 938);
            label15.Name = "label15";
            label15.Size = new Size(106, 25);
            label15.TabIndex = 61;
            label15.Text = "Description:";
            label15.Click += label15_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = SystemColors.ControlText;
            label22.Location = new Point(92, 840);
            label22.Name = "label22";
            label22.Size = new Size(518, 25);
            label22.TabIndex = 60;
            label22.Text = "Description: Items that have been Wishlisted will be placed here.\r\n";
            label22.Click += lblWishlistDescription;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = SystemColors.ControlText;
            label23.Location = new Point(92, 889);
            label23.Name = "label23";
            label23.Size = new Size(106, 25);
            label23.TabIndex = 59;
            label23.Text = "Description:";
            label23.Click += label23_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.ControlText;
            label24.Location = new Point(92, 789);
            label24.Name = "label24";
            label24.Size = new Size(508, 75);
            label24.TabIndex = 58;
            label24.Text = "Description: Items that have been favorited will be placed here.\r\n\r\n\r\n";
            label24.Click += lblFavoritesDescription;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label25.ForeColor = SystemColors.ControlText;
            label25.Location = new Point(92, 761);
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
            label26.Font = new Font("Ebrima", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label26.ForeColor = SystemColors.ControlText;
            label26.Location = new Point(594, 739);
            label26.Name = "label26";
            label26.Size = new Size(64, 32);
            label26.TabIndex = 56;
            label26.Text = "Lists";
            label26.Click += lblListHeader;
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
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(button17);
            Controls.Add(pictureBox6);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(button16);
            Controls.Add(pictureBox5);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(button10);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(button9);
            Controls.Add(pictureBox3);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(button15);
            Controls.Add(pictureBox2);
            Controls.Add(button14);
            Controls.Add(button8);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Recommendations);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "DiscoveryPageForm";
            Text = "DiscoveryPageForm";
            Load += DiscoveryPageForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private Label Recommendations;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label10;
        private Label label11;
        private Button button8;
        private Button button6;
        private Button button14;
        private PictureBox pictureBox2;
        private Button button15;
        private Button button9;
        private PictureBox pictureBox3;
        private Label label16;
        private Label label17;
        private Button button10;
        private PictureBox pictureBox4;
        private Label label6;
        private Label label12;
        private Button button16;
        private PictureBox pictureBox5;
        private Label label18;
        private Label label19;
        private Button button17;
        private PictureBox pictureBox6;
        private Label label20;
        private Label label21;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
    }
}