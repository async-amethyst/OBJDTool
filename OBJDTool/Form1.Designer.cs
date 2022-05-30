namespace OBJDTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadOBJD = new MetroFramework.Controls.MetroButton();
            this.entry1Cnt = new MetroFramework.Controls.MetroLabel();
            this.entry2Cnt = new MetroFramework.Controls.MetroLabel();
            this.DropDown = new System.Windows.Forms.ComboBox();
            this.Section1Box = new System.Windows.Forms.ComboBox();
            this.Section2Box = new System.Windows.Forms.ComboBox();
            this.Sec1Bundle = new MetroFramework.Controls.MetroLabel();
            this.Sec1G1M = new MetroFramework.Controls.MetroLabel();
            this.Section2Scale = new MetroFramework.Controls.MetroLabel();
            this.Section2Rot = new MetroFramework.Controls.MetroLabel();
            this.Section2Pos = new MetroFramework.Controls.MetroLabel();
            this.Sec2ModelID = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // LoadOBJD
            // 
            this.LoadOBJD.Location = new System.Drawing.Point(34, 28);
            this.LoadOBJD.Name = "LoadOBJD";
            this.LoadOBJD.Size = new System.Drawing.Size(75, 23);
            this.LoadOBJD.TabIndex = 0;
            this.LoadOBJD.Text = "Load OBJD";
            this.LoadOBJD.Click += new System.EventHandler(this.LoadOBJD_Click);
            // 
            // entry1Cnt
            // 
            this.entry1Cnt.AutoSize = true;
            this.entry1Cnt.Location = new System.Drawing.Point(34, 121);
            this.entry1Cnt.Name = "entry1Cnt";
            this.entry1Cnt.Size = new System.Drawing.Size(79, 19);
            this.entry1Cnt.TabIndex = 2;
            this.entry1Cnt.Text = "Sec1 Entries:";
            // 
            // entry2Cnt
            // 
            this.entry2Cnt.AutoSize = true;
            this.entry2Cnt.Location = new System.Drawing.Point(34, 151);
            this.entry2Cnt.Name = "entry2Cnt";
            this.entry2Cnt.Size = new System.Drawing.Size(81, 19);
            this.entry2Cnt.TabIndex = 3;
            this.entry2Cnt.Text = "Sec2 Entires:";
            // 
            // DropDown
            // 
            this.DropDown.FormattingEnabled = true;
            this.DropDown.Location = new System.Drawing.Point(34, 76);
            this.DropDown.Name = "DropDown";
            this.DropDown.Size = new System.Drawing.Size(121, 23);
            this.DropDown.TabIndex = 5;
            this.DropDown.SelectedIndexChanged += new System.EventHandler(this.DropDown_SelectedIndexChanged);
            // 
            // Section1Box
            // 
            this.Section1Box.FormattingEnabled = true;
            this.Section1Box.Location = new System.Drawing.Point(330, 76);
            this.Section1Box.Name = "Section1Box";
            this.Section1Box.Size = new System.Drawing.Size(121, 23);
            this.Section1Box.TabIndex = 6;
            this.Section1Box.SelectedIndexChanged += new System.EventHandler(this.Section1Box_SelectedIndexChanged);
            // 
            // Section2Box
            // 
            this.Section2Box.FormattingEnabled = true;
            this.Section2Box.Location = new System.Drawing.Point(620, 76);
            this.Section2Box.Name = "Section2Box";
            this.Section2Box.Size = new System.Drawing.Size(121, 23);
            this.Section2Box.TabIndex = 7;
            this.Section2Box.SelectedIndexChanged += new System.EventHandler(this.Section2Box_SelectedIndexChanged);
            // 
            // Sec1Bundle
            // 
            this.Sec1Bundle.AutoSize = true;
            this.Sec1Bundle.Location = new System.Drawing.Point(330, 121);
            this.Sec1Bundle.Name = "Sec1Bundle";
            this.Sec1Bundle.Size = new System.Drawing.Size(64, 19);
            this.Sec1Bundle.TabIndex = 8;
            this.Sec1Bundle.Text = "BundleID:";
            // 
            // Sec1G1M
            // 
            this.Sec1G1M.AutoSize = true;
            this.Sec1G1M.Location = new System.Drawing.Point(330, 151);
            this.Sec1G1M.Name = "Sec1G1M";
            this.Sec1G1M.Size = new System.Drawing.Size(62, 19);
            this.Sec1G1M.TabIndex = 9;
            this.Sec1G1M.Text = "ModelID:";
            // 
            // Section2Scale
            // 
            this.Section2Scale.AutoSize = true;
            this.Section2Scale.Location = new System.Drawing.Point(556, 121);
            this.Section2Scale.Name = "Section2Scale";
            this.Section2Scale.Size = new System.Drawing.Size(81, 19);
            this.Section2Scale.TabIndex = 10;
            this.Section2Scale.Text = "metroLabel1";
            // 
            // Section2Rot
            // 
            this.Section2Rot.AutoSize = true;
            this.Section2Rot.Location = new System.Drawing.Point(556, 151);
            this.Section2Rot.Name = "Section2Rot";
            this.Section2Rot.Size = new System.Drawing.Size(81, 19);
            this.Section2Rot.TabIndex = 11;
            this.Section2Rot.Text = "metroLabel1";
            // 
            // Section2Pos
            // 
            this.Section2Pos.AutoSize = true;
            this.Section2Pos.Location = new System.Drawing.Point(556, 182);
            this.Section2Pos.Name = "Section2Pos";
            this.Section2Pos.Size = new System.Drawing.Size(81, 19);
            this.Section2Pos.TabIndex = 12;
            this.Section2Pos.Text = "metroLabel1";
            // 
            // Sec2ModelID
            // 
            this.Sec2ModelID.AutoSize = true;
            this.Sec2ModelID.Location = new System.Drawing.Point(556, 211);
            this.Sec2ModelID.Name = "Sec2ModelID";
            this.Sec2ModelID.Size = new System.Drawing.Size(81, 19);
            this.Sec2ModelID.TabIndex = 13;
            this.Sec2ModelID.Text = "metroLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sec2ModelID);
            this.Controls.Add(this.Section2Pos);
            this.Controls.Add(this.Section2Rot);
            this.Controls.Add(this.Section2Scale);
            this.Controls.Add(this.Sec1G1M);
            this.Controls.Add(this.Sec1Bundle);
            this.Controls.Add(this.Section2Box);
            this.Controls.Add(this.Section1Box);
            this.Controls.Add(this.DropDown);
            this.Controls.Add(this.entry2Cnt);
            this.Controls.Add(this.entry1Cnt);
            this.Controls.Add(this.LoadOBJD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton LoadOBJD;
        private MetroFramework.Controls.MetroLabel entry1Cnt;
        private MetroFramework.Controls.MetroLabel entry2Cnt;
        private ComboBox DropDown;
        private ComboBox Section1Box;
        private ComboBox Section2Box;
        private MetroFramework.Controls.MetroLabel Sec1Bundle;
        private MetroFramework.Controls.MetroLabel Sec1G1M;
        private MetroFramework.Controls.MetroLabel Section2Scale;
        private MetroFramework.Controls.MetroLabel Section2Rot;
        private MetroFramework.Controls.MetroLabel Section2Pos;
        private MetroFramework.Controls.MetroLabel Sec2ModelID;
    }
}