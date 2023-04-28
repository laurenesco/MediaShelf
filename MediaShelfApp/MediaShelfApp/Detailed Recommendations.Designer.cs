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
            dgvResults = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // lblRecommendations
            // 
            lblRecommendations.AutoSize = true;
            lblRecommendations.BackColor = SystemColors.ControlLightLight;
            lblRecommendations.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecommendations.Location = new Point(396, 12);
            lblRecommendations.Margin = new Padding(2, 0, 2, 0);
            lblRecommendations.Name = "lblRecommendations";
            lblRecommendations.Size = new Size(351, 54);
            lblRecommendations.TabIndex = 1;
            lblRecommendations.Text = "Recommendations";
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResults.BackgroundColor = SystemColors.ControlLightLight;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(47, 102);
            dgvResults.Margin = new Padding(2);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 62;
            dgvResults.RowTemplate.Height = 33;
            dgvResults.Size = new Size(1024, 595);
            dgvResults.TabIndex = 4;
            dgvResults.CellContentClick += dgvResults_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(13, 13);
            btnBack.Margin = new Padding(4, 4, 4, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 47);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Detailed_Recommendations
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BACKGROUND_WHITE;
            ClientSize = new Size(1115, 752);
            Controls.Add(btnBack);
            Controls.Add(dgvResults);
            Controls.Add(lblRecommendations);
            Margin = new Padding(2);
            Name = "Detailed_Recommendations";
            Text = "Detailed_Recommendations";
            Load += Detailed_Recommendations_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRecommendations;
        private DataGridView dgvResults;
        private Button btnBack;
    }
}