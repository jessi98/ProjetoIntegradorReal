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
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Cmp;

namespace ProjetoIntegradorReal
{
    public partial class CadastroPessoas: Form
    {
        public int? cpf = null;

        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=doacao";

        public CadastroPessoas()
        {
            InitializeComponent();
        }

        private void CadastroPessoas_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Conexao = new MySqlConnection(data_source);
            Conexao.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conexao;

            if (String.IsNullOrEmpty(txtBusca.Text))
            {
                MessageBox.Show("Escreva um CPF!");
                return;
            }

            if (rdbDoador.Checked == true)
            {
                string sql = "SELECT id_doador FROM pessoa_doador WHERE cpf_doador = @cpf";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                comando.Parameters.AddWithValue("@cpf", Convert.ToInt64(txtBusca.Text));

                Object cpf = comando.ExecuteScalar();

                if (cpf == null)
                {
                    DialogResult result = MessageBox.Show("CPF não encontrado, deseja adicionar uma pessoa?", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                    {
                        MostrarTudo();
                    }
                }
                else
                {
                    MostrarTudo();

                    string sql2 = "SELECT nome, endereco, telefone, cpf_doador FROM pessoa_doador WHERE cpf_doador = @cpf";

                    MySqlCommand comand = new MySqlCommand(sql2, Conexao);

                    comand.Parameters.AddWithValue("@cpf", Convert.ToInt64(txtBusca.Text));

                    MySqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        txtNome.Text = reader.GetString(0);
                        txtEndereco.Text = reader.GetString(1);
                        txtTelefone.Text = reader.GetString(2);
                        txtCPF.Text = reader.GetInt64(3).ToString();
                    }
                }
            }

            else if (rdbRecebedor.Checked == true)
            {
                string sql = "SELECT id_recebedor FROM pessoa_recebedor WHERE cpf_recebedor = @cpf";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                comando.Parameters.AddWithValue("@cpf", Convert.ToInt64(txtBusca.Text));

                Object cpf = comando.ExecuteScalar();

                if (cpf == null)
                {
                    DialogResult result = MessageBox.Show("CPF não encontrado, deseja adicionar uma pessoa?", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                    {
                        MostrarTudo();
                    }
                }
                else
                {
                    MostrarTudo();

                    string sql2 = "SELECT nome, endereco, telefone, cpf_recebedor FROM pessoa_recebedor WHERE cpf_recebedor = @cpf";

                    MySqlCommand comand = new MySqlCommand(sql2, Conexao);

                    comand.Parameters.AddWithValue("@cpf", Convert.ToInt64(txtBusca.Text));

                    MySqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        txtNome.Text = reader.GetString(0);
                        txtEndereco.Text = reader.GetString(1);
                        txtTelefone.Text = reader.GetString(2);
                        txtCPF.Text = reader.GetInt64(3).ToString();
                    }
                }
            }

            else
            {
                MessageBox.Show("Selecione um tipo de cadastro");
            }

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
                controle.Enabled = false;
                controle.Visible = false;
                if (controle is TextBox)
                {
                    controle.Text = "";
                }

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCPF.Text))
            {
                MessageBox.Show(" Campos vazios \n Verifique os campos", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show(" Campos vazios \n Verifique os campos", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show(" Campos vazios \n Verifique os campos", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show(" Campos vazios \n Verifique os campos", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                if (rdbDoador.Checked == true)
                {
                    string sql = "SELECT id_doador FROM pessoa_doador WHERE cpf_doador = @cpf";
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    comando.Parameters.AddWithValue("@cpf", Convert.ToInt64(txtCPF.Text));

                    Object cpf = comando.ExecuteScalar();

                    if (cpf == null)
                    {

                        cmd.Parameters.Clear();
                        cmd.CommandText = "INSERT INTO pessoa_doador (nome, endereco, telefone, cpf_doador)" +
                                          "VALUES (@nome, @endereco, @telefone, @cpf_doador)";

                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                        cmd.Parameters.AddWithValue("@cpf_doador", Convert.ToInt64(txtCPF.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro realizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        EsconderTudo();
                    }

                    else
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "UPDATE pessoa_doador " +
                                          "SET nome = @nome, endereco = @endereco, telefone = @telefone, cpf_doador = @cpf_doador " +
                                          "WHERE id_doador = @id";

                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                        cmd.Parameters.AddWithValue("@cpf_doador", Convert.ToInt64(txtCPF.Text));
                        cmd.Parameters.AddWithValue("@id", cpf);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro atualizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        EsconderTudo();
                    }
                }
                else if (rdbRecebedor.Checked == true)
                {
                    string sql = "SELECT id_recebedor FROM pessoa_recebedor WHERE cpf_recebedor = @cpf";
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    comando.Parameters.AddWithValue("@cpf", Convert.ToInt64(txtCPF.Text));

                    Object cpf = comando.ExecuteScalar();

                    if (cpf == null)
                    {

                        cmd.Parameters.Clear();
                        cmd.CommandText = "INSERT INTO pessoa_recebedor (nome, endereco, telefone, cpf_recebedor)" +
                                          "VALUES (@nome, @endereco, @telefone, @cpf_recebedor)";

                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                        cmd.Parameters.AddWithValue("@cpf_recebedor", Convert.ToInt64(txtCPF.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro realizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        EsconderTudo();

                    }
                    else
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "UPDATE pessoa_recebedor " +
                                          "SET nome = @nome, endereco = @endereco, telefone = @telefone, cpf_recebedor = @cpf_recebedor " +
                                          "WHERE id_recebedor = @cpf";

                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                        cmd.Parameters.AddWithValue("@cpf_recebedor", Convert.ToInt64(txtCPF.Text));
                        cmd.Parameters.AddWithValue("@cpf", cpf);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro atualizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        EsconderTudo();
                    }
                }

                else
                {
                    MessageBox.Show("Selecione um tipo ao cadastro");
                }
            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Error " + "has occured: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Has occured: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
