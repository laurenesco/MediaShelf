namespace MediaShelfApp
{
    partial class SearchResults
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
            searchBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            checkedListBox2 = new CheckedListBox();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            label1 = new Label();
            btnNavBack = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(534, 115);
            searchBox1.Margin = new Padding(5, 6, 5, 6);
            searchBox1.Name = "searchBox1";
            searchBox1.PlaceholderText = "Search";
            searchBox1.Size = new Size(711, 39);
            searchBox1.TabIndex = 0;
            searchBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(53, 872);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(270, 63);
            button1.TabIndex = 2;
            button1.Text = "Add Manual Entry";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkedListBox2);
            panel1.Controls.Add(checkedListBox1);
            panel1.Location = new Point(53, 116);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 738);
            panel1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(91, 667);
            dateTimePicker2.Margin = new Padding(5, 6, 5, 6);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(139, 39);
            dateTimePicker2.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 677);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(44, 32);
            label7.TabIndex = 7;
            label7.Text = "To:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(36, 557);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(159, 32);
            label5.TabIndex = 5;
            label5.Text = "Release Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(91, 607);
            dateTimePicker1.Margin = new Padding(5, 6, 5, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 39);
            dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 293);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 32);
            label4.TabIndex = 8;
            label4.Text = "Genre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 614);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 32);
            label6.TabIndex = 5;
            label6.Text = "From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 31);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 6;
            label3.Text = "Type";
            // 
            // checkedListBox2
            // 
            checkedListBox2.BorderStyle = BorderStyle.None;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Horror", "Science Fiction", "Fantasy" });
            checkedListBox2.Location = new Point(44, 326);
            checkedListBox2.Margin = new Padding(5, 6, 5, 6);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(190, 108);
            checkedListBox2.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Books", "Movies", "Music", "Games", "Other" });
            checkedListBox1.Location = new Point(44, 64);
            checkedListBox1.Margin = new Padding(5, 6, 5, 6);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 108);
            checkedListBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(772, 27);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(262, 54);
            label2.TabIndex = 5;
            label2.Text = "Media Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(143, 65);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 45);
            label1.TabIndex = 6;
            label1.Text = "Filters";
            // 
            // btnNavBack
            // 
            btnNavBack.Location = new Point(20, 19);
            btnNavBack.Margin = new Padding(5);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(153, 46);
            btnNavBack.TabIndex = 7;
            btnNavBack.Text = "Back";
            btnNavBack.UseVisualStyleBackColor = true;
            btnNavBack.Click += btnNavBack_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1286, 113);
            button2.Name = "button2";
            button2.Size = new Size(146, 44);
            button2.TabIndex = 8;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(633, 827);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(501, 106);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(534, 182);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(724, 607);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // comboBox1
            // 
            comboBox1.CausesValidation = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Movies/TV Shows", "Books", "Music", "Video Games" });
            comboBox1.Location = new Point(1226, 27);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 11;
            // 
            // SearchResults
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 960);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(btnNavBack);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(searchBox1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "SearchResults";
            Text = "SearchResults";
            FormClosing += SearchResults_FormClosing;
            Load += SearchResults_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox searchBox1;
        private Button button1;
        private Panel panel1;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private CheckedListBox checkedListBox2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Label label2;
        private Label label1;
        private Button btnNavBack;
        private Button button2;
        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBox1;
    }
}