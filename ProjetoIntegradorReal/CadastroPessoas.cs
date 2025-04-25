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
    public partial class CadastroPessoas: Form
    {
        public CadastroPessoas()
        {
            InitializeComponent();
        }

        private void CadastroPessoas_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MostrarTudo();
        }

        private void MostrarTudo()
        {
            var controles = new Control[]
            {
                lblCPF, lblEndereco, lblLinha, lblNome, lblTefone,
                txtCPF, txtEndereco, txtNome, txtTelefone
            };
            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;

            }
        }

        private void EsconderTudo()
        {
            var controles = new Control[]
            {
                lblCPF, lblEndereco, lblLinha, lblNome, lblTefone,
                txtCPF, txtEndereco, txtNome, txtTelefone
            };
            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
