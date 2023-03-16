namespace AplicacoesparaTeste
{
    partial class frmprinc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprinc));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplicaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicaçãoBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptSqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDoBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDoBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fIREBIRDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLSERVERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicaçõesToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplicaçõesToolStripMenuItem
            // 
            this.aplicaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeEmailToolStripMenuItem,
            this.aplicaçãoBDToolStripMenuItem});
            this.aplicaçõesToolStripMenuItem.Name = "aplicaçõesToolStripMenuItem";
            this.aplicaçõesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.aplicaçõesToolStripMenuItem.Text = "Aplicações";
            // 
            // testeEmailToolStripMenuItem
            // 
            this.testeEmailToolStripMenuItem.Name = "testeEmailToolStripMenuItem";
            this.testeEmailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testeEmailToolStripMenuItem.Text = "Teste Email";
            this.testeEmailToolStripMenuItem.Click += new System.EventHandler(this.testeEmailToolStripMenuItem_Click);
            // 
            // aplicaçãoBDToolStripMenuItem
            // 
            this.aplicaçãoBDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptSqlToolStripMenuItem,
            this.backupDoBancoToolStripMenuItem,
            this.restoreDoBancoToolStripMenuItem});
            this.aplicaçãoBDToolStripMenuItem.Name = "aplicaçãoBDToolStripMenuItem";
            this.aplicaçãoBDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aplicaçãoBDToolStripMenuItem.Text = "Aplicação BD";
            // 
            // scriptSqlToolStripMenuItem
            // 
            this.scriptSqlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIREBIRDToolStripMenuItem,
            this.sQLSERVERToolStripMenuItem});
            this.scriptSqlToolStripMenuItem.Name = "scriptSqlToolStripMenuItem";
            this.scriptSqlToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.scriptSqlToolStripMenuItem.Text = "Script Sql";
            // 
            // backupDoBancoToolStripMenuItem
            // 
            this.backupDoBancoToolStripMenuItem.Name = "backupDoBancoToolStripMenuItem";
            this.backupDoBancoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.backupDoBancoToolStripMenuItem.Text = "Backup do Banco";
            this.backupDoBancoToolStripMenuItem.Click += new System.EventHandler(this.backupDoBancoToolStripMenuItem_Click);
            // 
            // restoreDoBancoToolStripMenuItem
            // 
            this.restoreDoBancoToolStripMenuItem.Name = "restoreDoBancoToolStripMenuItem";
            this.restoreDoBancoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.restoreDoBancoToolStripMenuItem.Text = "Restore do Banco";
            this.restoreDoBancoToolStripMenuItem.Click += new System.EventHandler(this.restoreDoBancoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // fIREBIRDToolStripMenuItem
            // 
            this.fIREBIRDToolStripMenuItem.Name = "fIREBIRDToolStripMenuItem";
            this.fIREBIRDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fIREBIRDToolStripMenuItem.Text = "FIREBIRD";
            this.fIREBIRDToolStripMenuItem.Click += new System.EventHandler(this.fIREBIRDToolStripMenuItem_Click);
            // 
            // sQLSERVERToolStripMenuItem
            // 
            this.sQLSERVERToolStripMenuItem.Name = "sQLSERVERToolStripMenuItem";
            this.sQLSERVERToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sQLSERVERToolStripMenuItem.Text = "SQL SERVER";
            this.sQLSERVERToolStripMenuItem.Click += new System.EventHandler(this.sQLSERVERToolStripMenuItem_Click);
            // 
            // frmprinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 238);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmprinc";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplicaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aplicaçãoBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptSqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDoBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreDoBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIREBIRDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLSERVERToolStripMenuItem;
    }
}

