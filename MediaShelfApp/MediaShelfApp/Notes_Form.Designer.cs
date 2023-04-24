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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes_Form));
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
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(379, 41);
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
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(118, 36);
            this.btnAddNote.TabIndex = 5;
            this.btnAddNote.Text = "Save";
            this.btnAddNote.UseVisualStyleBackColor = true;
            // 
            // txtNote1
            // 
            this.txtNote1.BackColor = System.Drawing.SystemColors.Info;
            this.txtNote1.Location = new System.Drawing.Point(42, 165);
            this.txtNote1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote1.MaxLength = 400;
            this.txtNote1.Multiline = true;
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.Size = new System.Drawing.Size(232, 205);
            this.txtNote1.TabIndex = 12;
            // 
            // txtNote2
            // 
            this.txtNote2.BackColor = System.Drawing.SystemColors.Info;
            this.txtNote2.Location = new System.Drawing.Point(302, 165);
            this.txtNote2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote2.MaxLength = 400;
            this.txtNote2.Multiline = true;
            this.txtNote2.Name = "txtNote2";
            this.txtNote2.Size = new System.Drawing.Size(232, 205);
            this.txtNote2.TabIndex = 15;
            // 
            // txtNote3
            // 
            this.txtNote3.BackColor = System.Drawing.SystemColors.Info;
            this.txtNote3.Location = new System.Drawing.Point(561, 165);
            this.txtNote3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote3.MaxLength = 400;
            this.txtNote3.Multiline = true;
            this.txtNote3.Name = "txtNote3";
            this.txtNote3.Size = new System.Drawing.Size(232, 205);
            this.txtNote3.TabIndex = 16;
            // 
            // txtNote4
            // 
            this.txtNote4.BackColor = System.Drawing.SystemColors.Info;
            this.txtNote4.Location = new System.Drawing.Point(820, 165);
            this.txtNote4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote4.MaxLength = 400;
            this.txtNote4.Multiline = true;
            this.txtNote4.Name = "txtNote4";
            this.txtNote4.Size = new System.Drawing.Size(232, 205);
            this.txtNote4.TabIndex = 17;
            // 
            // btnNavBack
            // 
            this.btnNavBack.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavBack.Location = new System.Drawing.Point(15, 15);
            this.btnNavBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavBack.Name = "btnNavBack";
            this.btnNavBack.Size = new System.Drawing.Size(118, 36);
            this.btnNavBack.TabIndex = 23;
            this.btnNavBack.Text = "Back";
            this.btnNavBack.UseVisualStyleBackColor = true;
            // 
            // flpTags
            // 
            this.flpTags.AutoScroll = true;
            this.flpTags.BackColor = System.Drawing.Color.Transparent;
            this.flpTags.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpTags.Location = new System.Drawing.Point(0, 541);
            this.flpTags.Margin = new System.Windows.Forms.Padding(2);
            this.flpTags.Name = "flpTags";
            this.flpTags.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.flpTags.Size = new System.Drawing.Size(1102, 150);
            this.flpTags.TabIndex = 24;
            // 
            // lblAddTagPrompt
            // 
            this.lblAddTagPrompt.AutoSize = true;
            this.lblAddTagPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblAddTagPrompt.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddTagPrompt.Location = new System.Drawing.Point(42, 434);
            this.lblAddTagPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddTagPrompt.Name = "lblAddTagPrompt";
            this.lblAddTagPrompt.Size = new System.Drawing.Size(180, 25);
            this.lblAddTagPrompt.TabIndex = 25;
            this.lblAddTagPrompt.Text = "Add Tag to this Item:";
            // 
            // cmbAddTags
            // 
            this.cmbAddTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddTags.FormattingEnabled = true;
            this.cmbAddTags.Items.AddRange(new object[] {
            "(none)"});
            this.cmbAddTags.Location = new System.Drawing.Point(232, 430);
            this.cmbAddTags.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddTags.MaxDropDownItems = 100;
            this.cmbAddTags.Name = "cmbAddTags";
            this.cmbAddTags.Size = new System.Drawing.Size(182, 33);
            this.cmbAddTags.Sorted = true;
            this.cmbAddTags.TabIndex = 26;
            // 
            // btnAddTag
            // 
            this.btnAddTag.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTag.Location = new System.Drawing.Point(298, 469);
            this.btnAddTag.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(118, 36);
            this.btnAddTag.TabIndex = 27;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTag
            // 
            this.btnDeleteTag.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTag.Location = new System.Drawing.Point(935, 470);
            this.btnDeleteTag.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteTag.Name = "btnDeleteTag";
            this.btnDeleteTag.Size = new System.Drawing.Size(118, 36);
            this.btnDeleteTag.TabIndex = 30;
            this.btnDeleteTag.Text = "Delete Tag";
            this.btnDeleteTag.UseVisualStyleBackColor = true;
            // 
            // cmbDeleteTags
            // 
            this.cmbDeleteTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeleteTags.FormattingEnabled = true;
            this.cmbDeleteTags.Items.AddRange(new object[] {
            "(none)"});
            this.cmbDeleteTags.Location = new System.Drawing.Point(870, 430);
            this.cmbDeleteTags.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDeleteTags.MaxDropDownItems = 100;
            this.cmbDeleteTags.Name = "cmbDeleteTags";
            this.cmbDeleteTags.Size = new System.Drawing.Size(182, 33);
            this.cmbDeleteTags.Sorted = true;
            this.cmbDeleteTags.TabIndex = 29;
            // 
            // lblDeleteTagPrompt
            // 
            this.lblDeleteTagPrompt.AutoSize = true;
            this.lblDeleteTagPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteTagPrompt.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeleteTagPrompt.Location = new System.Drawing.Point(638, 434);
            this.lblDeleteTagPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeleteTagPrompt.Name = "lblDeleteTagPrompt";
            this.lblDeleteTagPrompt.Size = new System.Drawing.Size(218, 25);
            this.lblDeleteTagPrompt.TabIndex = 28;
            this.lblDeleteTagPrompt.Text = "Delete Tag from this Item:";
            // 
            // Notes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1102, 691);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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