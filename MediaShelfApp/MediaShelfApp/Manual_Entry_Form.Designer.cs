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
            this.btnNavBack = new System.Windows.Forms.Button();
            this.ME_fowardButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ME_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ME_creator = new System.Windows.Forms.TextBox();
            this.ME_type = new System.Windows.Forms.TextBox();
            this.ME_genre = new System.Windows.Forms.TextBox();
            this.ME_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ME_description = new System.Windows.Forms.TextBox();
            this.ME_addButton = new System.Windows.Forms.Button();
            this.ME_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ME_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNavBack
            // 
            this.btnNavBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNavBack.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNavBack.Location = new System.Drawing.Point(15, 15);
            this.btnNavBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavBack.Name = "btnNavBack";
            this.btnNavBack.Size = new System.Drawing.Size(48, 36);
            this.btnNavBack.TabIndex = 5;
            this.btnNavBack.Text = "<";
            this.btnNavBack.UseVisualStyleBackColor = false;
            this.btnNavBack.Click += new System.EventHandler(this.btnNavBack_Click);
            // 
            // ME_fowardButton
            // 
            this.ME_fowardButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ME_fowardButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ME_fowardButton.Location = new System.Drawing.Point(70, 15);
            this.ME_fowardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ME_fowardButton.Name = "ME_fowardButton";
            this.ME_fowardButton.Size = new System.Drawing.Size(48, 36);
            this.ME_fowardButton.TabIndex = 6;
            this.ME_fowardButton.Text = ">";
            this.ME_fowardButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(375, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manual Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(389, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Title:";
            // 
            // ME_title
            // 
            this.ME_title.Location = new System.Drawing.Point(462, 109);
            this.ME_title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ME_title.Name = "ME_title";
            this.ME_title.Size = new System.Drawing.Size(320, 31);
            this.ME_title.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(389, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Creator:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(389, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(389, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Genre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(389, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Release Date:";
            // 
            // ME_creator
            // 
            this.ME_creator.Location = new System.Drawing.Point(498, 146);
            this.ME_creator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ME_creator.Name = "ME_creator";
            this.ME_creator.Size = new System.Drawing.Size(285, 31);
            this.ME_creator.TabIndex = 14;
            // 
            // ME_type
            // 
            this.ME_type.Location = new System.Drawing.Point(462, 181);
            this.ME_type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ME_type.Name = "ME_type";
            this.ME_type.ReadOnly = true;
            this.ME_type.Size = new System.Drawing.Size(320, 31);
            this.ME_type.TabIndex = 15;
            // 
            // ME_genre
            // 
            this.ME_genre.Location = new System.Drawing.Point(481, 218);
            this.ME_genre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ME_genre.Name = "ME_genre";
            this.ME_genre.Size = new System.Drawing.Size(302, 31);
            this.ME_genre.TabIndex = 16;
            // 
            // ME_date
            // 
            this.ME_date.Location = new System.Drawing.Point(554, 261);
            this.ME_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ME_date.Name = "ME_date";
            this.ME_date.Size = new System.Drawing.Size(229, 31);
            this.ME_date.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(100, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Description:";
            // 
            // ME_description
            // 
            this.ME_description.Location = new System.Drawing.Point(100, 359);
            this.ME_description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ME_description.Multiline = true;
            this.ME_description.Name = "ME_description";
            this.ME_description.Size = new System.Drawing.Size(884, 176);
            this.ME_description.TabIndex = 19;
            // 
            // ME_addButton
            // 
            this.ME_addButton.Location = new System.Drawing.Point(868, 556);
            this.ME_addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ME_addButton.Name = "ME_addButton";
            this.ME_addButton.Size = new System.Drawing.Size(118, 36);
            this.ME_addButton.TabIndex = 20;
            this.ME_addButton.Text = "Add";
            this.ME_addButton.UseVisualStyleBackColor = true;
            this.ME_addButton.Click += new System.EventHandler(this.ME_addButton_Click);
            // 
            // ME_pic
            // 
            this.ME_pic.Location = new System.Drawing.Point(112, 96);
            this.ME_pic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ME_pic.Name = "ME_pic";
            this.ME_pic.Size = new System.Drawing.Size(238, 208);
            this.ME_pic.TabIndex = 21;
            this.ME_pic.TabStop = false;
            // 
            // Manual_Entry_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 608);
            this.Controls.Add(this.ME_pic);
            this.Controls.Add(this.ME_addButton);
            this.Controls.Add(this.ME_description);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ME_date);
            this.Controls.Add(this.ME_genre);
            this.Controls.Add(this.ME_type);
            this.Controls.Add(this.ME_creator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ME_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ME_fowardButton);
            this.Controls.Add(this.btnNavBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Manual_Entry_Form";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.ME_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNavBack;
        private Button ME_fowardButton;
        private Label label1;
        private Label label2;
        private TextBox ME_title;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ME_creator;
        private TextBox ME_type;
        private TextBox ME_genre;
        private DateTimePicker ME_date;
        private Label label7;
        private TextBox ME_description;
        private Button ME_addButton;
        private PictureBox ME_pic;
    }
}