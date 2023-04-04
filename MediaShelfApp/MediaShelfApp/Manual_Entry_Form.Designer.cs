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
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescriptionText = new System.Windows.Forms.TextBox();
            this.btnAddButton = new System.Windows.Forms.Button();
            this.picboxImage = new System.Windows.Forms.PictureBox();
            this.lblTagName = new System.Windows.Forms.Label();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.lblAddTag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackButton
            // 
            this.btnBackButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBackButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackButton.Location = new System.Drawing.Point(10, 10);
            this.btnBackButton.Name = "btnBackButton";
            this.btnBackButton.Size = new System.Drawing.Size(68, 37);
            this.btnBackButton.TabIndex = 5;
            this.btnBackButton.Text = "Back";
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.btnNavBack_Click);
            // 
            // lblManualEntry
            // 
            this.lblManualEntry.AutoSize = true;
            this.lblManualEntry.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManualEntry.Location = new System.Drawing.Point(353, 19);
            this.lblManualEntry.Name = "lblManualEntry";
            this.lblManualEntry.Size = new System.Drawing.Size(127, 28);
            this.lblManualEntry.TabIndex = 7;
            this.lblManualEntry.Text = "Manual Entry";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(326, 95);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 28);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(379, 94);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(304, 35);
            this.txtTitle.TabIndex = 9;
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreator.Location = new System.Drawing.Point(299, 134);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(81, 28);
            this.lblCreator.TabIndex = 10;
            this.lblCreator.Text = "Creator:";
            this.lblCreator.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTags.Location = new System.Drawing.Point(264, 172);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(116, 28);
            this.lblTags.TabIndex = 12;
            this.lblTags.Text = "Genre/Tags:";
            this.lblTags.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReleaseDate.Location = new System.Drawing.Point(251, 213);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(127, 28);
            this.lblReleaseDate.TabIndex = 13;
            this.lblReleaseDate.Text = "Release Date:";
            this.lblReleaseDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCreator
            // 
            this.txtCreator.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCreator.Location = new System.Drawing.Point(379, 133);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(304, 35);
            this.txtCreator.TabIndex = 14;
            // 
            // txtTags
            // 
            this.txtTags.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTags.Location = new System.Drawing.Point(379, 171);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(304, 35);
            this.txtTags.TabIndex = 16;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpReleaseDate.Location = new System.Drawing.Point(379, 210);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(304, 35);
            this.dtpReleaseDate.TabIndex = 17;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(41, 269);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(116, 28);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescriptionText
            // 
            this.txtDescriptionText.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescriptionText.Location = new System.Drawing.Point(46, 298);
            this.txtDescriptionText.Multiline = true;
            this.txtDescriptionText.Name = "txtDescriptionText";
            this.txtDescriptionText.Size = new System.Drawing.Size(702, 136);
            this.txtDescriptionText.TabIndex = 19;
            // 
            // btnAddButton
            // 
            this.btnAddButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddButton.Location = new System.Drawing.Point(680, 439);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(68, 37);
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
            this.picboxImage.Location = new System.Drawing.Point(46, 66);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(200, 200);
            this.picboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImage.TabIndex = 21;
            this.picboxImage.TabStop = false;
            this.picboxImage.Click += new System.EventHandler(this.picboxImage_Click);
            // 
            // lblTagName
            // 
            this.lblTagName.AutoSize = true;
            this.lblTagName.Location = new System.Drawing.Point(244, 136);
            this.lblTagName.Name = "lblTagName";
            this.lblTagName.Size = new System.Drawing.Size(79, 20);
            this.lblTagName.TabIndex = 22;
            this.lblTagName.Text = "Tag Name:";
            this.lblTagName.Visible = false;
            // 
            // txtTagName
            // 
            this.txtTagName.Location = new System.Drawing.Point(337, 133);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(222, 27);
            this.txtTagName.TabIndex = 23;
            this.txtTagName.Visible = false;
            // 
            // lblAddTag
            // 
            this.lblAddTag.AutoSize = true;
            this.lblAddTag.Location = new System.Drawing.Point(337, 21);
            this.lblAddTag.Name = "lblAddTag";
            this.lblAddTag.Size = new System.Drawing.Size(76, 20);
            this.lblAddTag.TabIndex = 24;
            this.lblAddTag.Text = "Add a Tag";
            this.lblAddTag.Visible = false;
            // 
            // Manual_Entry_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(761, 486);
            this.Controls.Add(this.lblAddTag);
            this.Controls.Add(this.txtTagName);
            this.Controls.Add(this.lblTagName);
            this.Controls.Add(this.picboxImage);
            this.Controls.Add(this.btnAddButton);
            this.Controls.Add(this.txtDescriptionText);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.txtTags);
            this.Controls.Add(this.txtCreator);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblManualEntry);
            this.Controls.Add(this.btnBackButton);
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
        private DateTimePicker dtpReleaseDate;
        private Label lblDescription;
        private TextBox txtDescriptionText;
        private Button btnAddButton;
        private PictureBox picboxImage;
        private Label lblTagName;
        private TextBox txtTagName;
        private Label lblAddTag;
    }
}