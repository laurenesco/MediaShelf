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
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblDeleteTagPrompt = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            cmbDeleteTags = new ComboBox();
            btnDeleteTag = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblAddTagPrompt = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            cmbAddTags = new ComboBox();
            btnAddTag = new Button();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Ebrima", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(42, 46);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1011, 115);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Item Name Label";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddNote
            // 
            btnAddNote.Enabled = false;
            btnAddNote.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNote.Location = new Point(961, 15);
            btnAddNote.Margin = new Padding(4, 4, 4, 4);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(118, 42);
            btnAddNote.TabIndex = 5;
            btnAddNote.Text = "Save";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // txtNote1
            // 
            txtNote1.BackColor = SystemColors.Info;
            txtNote1.Location = new Point(42, 165);
            txtNote1.Margin = new Padding(4, 4, 4, 4);
            txtNote1.MaxLength = 400;
            txtNote1.Multiline = true;
            txtNote1.Name = "txtNote1";
            txtNote1.Size = new Size(232, 205);
            txtNote1.TabIndex = 12;
            txtNote1.TextChanged += txtNote1_TextChanged;
            // 
            // txtNote2
            // 
            txtNote2.BackColor = SystemColors.Info;
            txtNote2.Location = new Point(302, 165);
            txtNote2.Margin = new Padding(4, 4, 4, 4);
            txtNote2.MaxLength = 400;
            txtNote2.Multiline = true;
            txtNote2.Name = "txtNote2";
            txtNote2.Size = new Size(232, 205);
            txtNote2.TabIndex = 15;
            txtNote2.TextChanged += txtNote2_TextChanged;
            // 
            // txtNote3
            // 
            txtNote3.BackColor = SystemColors.Info;
            txtNote3.Location = new Point(561, 165);
            txtNote3.Margin = new Padding(4, 4, 4, 4);
            txtNote3.MaxLength = 400;
            txtNote3.Multiline = true;
            txtNote3.Name = "txtNote3";
            txtNote3.Size = new Size(232, 205);
            txtNote3.TabIndex = 16;
            txtNote3.TextChanged += txtNote3_TextChanged;
            // 
            // txtNote4
            // 
            txtNote4.BackColor = SystemColors.Info;
            txtNote4.Location = new Point(820, 165);
            txtNote4.Margin = new Padding(4, 4, 4, 4);
            txtNote4.MaxLength = 400;
            txtNote4.Multiline = true;
            txtNote4.Name = "txtNote4";
            txtNote4.Size = new Size(232, 205);
            txtNote4.TabIndex = 17;
            txtNote4.TextChanged += txtNote4_TextChanged;
            // 
            // btnNavBack
            // 
            btnNavBack.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavBack.Location = new Point(15, 15);
            btnNavBack.Margin = new Padding(4, 4, 4, 4);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(118, 42);
            btnNavBack.TabIndex = 23;
            btnNavBack.Text = "Back";
            btnNavBack.UseVisualStyleBackColor = true;
            btnNavBack.Click += btnNavBack_Click;
            // 
            // flpTags
            // 
            flpTags.AutoScroll = true;
            flpTags.BackColor = Color.Transparent;
            flpTags.Dock = DockStyle.Bottom;
            flpTags.Location = new Point(0, 540);
            flpTags.Margin = new Padding(2);
            flpTags.Name = "flpTags";
            flpTags.Padding = new Padding(8, 0, 8, 0);
            flpTags.Size = new Size(1102, 151);
            flpTags.TabIndex = 24;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.BackColor = Color.Transparent;
            flowLayoutPanel3.Controls.Add(lblDeleteTagPrompt);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel3.Location = new Point(561, 398);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(414, 89);
            flowLayoutPanel3.TabIndex = 34;
            // 
            // lblDeleteTagPrompt
            // 
            lblDeleteTagPrompt.AutoSize = true;
            lblDeleteTagPrompt.BackColor = Color.Transparent;
            lblDeleteTagPrompt.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeleteTagPrompt.Location = new Point(2, 8);
            lblDeleteTagPrompt.Margin = new Padding(2, 8, 2, 0);
            lblDeleteTagPrompt.Name = "lblDeleteTagPrompt";
            lblDeleteTagPrompt.Size = new Size(218, 25);
            lblDeleteTagPrompt.TabIndex = 28;
            lblDeleteTagPrompt.Text = "Delete Tag from this Item:";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.BackColor = Color.Transparent;
            flowLayoutPanel4.Controls.Add(cmbDeleteTags);
            flowLayoutPanel4.Controls.Add(btnDeleteTag);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(225, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(186, 83);
            flowLayoutPanel4.TabIndex = 33;
            // 
            // cmbDeleteTags
            // 
            cmbDeleteTags.Dock = DockStyle.Right;
            cmbDeleteTags.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeleteTags.DropDownWidth = 300;
            cmbDeleteTags.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDeleteTags.FormattingEnabled = true;
            cmbDeleteTags.Items.AddRange(new object[] { "(none)" });
            cmbDeleteTags.Location = new Point(2, 2);
            cmbDeleteTags.Margin = new Padding(2);
            cmbDeleteTags.MaxDropDownItems = 100;
            cmbDeleteTags.Name = "cmbDeleteTags";
            cmbDeleteTags.Size = new Size(182, 33);
            cmbDeleteTags.Sorted = true;
            cmbDeleteTags.TabIndex = 29;
            // 
            // btnDeleteTag
            // 
            btnDeleteTag.AutoSize = true;
            btnDeleteTag.Dock = DockStyle.Right;
            btnDeleteTag.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteTag.Location = new Point(44, 39);
            btnDeleteTag.Margin = new Padding(2);
            btnDeleteTag.Name = "btnDeleteTag";
            btnDeleteTag.Size = new Size(140, 42);
            btnDeleteTag.TabIndex = 30;
            btnDeleteTag.Text = "Delete Tag";
            btnDeleteTag.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(lblAddTagPrompt);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Location = new Point(42, 398);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(376, 89);
            flowLayoutPanel1.TabIndex = 33;
            // 
            // lblAddTagPrompt
            // 
            lblAddTagPrompt.AutoSize = true;
            lblAddTagPrompt.BackColor = Color.Transparent;
            lblAddTagPrompt.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddTagPrompt.Location = new Point(2, 8);
            lblAddTagPrompt.Margin = new Padding(2, 8, 2, 0);
            lblAddTagPrompt.Name = "lblAddTagPrompt";
            lblAddTagPrompt.Size = new Size(180, 25);
            lblAddTagPrompt.TabIndex = 25;
            lblAddTagPrompt.Text = "Add Tag to this Item:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(cmbAddTags);
            flowLayoutPanel2.Controls.Add(btnAddTag);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(187, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(186, 83);
            flowLayoutPanel2.TabIndex = 32;
            // 
            // cmbAddTags
            // 
            cmbAddTags.BackColor = SystemColors.Window;
            cmbAddTags.Dock = DockStyle.Right;
            cmbAddTags.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddTags.DropDownWidth = 300;
            cmbAddTags.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAddTags.FormattingEnabled = true;
            cmbAddTags.Items.AddRange(new object[] { "(none)" });
            cmbAddTags.Location = new Point(2, 2);
            cmbAddTags.Margin = new Padding(2);
            cmbAddTags.MaxDropDownItems = 100;
            cmbAddTags.Name = "cmbAddTags";
            cmbAddTags.Size = new Size(182, 33);
            cmbAddTags.Sorted = true;
            cmbAddTags.TabIndex = 26;
            // 
            // btnAddTag
            // 
            btnAddTag.AutoSize = true;
            btnAddTag.Dock = DockStyle.Right;
            btnAddTag.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddTag.Location = new Point(66, 39);
            btnAddTag.Margin = new Padding(2);
            btnAddTag.Name = "btnAddTag";
            btnAddTag.Size = new Size(118, 42);
            btnAddTag.TabIndex = 27;
            btnAddTag.Text = "Add Tag";
            btnAddTag.UseVisualStyleBackColor = true;
            // 
            // Notes_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BACKGROUND_WHITE;
            ClientSize = new Size(1102, 691);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flpTags);
            Controls.Add(btnNavBack);
            Controls.Add(txtNote4);
            Controls.Add(txtNote3);
            Controls.Add(txtNote2);
            Controls.Add(txtNote1);
            Controls.Add(btnAddNote);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Notes_Form";
            Text = "Notes";
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
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
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblDeleteTagPrompt;
        private FlowLayoutPanel flowLayoutPanel4;
        private ComboBox cmbDeleteTags;
        private Button btnDeleteTag;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblAddTagPrompt;
        private FlowLayoutPanel flowLayoutPanel2;
        private ComboBox cmbAddTags;
        private Button btnAddTag;
    }
}