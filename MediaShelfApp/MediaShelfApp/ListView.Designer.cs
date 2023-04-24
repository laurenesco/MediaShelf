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
            btnNavManualListItem = new Button();
            lblSearch = new Label();
            txtListSearch = new TextBox();
            cmbListSort = new ComboBox();
            lblSortBy = new Label();
            lblListName = new Label();
            btnNavBack = new Button();
            lblDescriptionText = new Label();
            dgvResults = new DataGridView();
            btnDeleteListItem = new Button();
            btnNotes = new Button();
            btnDeleteTag = new Button();
            btnAddTag = new Button();
            cmbSortTags = new ComboBox();
            txtTagsSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // btnNavManualListItem
            // 
            btnNavManualListItem.AutoSize = true;
            btnNavManualListItem.Location = new Point(947, 694);
            btnNavManualListItem.Name = "btnNavManualListItem";
            btnNavManualListItem.Size = new Size(94, 30);
            btnNavManualListItem.TabIndex = 147;
            btnNavManualListItem.Text = "Add Entry";
            btnNavManualListItem.UseVisualStyleBackColor = true;
            btnNavManualListItem.Click += btnNavManualEntry_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.ForeColor = SystemColors.ActiveBorder;
            lblSearch.Location = new Point(376, 169);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 20);
            lblSearch.TabIndex = 146;
            lblSearch.Text = "Search:";
            // 
            // txtListSearch
            // 
            txtListSearch.Location = new Point(437, 166);
            txtListSearch.Name = "txtListSearch";
            txtListSearch.Size = new Size(245, 27);
            txtListSearch.TabIndex = 145;
            txtListSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbListSort
            // 
            cmbListSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListSort.FormattingEnabled = true;
            cmbListSort.Location = new Point(890, 661);
            cmbListSort.Name = "cmbListSort";
            cmbListSort.Size = new Size(151, 28);
            cmbListSort.TabIndex = 136;
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSortBy.ForeColor = SystemColors.ActiveBorder;
            lblSortBy.Location = new Point(825, 664);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(59, 20);
            lblSortBy.TabIndex = 135;
            lblSortBy.Text = "Sort By:";
            // 
            // lblListName
            // 
            lblListName.AutoSize = true;
            lblListName.BackColor = Color.FromArgb(29, 29, 29);
            lblListName.Font = new Font("Ebrima", 21F, FontStyle.Regular, GraphicsUnit.Point);
            lblListName.ForeColor = SystemColors.ButtonFace;
            lblListName.Location = new Point(437, 27);
            lblListName.MinimumSize = new Size(250, 47);
            lblListName.Name = "lblListName";
            lblListName.Size = new Size(250, 47);
            lblListName.TabIndex = 127;
            lblListName.Text = "Manual Entries";
            lblListName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNavBack
            // 
            btnNavBack.Location = new Point(42, 697);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(94, 29);
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
            lblDescriptionText.Location = new Point(437, 74);
            lblDescriptionText.MinimumSize = new Size(250, 47);
            lblDescriptionText.Name = "lblDescriptionText";
            lblDescriptionText.Size = new Size(250, 47);
            lblDescriptionText.TabIndex = 162;
            lblDescriptionText.Text = "Description";
            lblDescriptionText.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AllowUserToOrderColumns = true;
            dgvResults.AllowUserToResizeColumns = false;
            dgvResults.AllowUserToResizeRows = false;
            dgvResults.BackgroundColor = Color.FromArgb(43, 41, 44);
            dgvResults.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.GridColor = Color.FromArgb(43, 41, 44);
            dgvResults.Location = new Point(42, 209);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 10;
            dgvResults.RowTemplate.Height = 29;
            dgvResults.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvResults.Size = new Size(999, 435);
            dgvResults.TabIndex = 163;
            // 
            // btnDeleteListItem
            // 
            btnDeleteListItem.Location = new Point(42, 661);
            btnDeleteListItem.Name = "btnDeleteListItem";
            btnDeleteListItem.Size = new Size(137, 30);
            btnDeleteListItem.TabIndex = 164;
            btnDeleteListItem.Text = "Delete Entry";
            btnDeleteListItem.UseVisualStyleBackColor = true;
            btnDeleteListItem.Click += btnDelete_Click;
            // 
            // btnNotes
            // 
            btnNotes.Location = new Point(498, 650);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(94, 29);
            btnNotes.TabIndex = 165;
            btnNotes.Text = "Notes";
            btnNotes.UseVisualStyleBackColor = true;
            btnNotes.Click += btnNotes_Click;
            // 
            // btnDeleteTag
            // 
            btnDeleteTag.Location = new Point(42, 661);
            btnDeleteTag.Name = "btnDeleteTag";
            btnDeleteTag.Size = new Size(137, 30);
            btnDeleteTag.TabIndex = 166;
            btnDeleteTag.Text = "Delete Tag";
            btnDeleteTag.UseVisualStyleBackColor = true;
            btnDeleteTag.Visible = false;
            btnDeleteTag.Click += btnDeleteTag_Click;
            // 
            // btnAddTag
            // 
            btnAddTag.AutoSize = true;
            btnAddTag.Location = new Point(947, 695);
            btnAddTag.Name = "btnAddTag";
            btnAddTag.Size = new Size(94, 30);
            btnAddTag.TabIndex = 167;
            btnAddTag.Text = "Add Tag";
            btnAddTag.UseVisualStyleBackColor = true;
            btnAddTag.Visible = false;
            btnAddTag.Click += btnAddTag_Click;
            // 
            // cmbSortTags
            // 
            cmbSortTags.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSortTags.FormattingEnabled = true;
            cmbSortTags.Location = new Point(890, 661);
            cmbSortTags.Name = "cmbSortTags";
            cmbSortTags.Size = new Size(151, 28);
            cmbSortTags.TabIndex = 168;
            cmbSortTags.Visible = false;
            // 
            // txtTagsSearch
            // 
            txtTagsSearch.Location = new Point(437, 166);
            txtTagsSearch.Name = "txtTagsSearch";
            txtTagsSearch.Size = new Size(245, 27);
            txtTagsSearch.TabIndex = 169;
            txtTagsSearch.Visible = false;
            txtTagsSearch.TextChanged += txtTagsSearch_TextChanged;
            // 
            // ListView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(1084, 761);
            Controls.Add(txtTagsSearch);
            Controls.Add(cmbSortTags);
            Controls.Add(btnAddTag);
            Controls.Add(btnDeleteTag);
            Controls.Add(btnNotes);
            Controls.Add(btnDeleteListItem);
            Controls.Add(dgvResults);
            Controls.Add(lblDescriptionText);
            Controls.Add(btnNavBack);
            Controls.Add(btnNavManualListItem);
            Controls.Add(lblSearch);
            Controls.Add(txtListSearch);
            Controls.Add(cmbListSort);
            Controls.Add(lblSortBy);
            Controls.Add(lblListName);
            Margin = new Padding(2);
            Name = "ListView";
            ShowIcon = false;
            Text = "List";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNavManualListItem;
        private Label lblSearch;
        private TextBox txtListSearch;
        private ComboBox cmbListSort;
        private Label lblSortBy;
        private Label lblListName;
        private Button btnNavBack;
        private Label lblDescriptionText;
        private DataGridView dgvResults;
        private Button btnDeleteListItem;
        private Button btnNotes;
        private Button btnDeleteTag;
        private Button btnAddTag;
        private ComboBox cmbSortTags;
        private TextBox txtTagsSearch;
    }
}