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
            this.btnNavManualListItem = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtListSearch = new System.Windows.Forms.TextBox();
            this.cmbListSort = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.lblListName = new System.Windows.Forms.Label();
            this.btnNavBack = new System.Windows.Forms.Button();
            this.lblDescriptionText = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnDeleteListItem = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnDeleteTag = new System.Windows.Forms.Button();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.cmbSortTags = new System.Windows.Forms.ComboBox();
            this.txtTagsSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNavManualListItem
            // 
            this.btnNavManualListItem.AutoSize = true;
            this.btnNavManualListItem.Location = new System.Drawing.Point(947, 694);
            this.btnNavManualListItem.Name = "btnNavManualListItem";
            this.btnNavManualListItem.Size = new System.Drawing.Size(94, 30);
            this.btnNavManualListItem.TabIndex = 147;
            this.btnNavManualListItem.Text = "Add Entry";
            this.btnNavManualListItem.UseVisualStyleBackColor = true;
            this.btnNavManualListItem.Click += new System.EventHandler(this.btnNavManualEntry_Click);
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
            // txtListSearch
            // 
            this.txtListSearch.Location = new System.Drawing.Point(437, 166);
            this.txtListSearch.Name = "txtListSearch";
            this.txtListSearch.Size = new System.Drawing.Size(245, 27);
            this.txtListSearch.TabIndex = 145;
            this.txtListSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbListSort
            // 
            this.cmbListSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListSort.FormattingEnabled = true;
            this.cmbListSort.Location = new System.Drawing.Point(890, 661);
            this.cmbListSort.Name = "cmbListSort";
            this.cmbListSort.Size = new System.Drawing.Size(151, 28);
            this.cmbListSort.TabIndex = 136;
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
            this.lblListName.Location = new System.Drawing.Point(465, 27);
            this.lblListName.Name = "lblListName";
            this.lblListName.Size = new System.Drawing.Size(173, 47);
            this.lblListName.TabIndex = 127;
            this.lblListName.Text = "List Name";
            this.lblListName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblDescriptionText.Location = new System.Drawing.Point(389, 74);
            this.lblDescriptionText.Name = "lblDescriptionText";
            this.lblDescriptionText.Size = new System.Drawing.Size(322, 46);
            this.lblDescriptionText.TabIndex = 162;
            this.lblDescriptionText.Text = "Description";
            this.lblDescriptionText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToOrderColumns = true;
            this.dgvResults.AllowUserToResizeColumns = false;
            this.dgvResults.AllowUserToResizeRows = false;
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
            // btnDeleteListItem
            // 
            this.btnDeleteListItem.Location = new System.Drawing.Point(42, 661);
            this.btnDeleteListItem.Name = "btnDeleteListItem";
            this.btnDeleteListItem.Size = new System.Drawing.Size(137, 30);
            this.btnDeleteListItem.TabIndex = 164;
            this.btnDeleteListItem.Text = "Delete Entry";
            this.btnDeleteListItem.UseVisualStyleBackColor = true;
            this.btnDeleteListItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(498, 650);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(94, 29);
            this.btnNotes.TabIndex = 165;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnDeleteTag
            // 
            this.btnDeleteTag.Location = new System.Drawing.Point(42, 661);
            this.btnDeleteTag.Name = "btnDeleteTag";
            this.btnDeleteTag.Size = new System.Drawing.Size(137, 30);
            this.btnDeleteTag.TabIndex = 166;
            this.btnDeleteTag.Text = "Delete Tag";
            this.btnDeleteTag.UseVisualStyleBackColor = true;
            this.btnDeleteTag.Visible = false;
            // 
            // btnAddTag
            // 
            this.btnAddTag.AutoSize = true;
            this.btnAddTag.Location = new System.Drawing.Point(947, 695);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(94, 30);
            this.btnAddTag.TabIndex = 167;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Visible = false;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // cmbSortTags
            // 
            this.cmbSortTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortTags.FormattingEnabled = true;
            this.cmbSortTags.Location = new System.Drawing.Point(890, 661);
            this.cmbSortTags.Name = "cmbSortTags";
            this.cmbSortTags.Size = new System.Drawing.Size(151, 28);
            this.cmbSortTags.TabIndex = 168;
            this.cmbSortTags.Visible = false;
            // 
            // txtTagsSearch
            // 
            this.txtTagsSearch.Location = new System.Drawing.Point(437, 166);
            this.txtTagsSearch.Name = "txtTagsSearch";
            this.txtTagsSearch.Size = new System.Drawing.Size(245, 27);
            this.txtTagsSearch.TabIndex = 169;
            this.txtTagsSearch.Visible = false;
            this.txtTagsSearch.TextChanged += new System.EventHandler(this.txtTagsSearch_TextChanged);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.txtTagsSearch);
            this.Controls.Add(this.cmbSortTags);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.btnDeleteTag);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnDeleteListItem);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.lblDescriptionText);
            this.Controls.Add(this.btnNavBack);
            this.Controls.Add(this.btnNavManualListItem);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtListSearch);
            this.Controls.Add(this.cmbListSort);
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