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
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnMovies;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSeaGreen;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(738, 221);
            button3.Name = "button3";
            button3.Size = new Size(110, 110);
            button3.TabIndex = 2;
            button3.Text = "TV Shows";
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
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnBooks;
            // 
            // button7
            // 
            button7.BackColor = Color.MediumPurple;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlText;
            button7.Location = new Point(903, 92);
            button7.Name = "button7";
            button7.Size = new Size(110, 110);
            button7.TabIndex = 6;
            button7.Text = "Games";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnGames;
            // 
            // label1
            // <<<<<<< HEAD
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ebrima", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(503, 18);
            label1.Name = "label1";
            label1.Size = new Size(260, 60);
            label1.TabIndex = 8;
            label1.Text = "MediaShelf";
            label1.Click += lblTopName;
//=======
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(402, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "MediaShelf";
            this.label1.Click += new System.EventHandler(this.lblTopName);
//>>>>>>> main
            // 
            // Recommendations
            // 
            Recommendations.AutoSize = true;
            Recommendations.BackColor = Color.Transparent;
            Recommendations.Font = new Font("Ebrima", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Recommendations.ForeColor = SystemColors.ControlText;
            Recommendations.Location = new Point(523, 349);
            Recommendations.Name = "Recommendations";
            Recommendations.Size = new Size(227, 32);
            Recommendations.TabIndex = 10;
            Recommendations.Text = "Recommendations";
            Recommendations.Click += lblRecommendations;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(306, 381);
            label2.Name = "label2";
            label2.Size = new Size(622, 28);
            label2.TabIndex = 11;
            label2.Text = "Based on your favorites/wishlist, [TAG] is your most viewed tag ";
            label2.Click += lblBasedOnYourInfo;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(306, 409);
            label3.Name = "label3";
            label3.Size = new Size(270, 28);
            label3.TabIndex = 12;
            label3.Text = "Other titles with [TAG] tag:";
            label3.Click += lblOtherTitlesWithTag;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(94, 455);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 106);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += picBox1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(199, 455);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 17;
            label4.Text = "Title";
            label4.Click += lblTitle1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(624, 455);
            label5.Name = "label5";
            label5.Size = new Size(55, 28);
            label5.TabIndex = 20;
            label5.Text = "Title";
            label5.Click += lblTitle2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(199, 482);
            label10.Name = "label10";
            label10.Size = new Size(62, 25);
            label10.TabIndex = 25;
            label10.Text = "Genre:";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(624, 482);
            label11.Name = "label11";
            label11.Size = new Size(62, 25);
            label11.TabIndex = 26;
            label11.Text = "Genre:";
            label11.Click += label11_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(257, 488);
            button8.Name = "button8";
            button8.Size = new Size(45, 20);
            button8.TabIndex = 31;
            button8.Text = "Horror";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnTag1;
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
            // button14
            // 
            button14.BackColor = Color.Gainsboro;
            button14.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button14.ForeColor = SystemColors.ActiveCaptionText;
            button14.Location = new Point(1046, 708);
            button14.Name = "button14";
            button14.Size = new Size(110, 34);
            button14.TabIndex = 37;
            button14.Text = "See More";
            button14.UseVisualStyleBackColor = false;
            button14.Click += btnSeeMoreRecommendations;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(523, 455);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 106);
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            pictureBox2.Click += picBox2;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(692, 488);
            button15.Name = "button15";
            button15.Size = new Size(45, 20);
            button15.TabIndex = 39;
            button15.Text = "Horror";
            button15.UseVisualStyleBackColor = true;
            button15.Click += btnTag2;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(1106, 483);
            button9.Name = "button9";
            button9.Size = new Size(45, 20);
            button9.TabIndex = 43;
            button9.Text = "Horror";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnTag3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Location = new Point(945, 455);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(104, 106);
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            pictureBox3.Click += picBox3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ControlText;
            label16.Location = new Point(1048, 482);
            label16.Name = "label16";
            label16.Size = new Size(62, 25);
            label16.TabIndex = 41;
            label16.Text = "Genre:";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlText;
            label17.Location = new Point(1046, 455);
            label17.Name = "label17";
            label17.Size = new Size(55, 28);
            label17.TabIndex = 40;
            label17.Text = "Title";
            label17.Click += lblTitle3;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(257, 618);
            button10.Name = "button10";
            button10.Size = new Size(45, 20);
            button10.TabIndex = 47;
            button10.Text = "Horror";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnTag4;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Location = new Point(94, 585);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(104, 106);
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            pictureBox4.Click += picBox4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(195, 613);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 45;
            label6.Text = "Genre:";
            label6.Click += label6_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(195, 585);
            label12.Name = "label12";
            label12.Size = new Size(55, 28);
            label12.TabIndex = 44;
            label12.Text = "Title";
            label12.Click += lblTitle4;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(683, 619);
            button16.Name = "button16";
            button16.Size = new Size(45, 20);
            button16.TabIndex = 51;
            button16.Text = "Horror";
            button16.UseVisualStyleBackColor = true;
            button16.Click += btnTag5;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Location = new Point(523, 585);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(104, 106);
            pictureBox5.TabIndex = 50;
            pictureBox5.TabStop = false;
            pictureBox5.Click += picBox5;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ControlText;
            label18.Location = new Point(624, 613);
            label18.Name = "label18";
            label18.Size = new Size(62, 25);
            label18.TabIndex = 49;
            label18.Text = "Genre:";
            label18.Click += label18_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ControlText;
            label19.Location = new Point(624, 585);
            label19.Name = "label19";
            label19.Size = new Size(55, 28);
            label19.TabIndex = 48;
            label19.Text = "Title";
            label19.Click += lblTitle5;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(1106, 613);
            button17.Name = "button17";
            button17.Size = new Size(45, 20);
            button17.TabIndex = 55;
            button17.Text = "Horror";
            button17.UseVisualStyleBackColor = true;
            button17.Click += btnTag6;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Location = new Point(945, 585);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(104, 106);
            pictureBox6.TabIndex = 54;
            pictureBox6.TabStop = false;
            pictureBox6.Click += picBox6;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ControlText;
            label20.Location = new Point(1046, 613);
            label20.Name = "label20";
            label20.Size = new Size(62, 25);
            label20.TabIndex = 53;
            label20.Text = "Genre:";
            label20.Click += label20_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Ebrima", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ControlText;
            label21.Location = new Point(1046, 585);
            label21.Name = "label21";
            label21.Size = new Size(55, 28);
            label21.TabIndex = 52;
            label21.Text = "Title";
            label21.Click += lblTitle6;
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