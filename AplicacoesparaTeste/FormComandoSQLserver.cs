using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
using System.Net.NetworkInformation;


namespace AplicacoesparaTeste
{
    public partial class FormComandoSQLserver : Form
    {
        public FormComandoSQLserver()
        {
            InitializeComponent();
        }

        //para apresentar as instancias na rede
        DataTable tabelaservidores = SmoApplication.EnumAvailableSqlServers(true);
        private static Server servidor;
        ServerConnection srvconn;
        string servidorselecionado;


        //objetos carregados no inicio padrao

        SqlConnection conexao = new SqlConnection();
        SqlCommand comandoexsql = new SqlCommand();
        SqlTransaction transacao;
        string stringconexao;
        bool permitecommit = false;
        string autwind = "NAO";



        private void validacoescampos()
        {

            if (cbxservidor.Text == "")
            {
                cbxservidor.Text = "LOCALHOST\\OBJETIVA";

            }
            if (txtloginbanco.Text == "")
            {
                txtloginbanco.Text = "SA";

            }
            if (txtsenhabanco.Text == "")
            {
                txtsenhabanco.Text = "SA_0bjetiva";
            }

        }// validar se estao preenchidos os campos se caso nao tiver preenche automatico

        private void btnexecutar_Click(object sender, EventArgs e)
        {
            string comando = "";
            btnexecutar.Visible = false;
            btncomit.Visible = false;
            btnroolback.Visible = false;


            try
            {
                if (transacao != null)
                {
                    transacao.Rollback();
                    permitecommit = false;
                    conexao.Close();
                    conexao.Open();

                }
                if (transacao == null)
                {
                    conexao.Close();
                    conexao.Open();
                }
                IDataReader dados;

                if (txtcomandossqls.SelectedText != "")
                {


                    comando = txtcomandossqls.SelectedText.ToUpper();
                }
                else
                {
                    comando = txtcomandossqls.Text.ToUpper();
                }

                comandoexsql.CommandText = comando;
                int indiceUP = comando.IndexOf("UPDATE");

                int indicede = comando.IndexOf("DELETE");

                int indicein = comando.IndexOf("INSERT");


                int indicese = comando.IndexOf("SELECT");
                if (indiceUP == -1)
                {
                    indiceUP = 10000000;
                }

                if (indicede == -1)
                {
                    indicede = 10000000;
                }

                if (indicein == -1)
                {
                    indicein = 10000000;
                }

                if (comando.ToUpper().Contains("SELECT") && indicese < indiceUP && indicese < indicede && indicese < indicein)
                {
                    permitecommit = false;
                    comandoexsql.CommandText = comando;
                    dados = comandoexsql.ExecuteReader();
                    dgvresultado.DataSource = new BindingSource(dados, null);
                    mensagempadrao("COMANDO");


                }

                if (comando.ToUpper().Contains("UPDATE") || comando.ToUpper().Contains("INSERT") || comando.ToUpper().Contains("DELETE"))
                {

                    if (transacao != null && permitecommit == true)
                    {
                        transacao.Rollback();
                        permitecommit = false;
                    }

                    transacao = null;
                    if (transacao == null)
                    {
                        transacao = conexao.BeginTransaction();
                    }
                    comandoexsql.Transaction = transacao;
                    comandoexsql.CommandText = comando;
                    comandoexsql.ExecuteNonQuery();
                    mensagempadrao("COMANDO");
                }
            }
            catch (Exception ex)
            {
                dgvresultado.Rows.Clear();
                dgvresultado.Columns.Clear();
                dgvresultado.Refresh();
                MessageBox.Show("ocorreu um erro:" + ex.Message, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtcomandossqls.Focus();
            btnexecutar.Visible = true;
            btncomit.Visible = true;
            btnroolback.Visible = true;

        }

        private void btndesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusconectado.Text == "Status da Conexão: Conectado ")
                {
                    conexao.Close();
                    // conexaofb.Close();
                    btnconectado.Visible = true;
                    btndesconectar.Visible = false;

                    //colocando para  modificar os registros
                    txtloginbanco.ReadOnly = false;
                    txtsenhabanco.ReadOnly = false;
                    cbxbanco.Visible = true;
                    cbxservidor.Visible = true;

                    opcoesexecucao.Visible = false;
                    txtcomandossqls.Visible = false;
                    dgvresultado.Visible = false;
                    txtcomandossqls.Text = "";
                    statusconectado.Text = "Status da Conexão: Desconectado ";

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("ocorreu um erro:" + ex.Message, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //desconectar do banco

        private void btnconectado_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxservidor.Text != "")
                {
                    if (autwind == "NAO")
                    {
                        stringconexao = "Data Source= " + cbxservidor.Text + "; Database=" + cbxbanco.Text.ToUpper() +
         " ;USER Id=" + txtloginbanco.Text + " ;Password=" + txtsenhabanco.Text;
                    }
                    if (autwind == "SIM")
                    {
                        stringconexao = "Data Source=" + cbxservidor.Text + "; Database=" + cbxbanco.Text.ToUpper() + ";Integrated Security=True;MultipleActiveResultSets=False";

                    }

                    conexao.ConnectionString = stringconexao;
                    srvconn.Disconnect();
                    conexao.Open();
                    comandoexsql.Connection = conexao;

                    statusconectado.Text = "Status da Conexão: Conectado ";
                    btnconectado.Visible = false;
                    btndesconectar.Visible = true;

                    //colocando para nao modificar os registros
                    txtloginbanco.ReadOnly = true;
                    txtsenhabanco.ReadOnly = true;
                    cbxbanco.Visible = false;
                    cbxservidor.Visible = false;

                    opcoesexecucao.Visible = true;
                    txtcomandossqls.Visible = true;
                    dgvresultado.Visible = true;

                }
                else
                {
                    MessageBox.Show("Falta informar o Caminho do banco de dados", "Falta informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ocorreu um erro:" + ex.Message, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// conectando no banco


        private void mensagempadrao(string nomemensagem)
        {
            if (nomemensagem == "COMANDO")
            {
                MessageBox.Show("Comando Executado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (nomemensagem == "COMMIT")
            {
                MessageBox.Show("Transação gravada no banco com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (nomemensagem == "ROOLBACK")
            {
                MessageBox.Show("Transação revertida no banco com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FormComandoSQLserver_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            WindowState = FormWindowState.Normal;
            try
            {
                if (tabelaservidores.Rows.Count > 0)
                {
                    foreach (DataRow drserver in tabelaservidores.Rows)
                    {
                        cbxservidor.Items.Add(drserver[0]);
                        // cbxservidor.Text = Convert.ToString(drserver["NOME"]);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("ocorreu um erro:" + ex.Message, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // buscar todas instancias que o computador consegue reconhecer

        private void cbxbanco_click(object sender, EventArgs e)
        {
            try
            {
                string enderecoping = cbxservidor.Text;
                int posicao = enderecoping.IndexOf("\\");
                enderecoping = enderecoping.Substring(0, posicao);

                Ping testeexiste = new Ping();
                bool pingable = false;
                PingReply reply = testeexiste.Send(enderecoping);
                pingable = reply.Status == IPStatus.Success;

                if (pingable = reply.Status == IPStatus.Success)
                {


                    cbxbanco.Items.Clear();
                    validacoescampos();
                    int conta = 0;
                    conta = cbxbanco.Items.Count;

                    srvconn = new ServerConnection(cbxservidor.Text);
                    srvconn.ConnectTimeout = 50;
                    srvconn.LockTimeout = 50;
                    srvconn.StatementTimeout = 50;

                    if (autwind == "NAO")
                    {
                        srvconn.LoginSecure = false;
                        srvconn.Login = txtloginbanco.Text;
                        srvconn.Password = txtsenhabanco.Text;
                    }
                    if (autwind == "SIM")
                    {
                        srvconn.LoginSecure = true;
                    }


                    servidor = new Server(srvconn);
                    foreach (Database dbserver in servidor.Databases)
                    {
                        cbxbanco.Items.Add(dbserver.Name);

                    }


                    //servidorselecionado = cbxservidor.Text;

                }
                else
                {
                    MessageBox.Show("Endereço inexistente:", "Host Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ocorreu um erro:" + ex.Message, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void chkwindwos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkwindwos.Checked == true)
            {
                autwind = "SIM";
                txtloginbanco.Visible = false;
                txtsenhabanco.Visible = false;
            }
            else
            {
                autwind = "NAO";
                txtloginbanco.Visible = true;
                txtsenhabanco.Visible = true;
            }
        }

        private void btncomit_Click(object sender, EventArgs e)
        {
            try
            {
                if (transacao != null)
                {
                    transacao.Commit();
                    transacao = null;
                    mensagempadrao("COMMIT");
                    permitecommit = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ocorreu um erro:" + ex.Message, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnroolback_Click(object sender, EventArgs e)
        {
            try
            {
                if (transacao != null)
                {
                    transacao.Rollback();
                    transacao = null;
                    permitecommit = false;
                    mensagempadrao("ROOLBACK");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ocorreu um erro:" + ex.Message, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } //buscar o banco de dados pela instancia ja configurada



    }
}
