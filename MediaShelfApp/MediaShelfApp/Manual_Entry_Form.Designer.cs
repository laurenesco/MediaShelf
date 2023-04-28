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
            lblDescription = new Label();
            txtDescriptionText = new TextBox();
            picboxImage = new PictureBox();
            lblAddTag = new Label();
            btnBackButton = new Button();
            btnAddButton = new Button();
            flpTagName = new FlowLayoutPanel();
            lblTagName = new Label();
            txtTagName = new TextBox();
            flpManualEntryFields = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblTitle = new Label();
            lblCreator = new Label();
            lblTags = new Label();
            lblReleaseDate = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            txtTitle = new TextBox();
            txtCreator = new TextBox();
            txtTags = new TextBox();
            dtpReleaseDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)picboxImage).BeginInit();
            flpTagName.SuspendLayout();
            flpManualEntryFields.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblManualEntry
            // 
            lblManualEntry.AutoSize = true;
            lblManualEntry.BackColor = Color.Transparent;
            lblManualEntry.Font = new Font("Ebrima", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblManualEntry.Location = new Point(460, 35);
            lblManualEntry.Margin = new Padding(4, 0, 4, 0);
            lblManualEntry.Name = "lblManualEntry";
            lblManualEntry.Size = new Size(227, 48);
            lblManualEntry.TabIndex = 7;
            lblManualEntry.Text = "Manual Entry";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(67, 400);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(106, 25);
            lblDescription.TabIndex = 18;
            lblDescription.Text = "Description:";
            // 
            // txtDescriptionText
            // 
            txtDescriptionText.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescriptionText.Location = new Point(71, 442);
            txtDescriptionText.Margin = new Padding(4);
            txtDescriptionText.Multiline = true;
            txtDescriptionText.Name = "txtDescriptionText";
            txtDescriptionText.Size = new Size(988, 169);
            txtDescriptionText.TabIndex = 19;
            // 
            // picboxImage
            // 
            picboxImage.BackColor = Color.White;
            picboxImage.BackgroundImage = Properties.Resources.uploadImagePrompt;
            picboxImage.BackgroundImageLayout = ImageLayout.Center;
            picboxImage.BorderStyle = BorderStyle.FixedSingle;
            picboxImage.Cursor = Cursors.Hand;
            picboxImage.Location = new Point(71, 122);
            picboxImage.Margin = new Padding(4);
            picboxImage.Name = "picboxImage";
            picboxImage.Size = new Size(250, 250);
            picboxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxImage.TabIndex = 21;
            picboxImage.TabStop = false;
            picboxImage.Click += picboxImage_Click;
            // 
            // lblAddTag
            // 
            lblAddTag.AutoSize = true;
            lblAddTag.BackColor = Color.Transparent;
            lblAddTag.Font = new Font("Ebrima", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddTag.Location = new Point(469, 35);
            lblAddTag.Margin = new Padding(4, 0, 4, 0);
            lblAddTag.Name = "lblAddTag";
            lblAddTag.Size = new Size(181, 48);
            lblAddTag.TabIndex = 24;
            lblAddTag.Text = "Add a Tag";
            lblAddTag.Visible = false;
            // 
            // btnBackButton
            // 
            btnBackButton.Location = new Point(15, 15);
            btnBackButton.Margin = new Padding(4);
            btnBackButton.Name = "btnBackButton";
            btnBackButton.Size = new Size(118, 36);
            btnBackButton.TabIndex = 25;
            btnBackButton.Text = "Back";
            btnBackButton.UseVisualStyleBackColor = true;
            btnBackButton.Click += btnNavBack_Click;
            // 
            // btnAddButton
            // 
            btnAddButton.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddButton.Location = new Point(945, 619);
            btnAddButton.Margin = new Padding(4);
            btnAddButton.Name = "btnAddButton";
            btnAddButton.Size = new Size(101, 42);
            btnAddButton.TabIndex = 26;
            btnAddButton.Text = "Add";
            btnAddButton.UseVisualStyleBackColor = true;
            btnAddButton.Click += btnAddButton_Click;
            // 
            // flpTagName
            // 
            flpTagName.AutoSize = true;
            flpTagName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpTagName.BackColor = Color.Transparent;
            flpTagName.Controls.Add(lblTagName);
            flpTagName.Controls.Add(txtTagName);
            flpTagName.Location = new Point(379, 307);
            flpTagName.Name = "flpTagName";
            flpTagName.Size = new Size(389, 40);
            flpTagName.TabIndex = 30;
            flpTagName.Visible = false;
            // 
            // lblTagName
            // 
            lblTagName.AutoSize = true;
            lblTagName.BackColor = Color.Transparent;
            lblTagName.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTagName.Location = new Point(4, 7);
            lblTagName.Margin = new Padding(4, 7, 4, 0);
            lblTagName.Name = "lblTagName";
            lblTagName.Size = new Size(97, 25);
            lblTagName.TabIndex = 22;
            lblTagName.Text = "Tag Name:";
            // 
            // txtTagName
            // 
            txtTagName.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTagName.Location = new Point(109, 4);
            txtTagName.Margin = new Padding(4);
            txtTagName.Name = "txtTagName";
            txtTagName.Size = new Size(276, 32);
            txtTagName.TabIndex = 23;
            // 
            // flpManualEntryFields
            // 
            flpManualEntryFields.AutoSize = true;
            flpManualEntryFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpManualEntryFields.BackColor = Color.Transparent;
            flpManualEntryFields.Controls.Add(flowLayoutPanel2);
            flpManualEntryFields.Controls.Add(flowLayoutPanel3);
            flpManualEntryFields.Location = new Point(381, 173);
            flpManualEntryFields.Name = "flpManualEntryFields";
            flpManualEntryFields.Size = new Size(524, 178);
            flpManualEntryFields.TabIndex = 29;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(lblTitle);
            flowLayoutPanel2.Controls.Add(lblCreator);
            flowLayoutPanel2.Controls.Add(lblTags);
            flowLayoutPanel2.Controls.Add(lblReleaseDate);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(0, 8, 0, 8);
            flowLayoutPanel2.Size = new Size(125, 171);
            flowLayoutPanel2.TabIndex = 28;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Dock = DockStyle.Right;
            lblTitle.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(73, 8);
            lblTitle.Margin = new Padding(4, 0, 4, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(48, 25);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Title:";
            lblTitle.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCreator
            // 
            lblCreator.AutoSize = true;
            lblCreator.BackColor = Color.Transparent;
            lblCreator.Dock = DockStyle.Right;
            lblCreator.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreator.Location = new Point(47, 51);
            lblCreator.Margin = new Padding(4, 0, 4, 18);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(74, 25);
            lblCreator.TabIndex = 10;
            lblCreator.Text = "Creator:";
            lblCreator.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTags
            // 
            lblTags.AutoSize = true;
            lblTags.BackColor = Color.Transparent;
            lblTags.Dock = DockStyle.Right;
            lblTags.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTags.Location = new Point(68, 94);
            lblTags.Margin = new Padding(4, 0, 4, 18);
            lblTags.Name = "lblTags";
            lblTags.Size = new Size(53, 25);
            lblTags.TabIndex = 12;
            lblTags.Text = "Tags:";
            lblTags.TextAlign = ContentAlignment.TopRight;
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.BackColor = Color.Transparent;
            lblReleaseDate.Dock = DockStyle.Right;
            lblReleaseDate.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblReleaseDate.Location = new Point(4, 138);
            lblReleaseDate.Margin = new Padding(4, 1, 4, 0);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(117, 25);
            lblReleaseDate.TabIndex = 13;
            lblReleaseDate.Text = "Release Date:";
            lblReleaseDate.TextAlign = ContentAlignment.TopRight;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.BackColor = Color.Transparent;
            flowLayoutPanel3.Controls.Add(txtTitle);
            flowLayoutPanel3.Controls.Add(txtCreator);
            flowLayoutPanel3.Controls.Add(txtTags);
            flowLayoutPanel3.Controls.Add(dtpReleaseDate);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(134, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(0, 3, 0, 0);
            flowLayoutPanel3.Size = new Size(387, 172);
            flowLayoutPanel3.TabIndex = 28;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(4, 7);
            txtTitle.Margin = new Padding(4, 4, 4, 7);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(379, 32);
            txtTitle.TabIndex = 9;
            // 
            // txtCreator
            // 
            txtCreator.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCreator.Location = new Point(4, 50);
            txtCreator.Margin = new Padding(4, 4, 4, 7);
            txtCreator.Name = "txtCreator";
            txtCreator.Size = new Size(379, 32);
            txtCreator.TabIndex = 14;
            // 
            // txtTags
            // 
            txtTags.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTags.Location = new Point(4, 93);
            txtTags.Margin = new Padding(4, 4, 4, 7);
            txtTags.Name = "txtTags";
            txtTags.Size = new Size(379, 32);
            txtTags.TabIndex = 16;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpReleaseDate.Location = new Point(4, 136);
            dtpReleaseDate.Margin = new Padding(4);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(379, 32);
            dtpReleaseDate.TabIndex = 17;
            // 
            // Manual_Entry_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.BACKGROUND_WHITE;
            ClientSize = new Size(1102, 691);
            Controls.Add(flpTagName);
            Controls.Add(flpManualEntryFields);
            Controls.Add(btnAddButton);
            Controls.Add(btnBackButton);
            Controls.Add(lblAddTag);
            Controls.Add(picboxImage);
            Controls.Add(txtDescriptionText);
            Controls.Add(lblDescription);
            Controls.Add(lblManualEntry);
            Margin = new Padding(4);
            Name = "Manual_Entry_Form";
            Text = "MediaShelf - Make Manual Entry";
            ((System.ComponentModel.ISupportInitialize)picboxImage).EndInit();
            flpTagName.ResumeLayout(false);
            flpTagName.PerformLayout();
            flpManualEntryFields.ResumeLayout(false);
            flpManualEntryFields.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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