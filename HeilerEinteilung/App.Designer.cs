namespace HeilerEinteilung
{
    partial class App
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
            this.btnAddAssoc = new System.Windows.Forms.Button();
            this.pnlAssocs = new System.Windows.Forms.Panel();
            this.tbBossName = new System.Windows.Forms.TextBox();
            this.lblBossName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatnachrichtInZwischenablageKopierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAssoc
            // 
            this.btnAddAssoc.Location = new System.Drawing.Point(12, 71);
            this.btnAddAssoc.Name = "btnAddAssoc";
            this.btnAddAssoc.Size = new System.Drawing.Size(434, 23);
            this.btnAddAssoc.TabIndex = 4;
            this.btnAddAssoc.Text = "Einteilung hinzufügen";
            this.btnAddAssoc.UseVisualStyleBackColor = true;
            this.btnAddAssoc.Click += new System.EventHandler(this.btnAddAssoc_Click);
            // 
            // pnlAssocs
            // 
            this.pnlAssocs.Location = new System.Drawing.Point(12, 100);
            this.pnlAssocs.Name = "pnlAssocs";
            this.pnlAssocs.Size = new System.Drawing.Size(434, 741);
            this.pnlAssocs.TabIndex = 7;
            // 
            // tbBossName
            // 
            this.tbBossName.Location = new System.Drawing.Point(57, 27);
            this.tbBossName.Name = "tbBossName";
            this.tbBossName.Size = new System.Drawing.Size(172, 20);
            this.tbBossName.TabIndex = 10;
            // 
            // lblBossName
            // 
            this.lblBossName.AutoSize = true;
            this.lblBossName.Location = new System.Drawing.Point(9, 30);
            this.lblBossName.Name = "lblBossName";
            this.lblBossName.Size = new System.Drawing.Size(30, 13);
            this.lblBossName.TabIndex = 11;
            this.lblBossName.Text = "Boss";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.generatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ladenToolStripMenuItem,
            this.speichernToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ladenToolStripMenuItem.Text = "Laden";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // generatorToolStripMenuItem
            // 
            this.generatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatnachrichtInZwischenablageKopierenToolStripMenuItem});
            this.generatorToolStripMenuItem.Name = "generatorToolStripMenuItem";
            this.generatorToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.generatorToolStripMenuItem.Text = "Generator";
            // 
            // chatnachrichtInZwischenablageKopierenToolStripMenuItem
            // 
            this.chatnachrichtInZwischenablageKopierenToolStripMenuItem.Name = "chatnachrichtInZwischenablageKopierenToolStripMenuItem";
            this.chatnachrichtInZwischenablageKopierenToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.chatnachrichtInZwischenablageKopierenToolStripMenuItem.Text = "Chatnachricht in Zwischenablage kopieren";
            this.chatnachrichtInZwischenablageKopierenToolStripMenuItem.Click += new System.EventHandler(this.chatnachrichtInZwischenablageKopierenToolStripMenuItem_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 853);
            this.Controls.Add(this.lblBossName);
            this.Controls.Add(this.tbBossName);
            this.Controls.Add(this.pnlAssocs);
            this.Controls.Add(this.btnAddAssoc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "App";
            this.Text = "WOW - Heiler Einteilung";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddAssoc;
        private System.Windows.Forms.Panel pnlAssocs;
        private System.Windows.Forms.TextBox tbBossName;
        private System.Windows.Forms.Label lblBossName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatnachrichtInZwischenablageKopierenToolStripMenuItem;
    }
}

