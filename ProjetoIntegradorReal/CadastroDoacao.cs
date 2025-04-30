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
    public partial class CadastroDoacao: Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=doacao";

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
                lblLivro1, lblLivro2, 
                cbxLivro1, cbxLivro2,
                lblBrinq1, lblBrinq2, 
                cbxBrinq1, cbxBrinq2,
                lblRoupa1, lblRoupa2, lblRoupa3,
                cbxRoupa1, cbxRoupa2, cbxRoupa3,
                cbxCestaBasica, cbxEletrodomestico, cbxEletrodomestico2, cbxEletrodomestico3,
                lblLinha,lblDescricaoProduto,txtDescricaoProduto, lblEletro1, lblEletro2, lblEletro3, lblCesta
            };
            foreach (var controle in controles)
            {
                controle.Enabled = false;
                controle.Visible = false;

            }
        }

        private void LimparTudo()
        {
            var controles = new Control[]
            {
                lblLivro1, lblLivro2,
                cbxLivro1, cbxLivro2,
                lblBrinq1, lblBrinq2,
                cbxBrinq1, cbxBrinq2,
                lblRoupa1, lblRoupa2, lblRoupa3,
                cbxRoupa1, cbxRoupa2, cbxRoupa3,
                cbxCestaBasica, cbxEletrodomestico, cbxEletrodomestico2, cbxEletrodomestico3, cmbProduto,
                lblLinha,lblDescricaoProduto,txtDescricaoProduto, lblEletro1, lblEletro2, lblEletro3, lblCesta
            };
            foreach (var controle in controles)
            {
                if (controle is TextBox)
                {
                    controle.Text = "";
                }
                if (controle is ComboBox)
                {
                    ((ComboBox)controle).SelectedIndex = -1;
                }

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
                lblBrinq1, lblBrinq2,
                cbxBrinq1, cbxBrinq2,
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
                lblLivro1, lblLivro2,
                cbxLivro1, cbxLivro2,
                lblLinha,lblDescricaoProduto,txtDescricaoProduto
            };
            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;

            }
        }

        private void MostrarEletro()
        {
            var controles = new Control[]
            {
                cbxEletrodomestico, cbxEletrodomestico2, cbxEletrodomestico3,
                lblLinha,lblDescricaoProduto,txtDescricaoProduto, lblEletro1, lblEletro2, lblEletro3
            };
            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;

            }
        }

        private void MostrarCesta()
        {
            var controles = new Control[]
            {
                cbxCestaBasica, lblLinha,lblDescricaoProduto,txtDescricaoProduto,
                lblCesta
            };
            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;

            }
        }

        private void MostrarCategoria()
        {
            var controles = new Control[]
            {
                lblProduto, cmbProduto
            };
            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;

            }
        }


        private void btnConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                string sql = "SELECT id_doador FROM pessoa_doador WHERE cpf_doador = @cpf";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                comando.Parameters.AddWithValue("@cpf", Convert.ToInt64(txtCPF.Text));

                Object cpf = comando.ExecuteScalar();

                if (cpf == null)
                {
                    DialogResult result =  MessageBox.Show(" Pessoa não encontrada! \n Deseja fazer o cadastro?", "Não encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    
                    if (result == DialogResult.Yes)
                    {
                        CadastroPessoas form = new CadastroPessoas();
                        form.ShowDialog();
                    }
                }
                else
                {
                    MostrarCategoria();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxEletrodomestico2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
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
            else if (cmbProduto.Text == "Eletrodomésticos")
            {
                EsconderTudo();
                MostrarEletro();
            }
            else if (cmbProduto.Text == "Cesta Básica")
            {
                EsconderTudo();
                MostrarCesta();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conexao = new MySqlConnection(data_source);
            Conexao.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conexao;

            if (cmbProduto.Text == "Roupas")
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO cadastro_doacao (categoria, subcategoria_1, subcategoria_2, subcategoria_3, descricao, doador2_cpf)" +
                                  "VALUES (@categoria, @subcategoria_1, @subcategoria_2, @subcategoria_3, @descricao, @cpf_doador)";

                cmd.Parameters.AddWithValue("@categoria", cmbProduto.Text);
                cmd.Parameters.AddWithValue("@subcategoria_1", cbxRoupa1.Text);
                cmd.Parameters.AddWithValue("@subcategoria_2", cbxRoupa2.Text);
                cmd.Parameters.AddWithValue("@subcategoria_3", cbxRoupa3.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricaoProduto.Text);
                cmd.Parameters.AddWithValue("@cpf_doador", Convert.ToInt64(txtCPF.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EsconderTudo();
                LimparTudo();
            }

            else if (cmbProduto.Text == "Livros")
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO cadastro_doacao (categoria, subcategoria_1, subcategoria_2, descricao, doador2_cpf)" +
                                  "VALUES (@categoria, @subcategoria_1, @subcategoria_2, @descricao, @cpf_doador)";

                cmd.Parameters.AddWithValue("@categoria", cmbProduto.Text);
                cmd.Parameters.AddWithValue("@subcategoria_1", cbxRoupa1.Text);
                cmd.Parameters.AddWithValue("@subcategoria_2", cbxRoupa2.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricaoProduto.Text);
                cmd.Parameters.AddWithValue("@cpf_doador", Convert.ToInt64(txtCPF.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EsconderTudo();
                LimparTudo();

            }

            else if (cmbProduto.Text == "Brinquedos")
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO cadastro_doacao (categoria, subcategoria_1, subcategoria_2, descricao, doador2_cpf)" +
                                  "VALUES (@categoria, @subcategoria_1, @subcategoria_2, @descricao, @cpf_doador)";

                cmd.Parameters.AddWithValue("@categoria", cmbProduto.Text);
                cmd.Parameters.AddWithValue("@subcategoria_1", cbxRoupa1.Text);
                cmd.Parameters.AddWithValue("@subcategoria_2", cbxRoupa2.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricaoProduto.Text);
                cmd.Parameters.AddWithValue("@cpf_doador", Convert.ToInt64(txtCPF.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EsconderTudo();
                LimparTudo();

            }
            else if (cmbProduto.Text == "Eletrodomésticos")
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO cadastro_doacao (categoria, subcategoria_1, subcategoria_2, subcategoria_3, descricao, doador2_cpf)" +
                                  "VALUES (@categoria, @subcategoria_1, @subcategoria_2, @subcategoria_3, @descricao, @cpf_doador)";

                cmd.Parameters.AddWithValue("@categoria", cmbProduto.Text);
                cmd.Parameters.AddWithValue("@subcategoria_1", cbxRoupa1.Text);
                cmd.Parameters.AddWithValue("@subcategoria_2", cbxRoupa2.Text);
                cmd.Parameters.AddWithValue("@subcategoria_3", cbxRoupa3.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricaoProduto.Text);
                cmd.Parameters.AddWithValue("@cpf_doador", Convert.ToInt64(txtCPF.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EsconderTudo();
                LimparTudo();
            }
            else if (cmbProduto.Text == "Cesta Básica")
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO cadastro_doacao (categoria, subcategoria_1, descricao, doador2_cpf)" +
                                  "VALUES (@categoria, @subcategoria_1, @descricao, @cpf_doador)";

                cmd.Parameters.AddWithValue("@categoria", cmbProduto.Text);
                cmd.Parameters.AddWithValue("@subcategoria_1", cbxRoupa1.Text);
                cmd.Parameters.AddWithValue("@subcategoria_2", cbxRoupa2.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricaoProduto.Text);
                cmd.Parameters.AddWithValue("@cpf_doador", Convert.ToInt64(txtCPF.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EsconderTudo();
                LimparTudo();
            }
        }
    }
}
