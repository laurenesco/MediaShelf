namespace MediaShelfApp
{
    partial class ListView
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
            this.btnNavManualEntry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblListName = new System.Windows.Forms.Label();
            this.btnNavBack = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNavManualEntry
            // 
            this.btnNavManualEntry.AutoSize = true;
            this.btnNavManualEntry.Location = new System.Drawing.Point(645, 122);
            this.btnNavManualEntry.Name = "btnNavManualEntry";
            this.btnNavManualEntry.Size = new System.Drawing.Size(137, 30);
            this.btnNavManualEntry.TabIndex = 147;
            this.btnNavManualEntry.Text = "Add Manual Entry";
            this.btnNavManualEntry.UseVisualStyleBackColor = true;
            this.btnNavManualEntry.Click += new System.EventHandler(this.btnNavManualEntry_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 146;
            this.label2.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(631, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 27);
            this.textBox1.TabIndex = 145;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(631, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 135;
            this.label3.Text = "Sort By:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(134, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 134;
            this.label14.Text = "Description:";
            // 
            // lblListName
            // 
            this.lblListName.AutoSize = true;
            this.lblListName.BackColor = System.Drawing.SystemColors.Control;
            this.lblListName.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListName.Location = new System.Drawing.Point(134, 56);
            this.lblListName.Name = "lblListName";
            this.lblListName.Size = new System.Drawing.Size(173, 47);
            this.lblListName.TabIndex = 127;
            this.lblListName.Text = "List Name";
            // 
            // btnNavBack
            // 
            this.btnNavBack.Location = new System.Drawing.Point(12, 12);
            this.btnNavBack.Name = "btnNavBack";
            this.btnNavBack.Size = new System.Drawing.Size(94, 29);
            this.btnNavBack.TabIndex = 160;
            this.btnNavBack.Text = "Back";
            this.btnNavBack.UseVisualStyleBackColor = true;
            this.btnNavBack.Click += new System.EventHandler(this.btnNavBack_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(226, 127);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(194, 60);
            this.lblDescription.TabIndex = 162;
            this.lblDescription.Text = "Description spans this label \r\nNew line possible\r\n\r\n";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToOrderColumns = true;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(61, 214);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 29;
            this.dgvResults.Size = new System.Drawing.Size(683, 391);
            this.dgvResults.TabIndex = 163;
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(812, 663);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnNavBack);
            this.Controls.Add(this.btnNavManualEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblListName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListView";
            this.Text = "ListView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnNavManualEntry;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label14;
        private Label lblListName;
        private Button btnNavBack;
        private Label lblDescription;
        private DataGridView dgvResults;
    }
}