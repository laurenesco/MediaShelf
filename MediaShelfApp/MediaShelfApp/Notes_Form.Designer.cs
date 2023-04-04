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
            txtNote5 = new TextBox();
            txtNote6 = new TextBox();
            txtNote7 = new TextBox();
            txtNote8 = new TextBox();
            btnNavBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Ebrima", 21F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(484, 34);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(450, 74);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Item Name Label";
            // 
            // btnAddNote
            // 
            btnAddNote.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNote.Location = new Point(1250, 19);
            btnAddNote.Margin = new Padding(5, 5, 5, 5);
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
            txtNote1.Location = new Point(52, 146);
            txtNote1.Margin = new Padding(5, 5, 5, 5);
            txtNote1.MaxLength = 400;
            txtNote1.Multiline = true;
            txtNote1.Name = "txtNote1";
            txtNote1.Size = new Size(300, 262);
            txtNote1.TabIndex = 12;
            // 
            // txtNote2
            // 
            txtNote2.BackColor = SystemColors.Info;
            txtNote2.Location = new Point(390, 146);
            txtNote2.Margin = new Padding(5, 5, 5, 5);
            txtNote2.MaxLength = 400;
            txtNote2.Multiline = true;
            txtNote2.Name = "txtNote2";
            txtNote2.Size = new Size(300, 262);
            txtNote2.TabIndex = 15;
            // 
            // txtNote3
            // 
            txtNote3.BackColor = SystemColors.Info;
            txtNote3.Location = new Point(726, 146);
            txtNote3.Margin = new Padding(5, 5, 5, 5);
            txtNote3.MaxLength = 400;
            txtNote3.Multiline = true;
            txtNote3.Name = "txtNote3";
            txtNote3.Size = new Size(300, 262);
            txtNote3.TabIndex = 16;
            // 
            // txtNote4
            // 
            txtNote4.BackColor = SystemColors.Info;
            txtNote4.Location = new Point(1063, 146);
            txtNote4.Margin = new Padding(5, 5, 5, 5);
            txtNote4.MaxLength = 400;
            txtNote4.Multiline = true;
            txtNote4.Name = "txtNote4";
            txtNote4.Size = new Size(300, 262);
            txtNote4.TabIndex = 17;
            // 
            // txtNote5
            // 
            txtNote5.BackColor = SystemColors.Info;
            txtNote5.Location = new Point(52, 459);
            txtNote5.Margin = new Padding(5, 5, 5, 5);
            txtNote5.MaxLength = 400;
            txtNote5.Multiline = true;
            txtNote5.Name = "txtNote5";
            txtNote5.Size = new Size(300, 262);
            txtNote5.TabIndex = 19;
            // 
            // txtNote6
            // 
            txtNote6.BackColor = SystemColors.Info;
            txtNote6.Location = new Point(390, 459);
            txtNote6.Margin = new Padding(5, 5, 5, 5);
            txtNote6.MaxLength = 400;
            txtNote6.Multiline = true;
            txtNote6.Name = "txtNote6";
            txtNote6.Size = new Size(300, 262);
            txtNote6.TabIndex = 20;
            // 
            // txtNote7
            // 
            txtNote7.BackColor = SystemColors.Info;
            txtNote7.Location = new Point(726, 459);
            txtNote7.Margin = new Padding(5, 5, 5, 5);
            txtNote7.MaxLength = 400;
            txtNote7.Multiline = true;
            txtNote7.Name = "txtNote7";
            txtNote7.Size = new Size(300, 262);
            txtNote7.TabIndex = 21;
            // 
            // txtNote8
            // 
            txtNote8.BackColor = SystemColors.Info;
            txtNote8.Location = new Point(1063, 459);
            txtNote8.Margin = new Padding(5, 5, 5, 5);
            txtNote8.MaxLength = 400;
            txtNote8.Multiline = true;
            txtNote8.Name = "txtNote8";
            txtNote8.Size = new Size(300, 262);
            txtNote8.TabIndex = 22;
            // 
            // btnNavBack
            // 
            btnNavBack.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavBack.Location = new Point(20, 19);
            btnNavBack.Margin = new Padding(5, 5, 5, 5);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(153, 46);
            btnNavBack.TabIndex = 23;
            btnNavBack.Text = "Back";
            btnNavBack.UseVisualStyleBackColor = true;
            btnNavBack.Click += btnNavBack_Click;
            // 
            // Notes_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 765);
            Controls.Add(btnNavBack);
            Controls.Add(txtNote8);
            Controls.Add(txtNote7);
            Controls.Add(txtNote6);
            Controls.Add(txtNote5);
            Controls.Add(txtNote4);
            Controls.Add(txtNote3);
            Controls.Add(txtNote2);
            Controls.Add(txtNote1);
            Controls.Add(btnAddNote);
            Controls.Add(lblTitle);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Notes_Form";
            Text = "Notes";
            FormClosing += Notes_Form_FormClosing;
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
        private TextBox txtNote5;
        private TextBox txtNote6;
        private TextBox txtNote7;
        private TextBox txtNote8;
        private Button btnNavBack;
    }
}