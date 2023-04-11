namespace MediaShelfApp
{
    partial class Manual_Entry_Form
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
            lblManualEntry = new Label();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblCreator = new Label();
            lblTags = new Label();
            lblReleaseDate = new Label();
            txtCreator = new TextBox();
            txtTags = new TextBox();
            dtpReleaseDate = new DateTimePicker();
            lblDescription = new Label();
            txtDescriptionText = new TextBox();
            picboxImage = new PictureBox();
            lblTagName = new Label();
            txtTagName = new TextBox();
            lblAddTag = new Label();
            btnBackButton = new Button();
            btnAddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)picboxImage).BeginInit();
            SuspendLayout();
            // 
            // lblManualEntry
            // 
            lblManualEntry.AutoSize = true;
            lblManualEntry.Font = new Font("Ebrima", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblManualEntry.Location = new Point(368, 28);
            lblManualEntry.Name = "lblManualEntry";
            lblManualEntry.Size = new Size(191, 41);
            lblManualEntry.TabIndex = 7;
            lblManualEntry.Text = "Manual Entry";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(395, 144);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Title:";
            lblTitle.TextAlign = ContentAlignment.TopRight;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(448, 136);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(304, 28);
            txtTitle.TabIndex = 9;
            // 
            // lblCreator
            // 
            lblCreator.AutoSize = true;
            lblCreator.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreator.Location = new Point(375, 183);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(61, 20);
            lblCreator.TabIndex = 10;
            lblCreator.Text = "Creator:";
            lblCreator.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTags
            // 
            lblTags.AutoSize = true;
            lblTags.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTags.Location = new Point(348, 221);
            lblTags.Name = "lblTags";
            lblTags.Size = new Size(88, 20);
            lblTags.TabIndex = 12;
            lblTags.Text = "Genre/Tags:";
            lblTags.TextAlign = ContentAlignment.TopRight;
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblReleaseDate.Location = new Point(337, 260);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(99, 20);
            lblReleaseDate.TabIndex = 13;
            lblReleaseDate.Text = "Release Date:";
            lblReleaseDate.TextAlign = ContentAlignment.TopRight;
            // 
            // txtCreator
            // 
            txtCreator.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCreator.Location = new Point(448, 175);
            txtCreator.Name = "txtCreator";
            txtCreator.Size = new Size(304, 28);
            txtCreator.TabIndex = 14;
            // 
            // txtTags
            // 
            txtTags.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTags.Location = new Point(448, 213);
            txtTags.Name = "txtTags";
            txtTags.Size = new Size(304, 28);
            txtTags.TabIndex = 16;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpReleaseDate.Location = new Point(448, 252);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(304, 28);
            dtpReleaseDate.TabIndex = 17;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(57, 320);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 18;
            lblDescription.Text = "Description:";
            // 
            // txtDescriptionText
            // 
            txtDescriptionText.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescriptionText.Location = new Point(46, 353);
            txtDescriptionText.Multiline = true;
            txtDescriptionText.Name = "txtDescriptionText";
            txtDescriptionText.Size = new Size(791, 136);
            txtDescriptionText.TabIndex = 19;
            // 
            // picboxImage
            // 
            picboxImage.BackColor = Color.White;
            picboxImage.BackgroundImage = Properties.Resources.uploadImagePrompt;
            picboxImage.BackgroundImageLayout = ImageLayout.Center;
            picboxImage.BorderStyle = BorderStyle.FixedSingle;
            picboxImage.Cursor = Cursors.Hand;
            picboxImage.Location = new Point(57, 98);
            picboxImage.Name = "picboxImage";
            picboxImage.Size = new Size(200, 200);
            picboxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxImage.TabIndex = 21;
            picboxImage.TabStop = false;
            picboxImage.Click += picboxImage_Click;
            // 
            // lblTagName
            // 
            lblTagName.AutoSize = true;
            lblTagName.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTagName.Location = new Point(282, 233);
            lblTagName.Name = "lblTagName";
            lblTagName.Size = new Size(81, 20);
            lblTagName.TabIndex = 22;
            lblTagName.Text = "Tag Name:";
            lblTagName.Visible = false;
            // 
            // txtTagName
            // 
            txtTagName.Location = new Point(375, 230);
            txtTagName.Name = "txtTagName";
            txtTagName.Size = new Size(222, 27);
            txtTagName.TabIndex = 23;
            txtTagName.Visible = false;
            // 
            // lblAddTag
            // 
            lblAddTag.AutoSize = true;
            lblAddTag.Font = new Font("Ebrima", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddTag.Location = new Point(375, 28);
            lblAddTag.Name = "lblAddTag";
            lblAddTag.Size = new Size(153, 41);
            lblAddTag.TabIndex = 24;
            lblAddTag.Text = "Add a Tag";
            lblAddTag.Visible = false;
            // 
            // btnBackButton
            // 
            btnBackButton.Location = new Point(12, 12);
            btnBackButton.Name = "btnBackButton";
            btnBackButton.Size = new Size(94, 29);
            btnBackButton.TabIndex = 25;
            btnBackButton.Text = "Back";
            btnBackButton.UseVisualStyleBackColor = true;
            btnBackButton.Click += btnNavBack_Click;
            // 
            // btnAddButton
            // 
            btnAddButton.Location = new Point(756, 495);
            btnAddButton.Name = "btnAddButton";
            btnAddButton.Size = new Size(81, 29);
            btnAddButton.TabIndex = 26;
            btnAddButton.Text = "Add";
            btnAddButton.UseVisualStyleBackColor = true;
            btnAddButton.Click += btnAddButton_Click;
            // 
            // Manual_Entry_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(882, 553);
            Controls.Add(btnAddButton);
            Controls.Add(btnBackButton);
            Controls.Add(lblAddTag);
            Controls.Add(txtTagName);
            Controls.Add(lblTagName);
            Controls.Add(picboxImage);
            Controls.Add(txtDescriptionText);
            Controls.Add(lblDescription);
            Controls.Add(dtpReleaseDate);
            Controls.Add(txtTags);
            Controls.Add(txtCreator);
            Controls.Add(lblReleaseDate);
            Controls.Add(lblTags);
            Controls.Add(lblCreator);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(lblManualEntry);
            Name = "Manual_Entry_Form";
            Text = "MediaShelf - Make Manual Entry";
            ((System.ComponentModel.ISupportInitialize)picboxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblManualEntry;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblCreator;
        private Label lblTags;
        private Label lblReleaseDate;
        private TextBox txtCreator;
        private TextBox txtTags;
        private DateTimePicker dtpReleaseDate;
        private Label lblDescription;
        private TextBox txtDescriptionText;
        private PictureBox picboxImage;
        private Label lblTagName;
        private TextBox txtTagName;
        private Label lblAddTag;
        private Button btnBackButton;
        private Button btnAddButton;
    }
}