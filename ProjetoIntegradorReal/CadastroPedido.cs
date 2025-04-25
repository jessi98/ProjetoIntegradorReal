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
    public partial class CadastroPedido: Form
    {
        public CadastroPedido()
        {
            InitializeComponent();
        }

        private void EsconderTudo()
        {
            var controles = new Control[]
            {
                cbxLivro, cbxEstadoLivro, cbxGeneroLivro,
                lblLivro, lblEstadoLivro, lblGeneroLivro,
                cbxBrinq, cbxTamanhoBrinq, cbxTipoBrinq,
                lblTamanhoBrinq, lblTipoBrinq, lblBrinq,
                cbxTamanho, cbxGenero, cbxPeca,
                lblTamanho, lblPeca, lblGenero,
                lblNome, lblTelefone, lblRegistro,
                txtNome, txtTelefone, txtRegistro,
                lblLinha

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
                cbxTamanho, cbxGenero, cbxPeca,
                lblTamanho, lblPeca, lblGenero,
                lblNome, lblTelefone, lblRegistro,
                txtNome, txtTelefone, txtRegistro,
                lblLinha

            };
            foreach(var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;

            }
                   
        }

        private void MostrarBrinq()
        {
            var controles = new Control[]
            {
                cbxBrinq, cbxTamanhoBrinq, cbxTipoBrinq,
                lblTamanhoBrinq, lblTipoBrinq, lblBrinq,
                lblNome, lblTelefone, lblRegistro,
                txtNome, txtTelefone, txtRegistro,
                lblLinha

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
                cbxLivro, cbxEstadoLivro, cbxGeneroLivro,
                lblLivro, lblEstadoLivro, lblGeneroLivro,
                lblNome, lblTelefone, lblRegistro,
                txtNome, txtTelefone, txtRegistro,
                lblLinha

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
            else if (cmbProduto.Text == "Brinquedos")
            {
                EsconderTudo();
                MostrarBrinq();
            }
            else if (cmbProduto.Text == "Livros")
            {
                EsconderTudo();
                MostrarLivro();
            }

        }
    }
}
