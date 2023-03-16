using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Services;

namespace AplicacoesparaTeste
{
    public partial class FormCOMANDOSFIREBIRD : Form
    {
        public FormCOMANDOSFIREBIRD()
        {
            InitializeComponent();
            //txtloginbanco.Text = "SYSDBA";
            //txtsenhabanco.Text = "masterkey";
        }
        FbConnectionStringBuilder stringconexao = new FbConnectionStringBuilder();
        FbConnection conexaofb = new FbConnection();
        FbCommand comandoexsql = new FbCommand();
        FbTransaction transacao;
        bool permitecommit = false;







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
        }//buscar caminho do banco Firebird



        private void validacoescampos()
        {

            if (txtservidor.Text == "")
            {
                txtservidor.Text = "LOCALHOST";

            }
            if (txtloginbanco.Text == "")
            {
                txtloginbanco.Text = "SYSDBA";

            }
            if (txtsenhabanco.Text == "")
            {
                txtsenhabanco.Text = "masterkey";
            }

        }  // validar se estao preenchidos os campos se caso nao tiver preenche automatico

        private void btnconectado_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnomebanco.Text != "")
                {
                    validacoescampos();

                    stringconexao.UserID = txtloginbanco.Text.ToUpper();
                    stringconexao.Password = txtsenhabanco.Text.ToLower();
                    stringconexao.DataSource = txtservidor.Text;
                    stringconexao.Database = txtnomebanco.Text;
                    stringconexao.ConnectionTimeout = 100;
                    stringconexao.Dialect = 3;
                    stringconexao.MinPoolSize = 0;
                    stringconexao.MaxPoolSize = 50;
                    stringconexao.PacketSize = 8192;
                    stringconexao.ServerType = 0;
                    stringconexao.Charset = "NONE";
                    conexaofb.ConnectionString = stringconexao.ConnectionString;

                    conexaofb.Open();

                    comandoexsql.Connection = conexaofb;
                    statusconectado.Text = "Status da Conexão: Conectado ";
                    btnconectado.Visible = false;
                    btndesconectar.Visible = true;

                    //colocando para nao modificar os registros
                    txtloginbanco.ReadOnly = true;
                    txtsenhabanco.ReadOnly = true;
                    txtnomebanco.ReadOnly = true;
                    txtservidor.ReadOnly = true;
                    btnbuscarbanco.Visible = false;
                    opcoesexecucao.Visible = true;
                    txtcomandossqls.Visible = true;
                    dgvresultado.Visible = true;

                }
                else
                {
                    MessageBox.Show("Falta informar o Caminho do banco de dados", "Falta informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (FbException ex)
            {

                MessageBox.Show("ocorreu um erro:" + ex.Message, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void btndesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusconectado.Text == "Status da Conexão: Conectado ")
                {
                    conexaofb.Close();
                    btnconectado.Visible = true;
                    btndesconectar.Visible = false;
                    dgvresultado.Rows.Clear();
                    dgvresultado.Refresh();
                    dgvresultado.Columns.Clear();
                    //colocando para  modificar os registros
                    txtloginbanco.ReadOnly = false;
                    txtsenhabanco.ReadOnly = false;
                    txtnomebanco.ReadOnly = false;
                    txtservidor.ReadOnly = false;
                    btnbuscarbanco.Visible = true;
                    opcoesexecucao.Visible = false;
                    txtcomandossqls.Visible = false;
                    dgvresultado.Visible = false;
                    txtcomandossqls.Text = "";
                    statusconectado.Text = "Status da Conexão: Desconectado ";



                }

            }
            catch (FbException ex)
            {

                MessageBox.Show("ocorreu um erro:" + ex.Message, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnexecutar_Click(object sender, EventArgs e)
        {
            string comando = "";
            btnexecutar.Visible = false;
            btncomit.Visible = false;
            btnroolback.Visible = false;




            try
            {
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

                    dados = comandoexsql.ExecuteReader();
                    permitecommit = false;
                    dgvresultado.DataSource = new BindingSource(dados, null);
                    mensagempadrao("COMANDO");
                    conexaofb.Close();
                    conexaofb.Open();

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
                        transacao = conexaofb.BeginTransaction();
                    }


                    comandoexsql.Transaction = transacao;
                    dgvresultado.Rows.Clear();
                    dgvresultado.Refresh();
                    dgvresultado.Columns.Clear();
                    comandoexsql.ExecuteNonQuery();
                    permitecommit = true;
                    mensagempadrao("COMANDO");


                }


            }
            catch (FbException ex)
            {
                dgvresultado.Rows.Clear();
                dgvresultado.Columns.Clear();
                dgvresultado.Refresh();
                MessageBox.Show("ocorreu um erro:" + ex.Message, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnexecutar.Visible = true;
            btncomit.Visible = true;
            btnroolback.Visible = true;
            txtcomandossqls.Focus();
        }

        private void btncomit_Click(object sender, EventArgs e)
        {
            if (permitecommit == true)
            {
                try
                {
                    transacao.Commit();
                    mensagempadrao("COMMIT");


                }
                catch (FbException ex)
                {

                    MessageBox.Show("ocorreu um erro:" + ex.Message, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                permitecommit = false;
            }

        }

        private void btnroolback_Click(object sender, EventArgs e)
        {
            if (permitecommit == true)
            {
                try
                {
                    transacao.Rollback();
                    mensagempadrao("ROOLBACK");
                }
                catch (FbException ex)
                {

                    MessageBox.Show("ocorreu um erro:" + ex.Message, "ERRO NA EXECUÇÃO DO METODO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                permitecommit = false;
            }
        }

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

    }



}
