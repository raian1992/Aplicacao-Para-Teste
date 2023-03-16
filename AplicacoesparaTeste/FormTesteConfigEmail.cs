using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop;
using System.Net.Mail;
using System.Net;





namespace AplicacoesparaTeste
{
    public partial class FormTesteConfigEmail : Form
    {
        public FormTesteConfigEmail()
        {
            InitializeComponent();
        }


        private void btntestepop_Click(object sender, EventArgs e)
        {

            if (txtenderecopop.Text != "" && txtenderecopop.Text != "" && txtloginpop.Text != "" && txtsenhapop.Text != "" && cbxportapop.Text != "")
            {
                TesteConexaoPOP();
            }


        }

        private void TesteConexaoPOP()
        {

            try
            {




                using (var cliente = new OpenPop.Pop3.Pop3Client())
                {
                    bool ssl = false;

                    if (cbksslpop.Checked == true)
                    {
                        ssl = true;
                    }
                    int timeout = 1000;
                    cliente.Connect(txtenderecopop.Text, Convert.ToInt32(cbxportapop.Text), ssl, timeout, timeout, certificateValidator);

                    cliente.Authenticate(txtloginpop.Text, txtsenhapop.Text);


                    int messageCount = cliente.GetMessageCount();
                    cliente.Disconnect();

                    if (messageCount > 0)
                    {
                        MessageBox.Show("Configuracao OK!", "Conectou", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
            catch (OpenPop.Pop3.Exceptions.InvalidLoginException ex)
            {
                MessageBox.Show("Ocorreu um erro na configuração:  " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro na configuração:  " + ex.InnerException, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool certificateValidator(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private void btntestesmtp_Click(object sender, EventArgs e)
        {
            try
            {

                string tituloemail = "Teste de envio de email";
                string texto = "Se esta lendo esse texto o envio foi realizado com sucesso!";

                SmtpClient cliente = new SmtpClient(txtenderecosmtp.Text, Convert.ToInt32(cbxportasmtp.Text));
                if (cbxcriptsmtp.Text == "nenhum")
                {
                    cliente.EnableSsl = false;
                }
                else
                {
                    cliente.EnableSsl = true;
                }
                cliente.Timeout = 10000;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new NetworkCredential(txtusuariosmtp.Text, txtsenhasmtp.Text);
                MailMessage msg = new MailMessage();
                msg.To.Add(txtemaildestinosmtp.Text);
                msg.From = new MailAddress(txtemailsmtp.Text);
                msg.Subject = tituloemail;
                msg.Body = texto;
                cliente.Send(msg);
                MessageBox.Show("Mensagem enviada", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no envio" + ex.Message, "Erro no envio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
