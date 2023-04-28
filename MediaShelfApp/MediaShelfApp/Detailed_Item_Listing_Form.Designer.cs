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
            cmbAddToList = new ComboBox();
            btnFavorite = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lblTitle = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblCreatorTitle = new Label();
            lblGenreTitle = new Label();
            lblReleaseDateTitle = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblCreatorValue = new Label();
            lblGenreValue = new Label();
            lblReleaseDateValue = new Label();
            lblDescriptionTitle = new Label();
            txtDescriptionValue = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMovieImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBookImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGameImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMusicImage).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackgroundImage = Properties.Resources.BACKGROUND_WHITE;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Transparent;
            splitContainer1.Panel1.Controls.Add(btnRecommendations);
            splitContainer1.Panel1.Controls.Add(btnNavBack);
            splitContainer1.Panel1.Controls.Add(pbMovieImage);
            splitContainer1.Panel1.Controls.Add(pbBookImage);
            splitContainer1.Panel1.Controls.Add(pbGameImage);
            splitContainer1.Panel1.Controls.Add(pbMusicImage);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Transparent;
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel4);
            splitContainer1.Panel2.Controls.Add(cmbAddToList);
            splitContainer1.Panel2.Controls.Add(btnFavorite);
            splitContainer1.Size = new Size(1172, 698);
            splitContainer1.SplitterDistance = 459;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // btnRecommendations
            // 
            btnRecommendations.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecommendations.Location = new Point(168, 8);
            btnRecommendations.Margin = new Padding(2);
            btnRecommendations.Name = "btnRecommendations";
            btnRecommendations.Size = new Size(223, 42);
            btnRecommendations.TabIndex = 5;
            btnRecommendations.Text = "Recommendations";
            btnRecommendations.UseVisualStyleBackColor = true;
            btnRecommendations.Click += btnRecommendations_Click;
            // 
            // btnNavBack
            // 
            btnNavBack.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavBack.Location = new Point(13, 8);
            btnNavBack.Margin = new Padding(4);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(114, 42);
            btnNavBack.TabIndex = 1;
            btnNavBack.Text = "Back";
            btnNavBack.UseVisualStyleBackColor = true;
            btnNavBack.Click += btnNavBack_Click;
            // 
            // pbMovieImage
            // 
            pbMovieImage.BackColor = SystemColors.ControlLightLight;
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
            pbBookImage.BackColor = SystemColors.ControlLightLight;
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
            pbGameImage.BackColor = SystemColors.ControlLightLight;
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
            btnFavorite.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFavorite.Location = new Point(510, 10);
            btnFavorite.Margin = new Padding(4);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(149, 42);
            btnFavorite.TabIndex = 0;
            btnFavorite.Text = "Add to List";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(lblTitle);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel4.Controls.Add(lblDescriptionTitle);
            flowLayoutPanel4.Controls.Add(txtDescriptionValue);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(51, 71);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(607, 556);
            flowLayoutPanel4.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(4, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.MaximumSize = new Size(615, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 68);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Location = new Point(3, 86);
            flowLayoutPanel1.Margin = new Padding(3, 18, 3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(141, 135);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(lblCreatorTitle);
            flowLayoutPanel2.Controls.Add(lblGenreTitle);
            flowLayoutPanel2.Controls.Add(lblReleaseDateTitle);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(125, 111);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // lblCreatorTitle
            // 
            lblCreatorTitle.AutoSize = true;
            lblCreatorTitle.BackColor = Color.Transparent;
            lblCreatorTitle.Dock = DockStyle.Right;
            lblCreatorTitle.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreatorTitle.Location = new Point(47, 0);
            lblCreatorTitle.Margin = new Padding(4, 0, 4, 18);
            lblCreatorTitle.Name = "lblCreatorTitle";
            lblCreatorTitle.Size = new Size(74, 25);
            lblCreatorTitle.TabIndex = 3;
            lblCreatorTitle.Text = "Creator:";
            // 
            // lblGenreTitle
            // 
            lblGenreTitle.AutoSize = true;
            lblGenreTitle.BackColor = Color.Transparent;
            lblGenreTitle.Dock = DockStyle.Right;
            lblGenreTitle.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenreTitle.Location = new Point(59, 43);
            lblGenreTitle.Margin = new Padding(4, 0, 4, 18);
            lblGenreTitle.Name = "lblGenreTitle";
            lblGenreTitle.Size = new Size(62, 25);
            lblGenreTitle.TabIndex = 4;
            lblGenreTitle.Text = "Genre:";
            // 
            // lblReleaseDateTitle
            // 
            lblReleaseDateTitle.AutoSize = true;
            lblReleaseDateTitle.BackColor = Color.Transparent;
            lblReleaseDateTitle.Dock = DockStyle.Right;
            lblReleaseDateTitle.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblReleaseDateTitle.Location = new Point(4, 86);
            lblReleaseDateTitle.Margin = new Padding(4, 0, 4, 0);
            lblReleaseDateTitle.Name = "lblReleaseDateTitle";
            lblReleaseDateTitle.Size = new Size(117, 25);
            lblReleaseDateTitle.TabIndex = 5;
            lblReleaseDateTitle.Text = "Release Date:";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(lblCreatorValue);
            flowLayoutPanel3.Controls.Add(lblGenreValue);
            flowLayoutPanel3.Controls.Add(lblReleaseDateValue);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(134, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(4, 129);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // lblCreatorValue
            // 
            lblCreatorValue.AutoSize = true;
            lblCreatorValue.BackColor = Color.Transparent;
            lblCreatorValue.Dock = DockStyle.Left;
            lblCreatorValue.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreatorValue.Location = new Point(2, 0);
            lblCreatorValue.Margin = new Padding(2, 0, 2, 18);
            lblCreatorValue.Name = "lblCreatorValue";
            lblCreatorValue.Size = new Size(0, 25);
            lblCreatorValue.TabIndex = 8;
            // 
            // lblGenreValue
            // 
            lblGenreValue.AutoSize = true;
            lblGenreValue.BackColor = Color.Transparent;
            lblGenreValue.Dock = DockStyle.Left;
            lblGenreValue.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenreValue.Location = new Point(2, 43);
            lblGenreValue.Margin = new Padding(2, 0, 2, 18);
            lblGenreValue.Name = "lblGenreValue";
            lblGenreValue.Size = new Size(0, 25);
            lblGenreValue.TabIndex = 9;
            // 
            // lblReleaseDateValue
            // 
            lblReleaseDateValue.AutoSize = true;
            lblReleaseDateValue.BackColor = Color.Transparent;
            lblReleaseDateValue.Dock = DockStyle.Left;
            lblReleaseDateValue.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblReleaseDateValue.Location = new Point(2, 86);
            lblReleaseDateValue.Margin = new Padding(2, 0, 2, 18);
            lblReleaseDateValue.Name = "lblReleaseDateValue";
            lblReleaseDateValue.Size = new Size(0, 25);
            lblReleaseDateValue.TabIndex = 10;
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescriptionTitle.Location = new Point(4, 252);
            lblDescriptionTitle.Margin = new Padding(4, 28, 4, 0);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(109, 25);
            lblDescriptionTitle.TabIndex = 6;
            lblDescriptionTitle.Text = "Description";
            // 
            // txtDescriptionValue
            // 
            txtDescriptionValue.BackColor = Color.WhiteSmoke;
            txtDescriptionValue.Location = new Point(2, 279);
            txtDescriptionValue.Margin = new Padding(2);
            txtDescriptionValue.Multiline = true;
            txtDescriptionValue.Name = "txtDescriptionValue";
            txtDescriptionValue.ReadOnly = true;
            txtDescriptionValue.ScrollBars = ScrollBars.Vertical;
            txtDescriptionValue.Size = new Size(603, 275);
            txtDescriptionValue.TabIndex = 11;
            // 
            // Detailed_Item_Listing_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BACKGROUND_WHITE;
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
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
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