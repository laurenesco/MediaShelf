namespace MediaShelfApp
{
    partial class Detailed_Recommendations
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
            this.lbl_recommendedTag = new System.Windows.Forms.Label();
            this.lbl_recommendations = new System.Windows.Forms.Label();
            this.flp_allFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_filters = new System.Windows.Forms.Label();
            this.gb_mediaType = new System.Windows.Forms.GroupBox();
            this.flp_allMediaTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.chkB_moviesTag = new System.Windows.Forms.CheckBox();
            this.chkB_gamesTag = new System.Windows.Forms.CheckBox();
            this.chkB_musicTag = new System.Windows.Forms.CheckBox();
            this.chkB_tvShowsTag = new System.Windows.Forms.CheckBox();
            this.chkB_booksTag = new System.Windows.Forms.CheckBox();
            this.gb_Genre = new System.Windows.Forms.GroupBox();
            this.flp_allGenres = new System.Windows.Forms.FlowLayoutPanel();
            this.chkB_horrorTag = new System.Windows.Forms.CheckBox();
            this.chkB_romanceTag = new System.Windows.Forms.CheckBox();
            this.chkB_fictionTag = new System.Windows.Forms.CheckBox();
            this.chkB_nonfictionTag = new System.Windows.Forms.CheckBox();
            this.chkB_recommendedTag = new System.Windows.Forms.CheckBox();
            this.gb_date = new System.Windows.Forms.GroupBox();
            this.gb_dateRanges = new System.Windows.Forms.FlowLayoutPanel();
            this.date_fromDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_toDate = new System.Windows.Forms.Label();
            this.date_ToDate = new System.Windows.Forms.DateTimePicker();
            this.dg_recommendationResults = new System.Windows.Forms.DataGridView();
            this.lbl_backButton = new System.Windows.Forms.Label();
            this.flp_allFilters.SuspendLayout();
            this.gb_mediaType.SuspendLayout();
            this.flp_allMediaTypes.SuspendLayout();
            this.gb_Genre.SuspendLayout();
            this.flp_allGenres.SuspendLayout();
            this.gb_date.SuspendLayout();
            this.gb_dateRanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_recommendationResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_recommendedTag
            // 
            this.lbl_recommendedTag.AutoSize = true;
            this.lbl_recommendedTag.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_recommendedTag.Location = new System.Drawing.Point(340, 33);
            this.lbl_recommendedTag.Name = "lbl_recommendedTag";
            this.lbl_recommendedTag.Size = new System.Drawing.Size(117, 54);
            this.lbl_recommendedTag.TabIndex = 0;
            this.lbl_recommendedTag.Text = "[TAG]";
            // 
            // lbl_recommendations
            // 
            this.lbl_recommendations.AutoSize = true;
            this.lbl_recommendations.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_recommendations.Location = new System.Drawing.Point(508, 33);
            this.lbl_recommendations.Name = "lbl_recommendations";
            this.lbl_recommendations.Size = new System.Drawing.Size(351, 54);
            this.lbl_recommendations.TabIndex = 1;
            this.lbl_recommendations.Text = "Recommendations";
            // 
            // flp_allFilters
            // 
            this.flp_allFilters.Controls.Add(this.lbl_filters);
            this.flp_allFilters.Controls.Add(this.gb_mediaType);
            this.flp_allFilters.Controls.Add(this.gb_Genre);
            this.flp_allFilters.Controls.Add(this.gb_date);
            this.flp_allFilters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_allFilters.Location = new System.Drawing.Point(30, 96);
            this.flp_allFilters.Name = "flp_allFilters";
            this.flp_allFilters.Size = new System.Drawing.Size(270, 644);
            this.flp_allFilters.TabIndex = 3;
            // 
            // lbl_filters
            // 
            this.lbl_filters.AutoSize = true;
            this.lbl_filters.Location = new System.Drawing.Point(3, 0);
            this.lbl_filters.Name = "lbl_filters";
            this.lbl_filters.Size = new System.Drawing.Size(58, 25);
            this.lbl_filters.TabIndex = 4;
            this.lbl_filters.Text = "Filters";
            // 
            // gb_mediaType
            // 
            this.gb_mediaType.Controls.Add(this.flp_allMediaTypes);
            this.gb_mediaType.Location = new System.Drawing.Point(3, 28);
            this.gb_mediaType.Name = "gb_mediaType";
            this.gb_mediaType.Size = new System.Drawing.Size(267, 213);
            this.gb_mediaType.TabIndex = 9;
            this.gb_mediaType.TabStop = false;
            this.gb_mediaType.Text = "Media Type";
            // 
            // flp_allMediaTypes
            // 
            this.flp_allMediaTypes.Controls.Add(this.chkB_moviesTag);
            this.flp_allMediaTypes.Controls.Add(this.chkB_gamesTag);
            this.flp_allMediaTypes.Controls.Add(this.chkB_musicTag);
            this.flp_allMediaTypes.Controls.Add(this.chkB_tvShowsTag);
            this.flp_allMediaTypes.Controls.Add(this.chkB_booksTag);
            this.flp_allMediaTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_allMediaTypes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_allMediaTypes.Location = new System.Drawing.Point(3, 27);
            this.flp_allMediaTypes.Name = "flp_allMediaTypes";
            this.flp_allMediaTypes.Size = new System.Drawing.Size(261, 183);
            this.flp_allMediaTypes.TabIndex = 0;
            // 
            // chkB_moviesTag
            // 
            this.chkB_moviesTag.AutoSize = true;
            this.chkB_moviesTag.Location = new System.Drawing.Point(3, 3);
            this.chkB_moviesTag.Name = "chkB_moviesTag";
            this.chkB_moviesTag.Size = new System.Drawing.Size(95, 29);
            this.chkB_moviesTag.TabIndex = 0;
            this.chkB_moviesTag.Text = "Movies";
            this.chkB_moviesTag.ThreeState = true;
            this.chkB_moviesTag.UseVisualStyleBackColor = true;
            // 
            // chkB_gamesTag
            // 
            this.chkB_gamesTag.AutoSize = true;
            this.chkB_gamesTag.Location = new System.Drawing.Point(3, 38);
            this.chkB_gamesTag.Name = "chkB_gamesTag";
            this.chkB_gamesTag.Size = new System.Drawing.Size(92, 29);
            this.chkB_gamesTag.TabIndex = 1;
            this.chkB_gamesTag.Text = "Games";
            this.chkB_gamesTag.ThreeState = true;
            this.chkB_gamesTag.UseVisualStyleBackColor = true;
            // 
            // chkB_musicTag
            // 
            this.chkB_musicTag.AutoSize = true;
            this.chkB_musicTag.Location = new System.Drawing.Point(3, 73);
            this.chkB_musicTag.Name = "chkB_musicTag";
            this.chkB_musicTag.Size = new System.Drawing.Size(84, 29);
            this.chkB_musicTag.TabIndex = 2;
            this.chkB_musicTag.Text = "Music";
            this.chkB_musicTag.ThreeState = true;
            this.chkB_musicTag.UseVisualStyleBackColor = true;
            // 
            // chkB_tvShowsTag
            // 
            this.chkB_tvShowsTag.AutoSize = true;
            this.chkB_tvShowsTag.Location = new System.Drawing.Point(3, 108);
            this.chkB_tvShowsTag.Name = "chkB_tvShowsTag";
            this.chkB_tvShowsTag.Size = new System.Drawing.Size(115, 29);
            this.chkB_tvShowsTag.TabIndex = 3;
            this.chkB_tvShowsTag.Text = "TV Shows";
            this.chkB_tvShowsTag.ThreeState = true;
            this.chkB_tvShowsTag.UseVisualStyleBackColor = true;
            // 
            // chkB_booksTag
            // 
            this.chkB_booksTag.AutoSize = true;
            this.chkB_booksTag.Location = new System.Drawing.Point(3, 143);
            this.chkB_booksTag.Name = "chkB_booksTag";
            this.chkB_booksTag.Size = new System.Drawing.Size(87, 29);
            this.chkB_booksTag.TabIndex = 4;
            this.chkB_booksTag.Text = "Books";
            this.chkB_booksTag.ThreeState = true;
            this.chkB_booksTag.UseVisualStyleBackColor = true;
            // 
            // gb_Genre
            // 
            this.gb_Genre.Controls.Add(this.flp_allGenres);
            this.gb_Genre.Location = new System.Drawing.Point(3, 247);
            this.gb_Genre.Name = "gb_Genre";
            this.gb_Genre.Size = new System.Drawing.Size(267, 213);
            this.gb_Genre.TabIndex = 10;
            this.gb_Genre.TabStop = false;
            this.gb_Genre.Text = "Genre";
            // 
            // flp_allGenres
            // 
            this.flp_allGenres.Controls.Add(this.chkB_horrorTag);
            this.flp_allGenres.Controls.Add(this.chkB_romanceTag);
            this.flp_allGenres.Controls.Add(this.chkB_fictionTag);
            this.flp_allGenres.Controls.Add(this.chkB_nonfictionTag);
            this.flp_allGenres.Controls.Add(this.chkB_recommendedTag);
            this.flp_allGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_allGenres.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_allGenres.Location = new System.Drawing.Point(3, 27);
            this.flp_allGenres.Name = "flp_allGenres";
            this.flp_allGenres.Size = new System.Drawing.Size(261, 183);
            this.flp_allGenres.TabIndex = 0;
            // 
            // chkB_horrorTag
            // 
            this.chkB_horrorTag.AutoSize = true;
            this.chkB_horrorTag.Location = new System.Drawing.Point(3, 3);
            this.chkB_horrorTag.Name = "chkB_horrorTag";
            this.chkB_horrorTag.Size = new System.Drawing.Size(91, 29);
            this.chkB_horrorTag.TabIndex = 0;
            this.chkB_horrorTag.Text = "Horror";
            this.chkB_horrorTag.ThreeState = true;
            this.chkB_horrorTag.UseVisualStyleBackColor = true;
            // 
            // chkB_romanceTag
            // 
            this.chkB_romanceTag.AutoSize = true;
            this.chkB_romanceTag.Location = new System.Drawing.Point(3, 38);
            this.chkB_romanceTag.Name = "chkB_romanceTag";
            this.chkB_romanceTag.Size = new System.Drawing.Size(111, 29);
            this.chkB_romanceTag.TabIndex = 1;
            this.chkB_romanceTag.Text = "Romance";
            this.chkB_romanceTag.ThreeState = true;
            this.chkB_romanceTag.UseVisualStyleBackColor = true;
            // 
            // chkB_fictionTag
            // 
            this.chkB_fictionTag.AutoSize = true;
            this.chkB_fictionTag.Location = new System.Drawing.Point(3, 73);
            this.chkB_fictionTag.Name = "chkB_fictionTag";
            this.chkB_fictionTag.Size = new System.Drawing.Size(90, 29);
            this.chkB_fictionTag.TabIndex = 2;
            this.chkB_fictionTag.Text = "Fiction";
            this.chkB_fictionTag.ThreeState = true;
            this.chkB_fictionTag.UseVisualStyleBackColor = true;
            // 
            // chkB_nonfictionTag
            // 
            this.chkB_nonfictionTag.AutoSize = true;
            this.chkB_nonfictionTag.Location = new System.Drawing.Point(3, 108);
            this.chkB_nonfictionTag.Name = "chkB_nonfictionTag";
            this.chkB_nonfictionTag.Size = new System.Drawing.Size(131, 29);
            this.chkB_nonfictionTag.TabIndex = 3;
            this.chkB_nonfictionTag.Text = "Non-Fiction";
            this.chkB_nonfictionTag.ThreeState = true;
            this.chkB_nonfictionTag.UseVisualStyleBackColor = true;
            // 
            // chkB_recommendedTag
            // 
            this.chkB_recommendedTag.AutoSize = true;
            this.chkB_recommendedTag.Checked = true;
            this.chkB_recommendedTag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkB_recommendedTag.Location = new System.Drawing.Point(3, 143);
            this.chkB_recommendedTag.Name = "chkB_recommendedTag";
            this.chkB_recommendedTag.Size = new System.Drawing.Size(80, 29);
            this.chkB_recommendedTag.TabIndex = 4;
            this.chkB_recommendedTag.Text = "[TAG]";
            this.chkB_recommendedTag.ThreeState = true;
            this.chkB_recommendedTag.UseVisualStyleBackColor = true;
            // 
            // gb_date
            // 
            this.gb_date.Controls.Add(this.gb_dateRanges);
            this.gb_date.Location = new System.Drawing.Point(3, 466);
            this.gb_date.Name = "gb_date";
            this.gb_date.Size = new System.Drawing.Size(267, 161);
            this.gb_date.TabIndex = 11;
            this.gb_date.TabStop = false;
            this.gb_date.Text = "Date Range";
            // 
            // gb_dateRanges
            // 
            this.gb_dateRanges.Controls.Add(this.date_fromDate);
            this.gb_dateRanges.Controls.Add(this.lbl_toDate);
            this.gb_dateRanges.Controls.Add(this.date_ToDate);
            this.gb_dateRanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_dateRanges.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.gb_dateRanges.Location = new System.Drawing.Point(3, 27);
            this.gb_dateRanges.Name = "gb_dateRanges";
            this.gb_dateRanges.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.gb_dateRanges.Size = new System.Drawing.Size(261, 131);
            this.gb_dateRanges.TabIndex = 7;
            // 
            // date_fromDate
            // 
            this.date_fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fromDate.Location = new System.Drawing.Point(3, 18);
            this.date_fromDate.MaxDate = new System.DateTime(2023, 2, 27, 0, 0, 0, 0);
            this.date_fromDate.MinDate = new System.DateTime(1853, 1, 1, 0, 0, 0, 0);
            this.date_fromDate.Name = "date_fromDate";
            this.date_fromDate.Size = new System.Drawing.Size(133, 31);
            this.date_fromDate.TabIndex = 4;
            this.date_fromDate.Value = new System.DateTime(2023, 2, 27, 0, 0, 0, 0);
            // 
            // lbl_toDate
            // 
            this.lbl_toDate.AutoSize = true;
            this.lbl_toDate.Location = new System.Drawing.Point(3, 52);
            this.lbl_toDate.Name = "lbl_toDate";
            this.lbl_toDate.Size = new System.Drawing.Size(29, 25);
            this.lbl_toDate.TabIndex = 5;
            this.lbl_toDate.Text = "to";
            // 
            // date_ToDate
            // 
            this.date_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ToDate.Location = new System.Drawing.Point(3, 80);
            this.date_ToDate.MaxDate = new System.DateTime(2023, 2, 27, 0, 0, 0, 0);
            this.date_ToDate.MinDate = new System.DateTime(1853, 1, 1, 0, 0, 0, 0);
            this.date_ToDate.Name = "date_ToDate";
            this.date_ToDate.Size = new System.Drawing.Size(133, 31);
            this.date_ToDate.TabIndex = 6;
            this.date_ToDate.Value = new System.DateTime(2023, 2, 27, 0, 0, 0, 0);
            // 
            // dg_recommendationResults
            // 
            this.dg_recommendationResults.AllowUserToDeleteRows = false;
            this.dg_recommendationResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_recommendationResults.Location = new System.Drawing.Point(340, 96);
            this.dg_recommendationResults.Name = "dg_recommendationResults";
            this.dg_recommendationResults.ReadOnly = true;
            this.dg_recommendationResults.RowHeadersWidth = 62;
            this.dg_recommendationResults.RowTemplate.Height = 33;
            this.dg_recommendationResults.Size = new System.Drawing.Size(763, 644);
            this.dg_recommendationResults.TabIndex = 4;
            // 
            // lbl_backButton
            // 
            this.lbl_backButton.AutoSize = true;
            this.lbl_backButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_backButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_backButton.Location = new System.Drawing.Point(31, 55);
            this.lbl_backButton.Name = "lbl_backButton";
            this.lbl_backButton.Size = new System.Drawing.Size(135, 25);
            this.lbl_backButton.TabIndex = 5;
            this.lbl_backButton.Text = "Back to Home";
            this.lbl_backButton.Click += new System.EventHandler(this.lbl_backButton_Click);
            // 
            // Detailed_Recommendations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 752);
            this.Controls.Add(this.lbl_backButton);
            this.Controls.Add(this.dg_recommendationResults);
            this.Controls.Add(this.flp_allFilters);
            this.Controls.Add(this.lbl_recommendations);
            this.Controls.Add(this.lbl_recommendedTag);
            this.Name = "Detailed_Recommendations";
            this.Text = "Detailed_Recommendations";
            this.flp_allFilters.ResumeLayout(false);
            this.flp_allFilters.PerformLayout();
            this.gb_mediaType.ResumeLayout(false);
            this.flp_allMediaTypes.ResumeLayout(false);
            this.flp_allMediaTypes.PerformLayout();
            this.gb_Genre.ResumeLayout(false);
            this.flp_allGenres.ResumeLayout(false);
            this.flp_allGenres.PerformLayout();
            this.gb_date.ResumeLayout(false);
            this.gb_dateRanges.ResumeLayout(false);
            this.gb_dateRanges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_recommendationResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_recommendedTag;
        private Label lbl_recommendations;
        private FlowLayoutPanel flp_allFilters;
        private Label lbl_filters;
        private DataGridView dg_recommendationResults;
        private GroupBox gb_mediaType;
        private FlowLayoutPanel flp_allMediaTypes;
        private CheckBox chkB_moviesTag;
        private CheckBox chkB_gamesTag;
        private CheckBox chkB_musicTag;
        private CheckBox chkB_tvShowsTag;
        private CheckBox chkB_booksTag;
        private GroupBox gb_Genre;
        private FlowLayoutPanel flp_allGenres;
        private CheckBox chkB_horrorTag;
        private CheckBox chkB_romanceTag;
        private CheckBox chkB_fictionTag;
        private CheckBox chkB_nonfictionTag;
        private CheckBox chkB_recommendedTag;
        private GroupBox gb_date;
        private FlowLayoutPanel gb_dateRanges;
        private DateTimePicker date_fromDate;
        private Label lbl_toDate;
        private DateTimePicker date_ToDate;
        private Label lbl_backButton;
    }
}