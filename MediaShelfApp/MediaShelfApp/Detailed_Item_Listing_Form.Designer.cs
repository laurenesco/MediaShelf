namespace MediaShelfApp
{
    partial class Detailed_Item_Listing_Form
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNavBack = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbAddToList = new System.Windows.Forms.ComboBox();
            this.btnFavorite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnNavBack);
            this.splitContainer1.Panel1.Controls.Add(this.picImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblDescription);
            this.splitContainer1.Panel2.Controls.Add(this.lblDescTitle);
            this.splitContainer1.Panel2.Controls.Add(this.lblDate);
            this.splitContainer1.Panel2.Controls.Add(this.lblGenre);
            this.splitContainer1.Panel2.Controls.Add(this.lblCreator);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitle);
            this.splitContainer1.Panel2.Controls.Add(this.cmbAddToList);
            this.splitContainer1.Panel2.Controls.Add(this.btnFavorite);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnNavBack
            // 
            this.btnNavBack.Location = new System.Drawing.Point(18, 395);
            this.btnNavBack.Name = "btnNavBack";
            this.btnNavBack.Size = new System.Drawing.Size(105, 29);
            this.btnNavBack.TabIndex = 1;
            this.btnNavBack.Text = "Back";
            this.btnNavBack.UseVisualStyleBackColor = true;
            this.btnNavBack.Click += new System.EventHandler(this.btnNavBack_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(18, 41);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(227, 212);
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(49, 291);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(163, 20);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description goes here...";
            // 
            // lblDescTitle
            // 
            this.lblDescTitle.AutoSize = true;
            this.lblDescTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescTitle.Location = new System.Drawing.Point(50, 264);
            this.lblDescTitle.Name = "lblDescTitle";
            this.lblDescTitle.Size = new System.Drawing.Size(89, 20);
            this.lblDescTitle.TabIndex = 6;
            this.lblDescTitle.Text = "Description";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(49, 183);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(99, 20);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Release Date:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(49, 151);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(51, 20);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre:";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(49, 118);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(61, 20);
            this.lblCreator.TabIndex = 3;
            this.lblCreator.Text = "Creator:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(39, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 57);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // cmbAddToList
            // 
            this.cmbAddToList.FormattingEnabled = true;
            this.cmbAddToList.Location = new System.Drawing.Point(333, 56);
            this.cmbAddToList.Name = "cmbAddToList";
            this.cmbAddToList.Size = new System.Drawing.Size(171, 28);
            this.cmbAddToList.TabIndex = 1;
            // 
            // btnFavorite
            // 
            this.btnFavorite.Location = new System.Drawing.Point(385, 100);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(119, 29);
            this.btnFavorite.TabIndex = 0;
            this.btnFavorite.Text = "Favorite";
            this.btnFavorite.UseVisualStyleBackColor = true;
            // 
            // Detailed_Item_Listing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Detailed_Item_Listing_Form";
            this.Text = "Detailed Item Listing";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnNavBack;
        private PictureBox picImage;
        private Button btnFavorite;
        private Label lblDescription;
        private Label lblDescTitle;
        private Label lblDate;
        private Label lblGenre;
        private Label lblCreator;
        private Label lblTitle;
        private ComboBox cmbAddToList;
    }
}