namespace AplicacoesparaTeste
{
    partial class FormCOMANDOSFIREBIRD
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
            this.btnbuscarbanco = new System.Windows.Forms.Button();
            this.txtnomebanco = new System.Windows.Forms.TextBox();
            this.lblnomebanco = new System.Windows.Forms.Label();
            this.txtsenhabanco = new System.Windows.Forms.TextBox();
            this.txtloginbanco = new System.Windows.Forms.TextBox();
            this.txtservidor = new System.Windows.Forms.TextBox();
            this.lblsenhabanc = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblservidor = new System.Windows.Forms.Label();
            this.btnconectado = new System.Windows.Forms.Button();
            this.btndesconectar = new System.Windows.Forms.Button();
            this.statusconectado = new System.Windows.Forms.Label();
            this.OPbuscararquivos = new System.Windows.Forms.OpenFileDialog();
            this.txtcomandossqls = new System.Windows.Forms.TextBox();
            this.dgvresultado = new System.Windows.Forms.DataGridView();
            this.opcoesexecucao = new System.Windows.Forms.GroupBox();
            this.btnexecutar = new System.Windows.Forms.Button();
            this.btncomit = new System.Windows.Forms.Button();
            this.btnroolback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresultado)).BeginInit();
            this.opcoesexecucao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbuscarbanco
            // 
            this.btnbuscarbanco.Location = new System.Drawing.Point(298, 53);
            this.btnbuscarbanco.Name = "btnbuscarbanco";
            this.btnbuscarbanco.Size = new System.Drawing.Size(96, 23);
            this.btnbuscarbanco.TabIndex = 3;
            this.btnbuscarbanco.Text = "Buscar Banco";
            this.btnbuscarbanco.UseVisualStyleBackColor = true;
            this.btnbuscarbanco.Click += new System.EventHandler(this.btnbuscarbanco_Click_1);
            // 
            // txtnomebanco
            // 
            this.txtnomebanco.Location = new System.Drawing.Point(103, 55);
            this.txtnomebanco.Name = "txtnomebanco";
            this.txtnomebanco.Size = new System.Drawing.Size(188, 20);
            this.txtnomebanco.TabIndex = 2;
            // 
            // lblnomebanco
            // 
            this.lblnomebanco.AutoSize = true;
            this.lblnomebanco.Location = new System.Drawing.Point(3, 61);
            this.lblnomebanco.Name = "lblnomebanco";
            this.lblnomebanco.Size = new System.Drawing.Size(99, 13);
            this.lblnomebanco.TabIndex = 44;
            this.lblnomebanco.Text = "Caminho do banco:";
            // 
            // txtsenhabanco
            // 
            this.txtsenhabanco.Location = new System.Drawing.Point(522, 58);
            this.txtsenhabanco.Name = "txtsenhabanco";
            this.txtsenhabanco.Size = new System.Drawing.Size(171, 20);
            this.txtsenhabanco.TabIndex = 5;
            this.txtsenhabanco.Text = "masterkey";
            this.txtsenhabanco.UseSystemPasswordChar = true;
            // 
            // txtloginbanco
            // 
            this.txtloginbanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtloginbanco.Location = new System.Drawing.Point(518, 11);
            this.txtloginbanco.Name = "txtloginbanco";
            this.txtloginbanco.Size = new System.Drawing.Size(171, 20);
            this.txtloginbanco.TabIndex = 4;
            this.txtloginbanco.Text = "SYSDBA";
            // 
            // txtservidor
            // 
            this.txtservidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtservidor.Location = new System.Drawing.Point(102, 18);
            this.txtservidor.Name = "txtservidor";
            this.txtservidor.Size = new System.Drawing.Size(188, 20);
            this.txtservidor.TabIndex = 1;
            this.txtservidor.Text = "LOCALHOST";
            // 
            // lblsenhabanc
            // 
            this.lblsenhabanc.AutoSize = true;
            this.lblsenhabanc.Location = new System.Drawing.Point(417, 65);
            this.lblsenhabanc.Name = "lblsenhabanc";
            this.lblsenhabanc.Size = new System.Drawing.Size(106, 13);
            this.lblsenhabanc.TabIndex = 41;
            this.lblsenhabanc.Text = "SENHA DO BANCO:";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(417, 18);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(102, 13);
            this.lbllogin.TabIndex = 39;
            this.lbllogin.Text = "LOGIN DO BANCO:";
            // 
            // lblservidor
            // 
            this.lblservidor.AutoSize = true;
            this.lblservidor.Location = new System.Drawing.Point(30, 21);
            this.lblservidor.Name = "lblservidor";
            this.lblservidor.Size = new System.Drawing.Size(66, 13);
            this.lblservidor.TabIndex = 37;
            this.lblservidor.Text = "SERVIDOR:";
            // 
            // btnconectado
            // 
            this.btnconectado.Location = new System.Drawing.Point(698, 8);
            this.btnconectado.Name = "btnconectado";
            this.btnconectado.Size = new System.Drawing.Size(84, 23);
            this.btnconectado.TabIndex = 6;
            this.btnconectado.Text = "Conectar";
            this.btnconectado.UseVisualStyleBackColor = true;
            this.btnconectado.Click += new System.EventHandler(this.btnconectado_Click);
            // 
            // btndesconectar
            // 
            this.btndesconectar.Location = new System.Drawing.Point(699, 58);
            this.btndesconectar.Name = "btndesconectar";
            this.btndesconectar.Size = new System.Drawing.Size(83, 23);
            this.btndesconectar.TabIndex = 7;
            this.btndesconectar.Text = "Desconectar";
            this.btndesconectar.UseVisualStyleBackColor = true;
            this.btndesconectar.Visible = false;
            this.btndesconectar.Click += new System.EventHandler(this.btndesconectar_Click);
            // 
            // statusconectado
            // 
            this.statusconectado.AutoSize = true;
            this.statusconectado.Location = new System.Drawing.Point(771, 40);
            this.statusconectado.Name = "statusconectado";
            this.statusconectado.Size = new System.Drawing.Size(97, 13);
            this.statusconectado.TabIndex = 48;
            this.statusconectado.Text = "Status da Conexao";
            // 
            // OPbuscararquivos
            // 
            this.OPbuscararquivos.FileName = "openFileDialog1";
            // 
            // txtcomandossqls
            // 
            this.txtcomandossqls.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcomandossqls.Location = new System.Drawing.Point(12, 165);
            this.txtcomandossqls.Multiline = true;
            this.txtcomandossqls.Name = "txtcomandossqls";
            this.txtcomandossqls.Size = new System.Drawing.Size(889, 158);
            this.txtcomandossqls.TabIndex = 8;
            this.txtcomandossqls.Visible = false;
            // 
            // dgvresultado
            // 
            this.dgvresultado.AllowUserToAddRows = false;
            this.dgvresultado.AllowUserToDeleteRows = false;
            this.dgvresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvresultado.Location = new System.Drawing.Point(12, 342);
            this.dgvresultado.Name = "dgvresultado";
            this.dgvresultado.ReadOnly = true;
            this.dgvresultado.Size = new System.Drawing.Size(889, 226);
            this.dgvresultado.TabIndex = 12;
            this.dgvresultado.Visible = false;
            // 
            // opcoesexecucao
            // 
            this.opcoesexecucao.Controls.Add(this.btnexecutar);
            this.opcoesexecucao.Controls.Add(this.btncomit);
            this.opcoesexecucao.Controls.Add(this.btnroolback);
            this.opcoesexecucao.Location = new System.Drawing.Point(12, 95);
            this.opcoesexecucao.Name = "opcoesexecucao";
            this.opcoesexecucao.Size = new System.Drawing.Size(889, 64);
            this.opcoesexecucao.TabIndex = 51;
            this.opcoesexecucao.TabStop = false;
            this.opcoesexecucao.Text = "Selecione o Tipo de Execução";
            this.opcoesexecucao.Visible = false;
            // 
            // btnexecutar
            // 
            this.btnexecutar.Location = new System.Drawing.Point(68, 19);
            this.btnexecutar.Name = "btnexecutar";
            this.btnexecutar.Size = new System.Drawing.Size(75, 23);
            this.btnexecutar.TabIndex = 9;
            this.btnexecutar.Text = "Executar";
            this.btnexecutar.UseVisualStyleBackColor = true;
            this.btnexecutar.Click += new System.EventHandler(this.btnexecutar_Click);
            // 
            // btncomit
            // 
            this.btncomit.Location = new System.Drawing.Point(286, 19);
            this.btncomit.Name = "btncomit";
            this.btncomit.Size = new System.Drawing.Size(75, 23);
            this.btncomit.TabIndex = 10;
            this.btncomit.Text = "Comit";
            this.btncomit.UseVisualStyleBackColor = true;
            this.btncomit.Click += new System.EventHandler(this.btncomit_Click);
            // 
            // btnroolback
            // 
            this.btnroolback.Location = new System.Drawing.Point(524, 19);
            this.btnroolback.Name = "btnroolback";
            this.btnroolback.Size = new System.Drawing.Size(75, 23);
            this.btnroolback.TabIndex = 11;
            this.btnroolback.Text = "Roolback";
            this.btnroolback.UseVisualStyleBackColor = true;
            this.btnroolback.Click += new System.EventHandler(this.btnroolback_Click);
            // 
            // FormCOMANDOSFIREBIRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 580);
            this.Controls.Add(this.opcoesexecucao);
            this.Controls.Add(this.dgvresultado);
            this.Controls.Add(this.txtcomandossqls);
            this.Controls.Add(this.statusconectado);
            this.Controls.Add(this.btndesconectar);
            this.Controls.Add(this.btnconectado);
            this.Controls.Add(this.btnbuscarbanco);
            this.Controls.Add(this.txtnomebanco);
            this.Controls.Add(this.lblnomebanco);
            this.Controls.Add(this.txtsenhabanco);
            this.Controls.Add(this.txtloginbanco);
            this.Controls.Add(this.txtservidor);
            this.Controls.Add(this.lblsenhabanc);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.lblservidor);
            this.Name = "FormCOMANDOSFIREBIRD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comandos SQLS (firebird)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvresultado)).EndInit();
            this.opcoesexecucao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscarbanco;
        private System.Windows.Forms.TextBox txtnomebanco;
        private System.Windows.Forms.Label lblnomebanco;
        private System.Windows.Forms.TextBox txtsenhabanco;
        private System.Windows.Forms.TextBox txtloginbanco;
        private System.Windows.Forms.TextBox txtservidor;
        private System.Windows.Forms.Label lblsenhabanc;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblservidor;
        private System.Windows.Forms.Button btnconectado;
        private System.Windows.Forms.Button btndesconectar;
        private System.Windows.Forms.Label statusconectado;
        private System.Windows.Forms.OpenFileDialog OPbuscararquivos;
        private System.Windows.Forms.TextBox txtcomandossqls;
        private System.Windows.Forms.DataGridView dgvresultado;
        private System.Windows.Forms.GroupBox opcoesexecucao;
        private System.Windows.Forms.Button btnexecutar;
        private System.Windows.Forms.Button btncomit;
        private System.Windows.Forms.Button btnroolback;
    }
}