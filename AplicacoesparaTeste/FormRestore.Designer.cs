namespace AplicacoesparaTeste
{
    partial class FormRestore
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
            this.OPbuscararquivos = new System.Windows.Forms.OpenFileDialog();
            this.lststatus = new System.Windows.Forms.ListBox();
            this.btnbuscarbanco = new System.Windows.Forms.Button();
            this.btnexecutar = new System.Windows.Forms.Button();
            this.btnbuscardir = new System.Windows.Forms.Button();
            this.txtnomebanco = new System.Windows.Forms.TextBox();
            this.lblnomebanco = new System.Windows.Forms.Label();
            this.txtcaminobackup = new System.Windows.Forms.TextBox();
            this.lblcaminhobakup = new System.Windows.Forms.Label();
            this.txtsenhabanco = new System.Windows.Forms.TextBox();
            this.txtloginbanco = new System.Windows.Forms.TextBox();
            this.txtservidor = new System.Windows.Forms.TextBox();
            this.txtinstancia = new System.Windows.Forms.TextBox();
            this.lblsenhabanc = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lbinstancia = new System.Windows.Forms.Label();
            this.lblservidor = new System.Windows.Forms.Label();
            this.cbxtipobanco = new System.Windows.Forms.ComboBox();
            this.lbltipobanco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OPbuscararquivos
            // 
            this.OPbuscararquivos.FileName = "openFileDialog1";
            // 
            // lststatus
            // 
            this.lststatus.FormattingEnabled = true;
            this.lststatus.Location = new System.Drawing.Point(53, 233);
            this.lststatus.Name = "lststatus";
            this.lststatus.ScrollAlwaysVisible = true;
            this.lststatus.Size = new System.Drawing.Size(373, 108);
            this.lststatus.TabIndex = 35;
            // 
            // btnbuscarbanco
            // 
            this.btnbuscarbanco.Location = new System.Drawing.Point(465, 164);
            this.btnbuscarbanco.Name = "btnbuscarbanco";
            this.btnbuscarbanco.Size = new System.Drawing.Size(96, 23);
            this.btnbuscarbanco.TabIndex = 36;
            this.btnbuscarbanco.Text = "Buscar Banco";
            this.btnbuscarbanco.UseVisualStyleBackColor = true;
            this.btnbuscarbanco.Visible = false;
            this.btnbuscarbanco.Click += new System.EventHandler(this.btnbuscarbanco_Click_1);
            // 
            // btnexecutar
            // 
            this.btnexecutar.Location = new System.Drawing.Point(432, 265);
            this.btnexecutar.Name = "btnexecutar";
            this.btnexecutar.Size = new System.Drawing.Size(129, 36);
            this.btnexecutar.TabIndex = 31;
            this.btnexecutar.Text = "Executar a Restauração";
            this.btnexecutar.UseVisualStyleBackColor = true;
            this.btnexecutar.Click += new System.EventHandler(this.btnexecutar_Click);
            // 
            // btnbuscardir
            // 
            this.btnbuscardir.Location = new System.Drawing.Point(465, 205);
            this.btnbuscardir.Name = "btnbuscardir";
            this.btnbuscardir.Size = new System.Drawing.Size(110, 36);
            this.btnbuscardir.TabIndex = 30;
            this.btnbuscardir.Text = "Buscar arquivo de backup";
            this.btnbuscardir.UseVisualStyleBackColor = true;
            this.btnbuscardir.Click += new System.EventHandler(this.btnbuscardir_Click);
            // 
            // txtnomebanco
            // 
            this.txtnomebanco.Location = new System.Drawing.Point(152, 167);
            this.txtnomebanco.Name = "txtnomebanco";
            this.txtnomebanco.Size = new System.Drawing.Size(292, 20);
            this.txtnomebanco.TabIndex = 29;
            // 
            // lblnomebanco
            // 
            this.lblnomebanco.AutoSize = true;
            this.lblnomebanco.Location = new System.Drawing.Point(50, 167);
            this.lblnomebanco.Name = "lblnomebanco";
            this.lblnomebanco.Size = new System.Drawing.Size(86, 13);
            this.lblnomebanco.TabIndex = 34;
            this.lblnomebanco.Text = "Nome do banco:";
            // 
            // txtcaminobackup
            // 
            this.txtcaminobackup.Location = new System.Drawing.Point(149, 207);
            this.txtcaminobackup.Name = "txtcaminobackup";
            this.txtcaminobackup.ReadOnly = true;
            this.txtcaminobackup.Size = new System.Drawing.Size(295, 20);
            this.txtcaminobackup.TabIndex = 33;
            // 
            // lblcaminhobakup
            // 
            this.lblcaminhobakup.AutoSize = true;
            this.lblcaminhobakup.Location = new System.Drawing.Point(50, 205);
            this.lblcaminhobakup.Name = "lblcaminhobakup";
            this.lblcaminhobakup.Size = new System.Drawing.Size(77, 13);
            this.lblcaminhobakup.TabIndex = 32;
            this.lblcaminhobakup.Text = "Buscar Dados:";
            // 
            // txtsenhabanco
            // 
            this.txtsenhabanco.Location = new System.Drawing.Point(446, 121);
            this.txtsenhabanco.Name = "txtsenhabanco";
            this.txtsenhabanco.Size = new System.Drawing.Size(138, 20);
            this.txtsenhabanco.TabIndex = 28;
            this.txtsenhabanco.UseSystemPasswordChar = true;
            // 
            // txtloginbanco
            // 
            this.txtloginbanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtloginbanco.Location = new System.Drawing.Point(152, 121);
            this.txtloginbanco.Name = "txtloginbanco";
            this.txtloginbanco.Size = new System.Drawing.Size(171, 20);
            this.txtloginbanco.TabIndex = 26;
            // 
            // txtservidor
            // 
            this.txtservidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtservidor.Location = new System.Drawing.Point(135, 73);
            this.txtservidor.Name = "txtservidor";
            this.txtservidor.Size = new System.Drawing.Size(188, 20);
            this.txtservidor.TabIndex = 22;
            this.txtservidor.Text = "LOCALHOST";
            // 
            // txtinstancia
            // 
            this.txtinstancia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtinstancia.Location = new System.Drawing.Point(432, 73);
            this.txtinstancia.Name = "txtinstancia";
            this.txtinstancia.Size = new System.Drawing.Size(152, 20);
            this.txtinstancia.TabIndex = 24;
            this.txtinstancia.Text = "OBJETIVA";
            // 
            // lblsenhabanc
            // 
            this.lblsenhabanc.AutoSize = true;
            this.lblsenhabanc.Location = new System.Drawing.Point(341, 124);
            this.lblsenhabanc.Name = "lblsenhabanc";
            this.lblsenhabanc.Size = new System.Drawing.Size(106, 13);
            this.lblsenhabanc.TabIndex = 27;
            this.lblsenhabanc.Text = "SENHA DO BANCO:";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(50, 124);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(102, 13);
            this.lbllogin.TabIndex = 25;
            this.lbllogin.Text = "LOGIN DO BANCO:";
            // 
            // lbinstancia
            // 
            this.lbinstancia.AutoSize = true;
            this.lbinstancia.Location = new System.Drawing.Point(341, 76);
            this.lbinstancia.Name = "lbinstancia";
            this.lbinstancia.Size = new System.Drawing.Size(67, 13);
            this.lbinstancia.TabIndex = 23;
            this.lbinstancia.Text = "INSTANCIA:";
            // 
            // lblservidor
            // 
            this.lblservidor.AutoSize = true;
            this.lblservidor.Location = new System.Drawing.Point(50, 76);
            this.lblservidor.Name = "lblservidor";
            this.lblservidor.Size = new System.Drawing.Size(66, 13);
            this.lblservidor.TabIndex = 21;
            this.lblservidor.Text = "SERVIDOR:";
            // 
            // cbxtipobanco
            // 
            this.cbxtipobanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtipobanco.FormattingEnabled = true;
            this.cbxtipobanco.Items.AddRange(new object[] {
            "SQL SERVER",
            "FIREBIRD"});
            this.cbxtipobanco.Location = new System.Drawing.Point(241, 25);
            this.cbxtipobanco.Name = "cbxtipobanco";
            this.cbxtipobanco.Size = new System.Drawing.Size(121, 21);
            this.cbxtipobanco.TabIndex = 20;
            this.cbxtipobanco.SelectedValueChanged += new System.EventHandler(this.cbxtipobanco_SelectedValueChanged);
            // 
            // lbltipobanco
            // 
            this.lbltipobanco.AutoSize = true;
            this.lbltipobanco.Location = new System.Drawing.Point(50, 28);
            this.lbltipobanco.Name = "lbltipobanco";
            this.lbltipobanco.Size = new System.Drawing.Size(185, 13);
            this.lbltipobanco.TabIndex = 19;
            this.lbltipobanco.Text = "Selecione o Tipo do banco de dados:";
            // 
            // FormRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 366);
            this.Controls.Add(this.lststatus);
            this.Controls.Add(this.btnbuscarbanco);
            this.Controls.Add(this.btnexecutar);
            this.Controls.Add(this.btnbuscardir);
            this.Controls.Add(this.txtnomebanco);
            this.Controls.Add(this.lblnomebanco);
            this.Controls.Add(this.txtcaminobackup);
            this.Controls.Add(this.lblcaminhobakup);
            this.Controls.Add(this.txtsenhabanco);
            this.Controls.Add(this.txtloginbanco);
            this.Controls.Add(this.txtservidor);
            this.Controls.Add(this.txtinstancia);
            this.Controls.Add(this.lblsenhabanc);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.lbinstancia);
            this.Controls.Add(this.lblservidor);
            this.Controls.Add(this.cbxtipobanco);
            this.Controls.Add(this.lbltipobanco);
            this.Name = "FormRestore";
            this.Text = "Restauração do Banco de dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OPbuscararquivos;
        private System.Windows.Forms.ListBox lststatus;
        private System.Windows.Forms.Button btnbuscarbanco;
        private System.Windows.Forms.Button btnexecutar;
        private System.Windows.Forms.Button btnbuscardir;
        private System.Windows.Forms.TextBox txtnomebanco;
        private System.Windows.Forms.Label lblnomebanco;
        private System.Windows.Forms.TextBox txtcaminobackup;
        private System.Windows.Forms.Label lblcaminhobakup;
        private System.Windows.Forms.TextBox txtsenhabanco;
        private System.Windows.Forms.TextBox txtloginbanco;
        private System.Windows.Forms.TextBox txtservidor;
        private System.Windows.Forms.TextBox txtinstancia;
        private System.Windows.Forms.Label lblsenhabanc;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lbinstancia;
        private System.Windows.Forms.Label lblservidor;
        private System.Windows.Forms.ComboBox cbxtipobanco;
        private System.Windows.Forms.Label lbltipobanco;
    }
}