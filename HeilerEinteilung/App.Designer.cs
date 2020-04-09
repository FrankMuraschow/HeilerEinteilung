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
            this.tbTankName = new System.Windows.Forms.TextBox();
            this.btnAddTank = new System.Windows.Forms.Button();
            this.lbAvailableTanks = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveTank = new System.Windows.Forms.Button();
            this.lblTanks = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoveHealer = new System.Windows.Forms.Button();
            this.lblHealers = new System.Windows.Forms.Label();
            this.btnAddHealer = new System.Windows.Forms.Button();
            this.tbHealerName = new System.Windows.Forms.TextBox();
            this.lbAvailableHealers = new System.Windows.Forms.ListBox();
            this.btnAddAssoc = new System.Windows.Forms.Button();
            this.btnLoadAssocs = new System.Windows.Forms.Button();
            this.btnSaveAssoc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTankName
            // 
            this.tbTankName.Location = new System.Drawing.Point(3, 40);
            this.tbTankName.Name = "tbTankName";
            this.tbTankName.Size = new System.Drawing.Size(120, 20);
            this.tbTankName.TabIndex = 1;
            // 
            // btnAddTank
            // 
            this.btnAddTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTank.Location = new System.Drawing.Point(129, 36);
            this.btnAddTank.Name = "btnAddTank";
            this.btnAddTank.Size = new System.Drawing.Size(75, 26);
            this.btnAddTank.TabIndex = 2;
            this.btnAddTank.Text = "Hinzufügen";
            this.btnAddTank.UseVisualStyleBackColor = true;
            this.btnAddTank.Click += new System.EventHandler(this.btnAddTank_Click);
            // 
            // lbAvailableTanks
            // 
            this.lbAvailableTanks.FormattingEnabled = true;
            this.lbAvailableTanks.Location = new System.Drawing.Point(3, 100);
            this.lbAvailableTanks.Name = "lbAvailableTanks";
            this.lbAvailableTanks.Size = new System.Drawing.Size(201, 95);
            this.lbAvailableTanks.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemoveTank);
            this.panel1.Controls.Add(this.lblTanks);
            this.panel1.Controls.Add(this.btnAddTank);
            this.panel1.Controls.Add(this.tbTankName);
            this.panel1.Controls.Add(this.lbAvailableTanks);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 239);
            this.panel1.TabIndex = 1;
            // 
            // btnRemoveTank
            // 
            this.btnRemoveTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTank.Location = new System.Drawing.Point(6, 201);
            this.btnRemoveTank.Name = "btnRemoveTank";
            this.btnRemoveTank.Size = new System.Drawing.Size(75, 26);
            this.btnRemoveTank.TabIndex = 4;
            this.btnRemoveTank.Text = "Entfernen";
            this.btnRemoveTank.UseVisualStyleBackColor = true;
            this.btnRemoveTank.Click += new System.EventHandler(this.btnRemoveTank_Click);
            // 
            // lblTanks
            // 
            this.lblTanks.AutoSize = true;
            this.lblTanks.Location = new System.Drawing.Point(3, 12);
            this.lblTanks.Name = "lblTanks";
            this.lblTanks.Size = new System.Drawing.Size(37, 13);
            this.lblTanks.TabIndex = 3;
            this.lblTanks.Text = "Tanks";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemoveHealer);
            this.panel2.Controls.Add(this.lblHealers);
            this.panel2.Controls.Add(this.btnAddHealer);
            this.panel2.Controls.Add(this.tbHealerName);
            this.panel2.Controls.Add(this.lbAvailableHealers);
            this.panel2.Location = new System.Drawing.Point(232, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 239);
            this.panel2.TabIndex = 3;
            // 
            // btnRemoveHealer
            // 
            this.btnRemoveHealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveHealer.Location = new System.Drawing.Point(6, 201);
            this.btnRemoveHealer.Name = "btnRemoveHealer";
            this.btnRemoveHealer.Size = new System.Drawing.Size(75, 26);
            this.btnRemoveHealer.TabIndex = 5;
            this.btnRemoveHealer.Text = "Entfernen";
            this.btnRemoveHealer.UseVisualStyleBackColor = true;
            this.btnRemoveHealer.Click += new System.EventHandler(this.btnRemoveHealer_Click);
            // 
            // lblHealers
            // 
            this.lblHealers.AutoSize = true;
            this.lblHealers.Location = new System.Drawing.Point(3, 12);
            this.lblHealers.Name = "lblHealers";
            this.lblHealers.Size = new System.Drawing.Size(34, 13);
            this.lblHealers.TabIndex = 4;
            this.lblHealers.Text = "Heiler";
            // 
            // btnAddHealer
            // 
            this.btnAddHealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHealer.Location = new System.Drawing.Point(129, 36);
            this.btnAddHealer.Name = "btnAddHealer";
            this.btnAddHealer.Size = new System.Drawing.Size(75, 26);
            this.btnAddHealer.TabIndex = 2;
            this.btnAddHealer.Text = "Hinzufügen";
            this.btnAddHealer.UseVisualStyleBackColor = true;
            this.btnAddHealer.Click += new System.EventHandler(this.btnAddHealer_Click);
            // 
            // tbHealerName
            // 
            this.tbHealerName.Location = new System.Drawing.Point(3, 40);
            this.tbHealerName.Name = "tbHealerName";
            this.tbHealerName.Size = new System.Drawing.Size(120, 20);
            this.tbHealerName.TabIndex = 1;
            // 
            // lbAvailableHealers
            // 
            this.lbAvailableHealers.FormattingEnabled = true;
            this.lbAvailableHealers.Location = new System.Drawing.Point(3, 100);
            this.lbAvailableHealers.Name = "lbAvailableHealers";
            this.lbAvailableHealers.Size = new System.Drawing.Size(201, 95);
            this.lbAvailableHealers.TabIndex = 0;
            // 
            // btnAddAssoc
            // 
            this.btnAddAssoc.Location = new System.Drawing.Point(12, 278);
            this.btnAddAssoc.Name = "btnAddAssoc";
            this.btnAddAssoc.Size = new System.Drawing.Size(434, 23);
            this.btnAddAssoc.TabIndex = 4;
            this.btnAddAssoc.Text = "Einteilung hinzufügen";
            this.btnAddAssoc.UseVisualStyleBackColor = true;
            this.btnAddAssoc.Click += new System.EventHandler(this.btnAddAssoc_Click);
            // 
            // btnLoadAssocs
            // 
            this.btnLoadAssocs.Location = new System.Drawing.Point(210, 651);
            this.btnLoadAssocs.Name = "btnLoadAssocs";
            this.btnLoadAssocs.Size = new System.Drawing.Size(117, 23);
            this.btnLoadAssocs.TabIndex = 5;
            this.btnLoadAssocs.Text = "Einteilung laden";
            this.btnLoadAssocs.UseVisualStyleBackColor = true;
            // 
            // btnSaveAssoc
            // 
            this.btnSaveAssoc.Location = new System.Drawing.Point(333, 651);
            this.btnSaveAssoc.Name = "btnSaveAssoc";
            this.btnSaveAssoc.Size = new System.Drawing.Size(117, 23);
            this.btnSaveAssoc.TabIndex = 6;
            this.btnSaveAssoc.Text = "Einteilung speichern";
            this.btnSaveAssoc.UseVisualStyleBackColor = true;
            this.btnSaveAssoc.Click += new System.EventHandler(this.btnSaveAssoc_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 686);
            this.Controls.Add(this.btnSaveAssoc);
            this.Controls.Add(this.btnLoadAssocs);
            this.Controls.Add(this.btnAddAssoc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "App";
            this.Text = "WOW - Heiler Einteilung";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddTank;
        private System.Windows.Forms.TextBox tbTankName;
        private System.Windows.Forms.ListBox lbAvailableTanks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTanks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHealers;
        private System.Windows.Forms.Button btnAddHealer;
        private System.Windows.Forms.TextBox tbHealerName;
        private System.Windows.Forms.ListBox lbAvailableHealers;
        private System.Windows.Forms.Button btnRemoveTank;
        private System.Windows.Forms.Button btnRemoveHealer;
        private System.Windows.Forms.Button btnAddAssoc;
        private System.Windows.Forms.Button btnLoadAssocs;
        private System.Windows.Forms.Button btnSaveAssoc;
    }
}

