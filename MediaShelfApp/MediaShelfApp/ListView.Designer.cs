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
            btnNavManualListItem.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavManualListItem.Location = new Point(1174, 868);
            btnNavManualListItem.Margin = new Padding(4);
            btnNavManualListItem.MinimumSize = new Size(128, 42);
            btnNavManualListItem.Name = "btnNavManualListItem";
            btnNavManualListItem.Size = new Size(128, 42);
            btnNavManualListItem.TabIndex = 147;
            btnNavManualListItem.Text = "Add Entry";
            btnNavManualListItem.UseVisualStyleBackColor = true;
            btnNavManualListItem.Click += btnNavManualEntry_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.ForeColor = SystemColors.ActiveCaptionText;
            lblSearch.Location = new Point(459, 211);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 25);
            lblSearch.TabIndex = 146;
            lblSearch.Text = "Search:";
            // 
            // txtListSearch
            // 
            txtListSearch.Location = new Point(546, 208);
            txtListSearch.Margin = new Padding(4);
            txtListSearch.Name = "txtListSearch";
            txtListSearch.Size = new Size(305, 31);
            txtListSearch.TabIndex = 145;
            txtListSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbListSort
            // 
            cmbListSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListSort.FormattingEnabled = true;
            cmbListSort.Location = new Point(1113, 826);
            cmbListSort.Margin = new Padding(4);
            cmbListSort.Name = "cmbListSort";
            cmbListSort.Size = new Size(188, 33);
            cmbListSort.TabIndex = 136;
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.BackColor = Color.Transparent;
            lblSortBy.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSortBy.ForeColor = SystemColors.ActiveCaptionText;
            lblSortBy.Location = new Point(1023, 830);
            lblSortBy.Margin = new Padding(4, 0, 4, 0);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(73, 25);
            lblSortBy.TabIndex = 135;
            lblSortBy.Text = "Sort By:";
            // 
            // lblListName
            // 
            lblListName.AutoSize = true;
            lblListName.BackColor = Color.Transparent;
            lblListName.Font = new Font("Ebrima", 21F, FontStyle.Regular, GraphicsUnit.Point);
            lblListName.ForeColor = SystemColors.ActiveCaptionText;
            lblListName.Location = new Point(546, 34);
            lblListName.Margin = new Padding(4, 0, 4, 0);
            lblListName.MinimumSize = new Size(312, 59);
            lblListName.Name = "lblListName";
            lblListName.Size = new Size(312, 59);
            lblListName.TabIndex = 127;
            lblListName.Text = "Manual Entries";
            lblListName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNavBack
            // 
            btnNavBack.Location = new Point(52, 871);
            btnNavBack.Margin = new Padding(4);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(118, 42);
            btnNavBack.TabIndex = 160;
            btnNavBack.Text = "Back";
            btnNavBack.UseVisualStyleBackColor = true;
            btnNavBack.Click += btnNavBack_Click;
            // 
            // lblDescriptionText
            // 
            lblDescriptionText.Anchor = AnchorStyles.Top;
            lblDescriptionText.BackColor = Color.Transparent;
            lblDescriptionText.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescriptionText.ForeColor = SystemColors.ActiveCaptionText;
            lblDescriptionText.Location = new Point(546, 92);
            lblDescriptionText.Margin = new Padding(4, 0, 4, 0);
            lblDescriptionText.MinimumSize = new Size(312, 59);
            lblDescriptionText.Name = "lblDescriptionText";
            lblDescriptionText.Size = new Size(312, 59);
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
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResults.BackgroundColor = SystemColors.ControlLightLight;
            dgvResults.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.GridColor = Color.FromArgb(43, 41, 44);
            dgvResults.Location = new Point(52, 261);
            dgvResults.Margin = new Padding(4);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 10;
            dgvResults.RowTemplate.Height = 29;
            dgvResults.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvResults.Size = new Size(1249, 544);
            dgvResults.TabIndex = 163;
            // 
            // btnDeleteListItem
            // 
            btnDeleteListItem.Location = new Point(52, 826);
            btnDeleteListItem.Margin = new Padding(4);
            btnDeleteListItem.Name = "btnDeleteListItem";
            btnDeleteListItem.Size = new Size(171, 38);
            btnDeleteListItem.TabIndex = 164;
            btnDeleteListItem.Text = "Delete Entry";
            btnDeleteListItem.UseVisualStyleBackColor = true;
            btnDeleteListItem.Click += btnDelete_Click;
            // 
            // btnNotes
            // 
            btnNotes.Location = new Point(622, 812);
            btnNotes.Margin = new Padding(4);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(118, 42);
            btnNotes.TabIndex = 165;
            btnNotes.Text = "Notes";
            btnNotes.UseVisualStyleBackColor = true;
            btnNotes.Click += btnNotes_Click;
            // 
            // btnDeleteTag
            // 
            btnDeleteTag.Location = new Point(52, 826);
            btnDeleteTag.Margin = new Padding(4);
            btnDeleteTag.Name = "btnDeleteTag";
            btnDeleteTag.Size = new Size(171, 42);
            btnDeleteTag.TabIndex = 166;
            btnDeleteTag.Text = "Delete Tag";
            btnDeleteTag.UseVisualStyleBackColor = true;
            btnDeleteTag.Visible = false;
            btnDeleteTag.Click += btnDeleteTag_Click;
            // 
            // btnAddTag
            // 
            btnAddTag.AutoSize = true;
            btnAddTag.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddTag.Location = new Point(1184, 868);
            btnAddTag.Margin = new Padding(4);
            btnAddTag.Name = "btnAddTag";
            btnAddTag.Size = new Size(118, 42);
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
            cmbSortTags.Location = new Point(1113, 826);
            cmbSortTags.Margin = new Padding(4);
            cmbSortTags.Name = "cmbSortTags";
            cmbSortTags.Size = new Size(188, 33);
            cmbSortTags.TabIndex = 168;
            cmbSortTags.Visible = false;
            // 
            // txtTagsSearch
            // 
            txtTagsSearch.Location = new Point(546, 208);
            txtTagsSearch.Margin = new Padding(4);
            txtTagsSearch.Name = "txtTagsSearch";
            txtTagsSearch.Size = new Size(305, 31);
            txtTagsSearch.TabIndex = 169;
            txtTagsSearch.Visible = false;
            txtTagsSearch.TextChanged += txtTagsSearch_TextChanged;
            // 
            // ListView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(29, 29, 29);
            BackgroundImage = Properties.Resources.BACKGROUND_WHITE;
            ClientSize = new Size(1355, 951);
            Controls.Add(txtTagsSearch);
            Controls.Add(txtListSearch);
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