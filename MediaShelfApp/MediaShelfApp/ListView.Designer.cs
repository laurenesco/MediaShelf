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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSortByParameter = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
            this.lblListName = new System.Windows.Forms.Label();
            this.btnNavBack = new System.Windows.Forms.Button();
            this.lblDescriptionText = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNavManualEntry
            // 
            this.btnNavManualEntry.AutoSize = true;
            this.btnNavManualEntry.Location = new System.Drawing.Point(645, 593);
            this.btnNavManualEntry.Name = "btnNavManualEntry";
            this.btnNavManualEntry.Size = new System.Drawing.Size(137, 30);
            this.btnNavManualEntry.TabIndex = 147;
            this.btnNavManualEntry.Text = "Add Manual Entry";
            this.btnNavManualEntry.UseVisualStyleBackColor = true;
            this.btnNavManualEntry.Click += new System.EventHandler(this.btnNavManualEntry_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(553, 46);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(56, 20);
            this.lblSearch.TabIndex = 146;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(631, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 27);
            this.txtSearch.TabIndex = 145;
            // 
            // cmbSortByParameter
            // 
            this.cmbSortByParameter.FormattingEnabled = true;
            this.cmbSortByParameter.Location = new System.Drawing.Point(631, 119);
            this.cmbSortByParameter.Name = "cmbSortByParameter";
            this.cmbSortByParameter.Size = new System.Drawing.Size(151, 28);
            this.cmbSortByParameter.TabIndex = 136;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(553, 122);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(59, 20);
            this.lblSortBy.TabIndex = 135;
            this.lblSortBy.Text = "Sort By:";
            // 
            // lblDescriptionTitle
            // 
            this.lblDescriptionTitle.AutoSize = true;
            this.lblDescriptionTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescriptionTitle.Location = new System.Drawing.Point(67, 108);
            this.lblDescriptionTitle.Name = "lblDescriptionTitle";
            this.lblDescriptionTitle.Size = new System.Drawing.Size(88, 20);
            this.lblDescriptionTitle.TabIndex = 134;
            this.lblDescriptionTitle.Text = "Description:";
            // 
            // lblListName
            // 
            this.lblListName.AutoSize = true;
            this.lblListName.BackColor = System.Drawing.SystemColors.Control;
            this.lblListName.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListName.Location = new System.Drawing.Point(61, 61);
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
            // lblDescriptionText
            // 
            this.lblDescriptionText.AutoSize = true;
            this.lblDescriptionText.Location = new System.Drawing.Point(159, 108);
            this.lblDescriptionText.Name = "lblDescriptionText";
            this.lblDescriptionText.Size = new System.Drawing.Size(194, 60);
            this.lblDescriptionText.TabIndex = 162;
            this.lblDescriptionText.Text = "Description spans this label \r\nNew line possible\r\n\r\n";
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
            this.dgvResults.Size = new System.Drawing.Size(685, 335);
            this.dgvResults.TabIndex = 163;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(688, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 164;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(812, 663);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.lblDescriptionText);
            this.Controls.Add(this.btnNavBack);
            this.Controls.Add(this.btnNavManualEntry);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSortByParameter);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.lblDescriptionTitle);
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
        private Label lblSearch;
        private TextBox txtSearch;
        private ComboBox cmbSortByParameter;
        private Label lblSortBy;
        private Label lblDescriptionTitle;
        private Label lblListName;
        private Button btnNavBack;
        private Label lblDescriptionText;
        private DataGridView dgvResults;
        private Button btnSearch;
    }
}