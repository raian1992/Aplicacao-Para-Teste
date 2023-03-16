namespace AplicacoesparaTeste
{
    partial class FormBackup
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
            this.lbltipobanco = new System.Windows.Forms.Label();
            this.cbxtipobanco = new System.Windows.Forms.ComboBox();
            this.lblservidor = new System.Windows.Forms.Label();
            this.lbinstancia = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblsenhabanc = new System.Windows.Forms.Label();
            this.txtinstancia = new System.Windows.Forms.TextBox();
            this.txtservidor = new System.Windows.Forms.TextBox();
            this.txtloginbanco = new System.Windows.Forms.TextBox();
            this.txtsenhabanco = new System.Windows.Forms.TextBox();
            this.lblcaminhobakup = new System.Windows.Forms.Label();
            this.txtcaminobackup = new System.Windows.Forms.TextBox();
            this.lblnomebanco = new System.Windows.Forms.Label();
            this.txtnomebanco = new System.Windows.Forms.TextBox();
            this.btnbuscardir = new System.Windows.Forms.Button();
            this.btnexecutar = new System.Windows.Forms.Button();
            this.buscarpastas = new System.Windows.Forms.FolderBrowserDialog();
            this.lststatus = new System.Windows.Forms.ListBox();
            this.btnbuscarbanco = new System.Windows.Forms.Button();
            this.OPbuscararquivos = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbltipobanco
            // 
            this.lbltipobanco.AutoSize = true;
            this.lbltipobanco.Location = new System.Drawing.Point(2, 34);
            this.lbltipobanco.Name = "lbltipobanco";
            this.lbltipobanco.Size = new System.Drawing.Size(185, 13);
            this.lbltipobanco.TabIndex = 0;
            this.lbltipobanco.Text = "Selecione o Tipo do banco de dados:";
            // 
            // cbxtipobanco
            // 
            this.cbxtipobanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtipobanco.FormattingEnabled = true;
            this.cbxtipobanco.Items.AddRange(new object[] {
            "SQL SERVER",
            "FIREBIRD"});
            this.cbxtipobanco.Location = new System.Drawing.Point(193, 31);
            this.cbxtipobanco.Name = "cbxtipobanco";
            this.cbxtipobanco.Size = new System.Drawing.Size(121, 21);
            this.cbxtipobanco.TabIndex = 1;
            this.cbxtipobanco.SelectedValueChanged += new System.EventHandler(this.cbxtipobanco_SelectedValueChanged);
            // 
            // lblservidor
            // 
            this.lblservidor.AutoSize = true;
            this.lblservidor.Location = new System.Drawing.Point(2, 82);
            this.lblservidor.Name = "lblservidor";
            this.lblservidor.Size = new System.Drawing.Size(66, 13);
            this.lblservidor.TabIndex = 2;
            this.lblservidor.Text = "SERVIDOR:";
            // 
            // lbinstancia
            // 
            this.lbinstancia.AutoSize = true;
            this.lbinstancia.Location = new System.Drawing.Point(293, 82);
            this.lbinstancia.Name = "lbinstancia";
            this.lbinstancia.Size = new System.Drawing.Size(67, 13);
            this.lbinstancia.TabIndex = 3;
            this.lbinstancia.Text = "INSTANCIA:";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(2, 130);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(102, 13);
            this.lbllogin.TabIndex = 4;
            this.lbllogin.Text = "LOGIN DO BANCO:";
            // 
            // lblsenhabanc
            // 
            this.lblsenhabanc.AutoSize = true;
            this.lblsenhabanc.Location = new System.Drawing.Point(293, 130);
            this.lblsenhabanc.Name = "lblsenhabanc";
            this.lblsenhabanc.Size = new System.Drawing.Size(106, 13);
            this.lblsenhabanc.TabIndex = 5;
            this.lblsenhabanc.Text = "SENHA DO BANCO:";
            // 
            // txtinstancia
            // 
            this.txtinstancia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtinstancia.Location = new System.Drawing.Point(384, 79);
            this.txtinstancia.Name = "txtinstancia";
            this.txtinstancia.Size = new System.Drawing.Size(152, 20);
            this.txtinstancia.TabIndex = 3;
            this.txtinstancia.Text = "OBJETIVA";
            // 
            // txtservidor
            // 
            this.txtservidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtservidor.Location = new System.Drawing.Point(87, 79);
            this.txtservidor.Name = "txtservidor";
            this.txtservidor.Size = new System.Drawing.Size(188, 20);
            this.txtservidor.TabIndex = 2;
            this.txtservidor.Text = "LOCALHOST";
            // 
            // txtloginbanco
            // 
            this.txtloginbanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtloginbanco.Location = new System.Drawing.Point(104, 127);
            this.txtloginbanco.Name = "txtloginbanco";
            this.txtloginbanco.Size = new System.Drawing.Size(171, 20);
            this.txtloginbanco.TabIndex = 4;
            // 
            // txtsenhabanco
            // 
            this.txtsenhabanco.Location = new System.Drawing.Point(398, 127);
            this.txtsenhabanco.Name = "txtsenhabanco";
            this.txtsenhabanco.Size = new System.Drawing.Size(138, 20);
            this.txtsenhabanco.TabIndex = 5;
            this.txtsenhabanco.UseSystemPasswordChar = true;
            // 
            // lblcaminhobakup
            // 
            this.lblcaminhobakup.AutoSize = true;
            this.lblcaminhobakup.Location = new System.Drawing.Point(-1, 216);
            this.lblcaminhobakup.Name = "lblcaminhobakup";
            this.lblcaminhobakup.Size = new System.Drawing.Size(105, 13);
            this.lblcaminhobakup.TabIndex = 10;
            this.lblcaminhobakup.Text = "Caminho do backup:";
            // 
            // txtcaminobackup
            // 
            this.txtcaminobackup.Location = new System.Drawing.Point(101, 213);
            this.txtcaminobackup.Name = "txtcaminobackup";
            this.txtcaminobackup.ReadOnly = true;
            this.txtcaminobackup.Size = new System.Drawing.Size(295, 20);
            this.txtcaminobackup.TabIndex = 11;
            // 
            // lblnomebanco
            // 
            this.lblnomebanco.AutoSize = true;
            this.lblnomebanco.Location = new System.Drawing.Point(2, 173);
            this.lblnomebanco.Name = "lblnomebanco";
            this.lblnomebanco.Size = new System.Drawing.Size(86, 13);
            this.lblnomebanco.TabIndex = 12;
            this.lblnomebanco.Text = "Nome do banco:";
            // 
            // txtnomebanco
            // 
            this.txtnomebanco.Location = new System.Drawing.Point(104, 173);
            this.txtnomebanco.Name = "txtnomebanco";
            this.txtnomebanco.Size = new System.Drawing.Size(292, 20);
            this.txtnomebanco.TabIndex = 6;
            // 
            // btnbuscardir
            // 
            this.btnbuscardir.Location = new System.Drawing.Point(417, 211);
            this.btnbuscardir.Name = "btnbuscardir";
            this.btnbuscardir.Size = new System.Drawing.Size(95, 23);
            this.btnbuscardir.TabIndex = 8;
            this.btnbuscardir.Text = "Buscar Diretorio";
            this.btnbuscardir.UseVisualStyleBackColor = true;
            this.btnbuscardir.Click += new System.EventHandler(this.btnbuscardir_Click);
            // 
            // btnexecutar
            // 
            this.btnexecutar.Location = new System.Drawing.Point(384, 271);
            this.btnexecutar.Name = "btnexecutar";
            this.btnexecutar.Size = new System.Drawing.Size(129, 36);
            this.btnexecutar.TabIndex = 9;
            this.btnexecutar.Text = "Executar o Backup";
            this.btnexecutar.UseVisualStyleBackColor = true;
            this.btnexecutar.Click += new System.EventHandler(this.btnexecutar_Click);
            // 
            // lststatus
            // 
            this.lststatus.FormattingEnabled = true;
            this.lststatus.Location = new System.Drawing.Point(5, 239);
            this.lststatus.Name = "lststatus";
            this.lststatus.ScrollAlwaysVisible = true;
            this.lststatus.Size = new System.Drawing.Size(373, 108);
            this.lststatus.TabIndex = 17;
            // 
            // btnbuscarbanco
            // 
            this.btnbuscarbanco.Location = new System.Drawing.Point(417, 170);
            this.btnbuscarbanco.Name = "btnbuscarbanco";
            this.btnbuscarbanco.Size = new System.Drawing.Size(96, 23);
            this.btnbuscarbanco.TabIndex = 18;
            this.btnbuscarbanco.Text = "Buscar Banco";
            this.btnbuscarbanco.UseVisualStyleBackColor = true;
            this.btnbuscarbanco.Visible = false;
            this.btnbuscarbanco.Click += new System.EventHandler(this.btnbuscarbanco_Click);
            // 
            // OPbuscararquivos
            // 
            this.OPbuscararquivos.FileName = "openFileDialog1";
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 352);
            this.Controls.Add(this.btnbuscarbanco);
            this.Controls.Add(this.lststatus);
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
            this.Name = "FormBackup";
            this.Text = "Backup Banco de dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltipobanco;
        private System.Windows.Forms.ComboBox cbxtipobanco;
        private System.Windows.Forms.Label lblservidor;
        private System.Windows.Forms.Label lbinstancia;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblsenhabanc;
        private System.Windows.Forms.TextBox txtinstancia;
        private System.Windows.Forms.TextBox txtservidor;
        private System.Windows.Forms.TextBox txtloginbanco;
        private System.Windows.Forms.TextBox txtsenhabanco;
        private System.Windows.Forms.Label lblcaminhobakup;
        private System.Windows.Forms.TextBox txtcaminobackup;
        private System.Windows.Forms.Label lblnomebanco;
        private System.Windows.Forms.TextBox txtnomebanco;
        private System.Windows.Forms.Button btnbuscardir;
        private System.Windows.Forms.Button btnexecutar;
        private System.Windows.Forms.FolderBrowserDialog buscarpastas;
        private System.Windows.Forms.ListBox lststatus;
        private System.Windows.Forms.Button btnbuscarbanco;
        private System.Windows.Forms.OpenFileDialog OPbuscararquivos;
    }
}