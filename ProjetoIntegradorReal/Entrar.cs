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
    public partial class Entrar: Form
    {
        public Entrar()
        {
            InitializeComponent();

            Login us = new Login();
            us.Codigo = 001;
            us.Nome = "admin";
            us.Senha = "admin";

            us.Cadastrar();

            Login us2 = new Login();
            us2.Codigo = 002;
            us2.Nome = "andre";
            us2.Senha = "1995";

            us2.Cadastrar();

            Login us3 = new Login();
            us3.Codigo = 003;
            us3.Nome = "theo";
            us3.Senha = "0800";

            us3.Cadastrar();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            foreach (Login user in Login.ListaUsuarios)
            {
                if ((user.Nome == txtNome.Text) && (user.Senha == txtSenha.Text))
                {
                    txtNome.Clear();
                    txtSenha.Clear();
                    MenuPrincipal form = new MenuPrincipal();
                    form.ShowDialog();

                    return;
                }


            }
            MessageBox.Show("Usuario não encontrado! Verifique os dados digitados.",
                            "Erro!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            txtNome.Clear();
            txtSenha.Clear();
            txtNome.Focus();
            return;
        }

        private void Entrar_Load(object sender, EventArgs e)
        {

        }

        private void chkMostrar_CheckedChanged_1(object sender, EventArgs e)
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

        private void txtNome_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }
    }
}
