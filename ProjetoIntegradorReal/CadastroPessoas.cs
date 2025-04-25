using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoIntegradorReal
{
    public partial class CadastroPessoas: Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=doacao";

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                if (rdbDoador.Checked == true)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO pessoa_doador (nome, endereco, telefone, cpf_doador)" +
                                      "VALUES (@nomq, @endereco, @telefone, @cpf_doador)";

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("cpf_doador", txtCPF.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rdbRecebedor.Checked == true)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO pessoa_doador (nome, endereco, telefone, cpf_doador)" +
                                      "VALUES (@nomq, @endereco, @telefone, @cpf_doador)";

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("cpf_doador", txtCPF.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                 
                }

            }
            catch
            {

            }
            finally
            {

            }
        }
    }
}
