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
            this.lblRecommendations = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFilters = new System.Windows.Forms.Label();
            this.grbMediaType = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkMovies = new System.Windows.Forms.CheckBox();
            this.chkGames = new System.Windows.Forms.CheckBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.chkTVShows = new System.Windows.Forms.CheckBox();
            this.chkBooks = new System.Windows.Forms.CheckBox();
            this.grbGenre = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkHorror = new System.Windows.Forms.CheckBox();
            this.chkRomance = new System.Windows.Forms.CheckBox();
            this.chkFiction = new System.Windows.Forms.CheckBox();
            this.chkNonFiction = new System.Windows.Forms.CheckBox();
            this.chkTag = new System.Windows.Forms.CheckBox();
            this.grbDateRange = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.grbMediaType.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.grbGenre.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.grbDateRange.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecommendations
            // 
            this.lblRecommendations.AutoSize = true;
            this.lblRecommendations.BackColor = System.Drawing.Color.Transparent;
            this.lblRecommendations.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecommendations.Location = new System.Drawing.Point(340, 29);
            this.lblRecommendations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecommendations.Name = "lblRecommendations";
            this.lblRecommendations.Size = new System.Drawing.Size(351, 54);
            this.lblRecommendations.TabIndex = 1;
            this.lblRecommendations.Text = "Recommendations";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lblFilters);
            this.flowLayoutPanel1.Controls.Add(this.grbMediaType);
            this.flowLayoutPanel1.Controls.Add(this.grbGenre);
            this.flowLayoutPanel1.Controls.Add(this.grbDateRange);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 96);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(312, 644);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Location = new System.Drawing.Point(2, 0);
            this.lblFilters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(58, 25);
            this.lblFilters.TabIndex = 4;
            this.lblFilters.Text = "Filters";
            // 
            // grbMediaType
            // 
            this.grbMediaType.AutoSize = true;
            this.grbMediaType.Controls.Add(this.flowLayoutPanel3);
            this.grbMediaType.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbMediaType.Location = new System.Drawing.Point(2, 27);
            this.grbMediaType.Margin = new System.Windows.Forms.Padding(2);
            this.grbMediaType.Name = "grbMediaType";
            this.grbMediaType.Padding = new System.Windows.Forms.Padding(2);
            this.grbMediaType.Size = new System.Drawing.Size(304, 194);
            this.grbMediaType.TabIndex = 9;
            this.grbMediaType.TabStop = false;
            this.grbMediaType.Text = "Media Type";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.chkMovies);
            this.flowLayoutPanel3.Controls.Add(this.chkGames);
            this.flowLayoutPanel3.Controls.Add(this.chkMusic);
            this.flowLayoutPanel3.Controls.Add(this.chkTVShows);
            this.flowLayoutPanel3.Controls.Add(this.chkBooks);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 27);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(300, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(300, 165);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // chkMovies
            // 
            this.chkMovies.AutoSize = true;
            this.chkMovies.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkMovies.Location = new System.Drawing.Point(2, 2);
            this.chkMovies.Margin = new System.Windows.Forms.Padding(2);
            this.chkMovies.Name = "chkMovies";
            this.chkMovies.Size = new System.Drawing.Size(95, 29);
            this.chkMovies.TabIndex = 0;
            this.chkMovies.Text = "Movies";
            this.chkMovies.ThreeState = true;
            this.chkMovies.UseVisualStyleBackColor = true;
            // 
            // chkGames
            // 
            this.chkGames.AutoSize = true;
            this.chkGames.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkGames.Location = new System.Drawing.Point(2, 35);
            this.chkGames.Margin = new System.Windows.Forms.Padding(2);
            this.chkGames.Name = "chkGames";
            this.chkGames.Size = new System.Drawing.Size(92, 29);
            this.chkGames.TabIndex = 1;
            this.chkGames.Text = "Games";
            this.chkGames.ThreeState = true;
            this.chkGames.UseVisualStyleBackColor = true;
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkMusic.Location = new System.Drawing.Point(2, 68);
            this.chkMusic.Margin = new System.Windows.Forms.Padding(2);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(84, 29);
            this.chkMusic.TabIndex = 2;
            this.chkMusic.Text = "Music";
            this.chkMusic.ThreeState = true;
            this.chkMusic.UseVisualStyleBackColor = true;
            // 
            // chkTVShows
            // 
            this.chkTVShows.AutoSize = true;
            this.chkTVShows.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkTVShows.Location = new System.Drawing.Point(2, 101);
            this.chkTVShows.Margin = new System.Windows.Forms.Padding(2);
            this.chkTVShows.Name = "chkTVShows";
            this.chkTVShows.Size = new System.Drawing.Size(115, 29);
            this.chkTVShows.TabIndex = 3;
            this.chkTVShows.Text = "TV Shows";
            this.chkTVShows.ThreeState = true;
            this.chkTVShows.UseVisualStyleBackColor = true;
            // 
            // chkBooks
            // 
            this.chkBooks.AutoSize = true;
            this.chkBooks.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBooks.Location = new System.Drawing.Point(2, 134);
            this.chkBooks.Margin = new System.Windows.Forms.Padding(2);
            this.chkBooks.Name = "chkBooks";
            this.chkBooks.Size = new System.Drawing.Size(87, 29);
            this.chkBooks.TabIndex = 4;
            this.chkBooks.Text = "Books";
            this.chkBooks.ThreeState = true;
            this.chkBooks.UseVisualStyleBackColor = true;
            // 
            // grbGenre
            // 
            this.grbGenre.AutoSize = true;
            this.grbGenre.Controls.Add(this.flowLayoutPanel4);
            this.grbGenre.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbGenre.Location = new System.Drawing.Point(2, 225);
            this.grbGenre.Margin = new System.Windows.Forms.Padding(2);
            this.grbGenre.Name = "grbGenre";
            this.grbGenre.Padding = new System.Windows.Forms.Padding(2);
            this.grbGenre.Size = new System.Drawing.Size(304, 194);
            this.grbGenre.TabIndex = 10;
            this.grbGenre.TabStop = false;
            this.grbGenre.Text = "Genre";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.chkHorror);
            this.flowLayoutPanel4.Controls.Add(this.chkRomance);
            this.flowLayoutPanel4.Controls.Add(this.chkFiction);
            this.flowLayoutPanel4.Controls.Add(this.chkNonFiction);
            this.flowLayoutPanel4.Controls.Add(this.chkTag);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(2, 27);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel4.MinimumSize = new System.Drawing.Size(300, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(300, 165);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // chkHorror
            // 
            this.chkHorror.AutoSize = true;
            this.chkHorror.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkHorror.Location = new System.Drawing.Point(2, 2);
            this.chkHorror.Margin = new System.Windows.Forms.Padding(2);
            this.chkHorror.Name = "chkHorror";
            this.chkHorror.Size = new System.Drawing.Size(91, 29);
            this.chkHorror.TabIndex = 0;
            this.chkHorror.Text = "Horror";
            this.chkHorror.ThreeState = true;
            this.chkHorror.UseVisualStyleBackColor = true;
            // 
            // chkRomance
            // 
            this.chkRomance.AutoSize = true;
            this.chkRomance.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRomance.Location = new System.Drawing.Point(2, 35);
            this.chkRomance.Margin = new System.Windows.Forms.Padding(2);
            this.chkRomance.Name = "chkRomance";
            this.chkRomance.Size = new System.Drawing.Size(112, 29);
            this.chkRomance.TabIndex = 1;
            this.chkRomance.Text = "Romance";
            this.chkRomance.ThreeState = true;
            this.chkRomance.UseVisualStyleBackColor = true;
            // 
            // chkFiction
            // 
            this.chkFiction.AutoSize = true;
            this.chkFiction.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFiction.Location = new System.Drawing.Point(2, 68);
            this.chkFiction.Margin = new System.Windows.Forms.Padding(2);
            this.chkFiction.Name = "chkFiction";
            this.chkFiction.Size = new System.Drawing.Size(90, 29);
            this.chkFiction.TabIndex = 2;
            this.chkFiction.Text = "Fiction";
            this.chkFiction.ThreeState = true;
            this.chkFiction.UseVisualStyleBackColor = true;
            // 
            // chkNonFiction
            // 
            this.chkNonFiction.AutoSize = true;
            this.chkNonFiction.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkNonFiction.Location = new System.Drawing.Point(2, 101);
            this.chkNonFiction.Margin = new System.Windows.Forms.Padding(2);
            this.chkNonFiction.Name = "chkNonFiction";
            this.chkNonFiction.Size = new System.Drawing.Size(131, 29);
            this.chkNonFiction.TabIndex = 3;
            this.chkNonFiction.Text = "Non-Fiction";
            this.chkNonFiction.ThreeState = true;
            this.chkNonFiction.UseVisualStyleBackColor = true;
            // 
            // chkTag
            // 
            this.chkTag.AutoSize = true;
            this.chkTag.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkTag.Location = new System.Drawing.Point(2, 134);
            this.chkTag.Margin = new System.Windows.Forms.Padding(2);
            this.chkTag.Name = "chkTag";
            this.chkTag.Size = new System.Drawing.Size(81, 29);
            this.chkTag.TabIndex = 4;
            this.chkTag.Text = "[TAG]";
            this.chkTag.ThreeState = true;
            this.chkTag.UseVisualStyleBackColor = true;
            // 
            // grbDateRange
            // 
            this.grbDateRange.AutoSize = true;
            this.grbDateRange.Controls.Add(this.flowLayoutPanel2);
            this.grbDateRange.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbDateRange.Location = new System.Drawing.Point(2, 423);
            this.grbDateRange.Margin = new System.Windows.Forms.Padding(2);
            this.grbDateRange.Name = "grbDateRange";
            this.grbDateRange.Padding = new System.Windows.Forms.Padding(2);
            this.grbDateRange.Size = new System.Drawing.Size(308, 126);
            this.grbDateRange.TabIndex = 11;
            this.grbDateRange.TabStop = false;
            this.grbDateRange.Text = "Date Range";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.dtpStartDate);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.dtpEndDate);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 27);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(304, 97);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStartDate.Location = new System.Drawing.Point(2, 2);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(300, 32);
            this.dtpStartDate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(2, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "to";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEndDate.Location = new System.Drawing.Point(2, 63);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(300, 32);
            this.dtpEndDate.TabIndex = 6;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(373, 96);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersWidth = 62;
            this.dgvResults.RowTemplate.Height = 33;
            this.dgvResults.Size = new System.Drawing.Size(862, 644);
            this.dgvResults.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Location = new System.Drawing.Point(30, 29);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 36);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Detailed_Recommendations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::MediaShelfApp.Properties.Resources.BACKGROUND_WHITE;
            this.ClientSize = new System.Drawing.Size(1246, 752);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblRecommendations);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Detailed_Recommendations";
            this.Text = "Detailed_Recommendations";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.grbMediaType.ResumeLayout(false);
            this.grbMediaType.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.grbGenre.ResumeLayout(false);
            this.grbGenre.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.grbDateRange.ResumeLayout(false);
            this.grbDateRange.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblRecommendations;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblFilters;
        private DataGridView dgvResults;
        private GroupBox grbMediaType;
        private FlowLayoutPanel flowLayoutPanel3;
        private CheckBox chkMovies;
        private CheckBox chkGames;
        private CheckBox chkMusic;
        private CheckBox chkTVShows;
        private CheckBox chkBooks;
        private GroupBox grbGenre;
        private FlowLayoutPanel flowLayoutPanel4;
        private CheckBox chkHorror;
        private CheckBox chkRomance;
        private CheckBox chkFiction;
        private CheckBox chkNonFiction;
        private CheckBox chkTag;
        private GroupBox grbDateRange;
        private FlowLayoutPanel flowLayoutPanel2;
        private DateTimePicker dtpStartDate;
        private Label label5;
        private DateTimePicker dtpEndDate;
        private Button btnBack;
    }
}