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
            label2 = new Label();
            btnNavBack = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(323, 154);
            searchBox1.Margin = new Padding(3, 4, 3, 4);
            searchBox1.Name = "searchBox1";
            searchBox1.PlaceholderText = "Search";
            searchBox1.Size = new Size(439, 27);
            searchBox1.TabIndex = 0;
            searchBox1.TextAlign = HorizontalAlignment.Center;
            searchBox1.KeyPress += searchBox1_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(59, 692);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(166, 39);
            button1.TabIndex = 2;
            button1.Text = "Add Manual Entry";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(456, 35);
            label2.Name = "label2";
            label2.Size = new Size(165, 35);
            label2.TabIndex = 5;
            label2.Text = "Media Search";
            // 
            // btnNavBack
            // 
            btnNavBack.Location = new Point(12, 12);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(94, 29);
            btnNavBack.TabIndex = 7;
            btnNavBack.Text = "Back";
            btnNavBack.UseVisualStyleBackColor = true;
            btnNavBack.Click += btnNavBack_Click;
            // 
            // button2
            // 
            button2.Location = new Point(792, 153);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(90, 28);
            button2.TabIndex = 8;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 197);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 10;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(978, 468);
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
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Movies/TV Shows", "Books", "Music", "Video Games" });
            comboBox1.Location = new Point(887, 692);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 28);
            comboBox1.TabIndex = 11;
            // 
            // SearchResults
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BACKGROUND_WHITE;
            ClientSize = new Size(1084, 761);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(btnNavBack);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(searchBox1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1102, 808);
            MinimumSize = new Size(1102, 808);
            Name = "SearchResults";
            Text = "SearchResults";
            Load += SearchResults_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox1;
        private Button button1;
        private Label label2;
        private Button btnNavBack;
        private Button button2;
        private DataGridView dataGridView1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBox1;
    }
}