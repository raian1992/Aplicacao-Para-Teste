using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FirebirdSql;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Services;
using System.IO;
using Microsoft.SqlServer;
using System.Net;
using Microsoft.SqlServer.Management;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.RegisteredServers;
using Microsoft.SqlServer.Management.Smo.SqlEnum;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Dmf;
using Microsoft.SqlServer.Management.Common;




namespace AplicacoesparaTeste
{
    public partial class FormRestore : Form
    {
        public FormRestore()
        {
            InitializeComponent();
            txtinstancia.Visible = false;
            lbinstancia.Visible = false;
            btnbuscardir.Visible = false;
            btnexecutar.Visible = false;
        }
        static string hostlocal;
        static string iplocal;

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
                txtcaminobackup.Text = "";

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
                txtcaminobackup.Text = "";
            }


        }//tipo de banco

        private void btnbuscardir_Click(object sender, EventArgs e)
        {
            if (cbxtipobanco.Text == "FIREBIRD")
            {
                OPbuscararquivos.Filter = "Arquivos de backup do banco de dados(*.BAK;*.GBK;*.RED;*.FBK;)|*.BAK;*.GBK;*.RED;*.FBK;";
                OPbuscararquivos.Title = "Selecione o Backup";
                OPbuscararquivos.FileName = "backup.bak";
                OPbuscararquivos.CheckFileExists = true;
                OPbuscararquivos.CheckPathExists = true;
                OPbuscararquivos.FilterIndex = 2;

                if (OPbuscararquivos.ShowDialog() == DialogResult.OK)
                {
                    txtcaminobackup.Text = OPbuscararquivos.FileName;

                }
            }
            if (cbxtipobanco.Text == "SQL SERVER")
            {
                OPbuscararquivos.Filter = "Arquivos de backup do banco de dados(*.BAK;)|*.BAK;";
                OPbuscararquivos.Title = "Selecione o Backup";
                OPbuscararquivos.FileName = "backup.bak";
                OPbuscararquivos.CheckFileExists = true;
                OPbuscararquivos.CheckPathExists = true;
                OPbuscararquivos.FilterIndex = 2;

                if (OPbuscararquivos.ShowDialog() == DialogResult.OK)
                {
                    txtcaminobackup.Text = OPbuscararquivos.FileName;

                }
            }

        }

        private void btnbuscarbanco_Click_1(object sender, EventArgs e)
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
        } //buscar caminho do banco Firebird


        private void percentual_completo(object sender, PercentCompleteEventArgs e)
        {
            lststatus.Items.Add(e.Message);
        }


        private void restaurar_backup_SQL()
        {
            string stringconexao = "";
            if (txtcaminobackup.Text != "" && txtloginbanco.Text != "" && txtsenhabanco.Text != "" && txtnomebanco.Text != "")
            {
                try
                {

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
                        Restore restaurar = new Restore();
                        restaurar.Action = RestoreActionType.Database;// define o tipo de restauração para banco de dados
                        restaurar.Database = txtnomebanco.Text;//nome do banco
                        BackupDeviceItem bkpsql = new BackupDeviceItem(txtcaminobackup.Text, DeviceType.File);
                        restaurar.Devices.Add(bkpsql);

                        restaurar.ReplaceDatabase = true;
                        restaurar.PercentComplete += percentual_completo;
                        ServerConnection srvconn = new ServerConnection(txtservidor.Text + "\\" + txtinstancia.Text, txtloginbanco.Text, txtsenhabanco.Text);
                        srvconn.LoginSecure = true;
                        Server servidor = new Server(srvconn);
                        restaurar.SqlRestore(servidor);

                        lststatus.Items.Add("100 % - Restauração terminada");

                        conexao.Close();
                        if (true)
                        {
                            MessageBox.Show("Restauração  efetuada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void restaurar_backup_firebird()
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
                    FbRestore restaurar = new FbRestore();
                    restaurar.ConnectionString = conexaofb.ToString();
                    restaurar.BackupFiles.Add(new FbBackupFile(txtcaminobackup.Text, 2048));
                    restaurar.Verbose = true;
                    restaurar.PageSize = 4096;
                    restaurar.Options = FbRestoreFlags.Create | FbRestoreFlags.Replace;

                    restaurar.ServiceOutput += new ServiceOutputEventHandler(ServiceOutput);

                    restaurar.Execute();

                    MessageBox.Show("Resauração efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FbException ex)
                {
                    MessageBox.Show("ocorreu um erro:" + ex.Message, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnexecutar_Click(object sender, EventArgs e)
        {
            btnbuscardir.Enabled = false;
            btnexecutar.Enabled = false;
            lststatus.Items.Clear();
            lststatus.Items.Add("");

            if (cbxtipobanco.Text == "SQL SERVER")
            {
                if (hostlocal.ToUpper() == txtservidor.Text.ToUpper() || iplocal == txtservidor.Text.ToUpper() || txtservidor.Text.ToUpper() == "LOCALHOST")
                {
                    restaurar_backup_SQL();

                }
            }

            if (cbxtipobanco.Text == "FIREBIRD")
            {
                if (hostlocal.ToUpper() == txtservidor.Text.ToUpper() || iplocal == txtservidor.Text.ToUpper() || txtservidor.Text.ToUpper() == "LOCALHOST")
                {

                    restaurar_backup_firebird();
                }
            }

            if (cbxtipobanco.Text != "FIREBIRD" && cbxtipobanco.Text != "SQL SERVER")
            {
                MessageBox.Show("Por favor informe o tipo do banco de dados", "Selecione o Tipo de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnbuscardir.Enabled = true;
            btnexecutar.Enabled = true;
        }
    }
}
