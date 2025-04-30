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
            txtSenha.PasswordChar = '*';
            
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
            Usuario us = new Usuario();
            us.Codigo = 1;
            us.Nome = "admin";
            us.Senha = "admin";
            
            Usuario.ListaUsuarios.Add(us);


        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            {
                foreach (Usuario user in Usuario.ListaUsuarios)

                {
                    if ((user.Nome == txtNome.Text) && (user.Senha == txtSenha.Text))
                    {
                        MessageBox.Show($"Bem vindo {user.Nome}!",
                            "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );

                        MenuPrincipal form = new MenuPrincipal();
                        form.ShowDialog();
                        this.Hide();

                        return;
                    }
                }
                MessageBox.Show("Usuario Não Autenticado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNome.Clear();
                txtSenha.Clear();
                return;

            }
        }

    }
}

