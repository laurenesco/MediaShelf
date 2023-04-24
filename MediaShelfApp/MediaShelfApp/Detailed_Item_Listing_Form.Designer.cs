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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detailed_Item_Listing_Form));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRecommendations = new System.Windows.Forms.Button();
            this.btnNavBack = new System.Windows.Forms.Button();
            this.pbMovieImage = new System.Windows.Forms.PictureBox();
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.pbGameImage = new System.Windows.Forms.PictureBox();
            this.pbMusicImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCreatorTitle = new System.Windows.Forms.Label();
            this.lblGenreTitle = new System.Windows.Forms.Label();
            this.lblReleaseDateTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCreatorValue = new System.Windows.Forms.Label();
            this.lblGenreValue = new System.Windows.Forms.Label();
            this.lblReleaseDateValue = new System.Windows.Forms.Label();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
            this.txtDescriptionValue = new System.Windows.Forms.TextBox();
            this.cmbAddToList = new System.Windows.Forms.ComboBox();
            this.btnFavorite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusicImage)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRecommendations);
            this.splitContainer1.Panel1.Controls.Add(this.btnNavBack);
            this.splitContainer1.Panel1.Controls.Add(this.pbMovieImage);
            this.splitContainer1.Panel1.Controls.Add(this.pbBookImage);
            this.splitContainer1.Panel1.Controls.Add(this.pbGameImage);
            this.splitContainer1.Panel1.Controls.Add(this.pbMusicImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel4);
            this.splitContainer1.Panel2.Controls.Add(this.cmbAddToList);
            this.splitContainer1.Panel2.Controls.Add(this.btnFavorite);
            this.splitContainer1.Size = new System.Drawing.Size(1172, 698);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnRecommendations
            // 
            this.btnRecommendations.Location = new System.Drawing.Point(184, 8);
            this.btnRecommendations.Name = "btnRecommendations";
            this.btnRecommendations.Size = new System.Drawing.Size(224, 36);
            this.btnRecommendations.TabIndex = 5;
            this.btnRecommendations.Text = "Recommendations";
            this.btnRecommendations.UseVisualStyleBackColor = true;
            this.btnRecommendations.Click += new System.EventHandler(this.btnRecommendations_Click);
            // 
            // btnNavBack
            // 
            this.btnNavBack.Location = new System.Drawing.Point(22, 8);
            this.btnNavBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavBack.Name = "btnNavBack";
            this.btnNavBack.Size = new System.Drawing.Size(131, 36);
            this.btnNavBack.TabIndex = 1;
            this.btnNavBack.Text = "Back";
            this.btnNavBack.UseVisualStyleBackColor = true;
            // 
            // pbMovieImage
            // 
            this.pbMovieImage.Location = new System.Drawing.Point(79, 70);
            this.pbMovieImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbMovieImage.Name = "pbMovieImage";
            this.pbMovieImage.Size = new System.Drawing.Size(400, 400);
            this.pbMovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMovieImage.TabIndex = 0;
            this.pbMovieImage.TabStop = false;
            // 
            // pbBookImage
            // 
            this.pbBookImage.Location = new System.Drawing.Point(26, 92);
            this.pbBookImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(461, 469);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImage.TabIndex = 2;
            this.pbBookImage.TabStop = false;
            this.pbBookImage.Visible = false;
            // 
            // pbGameImage
            // 
            this.pbGameImage.Location = new System.Drawing.Point(9, 92);
            this.pbGameImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbGameImage.Name = "pbGameImage";
            this.pbGameImage.Size = new System.Drawing.Size(461, 469);
            this.pbGameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGameImage.TabIndex = 3;
            this.pbGameImage.TabStop = false;
            this.pbGameImage.Visible = false;
            // 
            // pbMusicImage
            // 
            this.pbMusicImage.Location = new System.Drawing.Point(9, 92);
            this.pbMusicImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbMusicImage.Name = "pbMusicImage";
            this.pbMusicImage.Size = new System.Drawing.Size(461, 469);
            this.pbMusicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMusicImage.TabIndex = 4;
            this.pbMusicImage.TabStop = false;
            this.pbMusicImage.Visible = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.lblTitle);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel4.Controls.Add(this.lblDescriptionTitle);
            this.flowLayoutPanel4.Controls.Add(this.txtDescriptionValue);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(52, 92);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(607, 556);
            this.flowLayoutPanel4.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(4, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.MaximumSize = new System.Drawing.Size(615, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 68);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 86);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 18, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(141, 135);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.lblCreatorTitle);
            this.flowLayoutPanel2.Controls.Add(this.lblGenreTitle);
            this.flowLayoutPanel2.Controls.Add(this.lblReleaseDateTitle);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(125, 111);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // lblCreatorTitle
            // 
            this.lblCreatorTitle.AutoSize = true;
            this.lblCreatorTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatorTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCreatorTitle.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreatorTitle.Location = new System.Drawing.Point(47, 0);
            this.lblCreatorTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 18);
            this.lblCreatorTitle.Name = "lblCreatorTitle";
            this.lblCreatorTitle.Size = new System.Drawing.Size(74, 25);
            this.lblCreatorTitle.TabIndex = 3;
            this.lblCreatorTitle.Text = "Creator:";
            // 
            // lblGenreTitle
            // 
            this.lblGenreTitle.AutoSize = true;
            this.lblGenreTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGenreTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGenreTitle.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenreTitle.Location = new System.Drawing.Point(59, 43);
            this.lblGenreTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 18);
            this.lblGenreTitle.Name = "lblGenreTitle";
            this.lblGenreTitle.Size = new System.Drawing.Size(62, 25);
            this.lblGenreTitle.TabIndex = 4;
            this.lblGenreTitle.Text = "Genre:";
            // 
            // lblReleaseDateTitle
            // 
            this.lblReleaseDateTitle.AutoSize = true;
            this.lblReleaseDateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblReleaseDateTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblReleaseDateTitle.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReleaseDateTitle.Location = new System.Drawing.Point(4, 86);
            this.lblReleaseDateTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReleaseDateTitle.Name = "lblReleaseDateTitle";
            this.lblReleaseDateTitle.Size = new System.Drawing.Size(117, 25);
            this.lblReleaseDateTitle.TabIndex = 5;
            this.lblReleaseDateTitle.Text = "Release Date:";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.lblCreatorValue);
            this.flowLayoutPanel3.Controls.Add(this.lblGenreValue);
            this.flowLayoutPanel3.Controls.Add(this.lblReleaseDateValue);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(134, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(4, 129);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // lblCreatorValue
            // 
            this.lblCreatorValue.AutoSize = true;
            this.lblCreatorValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatorValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCreatorValue.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreatorValue.Location = new System.Drawing.Point(2, 0);
            this.lblCreatorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 18);
            this.lblCreatorValue.Name = "lblCreatorValue";
            this.lblCreatorValue.Size = new System.Drawing.Size(0, 25);
            this.lblCreatorValue.TabIndex = 8;
            // 
            // lblGenreValue
            // 
            this.lblGenreValue.AutoSize = true;
            this.lblGenreValue.BackColor = System.Drawing.Color.Transparent;
            this.lblGenreValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGenreValue.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenreValue.Location = new System.Drawing.Point(2, 43);
            this.lblGenreValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 18);
            this.lblGenreValue.Name = "lblGenreValue";
            this.lblGenreValue.Size = new System.Drawing.Size(0, 25);
            this.lblGenreValue.TabIndex = 9;
            // 
            // lblReleaseDateValue
            // 
            this.lblReleaseDateValue.AutoSize = true;
            this.lblReleaseDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblReleaseDateValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblReleaseDateValue.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReleaseDateValue.Location = new System.Drawing.Point(2, 86);
            this.lblReleaseDateValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 18);
            this.lblReleaseDateValue.Name = "lblReleaseDateValue";
            this.lblReleaseDateValue.Size = new System.Drawing.Size(0, 25);
            this.lblReleaseDateValue.TabIndex = 10;
            // 
            // lblDescriptionTitle
            // 
            this.lblDescriptionTitle.AutoSize = true;
            this.lblDescriptionTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescriptionTitle.Location = new System.Drawing.Point(4, 252);
            this.lblDescriptionTitle.Margin = new System.Windows.Forms.Padding(4, 28, 4, 0);
            this.lblDescriptionTitle.Name = "lblDescriptionTitle";
            this.lblDescriptionTitle.Size = new System.Drawing.Size(109, 25);
            this.lblDescriptionTitle.TabIndex = 6;
            this.lblDescriptionTitle.Text = "Description";
            // 
            // txtDescriptionValue
            // 
            this.txtDescriptionValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescriptionValue.Location = new System.Drawing.Point(2, 279);
            this.txtDescriptionValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescriptionValue.Multiline = true;
            this.txtDescriptionValue.Name = "txtDescriptionValue";
            this.txtDescriptionValue.ReadOnly = true;
            this.txtDescriptionValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionValue.Size = new System.Drawing.Size(603, 275);
            this.txtDescriptionValue.TabIndex = 11;
            // 
            // cmbAddToList
            // 
            this.cmbAddToList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddToList.FormattingEnabled = true;
            this.cmbAddToList.Location = new System.Drawing.Point(278, 12);
            this.cmbAddToList.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAddToList.Name = "cmbAddToList";
            this.cmbAddToList.Size = new System.Drawing.Size(213, 33);
            this.cmbAddToList.TabIndex = 1;
            // 
            // btnFavorite
            // 
            this.btnFavorite.Location = new System.Drawing.Point(510, 10);
            this.btnFavorite.Margin = new System.Windows.Forms.Padding(4);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(149, 36);
            this.btnFavorite.TabIndex = 0;
            this.btnFavorite.Text = "Favorite";
            this.btnFavorite.UseVisualStyleBackColor = true;
            // 
            // Detailed_Item_Listing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1172, 698);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Detailed_Item_Listing_Form";
            this.Text = "Detailed Item Listing";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusicImage)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnNavBack;
        private PictureBox pbMovieImage;
        private Button btnFavorite;
        private ComboBox cmbAddToList;
        private PictureBox pbBookImage;
        private PictureBox pbGameImage;
        private PictureBox pbMusicImage;
        private Button btnRecommendations;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label lblTitle;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblCreatorTitle;
        private Label lblGenreTitle;
        private Label lblReleaseDateTitle;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblCreatorValue;
        private Label lblGenreValue;
        private Label lblReleaseDateValue;
        private Label lblDescriptionTitle;
        private TextBox txtDescriptionValue;
    }
}