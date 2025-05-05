using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjetoIntegradorReal
{
    public partial class Entrar: Form
    {
        public Entrar()
        {
            InitializeComponent();
           
            Usuario us = new Usuario();
            us.Codigo = 001;
            us.Nome = "admin";
            us.Senha = "admin";
            
            us.Cadastrar();

            Usuario us2 = new Usuario();
            us2.Codigo = 002;
            us2.Nome = "andre";
            us2.Senha = "1995";

            us2.Cadastrar();

            Usuario us3 = new Usuario();
            us3.Codigo = 003;
            us3.Nome = "theo";
            us3.Senha = "0800";

            us3.Cadastrar();
        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in Usuario.ListaUsuario)
            {
                if ((user.Nome == txtNome.Text) && (user.Senha == txtSenha.Text))
                {
                    MessageBox.Show(
                        "Usuario Autenticado com Sucesso!",
                        "Sucesso!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );

                    MenuPrincipal form = new MenuPrincipal();
                    form.ShowDialog();

                    return;
                }


            }
            MessageBox.Show("Usuario não encontrado! Verifique 'Nome' e 'Senha' digitado.",
                            "Erro!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            txtNome.Clear();
            txtSenha.Clear();
            return;

        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked == true)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }

        private void Entrar_Load(object sender, EventArgs e)
        {

        }
    }
}
