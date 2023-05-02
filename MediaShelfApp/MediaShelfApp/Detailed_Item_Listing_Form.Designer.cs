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
            splitContainer1.Margin = new Padding(6, 4, 6, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ControlLightLight;
            splitContainer1.Panel1.Controls.Add(btnRecommendations);
            splitContainer1.Panel1.Controls.Add(btnNavBack);
            splitContainer1.Panel1.Controls.Add(pbMovieImage);
            splitContainer1.Panel1.Controls.Add(pbBookImage);
            splitContainer1.Panel1.Controls.Add(pbGameImage);
            splitContainer1.Panel1.Controls.Add(pbMusicImage);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = Properties.Resources.BACKGROUND_WHITE;
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
            splitContainer1.Size = new Size(1525, 892);
            splitContainer1.SplitterDistance = 598;
            splitContainer1.SplitterWidth = 7;
            splitContainer1.TabIndex = 0;
            // 
            // btnRecommendations
            // 
            btnRecommendations.Location = new Point(217, 9);
            btnRecommendations.Margin = new Padding(4);
            btnRecommendations.Name = "btnRecommendations";
            btnRecommendations.Size = new Size(243, 47);
            btnRecommendations.TabIndex = 5;
            btnRecommendations.Text = "Recommendations";
            btnRecommendations.UseVisualStyleBackColor = true;
            btnRecommendations.Click += btnRecommendations_Click;
            // 
            // btnNavBack
            // 
            btnNavBack.Location = new Point(30, 9);
            btnNavBack.Margin = new Padding(6, 4, 6, 4);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(171, 47);
            btnNavBack.TabIndex = 1;
            btnNavBack.Text = "Back";
            btnNavBack.UseVisualStyleBackColor = true;
            btnNavBack.Click += btnNavBack_Click;
            // 
            // pbMovieImage
            // 
            pbMovieImage.BackColor = SystemColors.ControlLightLight;
            pbMovieImage.Location = new Point(60, 90);
            pbMovieImage.Margin = new Padding(6, 4, 6, 4);
            pbMovieImage.MinimumSize = new Size(500, 700);
            pbMovieImage.Name = "pbMovieImage";
            pbMovieImage.Size = new Size(500, 700);
            pbMovieImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbMovieImage.TabIndex = 0;
            pbMovieImage.TabStop = false;
            // 
            // pbBookImage
            // 
            pbBookImage.BackColor = SystemColors.ControlLightLight;
            pbBookImage.Location = new Point(33, 119);
            pbBookImage.Margin = new Padding(4);
            pbBookImage.Name = "pbBookImage";
            pbBookImage.Size = new Size(600, 599);
            pbBookImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbBookImage.TabIndex = 2;
            pbBookImage.TabStop = false;
            pbBookImage.Visible = false;
            // 
            // pbGameImage
            // 
            pbGameImage.BackColor = SystemColors.ControlLightLight;
            pbGameImage.Location = new Point(11, 119);
            pbGameImage.Margin = new Padding(4);
            pbGameImage.Name = "pbGameImage";
            pbGameImage.Size = new Size(600, 599);
            pbGameImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGameImage.TabIndex = 3;
            pbGameImage.TabStop = false;
            pbGameImage.Visible = false;
            // 
            // pbMusicImage
            // 
            pbMusicImage.Location = new Point(11, 119);
            pbMusicImage.Margin = new Padding(4);
            pbMusicImage.Name = "pbMusicImage";
            pbMusicImage.Size = new Size(600, 599);
            pbMusicImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMusicImage.TabIndex = 4;
            pbMusicImage.TabStop = false;
            pbMusicImage.Visible = false;
            // 
            // lblCreatorValue
            // 
            lblCreatorValue.AutoSize = true;
            lblCreatorValue.BackColor = SystemColors.ControlLightLight;
            lblCreatorValue.Location = new Point(251, 260);
            lblCreatorValue.Margin = new Padding(4, 0, 4, 0);
            lblCreatorValue.Name = "lblCreatorValue";
            lblCreatorValue.Size = new Size(0, 32);
            lblCreatorValue.TabIndex = 8;
            // 
            // txtDescriptionValue
            // 
            txtDescriptionValue.BackColor = SystemColors.ControlLightLight;
            txtDescriptionValue.Location = new Point(89, 486);
            txtDescriptionValue.Margin = new Padding(4);
            txtDescriptionValue.Multiline = true;
            txtDescriptionValue.Name = "txtDescriptionValue";
            txtDescriptionValue.ReadOnly = true;
            txtDescriptionValue.ScrollBars = ScrollBars.Vertical;
            txtDescriptionValue.Size = new Size(782, 352);
            txtDescriptionValue.TabIndex = 11;
            // 
            // lblReleaseDateValue
            // 
            lblReleaseDateValue.AutoSize = true;
            lblReleaseDateValue.BackColor = SystemColors.ControlLightLight;
            lblReleaseDateValue.Location = new Point(251, 363);
            lblReleaseDateValue.Margin = new Padding(4, 0, 4, 0);
            lblReleaseDateValue.Name = "lblReleaseDateValue";
            lblReleaseDateValue.Size = new Size(0, 32);
            lblReleaseDateValue.TabIndex = 10;
            // 
            // lblGenreValue
            // 
            lblGenreValue.AutoSize = true;
            lblGenreValue.BackColor = SystemColors.ControlLightLight;
            lblGenreValue.Location = new Point(251, 311);
            lblGenreValue.Margin = new Padding(4, 0, 4, 0);
            lblGenreValue.Name = "lblGenreValue";
            lblGenreValue.Size = new Size(0, 32);
            lblGenreValue.TabIndex = 9;
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.BackColor = SystemColors.ControlLightLight;
            lblDescriptionTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescriptionTitle.Location = new Point(87, 444);
            lblDescriptionTitle.Margin = new Padding(6, 0, 6, 0);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(146, 32);
            lblDescriptionTitle.TabIndex = 6;
            lblDescriptionTitle.Text = "Description";
            // 
            // lblReleaseDateTitle
            // 
            lblReleaseDateTitle.AutoSize = true;
            lblReleaseDateTitle.BackColor = SystemColors.ControlLightLight;
            lblReleaseDateTitle.Location = new Point(89, 361);
            lblReleaseDateTitle.Margin = new Padding(6, 0, 6, 0);
            lblReleaseDateTitle.Name = "lblReleaseDateTitle";
            lblReleaseDateTitle.Size = new Size(156, 32);
            lblReleaseDateTitle.TabIndex = 5;
            lblReleaseDateTitle.Text = "Release Date:";
            lblReleaseDateTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGenreTitle
            // 
            lblGenreTitle.AutoSize = true;
            lblGenreTitle.BackColor = SystemColors.ControlLightLight;
            lblGenreTitle.Location = new Point(87, 309);
            lblGenreTitle.Margin = new Padding(6, 0, 6, 0);
            lblGenreTitle.MinimumSize = new Size(156, 32);
            lblGenreTitle.Name = "lblGenreTitle";
            lblGenreTitle.Size = new Size(156, 32);
            lblGenreTitle.TabIndex = 4;
            lblGenreTitle.Text = "Genre:";
            lblGenreTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCreatorTitle
            // 
            lblCreatorTitle.AutoSize = true;
            lblCreatorTitle.BackColor = SystemColors.ControlLightLight;
            lblCreatorTitle.Location = new Point(87, 258);
            lblCreatorTitle.Margin = new Padding(6, 0, 6, 0);
            lblCreatorTitle.MinimumSize = new Size(156, 32);
            lblCreatorTitle.Name = "lblCreatorTitle";
            lblCreatorTitle.Size = new Size(156, 32);
            lblCreatorTitle.TabIndex = 3;
            lblCreatorTitle.Text = "Creator:";
            lblCreatorTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ControlLightLight;
            lblTitle.Font = new Font("Segoe UI", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(71, 90);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.MaximumSize = new Size(799, 201);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(166, 91);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title";
            lblTitle.TextChanged += lblTitle_TextChanged;
            // 
            // cmbAddToList
            // 
            cmbAddToList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddToList.FormattingEnabled = true;
            cmbAddToList.Location = new Point(360, 17);
            cmbAddToList.Margin = new Padding(6, 4, 6, 4);
            cmbAddToList.Name = "cmbAddToList";
            cmbAddToList.Size = new Size(275, 40);
            cmbAddToList.TabIndex = 1;
            // 
            // btnFavorite
            // 
            btnFavorite.Location = new Point(663, 13);
            btnFavorite.Margin = new Padding(6, 4, 6, 4);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(193, 47);
            btnFavorite.TabIndex = 0;
            btnFavorite.Text = "Favorite";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // Detailed_Item_Listing_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 892);
            Controls.Add(splitContainer1);
            Margin = new Padding(6, 4, 6, 4);
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