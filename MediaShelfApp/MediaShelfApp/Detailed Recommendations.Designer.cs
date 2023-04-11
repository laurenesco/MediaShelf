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
            lblRecommendations = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblFilters = new Label();
            grbMediaType = new GroupBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            chkMovies = new CheckBox();
            chkGames = new CheckBox();
            chkMusic = new CheckBox();
            chkTVShows = new CheckBox();
            chkBooks = new CheckBox();
            grbGenre = new GroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            chkHorror = new CheckBox();
            chkRomance = new CheckBox();
            chkFiction = new CheckBox();
            chkNonFiction = new CheckBox();
            chkTag = new CheckBox();
            grbDateRange = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            dtpStartDate = new DateTimePicker();
            label5 = new Label();
            dtpEndDate = new DateTimePicker();
            dgvResults = new DataGridView();
            btnBack = new Button();
            flowLayoutPanel1.SuspendLayout();
            grbMediaType.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            grbGenre.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            grbDateRange.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // lblRecommendations
            // 
            lblRecommendations.AutoSize = true;
            lblRecommendations.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecommendations.Location = new Point(442, 37);
            lblRecommendations.Name = "lblRecommendations";
            lblRecommendations.Size = new Size(474, 72);
            lblRecommendations.TabIndex = 1;
            lblRecommendations.Text = "Recommendations";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblFilters);
            flowLayoutPanel1.Controls.Add(grbMediaType);
            flowLayoutPanel1.Controls.Add(grbGenre);
            flowLayoutPanel1.Controls.Add(grbDateRange);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(39, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(351, 824);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // lblFilters
            // 
            lblFilters.AutoSize = true;
            lblFilters.Location = new Point(3, 0);
            lblFilters.Name = "lblFilters";
            lblFilters.Size = new Size(77, 32);
            lblFilters.TabIndex = 4;
            lblFilters.Text = "Filters";
            // 
            // grbMediaType
            // 
            grbMediaType.Controls.Add(flowLayoutPanel3);
            grbMediaType.Location = new Point(3, 35);
            grbMediaType.Name = "grbMediaType";
            grbMediaType.Size = new Size(348, 272);
            grbMediaType.TabIndex = 9;
            grbMediaType.TabStop = false;
            grbMediaType.Text = "Media Type";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(chkMovies);
            flowLayoutPanel3.Controls.Add(chkGames);
            flowLayoutPanel3.Controls.Add(chkMusic);
            flowLayoutPanel3.Controls.Add(chkTVShows);
            flowLayoutPanel3.Controls.Add(chkBooks);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 35);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(342, 234);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // chkMovies
            // 
            chkMovies.AutoSize = true;
            chkMovies.Location = new Point(3, 3);
            chkMovies.Name = "chkMovies";
            chkMovies.Size = new Size(123, 36);
            chkMovies.TabIndex = 0;
            chkMovies.Text = "Movies";
            chkMovies.ThreeState = true;
            chkMovies.UseVisualStyleBackColor = true;
            // 
            // chkGames
            // 
            chkGames.AutoSize = true;
            chkGames.Location = new Point(3, 45);
            chkGames.Name = "chkGames";
            chkGames.Size = new Size(118, 36);
            chkGames.TabIndex = 1;
            chkGames.Text = "Games";
            chkGames.ThreeState = true;
            chkGames.UseVisualStyleBackColor = true;
            // 
            // chkMusic
            // 
            chkMusic.AutoSize = true;
            chkMusic.Location = new Point(3, 87);
            chkMusic.Name = "chkMusic";
            chkMusic.Size = new Size(109, 36);
            chkMusic.TabIndex = 2;
            chkMusic.Text = "Music";
            chkMusic.ThreeState = true;
            chkMusic.UseVisualStyleBackColor = true;
            // 
            // chkTVShows
            // 
            chkTVShows.AutoSize = true;
            chkTVShows.Location = new Point(3, 129);
            chkTVShows.Name = "chkTVShows";
            chkTVShows.Size = new Size(150, 36);
            chkTVShows.TabIndex = 3;
            chkTVShows.Text = "TV Shows";
            chkTVShows.ThreeState = true;
            chkTVShows.UseVisualStyleBackColor = true;
            // 
            // chkBooks
            // 
            chkBooks.AutoSize = true;
            chkBooks.Location = new Point(3, 171);
            chkBooks.Name = "chkBooks";
            chkBooks.Size = new Size(110, 36);
            chkBooks.TabIndex = 4;
            chkBooks.Text = "Books";
            chkBooks.ThreeState = true;
            chkBooks.UseVisualStyleBackColor = true;
            // 
            // grbGenre
            // 
            grbGenre.Controls.Add(flowLayoutPanel4);
            grbGenre.Location = new Point(3, 313);
            grbGenre.Name = "grbGenre";
            grbGenre.Size = new Size(348, 272);
            grbGenre.TabIndex = 10;
            grbGenre.TabStop = false;
            grbGenre.Text = "Genre";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(chkHorror);
            flowLayoutPanel4.Controls.Add(chkRomance);
            flowLayoutPanel4.Controls.Add(chkFiction);
            flowLayoutPanel4.Controls.Add(chkNonFiction);
            flowLayoutPanel4.Controls.Add(chkTag);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(3, 35);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(342, 234);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // chkHorror
            // 
            chkHorror.AutoSize = true;
            chkHorror.Location = new Point(3, 3);
            chkHorror.Name = "chkHorror";
            chkHorror.Size = new Size(115, 36);
            chkHorror.TabIndex = 0;
            chkHorror.Text = "Horror";
            chkHorror.ThreeState = true;
            chkHorror.UseVisualStyleBackColor = true;
            // 
            // chkRomance
            // 
            chkRomance.AutoSize = true;
            chkRomance.Location = new Point(3, 45);
            chkRomance.Name = "chkRomance";
            chkRomance.Size = new Size(144, 36);
            chkRomance.TabIndex = 1;
            chkRomance.Text = "Romance";
            chkRomance.ThreeState = true;
            chkRomance.UseVisualStyleBackColor = true;
            // 
            // chkFiction
            // 
            chkFiction.AutoSize = true;
            chkFiction.Location = new Point(3, 87);
            chkFiction.Name = "chkFiction";
            chkFiction.Size = new Size(117, 36);
            chkFiction.TabIndex = 2;
            chkFiction.Text = "Fiction";
            chkFiction.ThreeState = true;
            chkFiction.UseVisualStyleBackColor = true;
            // 
            // chkNonFiction
            // 
            chkNonFiction.AutoSize = true;
            chkNonFiction.Location = new Point(3, 129);
            chkNonFiction.Name = "chkNonFiction";
            chkNonFiction.Size = new Size(173, 36);
            chkNonFiction.TabIndex = 3;
            chkNonFiction.Text = "Non-Fiction";
            chkNonFiction.ThreeState = true;
            chkNonFiction.UseVisualStyleBackColor = true;
            // 
            // chkTag
            // 
            chkTag.AutoSize = true;
            chkTag.Location = new Point(3, 171);
            chkTag.Name = "chkTag";
            chkTag.Size = new Size(102, 36);
            chkTag.TabIndex = 4;
            chkTag.Text = "[TAG]";
            chkTag.ThreeState = true;
            chkTag.UseVisualStyleBackColor = true;
            // 
            // grbDateRange
            // 
            grbDateRange.Controls.Add(flowLayoutPanel2);
            grbDateRange.Location = new Point(3, 591);
            grbDateRange.Name = "grbDateRange";
            grbDateRange.Size = new Size(348, 206);
            grbDateRange.TabIndex = 11;
            grbDateRange.TabStop = false;
            grbDateRange.Text = "Date Range";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(dtpStartDate);
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(dtpEndDate);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 35);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(342, 168);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(3, 3);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(171, 39);
            dtpStartDate.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 45);
            label5.Name = "label5";
            label5.Size = new Size(36, 32);
            label5.TabIndex = 5;
            label5.Text = "to";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(3, 80);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(194, 39);
            dtpEndDate.TabIndex = 6;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(442, 123);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 62;
            dgvResults.RowTemplate.Height = 33;
            dgvResults.Size = new Size(991, 824);
            dgvResults.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(39, 37);
            btnBack.Margin = new Padding(5, 5, 5, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 46);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Detailed_Recommendations
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 963);
            Controls.Add(btnBack);
            Controls.Add(dgvResults);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblRecommendations);
            Name = "Detailed_Recommendations";
            Text = "Detailed_Recommendations";
            FormClosing += Detailed_Recommendations_FormClosing;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            grbMediaType.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            grbGenre.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            grbDateRange.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
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