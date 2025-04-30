using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorReal
{
    public partial class MenuPrincipal: Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastroDoacao_Click(object sender, EventArgs e)
        {
            CadastroDoacao form = new CadastroDoacao();
            form.ShowDialog();
        }

        private void btnCadastroPedido_Click(object sender, EventArgs e)
        {
            CadastroPedido form = new CadastroPedido();
            form.ShowDialog();
        }

        private void btnEditarDoacao_Click(object sender, EventArgs e)
        {
            StatusDoacao form = new StatusDoacao();
            form.ShowDialog();
        }

        private void btnCadastrarPessoa_Click(object sender, EventArgs e)
        {
            CadastroPessoas form = new CadastroPessoas();
            form.ShowDialog();
        }
    }
}
