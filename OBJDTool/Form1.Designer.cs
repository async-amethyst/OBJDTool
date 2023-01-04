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
            this.MapList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDATA0DirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Entry1List = new System.Windows.Forms.ListBox();
            this.FileLoadedName = new System.Windows.Forms.Label();
            this.Entry2List = new System.Windows.Forms.ListBox();
            this.EntryPos = new System.Windows.Forms.Label();
            this.EntryRot = new System.Windows.Forms.Label();
            this.EntryScale = new System.Windows.Forms.Label();
            this.bundleID = new System.Windows.Forms.Label();
            this.ModelID = new System.Windows.Forms.Label();
            this.MaterialHeader = new System.Windows.Forms.Label();
            this.MaterialList = new System.Windows.Forms.ListBox();
            this.DiffuseIndex = new System.Windows.Forms.Label();
            this.NormalIndex = new System.Windows.Forms.Label();
            this.SpecularIndex = new System.Windows.Forms.Label();
            this.EmissiveIndex = new System.Windows.Forms.Label();
            this.SubmeshIndex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapList
            // 
            this.MapList.FormattingEnabled = true;
            this.MapList.ItemHeight = 15;
            this.MapList.Location = new System.Drawing.Point(12, 51);
            this.MapList.Name = "MapList";
            this.MapList.ScrollAlwaysVisible = true;
            this.MapList.Size = new System.Drawing.Size(168, 619);
            this.MapList.TabIndex = 17;
            this.MapList.SelectedIndexChanged += new System.EventHandler(this.MapList_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.resetDATA0DirectoryToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem1.Text = "Unpack MDLK";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // resetDATA0DirectoryToolStripMenuItem
            // 
            this.resetDATA0DirectoryToolStripMenuItem.Name = "resetDATA0DirectoryToolStripMenuItem";
            this.resetDATA0DirectoryToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.resetDATA0DirectoryToolStripMenuItem.Text = "Reset DATA0 Directory";
            // 
            // Entry1List
            // 
            this.Entry1List.FormattingEnabled = true;
            this.Entry1List.ItemHeight = 15;
            this.Entry1List.Location = new System.Drawing.Point(475, 51);
            this.Entry1List.Name = "Entry1List";
            this.Entry1List.Size = new System.Drawing.Size(229, 619);
            this.Entry1List.TabIndex = 19;
            this.Entry1List.SelectedIndexChanged += new System.EventHandler(this.Entry1List_SelectedIndexChanged);
            // 
            // FileLoadedName
            // 
            this.FileLoadedName.AutoSize = true;
            this.FileLoadedName.Location = new System.Drawing.Point(299, 321);
            this.FileLoadedName.Name = "FileLoadedName";
            this.FileLoadedName.Size = new System.Drawing.Size(38, 15);
            this.FileLoadedName.TabIndex = 20;
            this.FileLoadedName.Text = "label1";
            this.FileLoadedName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Entry2List
            // 
            this.Entry2List.FormattingEnabled = true;
            this.Entry2List.ItemHeight = 15;
            this.Entry2List.Location = new System.Drawing.Point(1152, 51);
            this.Entry2List.Name = "Entry2List";
            this.Entry2List.Size = new System.Drawing.Size(120, 94);
            this.Entry2List.TabIndex = 21;
            this.Entry2List.SelectedIndexChanged += new System.EventHandler(this.Entry2List_SelectedIndexChanged);
            // 
            // EntryPos
            // 
            this.EntryPos.AutoSize = true;
            this.EntryPos.Location = new System.Drawing.Point(958, 219);
            this.EntryPos.Name = "EntryPos";
            this.EntryPos.Size = new System.Drawing.Size(38, 15);
            this.EntryPos.TabIndex = 22;
            this.EntryPos.Text = "label1";
            // 
            // EntryRot
            // 
            this.EntryRot.AutoSize = true;
            this.EntryRot.Location = new System.Drawing.Point(958, 257);
            this.EntryRot.Name = "EntryRot";
            this.EntryRot.Size = new System.Drawing.Size(38, 15);
            this.EntryRot.TabIndex = 23;
            this.EntryRot.Text = "label1";
            // 
            // EntryScale
            // 
            this.EntryScale.AutoSize = true;
            this.EntryScale.Location = new System.Drawing.Point(958, 296);
            this.EntryScale.Name = "EntryScale";
            this.EntryScale.Size = new System.Drawing.Size(38, 15);
            this.EntryScale.TabIndex = 24;
            this.EntryScale.Text = "label1";
            // 
            // bundleID
            // 
            this.bundleID.AutoSize = true;
            this.bundleID.Location = new System.Drawing.Point(833, 240);
            this.bundleID.Name = "bundleID";
            this.bundleID.Size = new System.Drawing.Size(38, 15);
            this.bundleID.TabIndex = 25;
            this.bundleID.Text = "label1";
            // 
            // ModelID
            // 
            this.ModelID.AutoSize = true;
            this.ModelID.Location = new System.Drawing.Point(833, 280);
            this.ModelID.Name = "ModelID";
            this.ModelID.Size = new System.Drawing.Size(38, 15);
            this.ModelID.TabIndex = 26;
            this.ModelID.Text = "label1";
            // 
            // MaterialHeader
            // 
            this.MaterialHeader.AutoSize = true;
            this.MaterialHeader.Location = new System.Drawing.Point(900, 466);
            this.MaterialHeader.Name = "MaterialHeader";
            this.MaterialHeader.Size = new System.Drawing.Size(116, 15);
            this.MaterialHeader.TabIndex = 27;
            this.MaterialHeader.Text = "Material Information";
            // 
            // MaterialList
            // 
            this.MaterialList.FormattingEnabled = true;
            this.MaterialList.ItemHeight = 15;
            this.MaterialList.Location = new System.Drawing.Point(833, 510);
            this.MaterialList.Name = "MaterialList";
            this.MaterialList.Size = new System.Drawing.Size(120, 154);
            this.MaterialList.TabIndex = 28;
            // 
            // DiffuseIndex
            // 
            this.DiffuseIndex.AutoSize = true;
            this.DiffuseIndex.Location = new System.Drawing.Point(1041, 510);
            this.DiffuseIndex.Name = "DiffuseIndex";
            this.DiffuseIndex.Size = new System.Drawing.Size(38, 15);
            this.DiffuseIndex.TabIndex = 29;
            this.DiffuseIndex.Text = "label1";
            // 
            // NormalIndex
            // 
            this.NormalIndex.AutoSize = true;
            this.NormalIndex.Location = new System.Drawing.Point(1041, 559);
            this.NormalIndex.Name = "NormalIndex";
            this.NormalIndex.Size = new System.Drawing.Size(38, 15);
            this.NormalIndex.TabIndex = 30;
            this.NormalIndex.Text = "label1";
            // 
            // SpecularIndex
            // 
            this.SpecularIndex.AutoSize = true;
            this.SpecularIndex.Location = new System.Drawing.Point(1041, 603);
            this.SpecularIndex.Name = "SpecularIndex";
            this.SpecularIndex.Size = new System.Drawing.Size(38, 15);
            this.SpecularIndex.TabIndex = 31;
            this.SpecularIndex.Text = "label1";
            // 
            // EmissiveIndex
            // 
            this.EmissiveIndex.AutoSize = true;
            this.EmissiveIndex.Location = new System.Drawing.Point(1041, 649);
            this.EmissiveIndex.Name = "EmissiveIndex";
            this.EmissiveIndex.Size = new System.Drawing.Size(38, 15);
            this.EmissiveIndex.TabIndex = 32;
            this.EmissiveIndex.Text = "label1";
            // 
            // SubmeshIndex
            // 
            this.SubmeshIndex.AutoSize = true;
            this.SubmeshIndex.Location = new System.Drawing.Point(1041, 693);
            this.SubmeshIndex.Name = "SubmeshIndex";
            this.SubmeshIndex.Size = new System.Drawing.Size(38, 15);
            this.SubmeshIndex.TabIndex = 33;
            this.SubmeshIndex.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Map Names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Section 1 Entry List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1152, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Section 2 Entries";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmeshIndex);
            this.Controls.Add(this.EmissiveIndex);
            this.Controls.Add(this.SpecularIndex);
            this.Controls.Add(this.NormalIndex);
            this.Controls.Add(this.DiffuseIndex);
            this.Controls.Add(this.MaterialList);
            this.Controls.Add(this.MaterialHeader);
            this.Controls.Add(this.ModelID);
            this.Controls.Add(this.bundleID);
            this.Controls.Add(this.EntryScale);
            this.Controls.Add(this.EntryRot);
            this.Controls.Add(this.EntryPos);
            this.Controls.Add(this.Entry2List);
            this.Controls.Add(this.FileLoadedName);
            this.Controls.Add(this.Entry1List);
            this.Controls.Add(this.MapList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kuro\'s OBJD Editor 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox MapList;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem resetDATA0DirectoryToolStripMenuItem;
        private ListBox Entry1List;
        private Label FileLoadedName;
        private ListBox Entry2List;
        private Label EntryPos;
        private Label EntryRot;
        private Label EntryScale;
        private Label bundleID;
        private Label ModelID;
        private Label MaterialHeader;
        private ListBox MaterialList;
        private Label DiffuseIndex;
        private Label NormalIndex;
        private Label SpecularIndex;
        private Label EmissiveIndex;
        private Label SubmeshIndex;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}