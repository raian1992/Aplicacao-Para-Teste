using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Runtime.InteropServices;

namespace AplicacoesparaTeste
{
    public partial class frmprinc : Form
    {
        public frmprinc()
        {
            InitializeComponent();
        }

        private void testeEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTesteConfigEmail frmemail = new FormTesteConfigEmail();
            frmemail.Show();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSobre frmsobre = new FormSobre();
            frmsobre.Show();
        }

        private void testarTLS12ToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void backupDoBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBackup frmbackup = new FormBackup();
            frmbackup.Show();
        }

        private void restoreDoBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRestore frmrestore = new FormRestore();
            frmrestore.Show();
        }

        private void fIREBIRDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCOMANDOSFIREBIRD firebird = new FormCOMANDOSFIREBIRD();
            firebird.Show();
        }

        private void sQLSERVERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComandoSQLserver sql = new FormComandoSQLserver();
            sql.Show();
        }
    }
}
