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
            btnNavManualListItem.Location = new Point(829, 520);
            btnNavManualListItem.Margin = new Padding(3, 2, 3, 2);
            btnNavManualListItem.Name = "btnNavManualListItem";
            btnNavManualListItem.Size = new Size(82, 25);
            btnNavManualListItem.TabIndex = 147;
            btnNavManualListItem.Text = "Add Entry";
            btnNavManualListItem.UseVisualStyleBackColor = true;
            btnNavManualListItem.Click += btnNavManualEntry_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = SystemColors.ControlLightLight;
            lblSearch.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.ForeColor = SystemColors.ActiveCaptionText;
            lblSearch.Location = new Point(329, 127);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 146;
            lblSearch.Text = "Search:";
            // 
            // txtListSearch
            // 
            txtListSearch.Location = new Point(382, 124);
            txtListSearch.Margin = new Padding(3, 2, 3, 2);
            txtListSearch.Name = "txtListSearch";
            txtListSearch.Size = new Size(215, 23);
            txtListSearch.TabIndex = 145;
            txtListSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbListSort
            // 
            cmbListSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListSort.FormattingEnabled = true;
            cmbListSort.Location = new Point(779, 496);
            cmbListSort.Margin = new Padding(3, 2, 3, 2);
            cmbListSort.Name = "cmbListSort";
            cmbListSort.Size = new Size(133, 23);
            cmbListSort.TabIndex = 136;
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.BackColor = SystemColors.ControlLight;
            lblSortBy.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSortBy.ForeColor = SystemColors.ActiveCaptionText;
            lblSortBy.Location = new Point(722, 498);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(47, 15);
            lblSortBy.TabIndex = 135;
            lblSortBy.Text = "Sort By:";
            // 
            // lblListName
            // 
            lblListName.AutoSize = true;
            lblListName.BackColor = SystemColors.ControlLightLight;
            lblListName.Font = new Font("Ebrima", 21F, FontStyle.Regular, GraphicsUnit.Point);
            lblListName.ForeColor = SystemColors.ActiveCaptionText;
            lblListName.Location = new Point(382, 20);
            lblListName.MinimumSize = new Size(219, 35);
            lblListName.Name = "lblListName";
            lblListName.Size = new Size(219, 38);
            lblListName.TabIndex = 127;
            lblListName.Text = "Manual Entries";
            lblListName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNavBack
            // 
            btnNavBack.Location = new Point(37, 523);
            btnNavBack.Margin = new Padding(3, 2, 3, 2);
            btnNavBack.Name = "btnNavBack";
            btnNavBack.Size = new Size(82, 22);
            btnNavBack.TabIndex = 160;
            btnNavBack.Text = "Back";
            btnNavBack.UseVisualStyleBackColor = true;
            btnNavBack.Click += btnNavBack_Click;
            // 
            // lblDescriptionText
            // 
            lblDescriptionText.Anchor = AnchorStyles.Top;
            lblDescriptionText.BackColor = SystemColors.ControlLightLight;
            lblDescriptionText.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescriptionText.ForeColor = SystemColors.ActiveCaptionText;
            lblDescriptionText.Location = new Point(382, 56);
            lblDescriptionText.MinimumSize = new Size(219, 35);
            lblDescriptionText.Name = "lblDescriptionText";
            lblDescriptionText.Size = new Size(219, 35);
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
            dgvResults.BackgroundColor = SystemColors.ControlLightLight;
            dgvResults.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.GridColor = Color.FromArgb(43, 41, 44);
            dgvResults.Location = new Point(37, 157);
            dgvResults.Margin = new Padding(3, 2, 3, 2);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 10;
            dgvResults.RowTemplate.Height = 29;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.Size = new Size(874, 326);
            dgvResults.TabIndex = 163;
            dgvResults.CellContentClick += dgvResults_CellContentClick;
            // 
            // btnDeleteListItem
            // 
            btnDeleteListItem.Location = new Point(37, 496);
            btnDeleteListItem.Margin = new Padding(3, 2, 3, 2);
            btnDeleteListItem.Name = "btnDeleteListItem";
            btnDeleteListItem.Size = new Size(120, 22);
            btnDeleteListItem.TabIndex = 164;
            btnDeleteListItem.Text = "Delete Entry";
            btnDeleteListItem.UseVisualStyleBackColor = true;
            btnDeleteListItem.Click += btnDelete_Click;
            // 
            // btnNotes
            // 
            btnNotes.Location = new Point(436, 488);
            btnNotes.Margin = new Padding(3, 2, 3, 2);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(82, 22);
            btnNotes.TabIndex = 165;
            btnNotes.Text = "Notes";
            btnNotes.UseVisualStyleBackColor = true;
            btnNotes.Click += btnNotes_Click;
            // 
            // btnDeleteTag
            // 
            btnDeleteTag.Location = new Point(37, 496);
            btnDeleteTag.Margin = new Padding(3, 2, 3, 2);
            btnDeleteTag.Name = "btnDeleteTag";
            btnDeleteTag.Size = new Size(120, 22);
            btnDeleteTag.TabIndex = 166;
            btnDeleteTag.Text = "Delete Tag";
            btnDeleteTag.UseVisualStyleBackColor = true;
            btnDeleteTag.Visible = false;
            btnDeleteTag.Click += btnDeleteTag_Click;
            // 
            // btnAddTag
            // 
            btnAddTag.AutoSize = true;
            btnAddTag.Location = new Point(829, 521);
            btnAddTag.Margin = new Padding(3, 2, 3, 2);
            btnAddTag.Name = "btnAddTag";
            btnAddTag.Size = new Size(82, 25);
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
            cmbSortTags.Location = new Point(779, 496);
            cmbSortTags.Margin = new Padding(3, 2, 3, 2);
            cmbSortTags.Name = "cmbSortTags";
            cmbSortTags.Size = new Size(133, 23);
            cmbSortTags.TabIndex = 168;
            cmbSortTags.Visible = false;
            // 
            // txtTagsSearch
            // 
            txtTagsSearch.Location = new Point(382, 124);
            txtTagsSearch.Margin = new Padding(3, 2, 3, 2);
            txtTagsSearch.Name = "txtTagsSearch";
            txtTagsSearch.Size = new Size(215, 23);
            txtTagsSearch.TabIndex = 169;
            txtTagsSearch.Visible = false;
            txtTagsSearch.TextChanged += txtTagsSearch_TextChanged;
            // 
            // ListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(29, 29, 29);
            BackgroundImage = Properties.Resources.BACKGROUND_WHITE;
            ClientSize = new Size(948, 571);
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