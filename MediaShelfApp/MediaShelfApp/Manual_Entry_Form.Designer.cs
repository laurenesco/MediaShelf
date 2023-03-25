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
            this.btnBackButton = new System.Windows.Forms.Button();
            this.lblManualEntry = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.dateReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescriptionText = new System.Windows.Forms.TextBox();
            this.btnAddButton = new System.Windows.Forms.Button();
            this.picboxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackButton
            // 
            this.btnBackButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBackButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackButton.Location = new System.Drawing.Point(13, 13);
            this.btnBackButton.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackButton.Name = "btnBackButton";
            this.btnBackButton.Size = new System.Drawing.Size(85, 46);
            this.btnBackButton.TabIndex = 5;
            this.btnBackButton.Text = "Back";
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.btnNavBack_Click);
            // 
            // lblManualEntry
            // 
            this.lblManualEntry.AutoSize = true;
            this.lblManualEntry.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManualEntry.Location = new System.Drawing.Point(441, 24);
            this.lblManualEntry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManualEntry.Name = "lblManualEntry";
            this.lblManualEntry.Size = new System.Drawing.Size(155, 32);
            this.lblManualEntry.TabIndex = 7;
            this.lblManualEntry.Text = "Manual Entry";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(407, 119);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 32);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(474, 118);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(379, 40);
            this.txtTitle.TabIndex = 9;
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreator.Location = new System.Drawing.Point(374, 167);
            this.lblCreator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(97, 32);
            this.lblCreator.TabIndex = 10;
            this.lblCreator.Text = "Creator:";
            this.lblCreator.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTags.Location = new System.Drawing.Point(330, 215);
            this.lblTags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(141, 32);
            this.lblTags.TabIndex = 12;
            this.lblTags.Text = "Genre/Tags:";
            this.lblTags.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReleaseDate.Location = new System.Drawing.Point(314, 266);
            this.lblReleaseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(157, 32);
            this.lblReleaseDate.TabIndex = 13;
            this.lblReleaseDate.Text = "Release Date:";
            this.lblReleaseDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCreator
            // 
            this.txtCreator.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCreator.Location = new System.Drawing.Point(474, 166);
            this.txtCreator.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(379, 40);
            this.txtCreator.TabIndex = 14;
            // 
            // txtTags
            // 
            this.txtTags.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTags.Location = new System.Drawing.Point(474, 214);
            this.txtTags.Margin = new System.Windows.Forms.Padding(4);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(379, 40);
            this.txtTags.TabIndex = 16;
            // 
            // dateReleaseDate
            // 
            this.dateReleaseDate.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateReleaseDate.Location = new System.Drawing.Point(474, 262);
            this.dateReleaseDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateReleaseDate.Name = "dateReleaseDate";
            this.dateReleaseDate.Size = new System.Drawing.Size(379, 40);
            this.dateReleaseDate.TabIndex = 17;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(51, 336);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(140, 32);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescriptionText
            // 
            this.txtDescriptionText.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescriptionText.Location = new System.Drawing.Point(58, 372);
            this.txtDescriptionText.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescriptionText.Multiline = true;
            this.txtDescriptionText.Name = "txtDescriptionText";
            this.txtDescriptionText.Size = new System.Drawing.Size(877, 169);
            this.txtDescriptionText.TabIndex = 19;
            // 
            // btnAddButton
            // 
            this.btnAddButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddButton.Location = new System.Drawing.Point(850, 549);
            this.btnAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(85, 46);
            this.btnAddButton.TabIndex = 20;
            this.btnAddButton.Text = "Add";
            this.btnAddButton.UseVisualStyleBackColor = true;
            this.btnAddButton.Click += new System.EventHandler(this.ME_addButton_Click);
            // 
            // picboxImage
            // 
            this.picboxImage.BackColor = System.Drawing.Color.White;
            this.picboxImage.BackgroundImage = global::MediaShelfApp.Properties.Resources.uploadImagePrompt;
            this.picboxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picboxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxImage.Location = new System.Drawing.Point(58, 82);
            this.picboxImage.Margin = new System.Windows.Forms.Padding(4);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(250, 250);
            this.picboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImage.TabIndex = 21;
            this.picboxImage.TabStop = false;
            this.picboxImage.Click += new System.EventHandler(this.picboxImage_Click);
            // 
            // Manual_Entry_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(951, 608);
            this.Controls.Add(this.picboxImage);
            this.Controls.Add(this.btnAddButton);
            this.Controls.Add(this.txtDescriptionText);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dateReleaseDate);
            this.Controls.Add(this.txtTags);
            this.Controls.Add(this.txtCreator);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblManualEntry);
            this.Controls.Add(this.btnBackButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manual_Entry_Form";
            this.Text = "MediaShelf - Make Manual Entry";
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DateTimePicker dateReleaseDate;
        private Label lblDescription;
        private TextBox txtDescriptionText;
        private Button btnAddButton;
        private PictureBox picboxImage;
    }
}