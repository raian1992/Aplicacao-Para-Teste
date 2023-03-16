using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;
using System.Net;
using System.Data.SqlClient;
using FirebirdSql;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Services;
using System.IO;

namespace AplicacoesparaTeste
{
    public partial class FormBackup : Form
    {
        public FormBackup()
        {
            InitializeComponent();
            txtinstancia.Visible = false;
            lbinstancia.Visible = false;
            btnbuscardir.Visible = false;
            btnexecutar.Visible = false;
        }

        static string hostlocal;
        static string iplocal;

        private void backupsqlserver()
        {
            if (txtcaminobackup.Text != "" && txtloginbanco.Text != "" && txtsenhabanco.Text != "" && txtnomebanco.Text != "")
            {
                try
                {
                    string stringconexao = "";
                    if (txtinstancia.Text != "")
                    {
                        stringconexao = "Data Source= " + txtservidor.Text.ToUpper() + ".\\" + txtinstancia.Text.ToUpper() + "; Database=" + txtnomebanco.Text.ToUpper() +
                            " ;USER Id=" + txtloginbanco.Text + " ;Password=" + txtsenhabanco.Text;
                    }
                    else
                    {

                    }

                    using (SqlConnection conexao = new SqlConnection(stringconexao))
                    {
                        SqlCommand comando = new SqlCommand("BACKUP DATABASE [" + txtnomebanco.Text.ToUpper() + "] TO DISK = N'"
                            + txtcaminobackup.Text.ToUpper() + "\\" + txtnomebanco.Text.ToUpper() + DateTime.Now.Date.ToString("dd-MM-yyyy") + ".bak'" + " WITH NOFORMAT, NOINIT,  NAME = N'"
                            + txtnomebanco.Text.ToUpper() + "-" + DateTime.Now.Date.ToString("dd-MM-yyyy") + "', SKIP, NOREWIND, NOUNLOAD,  STATS = 10", conexao);


                        conexao.Open();

                        int retorno = comando.ExecuteNonQuery();
                        lststatus.Items.Add("100 % - Backup terminado");

                        conexao.Close();
                        if (retorno == -1)
                        {
                            MessageBox.Show("backup efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    //var servidor = new 
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ocorreu um erro:" + ex, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS CORRETAMENTE", "PREENCHIMENTO DOS CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnexecutar_Click(object sender, EventArgs e)
        {
            btnbuscardir.Enabled = false;
            btnexecutar.Enabled = false;
            lststatus.Items.Clear();
            lststatus.Items.Add("");

            string caminhobanco = "";


            if (cbxtipobanco.Text == "SQL SERVER")
            {
                if (hostlocal.ToUpper() == txtservidor.Text.ToUpper() || iplocal == txtservidor.Text.ToUpper() || txtservidor.Text.ToUpper() == "LOCALHOST")
                {
                    caminhobanco = txtcaminobackup.Text.ToUpper() + "\\" + txtnomebanco.Text.ToUpper() + DateTime.Now.Date.ToString("dd-MM-yyyy") + ".bak'";

                    if (!File.Exists(caminhobanco))
                    {
                        backupsqlserver();
                    }
                    else
                    {
                        File.Delete(caminhobanco);
                        backupsqlserver();
                    }
                }

            }

            if (cbxtipobanco.Text == "FIREBIRD")
            {
                if (hostlocal.ToUpper() == txtservidor.Text.ToUpper() || iplocal == txtservidor.Text.ToUpper() || txtservidor.Text.ToUpper() == "LOCALHOST")
                {
                    caminhobanco = txtcaminobackup.Text + "\\" + "backup_firebird -" + DateTime.Now.Date.ToString("dd-MM-yyyy") + ".gbk";
                    if (!File.Exists(caminhobanco))
                    {
                        backupfirebird();
                    }
                    else
                    {
                        File.Delete(caminhobanco);
                        backupfirebird();
                    }
                }


            }
            if (cbxtipobanco.Text != "FIREBIRD" && cbxtipobanco.Text != "SQL SERVER")
            {
                MessageBox.Show("Por favor informe o tipo do banco de dados", "Selecione o Tipo de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnbuscardir.Enabled = true;
            btnexecutar.Enabled = true;
        }

        private void btnbuscardir_Click(object sender, EventArgs e)
        {
            if (buscarpastas.ShowDialog() == DialogResult.OK)
            {
                txtcaminobackup.Text = buscarpastas.SelectedPath;

            }
        }


        private void backupfirebird()
        {
            if (txtcaminobackup.Text != "" && txtloginbanco.Text != "" && txtsenhabanco.Text != "" && txtnomebanco.Text != "")
            {
                try
                {
                    string caminhobanco = txtcaminobackup.Text + "\\" + "backup_firebird -" + DateTime.Now.Date.ToString("dd-MM-yyyy") + ".gbk";



                    FbConnectionStringBuilder conexaofb = new FbConnectionStringBuilder();
                    conexaofb.UserID = txtloginbanco.Text.ToUpper();
                    conexaofb.Password = txtsenhabanco.Text.ToLower();
                    conexaofb.Database = txtnomebanco.Text;

                    FbBackup backufb = new FbBackup();
                    backufb.ConnectionString = conexaofb.ToString();
                    backufb.BackupFiles.Add(new FbBackupFile(@caminhobanco, 2048));
                    backufb.Verbose = true;
                    backufb.Options = FbBackupFlags.IgnoreLimbo;
                    backufb.ServiceOutput += new ServiceOutputEventHandler(ServiceOutput); //mensagem de envio

                    backufb.Execute();

                    MessageBox.Show("backup efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FbException ex)
                {

                    MessageBox.Show("ocorreu um erro:" + ex, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS CORRETAMENTE", "PREENCHIMENTO DOS CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ServiceOutput(object sender, ServiceOutputEventArgs e)
        {
            this.lststatus.Items.Add(e.Message); // elaborar essa parte
            lststatus.Update();
            int conta = lststatus.Items.Count - 1;
            lststatus.SelectedIndex = lststatus.Items.Count - 1;
            Application.DoEvents();
        }

        private void cbxtipobanco_SelectedValueChanged(object sender, EventArgs e)
        {

            hostlocal = Dns.GetHostName();
            iplocal = Dns.GetHostAddresses(hostlocal)[2].ToString();

            if (cbxtipobanco.Text == "FIREBIRD")
            {
                txtinstancia.Visible = false;
                lbinstancia.Visible = false;
                txtloginbanco.Text = "SYSDBA";
                txtsenhabanco.Text = "masterkey";
                btnbuscardir.TabIndex = 8;
                btnexecutar.TabIndex = 9;
                btnbuscarbanco.Visible = true;
                btnbuscardir.Visible = true;
                btnexecutar.Visible = true;
                txtnomebanco.Text = "";


            }

            if (cbxtipobanco.Text == "SQL SERVER")
            {
                txtinstancia.Visible = true;
                lbinstancia.Visible = true;
                txtloginbanco.Text = "SA";
                txtsenhabanco.Text = "SA_0bjetiva";
                btnbuscardir.TabIndex = 7;
                btnexecutar.TabIndex = 8;
                btnbuscarbanco.Visible = false;
                btnbuscardir.Visible = true;
                btnexecutar.Visible = true;
                txtnomebanco.Text = "";


            }


        }

        private void btnbuscarbanco_Click(object sender, EventArgs e)
        {
            OPbuscararquivos.Filter = "Arquivos de banco de dados(*.FDB;*.GDB;*.RED;)|*.FDB;*.GDB;*.RED;";
            OPbuscararquivos.Title = "Selecione o Banco";
            OPbuscararquivos.FileName = "BANCO.FDB";
            OPbuscararquivos.CheckFileExists = true;
            OPbuscararquivos.CheckPathExists = true;
            OPbuscararquivos.FilterIndex = 2;

            if (OPbuscararquivos.ShowDialog() == DialogResult.OK)
            {
                txtnomebanco.Text = OPbuscararquivos.FileName;

            }
        }

    }
}

