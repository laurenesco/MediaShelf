namespace MediaShelfApp
{
    partial class Manual_Entry_Form
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
            this.btnNavBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNavBack
            // 
            this.btnNavBack.Location = new System.Drawing.Point(17, 19);
            this.btnNavBack.Name = "btnNavBack";
            this.btnNavBack.Size = new System.Drawing.Size(94, 29);
            this.btnNavBack.TabIndex = 0;
            this.btnNavBack.Text = "Back";
            this.btnNavBack.UseVisualStyleBackColor = true;
            this.btnNavBack.Click += new System.EventHandler(this.btnNavBack_Click);
            // 
            // Manual_Entry_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNavBack);
            this.Name = "Manual_Entry_Form";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNavBack;
    }
}