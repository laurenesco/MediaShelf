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
            this.lblListName = new System.Windows.Forms.Label();
            this.btnNavBack = new System.Windows.Forms.Button();
            this.lblDescriptionText = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNavManualEntry
            // 
            this.btnNavManualEntry.AutoSize = true;
            this.btnNavManualEntry.Location = new System.Drawing.Point(947, 694);
            this.btnNavManualEntry.Name = "btnNavManualEntry";
            this.btnNavManualEntry.Size = new System.Drawing.Size(94, 30);
            this.btnNavManualEntry.TabIndex = 147;
            this.btnNavManualEntry.Text = "Add Entry";
            this.btnNavManualEntry.UseVisualStyleBackColor = true;
            this.btnNavManualEntry.Click += new System.EventHandler(this.btnNavManualEntry_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSearch.Location = new System.Drawing.Point(376, 169);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(56, 20);
            this.lblSearch.TabIndex = 146;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(438, 166);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 27);
            this.txtSearch.TabIndex = 145;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbSortByParameter
            // 
            this.cmbSortByParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortByParameter.FormattingEnabled = true;
            this.cmbSortByParameter.Location = new System.Drawing.Point(890, 661);
            this.cmbSortByParameter.Name = "cmbSortByParameter";
            this.cmbSortByParameter.Size = new System.Drawing.Size(151, 28);
            this.cmbSortByParameter.TabIndex = 136;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSortBy.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSortBy.Location = new System.Drawing.Point(825, 664);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(59, 20);
            this.lblSortBy.TabIndex = 135;
            this.lblSortBy.Text = "Sort By:";
            // 
            // lblListName
            // 
            this.lblListName.AutoSize = true;
            this.lblListName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.lblListName.Font = new System.Drawing.Font("Ebrima", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListName.Location = new System.Drawing.Point(459, 27);
            this.lblListName.Name = "lblListName";
            this.lblListName.Size = new System.Drawing.Size(173, 47);
            this.lblListName.TabIndex = 127;
            this.lblListName.Text = "List Name";
            // 
            // btnNavBack
            // 
            this.btnNavBack.Location = new System.Drawing.Point(42, 697);
            this.btnNavBack.Name = "btnNavBack";
            this.btnNavBack.Size = new System.Drawing.Size(94, 29);
            this.btnNavBack.TabIndex = 160;
            this.btnNavBack.Text = "Back";
            this.btnNavBack.UseVisualStyleBackColor = true;
            this.btnNavBack.Click += new System.EventHandler(this.btnNavBack_Click);
            // 
            // lblDescriptionText
            // 
            this.lblDescriptionText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescriptionText.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescriptionText.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDescriptionText.Location = new System.Drawing.Point(459, 74);
            this.lblDescriptionText.Name = "lblDescriptionText";
            this.lblDescriptionText.Size = new System.Drawing.Size(230, 52);
            this.lblDescriptionText.TabIndex = 162;
            this.lblDescriptionText.Text = "Description";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToOrderColumns = true;
            this.dgvResults.AllowUserToResizeColumns = false;
            this.dgvResults.AllowUserToResizeRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.dgvResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.dgvResults.Location = new System.Drawing.Point(42, 209);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersWidth = 10;
            this.dgvResults.RowTemplate.Height = 29;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResults.Size = new System.Drawing.Size(999, 435);
            this.dgvResults.TabIndex = 163;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(42, 661);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 30);
            this.btnDelete.TabIndex = 164;
            this.btnDelete.Text = "Delete Entry";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.lblDescriptionText);
            this.Controls.Add(this.btnNavBack);
            this.Controls.Add(this.btnNavManualEntry);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSortByParameter);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.lblListName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListView";
            this.ShowIcon = false;
            this.Text = "List";
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
        private Label lblListName;
        private Button btnNavBack;
        private Label lblDescriptionText;
        private DataGridView dgvResults;
        private Button btnDelete;
    }
}