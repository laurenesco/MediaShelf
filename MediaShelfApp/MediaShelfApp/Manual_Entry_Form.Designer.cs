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
            btnBackButton = new Button();
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
            btnAddButton = new Button();
            picboxImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picboxImage).BeginInit();
            SuspendLayout();
            // 
            // btnBackButton
            // 
            btnBackButton.BackColor = SystemColors.ScrollBar;
            btnBackButton.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackButton.Location = new Point(16, 16);
            btnBackButton.Margin = new Padding(5, 5, 5, 5);
            btnBackButton.Name = "btnBackButton";
            btnBackButton.Size = new Size(110, 59);
            btnBackButton.TabIndex = 5;
            btnBackButton.Text = "Back";
            btnBackButton.UseVisualStyleBackColor = false;
            btnBackButton.Click += btnNavBack_Click;
            // 
            // lblManualEntry
            // 
            lblManualEntry.AutoSize = true;
            lblManualEntry.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblManualEntry.Location = new Point(574, 30);
            lblManualEntry.Margin = new Padding(5, 0, 5, 0);
            lblManualEntry.Name = "lblManualEntry";
            lblManualEntry.Size = new Size(205, 45);
            lblManualEntry.TabIndex = 7;
            lblManualEntry.Text = "Manual Entry";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(530, 152);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(88, 45);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Title:";
            lblTitle.TextAlign = ContentAlignment.TopRight;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(616, 150);
            txtTitle.Margin = new Padding(5, 5, 5, 5);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(492, 51);
            txtTitle.TabIndex = 9;
            // 
            // lblCreator
            // 
            lblCreator.AutoSize = true;
            lblCreator.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreator.Location = new Point(486, 214);
            lblCreator.Margin = new Padding(5, 0, 5, 0);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(132, 45);
            lblCreator.TabIndex = 10;
            lblCreator.Text = "Creator:";
            lblCreator.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTags
            // 
            lblTags.AutoSize = true;
            lblTags.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTags.Location = new Point(429, 275);
            lblTags.Margin = new Padding(5, 0, 5, 0);
            lblTags.Name = "lblTags";
            lblTags.Size = new Size(190, 45);
            lblTags.TabIndex = 12;
            lblTags.Text = "Genre/Tags:";
            lblTags.TextAlign = ContentAlignment.TopRight;
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblReleaseDate.Location = new Point(408, 341);
            lblReleaseDate.Margin = new Padding(5, 0, 5, 0);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(210, 45);
            lblReleaseDate.TabIndex = 13;
            lblReleaseDate.Text = "Release Date:";
            lblReleaseDate.TextAlign = ContentAlignment.TopRight;
            // 
            // txtCreator
            // 
            txtCreator.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCreator.Location = new Point(616, 213);
            txtCreator.Margin = new Padding(5, 5, 5, 5);
            txtCreator.Name = "txtCreator";
            txtCreator.Size = new Size(492, 51);
            txtCreator.TabIndex = 14;
            // 
            // txtTags
            // 
            txtTags.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTags.Location = new Point(616, 274);
            txtTags.Margin = new Padding(5, 5, 5, 5);
            txtTags.Name = "txtTags";
            txtTags.Size = new Size(492, 51);
            txtTags.TabIndex = 16;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpReleaseDate.Location = new Point(616, 336);
            dtpReleaseDate.Margin = new Padding(5, 5, 5, 5);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(492, 51);
            dtpReleaseDate.TabIndex = 17;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(67, 430);
            lblDescription.Margin = new Padding(5, 0, 5, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(189, 45);
            lblDescription.TabIndex = 18;
            lblDescription.Text = "Description:";
            // 
            // txtDescriptionText
            // 
            txtDescriptionText.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescriptionText.Location = new Point(75, 477);
            txtDescriptionText.Margin = new Padding(5, 5, 5, 5);
            txtDescriptionText.Multiline = true;
            txtDescriptionText.Name = "txtDescriptionText";
            txtDescriptionText.Size = new Size(1138, 215);
            txtDescriptionText.TabIndex = 19;
            // 
            // btnAddButton
            // 
            btnAddButton.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddButton.Location = new Point(1105, 702);
            btnAddButton.Margin = new Padding(5, 5, 5, 5);
            btnAddButton.Name = "btnAddButton";
            btnAddButton.Size = new Size(110, 59);
            btnAddButton.TabIndex = 20;
            btnAddButton.Text = "Add";
            btnAddButton.UseVisualStyleBackColor = true;
            btnAddButton.Click += ME_addButton_Click;
            // 
            // picboxImage
            // 
            picboxImage.BackColor = Color.White;
            picboxImage.BackgroundImage = Properties.Resources.uploadImagePrompt;
            picboxImage.BackgroundImageLayout = ImageLayout.Center;
            picboxImage.BorderStyle = BorderStyle.FixedSingle;
            picboxImage.Cursor = Cursors.Hand;
            picboxImage.Location = new Point(75, 106);
            picboxImage.Margin = new Padding(5, 5, 5, 5);
            picboxImage.Name = "picboxImage";
            picboxImage.Size = new Size(324, 319);
            picboxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxImage.TabIndex = 21;
            picboxImage.TabStop = false;
            picboxImage.Click += picboxImage_Click;
            // 
            // Manual_Entry_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1237, 778);
            Controls.Add(picboxImage);
            Controls.Add(btnAddButton);
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
            Controls.Add(btnBackButton);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Manual_Entry_Form";
            Text = "MediaShelf - Make Manual Entry";
            FormClosing += Manual_Entry_Form_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picboxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackButton;
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
        private Button btnAddButton;
        private PictureBox picboxImage;
    }
}