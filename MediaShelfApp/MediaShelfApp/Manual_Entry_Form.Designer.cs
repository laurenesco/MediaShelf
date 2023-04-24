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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manual_Entry_Form));
            this.lblManualEntry = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescriptionText = new System.Windows.Forms.TextBox();
            this.picboxImage = new System.Windows.Forms.PictureBox();
            this.lblAddTag = new System.Windows.Forms.Label();
            this.btnBackButton = new System.Windows.Forms.Button();
            this.btnAddButton = new System.Windows.Forms.Button();
            this.flpTagName = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTagName = new System.Windows.Forms.Label();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.flpManualEntryFields = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            this.flpTagName.SuspendLayout();
            this.flpManualEntryFields.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManualEntry
            // 
            this.lblManualEntry.AutoSize = true;
            this.lblManualEntry.BackColor = System.Drawing.Color.Transparent;
            this.lblManualEntry.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManualEntry.Location = new System.Drawing.Point(460, 35);
            this.lblManualEntry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManualEntry.Name = "lblManualEntry";
            this.lblManualEntry.Size = new System.Drawing.Size(227, 48);
            this.lblManualEntry.TabIndex = 7;
            this.lblManualEntry.Text = "Manual Entry";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(71, 400);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(106, 25);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescriptionText
            // 
            this.txtDescriptionText.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescriptionText.Location = new System.Drawing.Point(58, 441);
            this.txtDescriptionText.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescriptionText.Multiline = true;
            this.txtDescriptionText.Name = "txtDescriptionText";
            this.txtDescriptionText.Size = new System.Drawing.Size(988, 169);
            this.txtDescriptionText.TabIndex = 19;
            // 
            // picboxImage
            // 
            this.picboxImage.BackColor = System.Drawing.Color.White;
            this.picboxImage.BackgroundImage = global::MediaShelfApp.Properties.Resources.uploadImagePrompt;
            this.picboxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picboxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxImage.Location = new System.Drawing.Point(71, 122);
            this.picboxImage.Margin = new System.Windows.Forms.Padding(4);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(250, 250);
            this.picboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImage.TabIndex = 21;
            this.picboxImage.TabStop = false;
            // 
            // lblAddTag
            // 
            this.lblAddTag.AutoSize = true;
            this.lblAddTag.BackColor = System.Drawing.Color.Transparent;
            this.lblAddTag.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddTag.Location = new System.Drawing.Point(469, 35);
            this.lblAddTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddTag.Name = "lblAddTag";
            this.lblAddTag.Size = new System.Drawing.Size(181, 48);
            this.lblAddTag.TabIndex = 24;
            this.lblAddTag.Text = "Add a Tag";
            this.lblAddTag.Visible = false;
            // 
            // btnBackButton
            // 
            this.btnBackButton.Location = new System.Drawing.Point(15, 15);
            this.btnBackButton.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackButton.Name = "btnBackButton";
            this.btnBackButton.Size = new System.Drawing.Size(118, 36);
            this.btnBackButton.TabIndex = 25;
            this.btnBackButton.Text = "Back";
            this.btnBackButton.UseVisualStyleBackColor = true;
            // 
            // btnAddButton
            // 
            this.btnAddButton.Location = new System.Drawing.Point(945, 619);
            this.btnAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(101, 36);
            this.btnAddButton.TabIndex = 26;
            this.btnAddButton.Text = "Add";
            this.btnAddButton.UseVisualStyleBackColor = true;
            // 
            // flpTagName
            // 
            this.flpTagName.AutoSize = true;
            this.flpTagName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpTagName.BackColor = System.Drawing.Color.Transparent;
            this.flpTagName.Controls.Add(this.lblTagName);
            this.flpTagName.Controls.Add(this.txtTagName);
            this.flpTagName.Location = new System.Drawing.Point(350, 297);
            this.flpTagName.Name = "flpTagName";
            this.flpTagName.Size = new System.Drawing.Size(389, 40);
            this.flpTagName.TabIndex = 30;
            this.flpTagName.Visible = false;
            // 
            // lblTagName
            // 
            this.lblTagName.AutoSize = true;
            this.lblTagName.BackColor = System.Drawing.Color.Transparent;
            this.lblTagName.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTagName.Location = new System.Drawing.Point(4, 7);
            this.lblTagName.Margin = new System.Windows.Forms.Padding(4, 7, 4, 0);
            this.lblTagName.Name = "lblTagName";
            this.lblTagName.Size = new System.Drawing.Size(97, 25);
            this.lblTagName.TabIndex = 22;
            this.lblTagName.Text = "Tag Name:";
            // 
            // txtTagName
            // 
            this.txtTagName.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTagName.Location = new System.Drawing.Point(109, 4);
            this.txtTagName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(276, 32);
            this.txtTagName.TabIndex = 23;
            // 
            // flpManualEntryFields
            // 
            this.flpManualEntryFields.AutoSize = true;
            this.flpManualEntryFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpManualEntryFields.BackColor = System.Drawing.Color.Transparent;
            this.flpManualEntryFields.Controls.Add(this.flowLayoutPanel2);
            this.flpManualEntryFields.Controls.Add(this.flowLayoutPanel3);
            this.flpManualEntryFields.Location = new System.Drawing.Point(352, 163);
            this.flpManualEntryFields.Name = "flpManualEntryFields";
            this.flpManualEntryFields.Size = new System.Drawing.Size(524, 178);
            this.flpManualEntryFields.TabIndex = 29;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.lblTitle);
            this.flowLayoutPanel2.Controls.Add(this.lblCreator);
            this.flowLayoutPanel2.Controls.Add(this.lblTags);
            this.flowLayoutPanel2.Controls.Add(this.lblReleaseDate);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(125, 171);
            this.flowLayoutPanel2.TabIndex = 28;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(73, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 25);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.BackColor = System.Drawing.Color.Transparent;
            this.lblCreator.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCreator.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreator.Location = new System.Drawing.Point(47, 51);
            this.lblCreator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 18);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(74, 25);
            this.lblCreator.TabIndex = 10;
            this.lblCreator.Text = "Creator:";
            this.lblCreator.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.BackColor = System.Drawing.Color.Transparent;
            this.lblTags.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTags.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTags.Location = new System.Drawing.Point(68, 94);
            this.lblTags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 18);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(53, 25);
            this.lblTags.TabIndex = 12;
            this.lblTags.Text = "Tags:";
            this.lblTags.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReleaseDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblReleaseDate.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReleaseDate.Location = new System.Drawing.Point(4, 138);
            this.lblReleaseDate.Margin = new System.Windows.Forms.Padding(4, 1, 4, 0);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(117, 25);
            this.lblReleaseDate.TabIndex = 13;
            this.lblReleaseDate.Text = "Release Date:";
            this.lblReleaseDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.txtTitle);
            this.flowLayoutPanel3.Controls.Add(this.txtCreator);
            this.flowLayoutPanel3.Controls.Add(this.txtTags);
            this.flowLayoutPanel3.Controls.Add(this.dtpReleaseDate);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(134, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(387, 172);
            this.flowLayoutPanel3.TabIndex = 28;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(4, 7);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(379, 32);
            this.txtTitle.TabIndex = 9;
            // 
            // txtCreator
            // 
            this.txtCreator.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCreator.Location = new System.Drawing.Point(4, 50);
            this.txtCreator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(379, 32);
            this.txtCreator.TabIndex = 14;
            // 
            // txtTags
            // 
            this.txtTags.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTags.Location = new System.Drawing.Point(4, 93);
            this.txtTags.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(379, 32);
            this.txtTags.TabIndex = 16;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpReleaseDate.Location = new System.Drawing.Point(4, 136);
            this.dtpReleaseDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(379, 32);
            this.dtpReleaseDate.TabIndex = 17;
            // 
            // Manual_Entry_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1102, 691);
            this.Controls.Add(this.flpTagName);
            this.Controls.Add(this.flpManualEntryFields);
            this.Controls.Add(this.btnAddButton);
            this.Controls.Add(this.btnBackButton);
            this.Controls.Add(this.lblAddTag);
            this.Controls.Add(this.picboxImage);
            this.Controls.Add(this.txtDescriptionText);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblManualEntry);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manual_Entry_Form";
            this.Text = "MediaShelf - Make Manual Entry";
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
            this.flpTagName.ResumeLayout(false);
            this.flpTagName.PerformLayout();
            this.flpManualEntryFields.ResumeLayout(false);
            this.flpManualEntryFields.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblManualEntry;
        private Label lblDescription;
        private TextBox txtDescriptionText;
        private PictureBox picboxImage;
        private Label lblAddTag;
        private Button btnBackButton;
        private Button btnAddButton;
        private FlowLayoutPanel flpTagName;
        private Label lblTagName;
        private TextBox txtTagName;
        private FlowLayoutPanel flpManualEntryFields;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblTitle;
        private Label lblCreator;
        private Label lblTags;
        private Label lblReleaseDate;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox txtTitle;
        private TextBox txtCreator;
        private TextBox txtTags;
        private DateTimePicker dtpReleaseDate;
    }
}