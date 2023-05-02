namespace MediaShelfApp
{
    partial class Notes_Form
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
            lblTitle = new Label();
            btnAddNote = new Button();
            txtNote1 = new TextBox();
            txtNote2 = new TextBox();
            txtNote3 = new TextBox();
            txtNote4 = new TextBox();
            btnNavBack = new Button();
            flpTags = new FlowLayoutPanel();
            lblAddTagPrompt = new Label();
            cmbAddTags = new ComboBox();
            btnAddTag = new Button();
            btnDeleteTag = new Button();
            cmbDeleteTags = new ComboBox();
            lblDeleteTagPrompt = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ControlLightLight;
            lblTitle.Font = new Font("Ebrima", 21F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(55, 90);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.MinimumSize = new Size(1310, 74);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1310, 74);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Item Name Label";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddNote
            // 
            btnAddNote.Enabled = false;
            btnAddNote.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNote.Location = new Point(1250, 19);
            btnAddNote.Margin = new Padding(5);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(153, 46);
            btnAddNote.TabIndex = 5;
            btnAddNote.Text = "Save";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // txtNote1
            // 
            txtNote1.BackColor = SystemColors.Info;
            txtNote1.Location = new Point(55, 211);
            txtNote1.Margin = new Padding(5);
            txtNote1.MaxLength = 400;
            txtNote1.Multiline = true;
            txtNote1.Name = "txtNote1";
            txtNote1.Size = new Size(300, 262);
            txtNote1.TabIndex = 12;
            txtNote1.TextChanged += txtNote1_TextChanged;
            // 
            // txtNote2
            // 
            txtNote2.BackColor = SystemColors.Info;
            txtNote2.Location = new Point(393, 211);
            txtNote2.Margin = new Padding(5);
            txtNote2.MaxLength = 400;
            txtNote2.Multiline = true;
            txtNote2.Name = "txtNote2";
            txtNote2.Size = new Size(300, 262);
            txtNote2.TabIndex = 15;
            txtNote2.TextChanged += txtNote2_TextChanged;
            // 
            // txtNote3
            // 
            txtNote3.BackColor = SystemColors.Info;
            txtNote3.Location = new Point(730, 211);
            txtNote3.Margin = new Padding(5);
            txtNote3.MaxLength = 400;
            txtNote3.Multiline = true;
            txtNote3.Name = "txtNote3";
            txtNote3.Size = new Size(300, 262);
            txtNote3.TabIndex = 16;
            txtNote3.TextChanged += txtNote3_TextChanged;
            // 
            // txtNote4
            // 
            txtNote4.BackColor = SystemColors.Info;
            txtNote4.Location = new Point(1066, 211);
            txtNote4.Margin = new Padding(5);
            txtNote4.MaxLength = 400;
            txtNote4.Multiline = true;
            txtNote4.Name = "txtNote4";
            txtNote4.Size = new Size(300, 262);
            txtNote4.TabIndex = 17;
            txtNote4.TextChanged += txtNote4_TextChanged;
            // 
            // btnNavBack
            // 
            btnNavBack.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavBack.Location = new Point(20, 19);
            btnNavBack.Margin = new Padding(5);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(153, 46);
            btnNavBack.TabIndex = 23;
            btnNavBack.Text = "Back";
            btnNavBack.UseVisualStyleBackColor = true;
            btnNavBack.Click += btnNavBack_Click;
            // 
            // flpTags
            // 
            flpTags.AutoScroll = true;
            flpTags.BackColor = SystemColors.ControlLightLight;
            flpTags.BackgroundImage = Properties.Resources.BACKGROUND_WHITE;
            flpTags.Dock = DockStyle.Bottom;
            flpTags.Location = new Point(0, 691);
            flpTags.Name = "flpTags";
            flpTags.Padding = new Padding(10, 0, 10, 0);
            flpTags.Size = new Size(1433, 194);
            flpTags.TabIndex = 24;
            // 
            // lblAddTagPrompt
            // 
            lblAddTagPrompt.AutoSize = true;
            lblAddTagPrompt.BackColor = SystemColors.ControlLightLight;
            lblAddTagPrompt.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddTagPrompt.Location = new Point(55, 555);
            lblAddTagPrompt.Name = "lblAddTagPrompt";
            lblAddTagPrompt.Size = new Size(237, 32);
            lblAddTagPrompt.TabIndex = 25;
            lblAddTagPrompt.Text = "Add Tag to this Item:";
            // 
            // cmbAddTags
            // 
            cmbAddTags.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddTags.FormattingEnabled = true;
            cmbAddTags.Items.AddRange(new object[] { "(none)" });
            cmbAddTags.Location = new Point(302, 550);
            cmbAddTags.MaxDropDownItems = 100;
            cmbAddTags.Name = "cmbAddTags";
            cmbAddTags.Size = new Size(235, 40);
            cmbAddTags.Sorted = true;
            cmbAddTags.TabIndex = 26;
            cmbAddTags.SelectedIndexChanged += cmbAddTags_SelectedIndexChanged;
            // 
            // btnAddTag
            // 
            btnAddTag.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddTag.Location = new Point(387, 600);
            btnAddTag.Name = "btnAddTag";
            btnAddTag.Size = new Size(153, 46);
            btnAddTag.TabIndex = 27;
            btnAddTag.Text = "Add Tag";
            btnAddTag.UseVisualStyleBackColor = true;
            btnAddTag.Click += btnAddTag_Click;
            // 
            // btnDeleteTag
            // 
            btnDeleteTag.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteTag.Location = new Point(1216, 602);
            btnDeleteTag.Name = "btnDeleteTag";
            btnDeleteTag.Size = new Size(153, 46);
            btnDeleteTag.TabIndex = 30;
            btnDeleteTag.Text = "Delete Tag";
            btnDeleteTag.UseVisualStyleBackColor = true;
            btnDeleteTag.Click += btnDeleteTag_Click;
            // 
            // cmbDeleteTags
            // 
            cmbDeleteTags.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeleteTags.FormattingEnabled = true;
            cmbDeleteTags.Items.AddRange(new object[] { "(none)" });
            cmbDeleteTags.Location = new Point(1131, 550);
            cmbDeleteTags.MaxDropDownItems = 100;
            cmbDeleteTags.Name = "cmbDeleteTags";
            cmbDeleteTags.Size = new Size(235, 40);
            cmbDeleteTags.Sorted = true;
            cmbDeleteTags.TabIndex = 29;
            cmbDeleteTags.SelectedIndexChanged += cmbDeleteTags_SelectedIndexChanged;
            // 
            // lblDeleteTagPrompt
            // 
            lblDeleteTagPrompt.AutoSize = true;
            lblDeleteTagPrompt.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeleteTagPrompt.Location = new Point(829, 555);
            lblDeleteTagPrompt.Name = "lblDeleteTagPrompt";
            lblDeleteTagPrompt.Size = new Size(293, 32);
            lblDeleteTagPrompt.TabIndex = 28;
            lblDeleteTagPrompt.Text = "Delete Tag from this Item:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 643);
            label1.Name = "label1";
            label1.Size = new Size(89, 45);
            label1.TabIndex = 31;
            label1.Text = "Tags:";
            // 
            // Notes_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BACKGROUND_WHITE;
            ClientSize = new Size(1433, 885);
            Controls.Add(label1);
            Controls.Add(btnDeleteTag);
            Controls.Add(cmbDeleteTags);
            Controls.Add(lblDeleteTagPrompt);
            Controls.Add(btnAddTag);
            Controls.Add(cmbAddTags);
            Controls.Add(lblAddTagPrompt);
            Controls.Add(flpTags);
            Controls.Add(btnNavBack);
            Controls.Add(txtNote4);
            Controls.Add(txtNote3);
            Controls.Add(txtNote2);
            Controls.Add(txtNote1);
            Controls.Add(btnAddNote);
            Controls.Add(lblTitle);
            Margin = new Padding(5);
            Name = "Notes_Form";
            Text = "Notes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAddNote;
        private TextBox txtNote1;
        private TextBox txtNote2;
        private TextBox txtNote3;
        private TextBox txtNote4;
        private Button btnNavBack;
        private FlowLayoutPanel flpTags;
        private Label lblAddTagPrompt;
        private ComboBox cmbAddTags;
        private Button btnAddTag;
        private Button btnDeleteTag;
        private ComboBox cmbDeleteTags;
        private Label lblDeleteTagPrompt;
        private Label label1;
    }
}