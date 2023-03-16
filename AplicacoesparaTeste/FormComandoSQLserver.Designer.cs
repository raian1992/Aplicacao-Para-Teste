namespace AplicacoesparaTeste
{
    partial class FormComandoSQLserver
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
            this.btnexecutar = new System.Windows.Forms.Button();
            this.btnroolback = new System.Windows.Forms.Button();
            this.opcoesexecucao = new System.Windows.Forms.GroupBox();
            this.btncomit = new System.Windows.Forms.Button();
            this.dgvresultado = new System.Windows.Forms.DataGridView();
            this.txtcomandossqls = new System.Windows.Forms.TextBox();
            this.btndesconectar = new System.Windows.Forms.Button();
            this.btnconectado = new System.Windows.Forms.Button();
            this.OPbuscararquivos = new System.Windows.Forms.OpenFileDialog();
            this.statusconectado = new System.Windows.Forms.Label();
            this.lblnomebanco = new System.Windows.Forms.Label();
            this.txtsenhabanco = new System.Windows.Forms.TextBox();
            this.txtloginbanco = new System.Windows.Forms.TextBox();
            this.lblsenhabanc = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblservidor = new System.Windows.Forms.Label();
            this.cbxservidor = new System.Windows.Forms.ComboBox();
            this.cbxbanco = new System.Windows.Forms.ComboBox();
            this.chkwindwos = new System.Windows.Forms.CheckBox();
            this.opcoesexecucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexecutar
            // 
            this.btnexecutar.Location = new System.Drawing.Point(68, 19);
            this.btnexecutar.Name = "btnexecutar";
            this.btnexecutar.Size = new System.Drawing.Size(75, 23);
            this.btnexecutar.TabIndex = 52;
            this.btnexecutar.Text = "Executar";
            this.btnexecutar.UseVisualStyleBackColor = true;
            this.btnexecutar.Click += new System.EventHandler(this.btnexecutar_Click);
            // 
            // btnroolback
            // 
            this.btnroolback.Location = new System.Drawing.Point(524, 19);
            this.btnroolback.Name = "btnroolback";
            this.btnroolback.Size = new System.Drawing.Size(75, 23);
            this.btnroolback.TabIndex = 54;
            this.btnroolback.Text = "Roolback";
            this.btnroolback.UseVisualStyleBackColor = true;
            this.btnroolback.Click += new System.EventHandler(this.btnroolback_Click);
            // 
            // opcoesexecucao
            // 
            this.opcoesexecucao.Controls.Add(this.btnexecutar);
            this.opcoesexecucao.Controls.Add(this.btncomit);
            this.opcoesexecucao.Controls.Add(this.btnroolback);
            this.opcoesexecucao.Location = new System.Drawing.Point(65, 93);
            this.opcoesexecucao.Name = "opcoesexecucao";
            this.opcoesexecucao.Size = new System.Drawing.Size(889, 64);
            this.opcoesexecucao.TabIndex = 66;
            this.opcoesexecucao.TabStop = false;
            this.opcoesexecucao.Text = "Selecione o Tipo de Execução";
            this.opcoesexecucao.Visible = false;
            // 
            // btncomit
            // 
            this.btncomit.Location = new System.Drawing.Point(286, 19);
            this.btncomit.Name = "btncomit";
            this.btncomit.Size = new System.Drawing.Size(75, 23);
            this.btncomit.TabIndex = 53;
            this.btncomit.Text = "Comit";
            this.btncomit.UseVisualStyleBackColor = true;
            this.btncomit.Click += new System.EventHandler(this.btncomit_Click);
            // 
            // dgvresultado
            // 
            this.dgvresultado.AllowUserToAddRows = false;
            this.dgvresultado.AllowUserToDeleteRows = false;
            this.dgvresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvresultado.Location = new System.Drawing.Point(65, 340);
            this.dgvresultado.Name = "dgvresultado";
            this.dgvresultado.ReadOnly = true;
            this.dgvresultado.Size = new System.Drawing.Size(889, 226);
            this.dgvresultado.TabIndex = 65;
            this.dgvresultado.Visible = false;
            // 
            // txtcomandossqls
            // 
            this.txtcomandossqls.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcomandossqls.Location = new System.Drawing.Point(65, 163);
            this.txtcomandossqls.Multiline = true;
            this.txtcomandossqls.Name = "txtcomandossqls";
            this.txtcomandossqls.Size = new System.Drawing.Size(889, 158);
            this.txtcomandossqls.TabIndex = 64;
            this.txtcomandossqls.Visible = false;
            // 
            // btndesconectar
            // 
            this.btndesconectar.Location = new System.Drawing.Point(752, 56);
            this.btndesconectar.Name = "btndesconectar";
            this.btndesconectar.Size = new System.Drawing.Size(83, 23);
            this.btndesconectar.TabIndex = 62;
            this.btndesconectar.Text = "Desconectar";
            this.btndesconectar.UseVisualStyleBackColor = true;
            this.btndesconectar.Visible = false;
            this.btndesconectar.Click += new System.EventHandler(this.btndesconectar_Click);
            // 
            // btnconectado
            // 
            this.btnconectado.Location = new System.Drawing.Point(751, 6);
            this.btnconectado.Name = "btnconectado";
            this.btnconectado.Size = new System.Drawing.Size(84, 23);
            this.btnconectado.TabIndex = 61;
            this.btnconectado.Text = "Conectar";
            this.btnconectado.UseVisualStyleBackColor = true;
            this.btnconectado.Click += new System.EventHandler(this.btnconectado_Click);
            // 
            // OPbuscararquivos
            // 
            this.OPbuscararquivos.FileName = "openFileDialog1";
            // 
            // statusconectado
            // 
            this.statusconectado.AutoSize = true;
            this.statusconectado.Location = new System.Drawing.Point(824, 38);
            this.statusconectado.Name = "statusconectado";
            this.statusconectado.Size = new System.Drawing.Size(97, 13);
            this.statusconectado.TabIndex = 63;
            this.statusconectado.Text = "Status da Conexao";
            // 
            // lblnomebanco
            // 
            this.lblnomebanco.AutoSize = true;
            this.lblnomebanco.Location = new System.Drawing.Point(56, 59);
            this.lblnomebanco.Name = "lblnomebanco";
            this.lblnomebanco.Size = new System.Drawing.Size(86, 13);
            this.lblnomebanco.TabIndex = 59;
            this.lblnomebanco.Text = "Nome do banco:";
            // 
            // txtsenhabanco
            // 
            this.txtsenhabanco.Location = new System.Drawing.Point(575, 56);
            this.txtsenhabanco.Name = "txtsenhabanco";
            this.txtsenhabanco.Size = new System.Drawing.Size(171, 20);
            this.txtsenhabanco.TabIndex = 57;
            this.txtsenhabanco.Text = "SA_0bjetiva";
            this.txtsenhabanco.UseSystemPasswordChar = true;
            // 
            // txtloginbanco
            // 
            this.txtloginbanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtloginbanco.Location = new System.Drawing.Point(571, 9);
            this.txtloginbanco.Name = "txtloginbanco";
            this.txtloginbanco.Size = new System.Drawing.Size(171, 20);
            this.txtloginbanco.TabIndex = 55;
            this.txtloginbanco.Text = "SA";
            // 
            // lblsenhabanc
            // 
            this.lblsenhabanc.AutoSize = true;
            this.lblsenhabanc.Location = new System.Drawing.Point(470, 63);
            this.lblsenhabanc.Name = "lblsenhabanc";
            this.lblsenhabanc.Size = new System.Drawing.Size(106, 13);
            this.lblsenhabanc.TabIndex = 56;
            this.lblsenhabanc.Text = "SENHA DO BANCO:";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(470, 16);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(102, 13);
            this.lbllogin.TabIndex = 54;
            this.lbllogin.Text = "LOGIN DO BANCO:";
            // 
            // lblservidor
            // 
            this.lblservidor.AutoSize = true;
            this.lblservidor.Location = new System.Drawing.Point(83, 19);
            this.lblservidor.Name = "lblservidor";
            this.lblservidor.Size = new System.Drawing.Size(66, 13);
            this.lblservidor.TabIndex = 52;
            this.lblservidor.Text = "SERVIDOR:";
            // 
            // cbxservidor
            // 
            this.cbxservidor.FormattingEnabled = true;
            this.cbxservidor.Location = new System.Drawing.Point(161, 13);
            this.cbxservidor.Name = "cbxservidor";
            this.cbxservidor.Size = new System.Drawing.Size(191, 21);
            this.cbxservidor.TabIndex = 67;
            // 
            // cbxbanco
            // 
            this.cbxbanco.FormattingEnabled = true;
            this.cbxbanco.Location = new System.Drawing.Point(161, 56);
            this.cbxbanco.Name = "cbxbanco";
            this.cbxbanco.Size = new System.Drawing.Size(191, 21);
            this.cbxbanco.TabIndex = 68;
            this.cbxbanco.Click += new System.EventHandler(this.cbxbanco_click);
            // 
            // chkwindwos
            // 
            this.chkwindwos.AutoSize = true;
            this.chkwindwos.Location = new System.Drawing.Point(353, 37);
            this.chkwindwos.Name = "chkwindwos";
            this.chkwindwos.Size = new System.Drawing.Size(136, 17);
            this.chkwindwos.TabIndex = 69;
            this.chkwindwos.Text = "Autenticação Windwos";
            this.chkwindwos.UseVisualStyleBackColor = true;
            this.chkwindwos.CheckedChanged += new System.EventHandler(this.chkwindwos_CheckedChanged);
            // 
            // FormComandoSQLserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 590);
            this.Controls.Add(this.chkwindwos);
            this.Controls.Add(this.cbxbanco);
            this.Controls.Add(this.cbxservidor);
            this.Controls.Add(this.opcoesexecucao);
            this.Controls.Add(this.dgvresultado);
            this.Controls.Add(this.txtcomandossqls);
            this.Controls.Add(this.btndesconectar);
            this.Controls.Add(this.btnconectado);
            this.Controls.Add(this.statusconectado);
            this.Controls.Add(this.lblnomebanco);
            this.Controls.Add(this.txtsenhabanco);
            this.Controls.Add(this.txtloginbanco);
            this.Controls.Add(this.lblsenhabanc);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.lblservidor);
            this.Name = "FormComandoSQLserver";
            this.Text = "Comandos SQL ( SQL SERVER)";
            this.Load += new System.EventHandler(this.FormComandoSQLserver_Load);
            this.opcoesexecucao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvresultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexecutar;
        private System.Windows.Forms.Button btnroolback;
        private System.Windows.Forms.GroupBox opcoesexecucao;
        private System.Windows.Forms.Button btncomit;
        private System.Windows.Forms.DataGridView dgvresultado;
        private System.Windows.Forms.TextBox txtcomandossqls;
        private System.Windows.Forms.Button btndesconectar;
        private System.Windows.Forms.Button btnconectado;
        private System.Windows.Forms.OpenFileDialog OPbuscararquivos;
        private System.Windows.Forms.Label statusconectado;
        private System.Windows.Forms.Label lblnomebanco;
        private System.Windows.Forms.TextBox txtsenhabanco;
        private System.Windows.Forms.TextBox txtloginbanco;
        private System.Windows.Forms.Label lblsenhabanc;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblservidor;
        private System.Windows.Forms.ComboBox cbxservidor;
        private System.Windows.Forms.ComboBox cbxbanco;
        private System.Windows.Forms.CheckBox chkwindwos;
    }
}