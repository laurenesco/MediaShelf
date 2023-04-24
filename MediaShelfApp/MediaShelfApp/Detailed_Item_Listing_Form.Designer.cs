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
            lblCreatorValue = new Label();
            txtDescriptionValue = new TextBox();
            lblReleaseDateValue = new Label();
            lblGenreValue = new Label();
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
            splitContainer1.Panel2.Controls.Add(lblCreatorValue);
            splitContainer1.Panel2.Controls.Add(txtDescriptionValue);
            splitContainer1.Panel2.Controls.Add(lblReleaseDateValue);
            splitContainer1.Panel2.Controls.Add(lblGenreValue);
            splitContainer1.Panel2.Controls.Add(lblDescriptionTitle);
            splitContainer1.Panel2.Controls.Add(lblReleaseDateTitle);
            splitContainer1.Panel2.Controls.Add(lblGenreTitle);
            splitContainer1.Panel2.Controls.Add(lblCreatorTitle);
            splitContainer1.Panel2.Controls.Add(lblTitle);
            splitContainer1.Panel2.Controls.Add(cmbAddToList);
            splitContainer1.Panel2.Controls.Add(btnFavorite);
            splitContainer1.Size = new Size(938, 558);
            splitContainer1.SplitterDistance = 368;
            splitContainer1.TabIndex = 0;
            // 
            // btnRecommendations
            // 
            btnRecommendations.Location = new Point(134, 6);
            btnRecommendations.Margin = new Padding(2);
            btnRecommendations.Name = "btnRecommendations";
            btnRecommendations.Size = new Size(150, 29);
            btnRecommendations.TabIndex = 5;
            btnRecommendations.Text = "Recommendations";
            btnRecommendations.UseVisualStyleBackColor = true;
            btnRecommendations.Click += btnRecommendations_Click;
            // 
            // btnNavBack
            // 
            btnNavBack.Location = new Point(18, 6);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(105, 29);
            btnNavBack.TabIndex = 1;
            btnNavBack.Text = "Back";
            btnNavBack.UseVisualStyleBackColor = true;
            btnNavBack.Click += btnNavBack_Click;
            // 
            // pbMovieImage
            // 
            pbMovieImage.Location = new Point(63, 56);
            pbMovieImage.Name = "pbMovieImage";
            pbMovieImage.Size = new Size(400, 400);
            pbMovieImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbMovieImage.TabIndex = 0;
            pbMovieImage.TabStop = false;
            // 
            // pbBookImage
            // 
            pbBookImage.Location = new Point(21, 74);
            pbBookImage.Margin = new Padding(2);
            pbBookImage.Name = "pbBookImage";
            pbBookImage.Size = new Size(369, 375);
            pbBookImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbBookImage.TabIndex = 2;
            pbBookImage.TabStop = false;
            pbBookImage.Visible = false;
            // 
            // pbGameImage
            // 
            pbGameImage.Location = new Point(7, 74);
            pbGameImage.Margin = new Padding(2);
            pbGameImage.Name = "pbGameImage";
            pbGameImage.Size = new Size(369, 375);
            pbGameImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGameImage.TabIndex = 3;
            pbGameImage.TabStop = false;
            pbGameImage.Visible = false;
            // 
            // pbMusicImage
            // 
            pbMusicImage.Location = new Point(7, 74);
            pbMusicImage.Margin = new Padding(2);
            pbMusicImage.Name = "pbMusicImage";
            pbMusicImage.Size = new Size(369, 375);
            pbMusicImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMusicImage.TabIndex = 4;
            pbMusicImage.TabStop = false;
            pbMusicImage.Visible = false;
            // 
            // lblCreatorValue
            // 
            lblCreatorValue.AutoSize = true;
            lblCreatorValue.Location = new Point(154, 162);
            lblCreatorValue.Margin = new Padding(2, 0, 2, 0);
            lblCreatorValue.Name = "lblCreatorValue";
            lblCreatorValue.Size = new Size(0, 20);
            lblCreatorValue.TabIndex = 8;
            // 
            // txtDescriptionValue
            // 
            txtDescriptionValue.Location = new Point(55, 304);
            txtDescriptionValue.Margin = new Padding(2);
            txtDescriptionValue.Multiline = true;
            txtDescriptionValue.Name = "txtDescriptionValue";
            txtDescriptionValue.ReadOnly = true;
            txtDescriptionValue.ScrollBars = ScrollBars.Vertical;
            txtDescriptionValue.Size = new Size(483, 221);
            txtDescriptionValue.TabIndex = 11;
            // 
            // lblReleaseDateValue
            // 
            lblReleaseDateValue.AutoSize = true;
            lblReleaseDateValue.Location = new Point(154, 227);
            lblReleaseDateValue.Margin = new Padding(2, 0, 2, 0);
            lblReleaseDateValue.Name = "lblReleaseDateValue";
            lblReleaseDateValue.Size = new Size(0, 20);
            lblReleaseDateValue.TabIndex = 10;
            // 
            // lblGenreValue
            // 
            lblGenreValue.AutoSize = true;
            lblGenreValue.Location = new Point(154, 195);
            lblGenreValue.Margin = new Padding(2, 0, 2, 0);
            lblGenreValue.Name = "lblGenreValue";
            lblGenreValue.Size = new Size(0, 20);
            lblGenreValue.TabIndex = 9;
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescriptionTitle.Location = new Point(54, 277);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(89, 20);
            lblDescriptionTitle.TabIndex = 6;
            lblDescriptionTitle.Text = "Description";
            // 
            // lblReleaseDateTitle
            // 
            lblReleaseDateTitle.AutoSize = true;
            lblReleaseDateTitle.Location = new Point(55, 225);
            lblReleaseDateTitle.Name = "lblReleaseDateTitle";
            lblReleaseDateTitle.Size = new Size(99, 20);
            lblReleaseDateTitle.TabIndex = 5;
            lblReleaseDateTitle.Text = "Release Date:";
            lblReleaseDateTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGenreTitle
            // 
            lblGenreTitle.AutoSize = true;
            lblGenreTitle.Location = new Point(54, 193);
            lblGenreTitle.MinimumSize = new Size(96, 20);
            lblGenreTitle.Name = "lblGenreTitle";
            lblGenreTitle.Size = new Size(96, 20);
            lblGenreTitle.TabIndex = 4;
            lblGenreTitle.Text = "Genre:";
            lblGenreTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCreatorTitle
            // 
            lblCreatorTitle.AutoSize = true;
            lblCreatorTitle.Location = new Point(54, 161);
            lblCreatorTitle.MinimumSize = new Size(96, 20);
            lblCreatorTitle.Name = "lblCreatorTitle";
            lblCreatorTitle.Size = new Size(96, 20);
            lblCreatorTitle.TabIndex = 3;
            lblCreatorTitle.Text = "Creator:";
            lblCreatorTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(43, 56);
            lblTitle.MaximumSize = new Size(492, 125);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(103, 57);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title";
            lblTitle.TextChanged += lblTitle_TextChanged;
            // 
            // cmbAddToList
            // 
            cmbAddToList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddToList.FormattingEnabled = true;
            cmbAddToList.Location = new Point(222, 10);
            cmbAddToList.Name = "cmbAddToList";
            cmbAddToList.Size = new Size(171, 28);
            cmbAddToList.TabIndex = 1;
            // 
            // btnFavorite
            // 
            btnFavorite.Location = new Point(408, 8);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(119, 29);
            btnFavorite.TabIndex = 0;
            btnFavorite.Text = "Favorite";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // Detailed_Item_Listing_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 558);
            Controls.Add(splitContainer1);
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