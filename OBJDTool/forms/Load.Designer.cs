namespace OBJDTool.forms
{
    partial class Load
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
            this.Status1 = new System.Windows.Forms.Label();
            this.ProgBar = new System.Windows.Forms.ProgressBar();
            this.Status2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Status1
            // 
            this.Status1.AutoSize = true;
            this.Status1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Status1.Location = new System.Drawing.Point(14, 54);
            this.Status1.MaximumSize = new System.Drawing.Size(400, 0);
            this.Status1.Name = "Status1";
            this.Status1.Size = new System.Drawing.Size(358, 32);
            this.Status1.TabIndex = 0;
            this.Status1.Text = "Loading Map 0 - Remiere Vilage";
            this.Status1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProgBar
            // 
            this.ProgBar.Location = new System.Drawing.Point(33, 28);
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.Size = new System.Drawing.Size(300, 23);
            this.ProgBar.TabIndex = 1;
            // 
            // Status2
            // 
            this.Status2.AutoSize = true;
            this.Status2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Status2.Location = new System.Drawing.Point(94, 86);
            this.Status2.MaximumSize = new System.Drawing.Size(300, 0);
            this.Status2.Name = "Status2";
            this.Status2.Size = new System.Drawing.Size(191, 21);
            this.Status2.TabIndex = 2;
            this.Status2.Text = "Reading Section1 Entries...";
            this.Status2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.Status2);
            this.Controls.Add(this.ProgBar);
            this.Controls.Add(this.Status1);
            this.Name = "Load";
            this.Text = "Loading...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label Status1;
        public ProgressBar ProgBar;
        public Label Status2;
    }
}