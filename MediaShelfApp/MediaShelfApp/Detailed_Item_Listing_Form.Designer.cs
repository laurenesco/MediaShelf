namespace MediaShelfApp
{
    partial class Detailed_Item_Listing_Form
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
            splitContainer1 = new SplitContainer();
            btnRecommendations = new Button();
            btnNavBack = new Button();
            pbMovieImage = new PictureBox();
            pbBookImage = new PictureBox();
            pbGameImage = new PictureBox();
            pbMusicImage = new PictureBox();
            txtDescriptionValue = new TextBox();
            lblReleaseDateValue = new Label();
            lblGenreValue = new Label();
            lblCreatorValue = new Label();
            lblDescriptionTitle = new Label();
            lblReleaseDateTitle = new Label();
            lblGenreTitle = new Label();
            lblCreatorTitle = new Label();
            lblTitle = new Label();
            cmbAddToList = new ComboBox();
            btnFavorite = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMovieImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBookImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGameImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMusicImage).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnRecommendations);
            splitContainer1.Panel1.Controls.Add(btnNavBack);
            splitContainer1.Panel1.Controls.Add(pbMovieImage);
            splitContainer1.Panel1.Controls.Add(pbBookImage);
            splitContainer1.Panel1.Controls.Add(pbGameImage);
            splitContainer1.Panel1.Controls.Add(pbMusicImage);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtDescriptionValue);
            splitContainer1.Panel2.Controls.Add(lblReleaseDateValue);
            splitContainer1.Panel2.Controls.Add(lblGenreValue);
            splitContainer1.Panel2.Controls.Add(lblCreatorValue);
            splitContainer1.Panel2.Controls.Add(lblDescriptionTitle);
            splitContainer1.Panel2.Controls.Add(lblReleaseDateTitle);
            splitContainer1.Panel2.Controls.Add(lblGenreTitle);
            splitContainer1.Panel2.Controls.Add(lblCreatorTitle);
            splitContainer1.Panel2.Controls.Add(lblTitle);
            splitContainer1.Panel2.Controls.Add(cmbAddToList);
            splitContainer1.Panel2.Controls.Add(btnFavorite);
            splitContainer1.Size = new Size(1172, 698);
            splitContainer1.SplitterDistance = 461;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // btnRecommendations
            // 
            btnRecommendations.Location = new Point(184, 8);
            btnRecommendations.Name = "btnRecommendations";
            btnRecommendations.Size = new Size(207, 36);
            btnRecommendations.TabIndex = 5;
            btnRecommendations.Text = "Recommendations";
            btnRecommendations.UseVisualStyleBackColor = true;
            btnRecommendations.Click += btnRecommendations_Click;
            // 
            // btnNavBack
            // 
            btnNavBack.Location = new Point(22, 8);
            btnNavBack.Margin = new Padding(4);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(131, 36);
            btnNavBack.TabIndex = 1;
            btnNavBack.Text = "Back";
            btnNavBack.UseVisualStyleBackColor = true;
            btnNavBack.Click += btnNavBack_Click;
            // 
            // pbMovieImage
            // 
            pbMovieImage.Location = new Point(79, 70);
            pbMovieImage.Margin = new Padding(4);
            pbMovieImage.Name = "pbMovieImage";
            pbMovieImage.Size = new Size(400, 400);
            pbMovieImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbMovieImage.TabIndex = 0;
            pbMovieImage.TabStop = false;
            // 
            // pbBookImage
            // 
            pbBookImage.Location = new Point(26, 92);
            pbBookImage.Margin = new Padding(2);
            pbBookImage.Name = "pbBookImage";
            pbBookImage.Size = new Size(461, 469);
            pbBookImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbBookImage.TabIndex = 2;
            pbBookImage.TabStop = false;
            pbBookImage.Visible = false;
            // 
            // pbGameImage
            // 
            pbGameImage.Location = new Point(9, 92);
            pbGameImage.Margin = new Padding(2);
            pbGameImage.Name = "pbGameImage";
            pbGameImage.Size = new Size(461, 469);
            pbGameImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGameImage.TabIndex = 3;
            pbGameImage.TabStop = false;
            pbGameImage.Visible = false;
            // 
            // pbMusicImage
            // 
            pbMusicImage.Location = new Point(9, 92);
            pbMusicImage.Margin = new Padding(2);
            pbMusicImage.Name = "pbMusicImage";
            pbMusicImage.Size = new Size(461, 469);
            pbMusicImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMusicImage.TabIndex = 4;
            pbMusicImage.TabStop = false;
            pbMusicImage.Visible = false;
            // 
            // txtDescriptionValue
            // 
            txtDescriptionValue.Location = new Point(69, 380);
            txtDescriptionValue.Margin = new Padding(2);
            txtDescriptionValue.Multiline = true;
            txtDescriptionValue.Name = "txtDescriptionValue";
            txtDescriptionValue.ReadOnly = true;
            txtDescriptionValue.ScrollBars = ScrollBars.Vertical;
            txtDescriptionValue.Size = new Size(603, 275);
            txtDescriptionValue.TabIndex = 11;
            // 
            // lblReleaseDateValue
            // 
            lblReleaseDateValue.AutoSize = true;
            lblReleaseDateValue.Location = new Point(204, 284);
            lblReleaseDateValue.Margin = new Padding(2, 0, 2, 0);
            lblReleaseDateValue.Name = "lblReleaseDateValue";
            lblReleaseDateValue.Size = new Size(0, 25);
            lblReleaseDateValue.TabIndex = 10;
            // 
            // lblGenreValue
            // 
            lblGenreValue.AutoSize = true;
            lblGenreValue.Location = new Point(162, 244);
            lblGenreValue.Margin = new Padding(2, 0, 2, 0);
            lblGenreValue.Name = "lblGenreValue";
            lblGenreValue.Size = new Size(0, 25);
            lblGenreValue.TabIndex = 9;
            // 
            // lblCreatorValue
            // 
            lblCreatorValue.AutoSize = true;
            lblCreatorValue.Location = new Point(162, 208);
            lblCreatorValue.Margin = new Padding(2, 0, 2, 0);
            lblCreatorValue.Name = "lblCreatorValue";
            lblCreatorValue.Size = new Size(0, 25);
            lblCreatorValue.TabIndex = 8;
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescriptionTitle.Location = new Point(68, 346);
            lblDescriptionTitle.Margin = new Padding(4, 0, 4, 0);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(109, 25);
            lblDescriptionTitle.TabIndex = 6;
            lblDescriptionTitle.Text = "Description";
            // 
            // lblReleaseDateTitle
            // 
            lblReleaseDateTitle.AutoSize = true;
            lblReleaseDateTitle.Location = new Point(69, 281);
            lblReleaseDateTitle.Margin = new Padding(4, 0, 4, 0);
            lblReleaseDateTitle.Name = "lblReleaseDateTitle";
            lblReleaseDateTitle.Size = new Size(116, 25);
            lblReleaseDateTitle.TabIndex = 5;
            lblReleaseDateTitle.Text = "Release Date:";
            // 
            // lblGenreTitle
            // 
            lblGenreTitle.AutoSize = true;
            lblGenreTitle.Location = new Point(68, 241);
            lblGenreTitle.Margin = new Padding(4, 0, 4, 0);
            lblGenreTitle.Name = "lblGenreTitle";
            lblGenreTitle.Size = new Size(62, 25);
            lblGenreTitle.TabIndex = 4;
            lblGenreTitle.Text = "Genre:";
            // 
            // lblCreatorTitle
            // 
            lblCreatorTitle.AutoSize = true;
            lblCreatorTitle.Location = new Point(68, 201);
            lblCreatorTitle.Margin = new Padding(4, 0, 4, 0);
            lblCreatorTitle.Name = "lblCreatorTitle";
            lblCreatorTitle.Size = new Size(74, 25);
            lblCreatorTitle.TabIndex = 3;
            lblCreatorTitle.Text = "Creator:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(54, 70);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.MaximumSize = new Size(615, 156);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 68);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title";
            lblTitle.TextChanged += lblTitle_TextChanged;
            // 
            // cmbAddToList
            // 
            cmbAddToList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddToList.FormattingEnabled = true;
            cmbAddToList.Location = new Point(278, 12);
            cmbAddToList.Margin = new Padding(4);
            cmbAddToList.Name = "cmbAddToList";
            cmbAddToList.Size = new Size(213, 33);
            cmbAddToList.TabIndex = 1;
            // 
            // btnFavorite
            // 
            btnFavorite.Location = new Point(510, 10);
            btnFavorite.Margin = new Padding(4);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(149, 36);
            btnFavorite.TabIndex = 0;
            btnFavorite.Text = "Favorite";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // Detailed_Item_Listing_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 698);
            Controls.Add(splitContainer1);
            Margin = new Padding(4);
            Name = "Detailed_Item_Listing_Form";
            Text = "Detailed Item Listing";
            Load += Detailed_Item_Listing_Form_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMovieImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBookImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGameImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMusicImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnNavBack;
        private PictureBox pbMovieImage;
        private Button btnFavorite;
        private Label lblDescriptionTitle;
        private Label lblReleaseDateTitle;
        private Label lblGenreTitle;
        private Label lblCreatorTitle;
        private Label lblTitle;
        private ComboBox cmbAddToList;
        private Label lblReleaseDateValue;
        private Label lblGenreValue;
        private Label lblCreatorValue;
        private TextBox txtDescriptionValue;
        private PictureBox pbBookImage;
        private PictureBox pbGameImage;
        private PictureBox pbMusicImage;
        private Button btnRecommendations;
    }
}