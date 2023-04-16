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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
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
            this.btnAddNote.AutoSize = true;
            this.btnAddNote.Enabled = false;
            this.btnAddNote.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNote.Location = new System.Drawing.Point(961, 15);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtNote1.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtNote2.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtNote3.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtNote4.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote4.MaxLength = 400;
            this.txtNote4.Multiline = true;
            this.txtNote4.Name = "txtNote4";
            this.txtNote4.Size = new System.Drawing.Size(232, 205);
            this.txtNote4.TabIndex = 17;
            // 
            // btnNavBack
            // 
            this.btnNavBack.AutoSize = true;
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
            this.lblAddTagPrompt.Location = new System.Drawing.Point(2, 8);
            this.lblAddTagPrompt.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.lblAddTagPrompt.Name = "lblAddTagPrompt";
            this.lblAddTagPrompt.Size = new System.Drawing.Size(180, 25);
            this.lblAddTagPrompt.TabIndex = 25;
            this.lblAddTagPrompt.Text = "Add Tag to this Item:";
            // 
            // cmbAddTags
            // 
            this.cmbAddTags.BackColor = System.Drawing.SystemColors.Window;
            this.cmbAddTags.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbAddTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddTags.DropDownWidth = 300;
            this.cmbAddTags.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAddTags.FormattingEnabled = true;
            this.cmbAddTags.Items.AddRange(new object[] {
            "(none)"});
            this.cmbAddTags.Location = new System.Drawing.Point(2, 2);
            this.cmbAddTags.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddTags.MaxDropDownItems = 100;
            this.cmbAddTags.Name = "cmbAddTags";
            this.cmbAddTags.Size = new System.Drawing.Size(182, 33);
            this.cmbAddTags.Sorted = true;
            this.cmbAddTags.TabIndex = 26;
            // 
            // btnAddTag
            // 
            this.btnAddTag.AutoSize = true;
            this.btnAddTag.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddTag.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTag.Location = new System.Drawing.Point(66, 39);
            this.btnAddTag.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(118, 42);
            this.btnAddTag.TabIndex = 27;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTag
            // 
            this.btnDeleteTag.AutoSize = true;
            this.btnDeleteTag.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteTag.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTag.Location = new System.Drawing.Point(44, 39);
            this.btnDeleteTag.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteTag.Name = "btnDeleteTag";
            this.btnDeleteTag.Size = new System.Drawing.Size(140, 42);
            this.btnDeleteTag.TabIndex = 30;
            this.btnDeleteTag.Text = "Delete Tag";
            this.btnDeleteTag.UseVisualStyleBackColor = true;
            // 
            // cmbDeleteTags
            // 
            this.cmbDeleteTags.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbDeleteTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeleteTags.DropDownWidth = 300;
            this.cmbDeleteTags.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDeleteTags.FormattingEnabled = true;
            this.cmbDeleteTags.Items.AddRange(new object[] {
            "(none)"});
            this.cmbDeleteTags.Location = new System.Drawing.Point(2, 2);
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
            this.lblDeleteTagPrompt.Location = new System.Drawing.Point(2, 8);
            this.lblDeleteTagPrompt.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.lblDeleteTagPrompt.Name = "lblDeleteTagPrompt";
            this.lblDeleteTagPrompt.Size = new System.Drawing.Size(218, 25);
            this.lblDeleteTagPrompt.TabIndex = 28;
            this.lblDeleteTagPrompt.Text = "Delete Tag from this Item:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lblAddTagPrompt);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 423);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(376, 89);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.cmbAddTags);
            this.flowLayoutPanel2.Controls.Add(this.btnAddTag);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(187, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(186, 83);
            this.flowLayoutPanel2.TabIndex = 32;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.lblDeleteTagPrompt);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(561, 423);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(414, 89);
            this.flowLayoutPanel3.TabIndex = 32;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.cmbDeleteTags);
            this.flowLayoutPanel4.Controls.Add(this.btnDeleteTag);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(225, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(186, 83);
            this.flowLayoutPanel4.TabIndex = 33;
            // 
            // Notes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MediaShelfApp.Properties.Resources.BACKGROUND_WHITE;
            this.ClientSize = new System.Drawing.Size(1102, 691);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
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
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
    }
}