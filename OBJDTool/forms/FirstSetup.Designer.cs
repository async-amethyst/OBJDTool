namespace OBJDTool.forms
{
    partial class FirstSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstSetup));
            this.TopLabel = new System.Windows.Forms.Label();
            this.FileOpenButton = new System.Windows.Forms.Button();
            this.FileOpenText = new System.Windows.Forms.TextBox();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopLabel.Location = new System.Drawing.Point(189, 9);
            this.TopLabel.MinimumSize = new System.Drawing.Size(300, 150);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(366, 150);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.Text = resources.GetString("TopLabel.Text");
            this.TopLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FileOpenButton
            // 
            this.FileOpenButton.Location = new System.Drawing.Point(221, 228);
            this.FileOpenButton.Name = "FileOpenButton";
            this.FileOpenButton.Size = new System.Drawing.Size(25, 23);
            this.FileOpenButton.TabIndex = 1;
            this.FileOpenButton.Text = "...";
            this.FileOpenButton.UseVisualStyleBackColor = true;
            this.FileOpenButton.Click += new System.EventHandler(this.FileOpenButton_Click);
            // 
            // FileOpenText
            // 
            this.FileOpenText.Location = new System.Drawing.Point(252, 228);
            this.FileOpenText.Name = "FileOpenText";
            this.FileOpenText.PlaceholderText = "File Directory...";
            this.FileOpenText.Size = new System.Drawing.Size(300, 23);
            this.FileOpenText.TabIndex = 2;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(332, 302);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton.TabIndex = 3;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // FirstSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.FileOpenText);
            this.Controls.Add(this.FileOpenButton);
            this.Controls.Add(this.TopLabel);
            this.Name = "FirstSetup";
            this.Text = "Welcome to OBJDTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TopLabel;
        private Button FileOpenButton;
        private TextBox FileOpenText;
        private Button ContinueButton;
    }
}