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
            btnNavManualEntry = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            cmbSortByParameter = new ComboBox();
            lblSortBy = new Label();
            lblListName = new Label();
            btnNavBack = new Button();
            lblDescriptionText = new Label();
            dgvResults = new DataGridView();
            btnDelete = new Button();
            btnNotes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // btnNavManualEntry
            // 
            btnNavManualEntry.AutoSize = true;
            btnNavManualEntry.Location = new Point(1539, 1110);
            btnNavManualEntry.Margin = new Padding(5);
            btnNavManualEntry.Name = "btnNavManualEntry";
            btnNavManualEntry.Size = new Size(153, 48);
            btnNavManualEntry.TabIndex = 147;
            btnNavManualEntry.Text = "Add Entry";
            btnNavManualEntry.UseVisualStyleBackColor = true;
            btnNavManualEntry.Click += btnNavManualEntry_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.ForeColor = SystemColors.ActiveBorder;
            lblSearch.Location = new Point(611, 270);
            lblSearch.Margin = new Padding(5, 0, 5, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(90, 32);
            lblSearch.TabIndex = 146;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(712, 266);
            txtSearch.Margin = new Padding(5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(396, 39);
            txtSearch.TabIndex = 145;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbSortByParameter
            // 
            cmbSortByParameter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSortByParameter.FormattingEnabled = true;
            cmbSortByParameter.Location = new Point(1446, 1058);
            cmbSortByParameter.Margin = new Padding(5);
            cmbSortByParameter.Name = "cmbSortByParameter";
            cmbSortByParameter.Size = new Size(243, 40);
            cmbSortByParameter.TabIndex = 136;
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSortBy.ForeColor = SystemColors.ActiveBorder;
            lblSortBy.Location = new Point(1341, 1062);
            lblSortBy.Margin = new Padding(5, 0, 5, 0);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(95, 32);
            lblSortBy.TabIndex = 135;
            lblSortBy.Text = "Sort By:";
            // 
            // lblListName
            // 
            lblListName.AutoSize = true;
            lblListName.BackColor = Color.FromArgb(29, 29, 29);
            lblListName.Font = new Font("Ebrima", 21F, FontStyle.Regular, GraphicsUnit.Point);
            lblListName.ForeColor = SystemColors.ButtonFace;
            lblListName.Location = new Point(746, 43);
            lblListName.Margin = new Padding(5, 0, 5, 0);
            lblListName.Name = "lblListName";
            lblListName.Size = new Size(277, 74);
            lblListName.TabIndex = 127;
            lblListName.Text = "List Name";
            // 
            // btnNavBack
            // 
            btnNavBack.Location = new Point(68, 1115);
            btnNavBack.Margin = new Padding(5);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(153, 46);
            btnNavBack.TabIndex = 160;
            btnNavBack.Text = "Back";
            btnNavBack.UseVisualStyleBackColor = true;
            btnNavBack.Click += btnNavBack_Click;
            // 
            // lblDescriptionText
            // 
            lblDescriptionText.Anchor = AnchorStyles.Top;
            lblDescriptionText.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescriptionText.ForeColor = SystemColors.ActiveBorder;
            lblDescriptionText.Location = new Point(746, 118);
            lblDescriptionText.Margin = new Padding(5, 0, 5, 0);
            lblDescriptionText.Name = "lblDescriptionText";
            lblDescriptionText.Size = new Size(374, 83);
            lblDescriptionText.TabIndex = 162;
            lblDescriptionText.Text = "Description";
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AllowUserToOrderColumns = true;
            dgvResults.AllowUserToResizeColumns = false;
            dgvResults.AllowUserToResizeRows = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResults.BackgroundColor = Color.FromArgb(43, 41, 44);
            dgvResults.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.GridColor = Color.FromArgb(43, 41, 44);
            dgvResults.Location = new Point(68, 334);
            dgvResults.Margin = new Padding(5);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 10;
            dgvResults.RowTemplate.Height = 29;
            dgvResults.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvResults.Size = new Size(1623, 696);
            dgvResults.TabIndex = 163;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(68, 1058);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(223, 48);
            btnDelete.TabIndex = 164;
            btnDelete.Text = "Delete Entry";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNotes
            // 
            btnNotes.Location = new Point(809, 1040);
            btnNotes.Margin = new Padding(5);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(153, 46);
            btnNotes.TabIndex = 165;
            btnNotes.Text = "Notes";
            btnNotes.UseVisualStyleBackColor = true;
            btnNotes.Click += btnNotes_Click;
            // 
            // ListView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(1762, 1218);
            Controls.Add(btnNotes);
            Controls.Add(btnDelete);
            Controls.Add(dgvResults);
            Controls.Add(lblDescriptionText);
            Controls.Add(btnNavBack);
            Controls.Add(btnNavManualEntry);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(cmbSortByParameter);
            Controls.Add(lblSortBy);
            Controls.Add(lblListName);
            Name = "ListView";
            ShowIcon = false;
            Text = "List";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnNotes;
    }
}