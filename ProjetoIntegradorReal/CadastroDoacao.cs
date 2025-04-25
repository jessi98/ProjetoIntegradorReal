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
    public partial class CadastroDoacao: Form
    {
        public CadastroDoacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroDoacao_Load(object sender, EventArgs e)
        {

        }

        private void EsconderTudo()
        {
            var controles = new Control[]
            {
                lblLivro1, lblLivro2, lblLivro3,
                cbxLivro1, cbxLivro2, cbxLivro3,
                lblBrinq1, lblBrinq2, lblBrinq3,
                cbxBrinq1, cbxBrinq2, cbxBrinq3,
                lblRoupa1, lblRoupa2, lblRoupa3,
                cbxRoupa1, cbxRoupa2, cbxRoupa3,
                lblLinha,lblDescricaoProduto,txtDescricaoProduto
            };
            foreach (var controle in controles)
            {
                controle.Enabled = false;
                controle.Visible = false;

            }
        }

        private void MostrarRoupa()
        {
            var controles = new Control[]
            {
                lblRoupa1, lblRoupa2, lblRoupa3,
                cbxRoupa1, cbxRoupa2, cbxRoupa3,
                lblLinha,lblDescricaoProduto,txtDescricaoProduto
            };
            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;

            }
        }
        private void MostrarBrinq()
        {
            var controles = new Control[]
            {
                lblBrinq1, lblBrinq2, lblBrinq3,
                cbxBrinq1, cbxBrinq2, cbxBrinq3,
                lblLinha,lblDescricaoProduto,txtDescricaoProduto
            };
            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;

            }
        }

        private void MostrarLivro()
        {
            var controles = new Control[]
            {
                lblLivro1, lblLivro2, lblLivro3,
                cbxLivro1, cbxLivro2, cbxLivro3,
                lblLinha,lblDescricaoProduto,txtDescricaoProduto
            };
            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;

            }
        }


        private void btnConfirma_Click(object sender, EventArgs e)
        {

            if (cmbProduto.Text == "Roupas")
            {
                EsconderTudo();
                MostrarRoupa();
            }

            else if (cmbProduto.Text == "Livros")
            {
                EsconderTudo();
                MostrarLivro();
            }
            
            else if (cmbProduto.Text == "Brinquedos")
            {
                EsconderTudo();
                MostrarBrinq();
            }

        }
    }
}
