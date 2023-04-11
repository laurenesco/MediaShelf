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
            btnNavBack = new Button();
            picMediaImage = new PictureBox();
            txtDescriptionValue = new TextBox();
            lblReleaseDateValue = new Label();
            lblGenreValue = new Label();
            lblCreatorValue = new Label();
            lblDescriptionValue = new Label();
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
            ((System.ComponentModel.ISupportInitialize)picMediaImage).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnNavBack);
            splitContainer1.Panel1.Controls.Add(picMediaImage);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtDescriptionValue);
            splitContainer1.Panel2.Controls.Add(lblReleaseDateValue);
            splitContainer1.Panel2.Controls.Add(lblGenreValue);
            splitContainer1.Panel2.Controls.Add(lblCreatorValue);
            splitContainer1.Panel2.Controls.Add(lblDescriptionValue);
            splitContainer1.Panel2.Controls.Add(lblDescriptionTitle);
            splitContainer1.Panel2.Controls.Add(lblReleaseDateTitle);
            splitContainer1.Panel2.Controls.Add(lblGenreTitle);
            splitContainer1.Panel2.Controls.Add(lblCreatorTitle);
            splitContainer1.Panel2.Controls.Add(lblTitle);
            splitContainer1.Panel2.Controls.Add(cmbAddToList);
            splitContainer1.Panel2.Controls.Add(btnFavorite);
            splitContainer1.Size = new Size(1524, 893);
            splitContainer1.SplitterDistance = 601;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // btnNavBack
            // 
            btnNavBack.Location = new Point(29, 10);
            btnNavBack.Margin = new Padding(5);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(171, 46);
            btnNavBack.TabIndex = 1;
            btnNavBack.Text = "Back";
            btnNavBack.UseVisualStyleBackColor = true;
            btnNavBack.Click += btnNavBack_Click;
            // 
            // picMediaImage
            // 
            picMediaImage.Location = new Point(29, 90);
            picMediaImage.Margin = new Padding(5);
            picMediaImage.Name = "picMediaImage";
            picMediaImage.Size = new Size(369, 339);
            picMediaImage.SizeMode = PictureBoxSizeMode.AutoSize;
            picMediaImage.TabIndex = 0;
            picMediaImage.TabStop = false;
            // 
            // txtDescriptionValue
            // 
            txtDescriptionValue.Location = new Point(89, 487);
            txtDescriptionValue.Multiline = true;
            txtDescriptionValue.Name = "txtDescriptionValue";
            txtDescriptionValue.ReadOnly = true;
            txtDescriptionValue.ScrollBars = ScrollBars.Vertical;
            txtDescriptionValue.Size = new Size(783, 351);
            txtDescriptionValue.TabIndex = 11;
            // 
            // lblReleaseDateValue
            // 
            lblReleaseDateValue.AutoSize = true;
            lblReleaseDateValue.Location = new Point(265, 350);
            lblReleaseDateValue.Name = "lblReleaseDateValue";
            lblReleaseDateValue.Size = new Size(0, 32);
            lblReleaseDateValue.TabIndex = 10;
            // 
            // lblGenreValue
            // 
            lblGenreValue.AutoSize = true;
            lblGenreValue.Location = new Point(211, 299);
            lblGenreValue.Name = "lblGenreValue";
            lblGenreValue.Size = new Size(0, 32);
            lblGenreValue.TabIndex = 9;
            // 
            // lblCreatorValue
            // 
            lblCreatorValue.AutoSize = true;
            lblCreatorValue.Location = new Point(211, 247);
            lblCreatorValue.Name = "lblCreatorValue";
            lblCreatorValue.Size = new Size(0, 32);
            lblCreatorValue.TabIndex = 8;
            // 
            // lblDescriptionValue
            // 
            lblDescriptionValue.AutoSize = true;
            lblDescriptionValue.Location = new Point(87, 487);
            lblDescriptionValue.Margin = new Padding(5, 0, 5, 0);
            lblDescriptionValue.MaximumSize = new Size(750, 0);
            lblDescriptionValue.Name = "lblDescriptionValue";
            lblDescriptionValue.Size = new Size(0, 32);
            lblDescriptionValue.TabIndex = 7;
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescriptionTitle.Location = new Point(88, 443);
            lblDescriptionTitle.Margin = new Padding(5, 0, 5, 0);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(146, 32);
            lblDescriptionTitle.TabIndex = 6;
            lblDescriptionTitle.Text = "Description";
            // 
            // lblReleaseDateTitle
            // 
            lblReleaseDateTitle.AutoSize = true;
            lblReleaseDateTitle.Location = new Point(89, 350);
            lblReleaseDateTitle.Margin = new Padding(5, 0, 5, 0);
            lblReleaseDateTitle.Name = "lblReleaseDateTitle";
            lblReleaseDateTitle.Size = new Size(156, 32);
            lblReleaseDateTitle.TabIndex = 5;
            lblReleaseDateTitle.Text = "Release Date:";
            // 
            // lblGenreTitle
            // 
            lblGenreTitle.AutoSize = true;
            lblGenreTitle.Location = new Point(88, 299);
            lblGenreTitle.Margin = new Padding(5, 0, 5, 0);
            lblGenreTitle.Name = "lblGenreTitle";
            lblGenreTitle.Size = new Size(83, 32);
            lblGenreTitle.TabIndex = 4;
            lblGenreTitle.Text = "Genre:";
            // 
            // lblCreatorTitle
            // 
            lblCreatorTitle.AutoSize = true;
            lblCreatorTitle.Location = new Point(88, 247);
            lblCreatorTitle.Margin = new Padding(5, 0, 5, 0);
            lblCreatorTitle.Name = "lblCreatorTitle";
            lblCreatorTitle.Size = new Size(97, 32);
            lblCreatorTitle.TabIndex = 3;
            lblCreatorTitle.Text = "Creator:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(70, 90);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.MaximumSize = new Size(750, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(166, 91);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title";
            // 
            // cmbAddToList
            // 
            cmbAddToList.FormattingEnabled = true;
            cmbAddToList.Location = new Point(361, 16);
            cmbAddToList.Margin = new Padding(5);
            cmbAddToList.Name = "cmbAddToList";
            cmbAddToList.Size = new Size(275, 40);
            cmbAddToList.TabIndex = 1;
            // 
            // btnFavorite
            // 
            btnFavorite.Location = new Point(663, 12);
            btnFavorite.Margin = new Padding(5);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(193, 46);
            btnFavorite.TabIndex = 0;
            btnFavorite.Text = "Favorite";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // Detailed_Item_Listing_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1524, 893);
            Controls.Add(splitContainer1);
            Margin = new Padding(5);
            Name = "Detailed_Item_Listing_Form";
            Text = "Detailed Item Listing";
            FormClosing += Detailed_Item_Listing_Form_FormClosing;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMediaImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnNavBack;
        private PictureBox picMediaImage;
        private Button btnFavorite;
        private Label lblDescriptionValue;
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
    }
}