using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace WF_3
{
    public partial class frmGerenciador : MaterialForm
    {
        public frmGerenciador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCriarPasta_Click(object sender, EventArgs e)
        {
            string criarPasta = @"D:\"+txtCriarPasta.Text;
            if (Directory.Exists(criarPasta))
            {
                MaterialMessageBox.Show("Pasta já Existe!");
            }
            else
            {
                Directory.CreateDirectory(criarPasta);
                MaterialMessageBox.Show("Pasta Criada!");
                txtCriarPasta.Clear();
            }
        }

        private void btnMoverArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                string origem = Path.Combine(@"D:\" + txtPastaOrigem.Text, txtArquivoOrigem.Text);
                string destino = Path.Combine(@"D:\" + txtPastaDestino.Text, txtArquivoOrigem.Text);

                File.Move(origem, destino);
                MaterialMessageBox.Show("Arquivo Movido!");
                txtArquivoOrigem.Clear();
                txtPastaDestino.Clear();
                txtPastaOrigem.Clear();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
            
        }

        private void btnDeletarPasta_Click(object sender, EventArgs e)
        {
            string deletarPasta = @"D:\" + txtDeletarPasta.Text;
            if (!Directory.Exists(deletarPasta))
            {
                MaterialMessageBox.Show("Pasta não Existe!");
            }
            else
            {
                Directory.Delete(deletarPasta);
                MaterialMessageBox.Show("Pasta Deletada!");
                txtDeletarPasta.Clear();

            }
        }
    }
}
