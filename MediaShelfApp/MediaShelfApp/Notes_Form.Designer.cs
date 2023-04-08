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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.txtNote1 = new System.Windows.Forms.TextBox();
            this.txtNote2 = new System.Windows.Forms.TextBox();
            this.txtNote3 = new System.Windows.Forms.TextBox();
            this.txtNote4 = new System.Windows.Forms.TextBox();
            this.btnNavBack = new System.Windows.Forms.Button();
            this.flpTags = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAddTagPrompt = new System.Windows.Forms.Label();
            this.cmbAddTags = new System.Windows.Forms.ComboBox();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.btnDeleteTag = new System.Windows.Forms.Button();
            this.cmbDeleteTags = new System.Windows.Forms.ComboBox();
            this.lblDeleteTagPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(372, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 57);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Item Name Label";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Enabled = false;
            this.btnAddNote.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNote.Location = new System.Drawing.Point(961, 15);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(118, 36);
            this.btnAddNote.TabIndex = 5;
            this.btnAddNote.Text = "Save";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // txtNote1
            // 
            this.txtNote1.BackColor = System.Drawing.SystemColors.Info;
            this.txtNote1.Location = new System.Drawing.Point(40, 114);
            this.txtNote1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote1.MaxLength = 400;
            this.txtNote1.Multiline = true;
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.Size = new System.Drawing.Size(232, 205);
            this.txtNote1.TabIndex = 12;
            this.txtNote1.TextChanged += new System.EventHandler(this.txtNote1_TextChanged);
            // 
            // txtNote2
            // 
            this.txtNote2.BackColor = System.Drawing.SystemColors.Info;
            this.txtNote2.Location = new System.Drawing.Point(300, 114);
            this.txtNote2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote2.MaxLength = 400;
            this.txtNote2.Multiline = true;
            this.txtNote2.Name = "txtNote2";
            this.txtNote2.Size = new System.Drawing.Size(232, 205);
            this.txtNote2.TabIndex = 15;
            this.txtNote2.TextChanged += new System.EventHandler(this.txtNote2_TextChanged);
            // 
            // txtNote3
            // 
            this.txtNote3.BackColor = System.Drawing.SystemColors.Info;
            this.txtNote3.Location = new System.Drawing.Point(559, 114);
            this.txtNote3.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote3.MaxLength = 400;
            this.txtNote3.Multiline = true;
            this.txtNote3.Name = "txtNote3";
            this.txtNote3.Size = new System.Drawing.Size(232, 205);
            this.txtNote3.TabIndex = 16;
            this.txtNote3.TextChanged += new System.EventHandler(this.txtNote3_TextChanged);
            // 
            // txtNote4
            // 
            this.txtNote4.BackColor = System.Drawing.SystemColors.Info;
            this.txtNote4.Location = new System.Drawing.Point(818, 114);
            this.txtNote4.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote4.MaxLength = 400;
            this.txtNote4.Multiline = true;
            this.txtNote4.Name = "txtNote4";
            this.txtNote4.Size = new System.Drawing.Size(232, 205);
            this.txtNote4.TabIndex = 17;
            this.txtNote4.TextChanged += new System.EventHandler(this.txtNote4_TextChanged);
            // 
            // btnNavBack
            // 
            this.btnNavBack.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavBack.Location = new System.Drawing.Point(15, 15);
            this.btnNavBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavBack.Name = "btnNavBack";
            this.btnNavBack.Size = new System.Drawing.Size(118, 36);
            this.btnNavBack.TabIndex = 23;
            this.btnNavBack.Text = "Back";
            this.btnNavBack.UseVisualStyleBackColor = true;
            this.btnNavBack.Click += new System.EventHandler(this.btnNavBack_Click);
            // 
            // flpTags
            // 
            this.flpTags.AutoScroll = true;
            this.flpTags.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpTags.Location = new System.Drawing.Point(0, 448);
            this.flpTags.Name = "flpTags";
            this.flpTags.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.flpTags.Size = new System.Drawing.Size(1094, 150);
            this.flpTags.TabIndex = 24;
            // 
            // lblAddTagPrompt
            // 
            this.lblAddTagPrompt.AutoSize = true;
            this.lblAddTagPrompt.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddTagPrompt.Location = new System.Drawing.Point(30, 336);
            this.lblAddTagPrompt.Name = "lblAddTagPrompt";
            this.lblAddTagPrompt.Size = new System.Drawing.Size(274, 38);
            this.lblAddTagPrompt.TabIndex = 25;
            this.lblAddTagPrompt.Text = "Add Tag to this Item:";
            // 
            // cmbAddTags
            // 
            this.cmbAddTags.FormattingEnabled = true;
            this.cmbAddTags.Items.AddRange(new object[] {
            "(none)"});
            this.cmbAddTags.Location = new System.Drawing.Point(310, 344);
            this.cmbAddTags.MaxDropDownItems = 100;
            this.cmbAddTags.Name = "cmbAddTags";
            this.cmbAddTags.Size = new System.Drawing.Size(182, 33);
            this.cmbAddTags.Sorted = true;
            this.cmbAddTags.TabIndex = 26;
            this.cmbAddTags.SelectedIndexChanged += new System.EventHandler(this.cmbAddTags_SelectedIndexChanged);
            // 
            // btnAddTag
            // 
            this.btnAddTag.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTag.Location = new System.Drawing.Point(380, 383);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(112, 49);
            this.btnAddTag.TabIndex = 27;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // btnDeleteTag
            // 
            this.btnDeleteTag.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTag.Location = new System.Drawing.Point(919, 383);
            this.btnDeleteTag.Name = "btnDeleteTag";
            this.btnDeleteTag.Size = new System.Drawing.Size(138, 49);
            this.btnDeleteTag.TabIndex = 30;
            this.btnDeleteTag.Text = "Delete Tag";
            this.btnDeleteTag.UseVisualStyleBackColor = true;
            this.btnDeleteTag.Click += new System.EventHandler(this.btnDeleteTag_Click);
            // 
            // cmbDeleteTags
            // 
            this.cmbDeleteTags.FormattingEnabled = true;
            this.cmbDeleteTags.Items.AddRange(new object[] {
            "(none)"});
            this.cmbDeleteTags.Location = new System.Drawing.Point(875, 344);
            this.cmbDeleteTags.MaxDropDownItems = 100;
            this.cmbDeleteTags.Name = "cmbDeleteTags";
            this.cmbDeleteTags.Size = new System.Drawing.Size(182, 33);
            this.cmbDeleteTags.Sorted = true;
            this.cmbDeleteTags.TabIndex = 29;
            this.cmbDeleteTags.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteTags_SelectedIndexChanged);
            // 
            // lblDeleteTagPrompt
            // 
            this.lblDeleteTagPrompt.AutoSize = true;
            this.lblDeleteTagPrompt.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeleteTagPrompt.Location = new System.Drawing.Point(530, 339);
            this.lblDeleteTagPrompt.Name = "lblDeleteTagPrompt";
            this.lblDeleteTagPrompt.Size = new System.Drawing.Size(339, 38);
            this.lblDeleteTagPrompt.TabIndex = 28;
            this.lblDeleteTagPrompt.Text = "Delete Tag from this Item:";
            // 
            // Notes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 598);
            this.Controls.Add(this.btnDeleteTag);
            this.Controls.Add(this.cmbDeleteTags);
            this.Controls.Add(this.lblDeleteTagPrompt);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.cmbAddTags);
            this.Controls.Add(this.lblAddTagPrompt);
            this.Controls.Add(this.flpTags);
            this.Controls.Add(this.btnNavBack);
            this.Controls.Add(this.txtNote4);
            this.Controls.Add(this.txtNote3);
            this.Controls.Add(this.txtNote2);
            this.Controls.Add(this.txtNote1);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Notes_Form";
            this.Text = "Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}