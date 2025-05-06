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
    public partial class StatusDoacao : Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=doacao";

        string tabela;
        int registro;
        int st;

        public StatusDoacao()
        {
            InitializeComponent();
            //Atualizar();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StatusDoacao_Load(object sender, EventArgs e)
        {
            foreach (status sta in status.list)
            {
                if (sta.tabela == "Doação")
                {
                    tabela = "cadastro_doacao";
                }
                else if (sta.tabela == "Pedido")
                {
                    tabela = "cadastro_pedido";
                }
                registro = sta.registro;
            }

            Conexao = new MySqlConnection(data_source);
            Conexao.Open();
            try
            {
                if (tabela == "cadastro_doacao")
                {
                    string sql = "SELECT registro, subcategoria_1, subcategoria_2, subcategoria_3, descricao, status, doador2_cpf, recebedor_cpf FROM cadastro_doacao WHERE registro = @registro";
                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.AddWithValue("@registro", registro);

                    MySqlDataReader reader = buscar.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtRegistro.Text = !reader.IsDBNull(0) ? reader.GetInt32(0).ToString() : "";
                            txtSub1.Text = !reader.IsDBNull(1) ? reader.GetString(1) : "";
                            txtSub2.Text = !reader.IsDBNull(2) ? reader.GetString(2) : "";
                            txtSub3.Text = !reader.IsDBNull(3) ? reader.GetString(3) : "";
                            txtDescricao.Text = !reader.IsDBNull(4) ? reader.GetString(4) : "";
                            st = !reader.IsDBNull(5) ? reader.GetInt32(5) : 0;
                            txtCPFDoador.Text = !reader.IsDBNull(6) ? reader.GetInt64(6).ToString() : "";
                            txtCPFRecebedor.Text = !reader.IsDBNull(7) ? reader.GetInt64(7).ToString() : "";
                        }
                        reader.Close();

                        if (st == 0)
                        {
                            rdbAtivo.Checked = true;
                        }
                        else if (st == 1)
                            rdbAguardando.Checked = true;
                    }
                    txtCPFDoador.Enabled = false;
                }

                else if (tabela == "cadastro_pedido")
                {
                    string sql = "SELECT registro, subcategoria_1, subcategoria_2, subcategoria_3, descricao, status, doador_cpf, recebedor_cpf FROM cadastro_pedido WHERE registro = @registro";
                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.AddWithValue("@registro", registro);

                    MySqlDataReader reader = buscar.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtRegistro.Text = !reader.IsDBNull(0) ? reader.GetInt32(0).ToString() : "";
                            txtSub1.Text = !reader.IsDBNull(1) ? reader.GetString(1) : "";
                            txtSub2.Text = !reader.IsDBNull(2) ? reader.GetString(2) : "";
                            txtSub3.Text = !reader.IsDBNull(3) ? reader.GetString(3) : "";
                            txtDescricao.Text = !reader.IsDBNull(4) ? reader.GetString(4) : "";
                            st = !reader.IsDBNull(5) ? reader.GetInt32(5) : 0;
                            txtCPFDoador.Text = !reader.IsDBNull(6) ? reader.GetInt64(6).ToString() : "";
                            txtCPFRecebedor.Text = !reader.IsDBNull(7) ? reader.GetInt64(7).ToString() : "";
                        }
                        reader.Close();

                        if (st == 0)
                        {
                            rdbAtivo.Checked = true;
                        }
                        else if (st == 1)
                            rdbAguardando.Checked = true;
                    }
                    txtCPFRecebedor.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        int atv;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conexao = new MySqlConnection(data_source);
            Conexao.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conexao;

            if (tabela == "cadastro_pedido")
            {

                cmd.Parameters.Clear(); 
                cmd.CommandText =
                    "UPDATE cadastro_pedido " +
                    "SET registro = @registro, subcategoria_1 = @subcategoria_1, subcategoria_2 = @subcategoria2, subcategoria_3 = @subcategoria3 " + 
                    ", descricao = @descricao, doador_cpf = @doadorcpf, recebedor_cpf = @recebedorcpf, status = @status" +
                    " WHERE registro = @id";
                cmd.Parameters.AddWithValue("@registro", Convert.ToInt32(txtRegistro.Text));
                cmd.Parameters.AddWithValue("@subcategoria_1", txtSub1.Text);
                cmd.Parameters.AddWithValue("@subcategoria2", txtSub2.Text);
                cmd.Parameters.AddWithValue("@subcategoria3", txtSub3.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                if (string.IsNullOrEmpty(txtCPFDoador.Text))
                {
                    cmd.Parameters.AddWithValue("doadorcpf", null);
                }
                else
                    cmd.Parameters.AddWithValue("@doadorcpf", Convert.ToInt64(txtCPFDoador.Text));

                cmd.Parameters.AddWithValue("@recebedorcpf", Convert.ToInt64(txtCPFRecebedor.Text));
                if (rdbAtivo.Checked == true)
                {
                    atv = 0;
                    cmd.Parameters.AddWithValue("@status", atv);
                }
                else if (rdbAguardando.Checked == true)
                {
                    atv = 1;
                    cmd.Parameters.AddWithValue("@status", atv);
                }

                if (string.IsNullOrEmpty(txtCPFDoador.Text) || string.IsNullOrEmpty(txtCPFRecebedor.Text))
                    atv = 0;
                else
                    atv = 1;


                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtRegistro.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Contato Atualizado com Sucesso", "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            else if (tabela == "cadastro_doacao")
            {

                cmd.Parameters.Clear();
                cmd.CommandText =
                    "UPDATE cadastro_doacao " +
                    "SET registro = @registro, subcategoria_1 = @subcategoria_1, subcategoria_2 = @subcategoria2, subcategoria_3 = @subcategoria3 " +
                    ", descricao = @descricao, doador2_cpf = @doadorcpf, recebedor_cpf = @recebedorcpf, status = @status" +
                    " WHERE registro = @id";
                cmd.Parameters.AddWithValue("@registro", Convert.ToInt32(txtRegistro.Text));
                cmd.Parameters.AddWithValue("@subcategoria_1", txtSub1.Text);
                cmd.Parameters.AddWithValue("@subcategoria2", txtSub2.Text);
                cmd.Parameters.AddWithValue("@subcategoria3", txtSub3.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@doadorcpf", Convert.ToInt64(txtCPFDoador.Text));
                if(string.IsNullOrEmpty(txtCPFRecebedor.Text))
                {
                    cmd.Parameters.AddWithValue("recebedorcpf", null);
                }
                else
                cmd.Parameters.AddWithValue("@recebedorcpf", Convert.ToInt64(txtCPFRecebedor.Text));

                if (rdbAtivo.Checked == true)
                {
                    atv = 0;
                    cmd.Parameters.AddWithValue("@status", atv);
                }
                else if (rdbAguardando.Checked == true)
                {
                    atv = 1;
                    cmd.Parameters.AddWithValue("@status", atv);
                }

                if (string.IsNullOrEmpty(txtCPFDoador.Text) || string.IsNullOrEmpty(txtCPFRecebedor.Text))
                    atv = 0;
                else 
                    atv = 1;
                    


                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtRegistro.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Contato Atualizado com Sucesso", "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            this.Close();
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Deseja excluir o contato?", "EXCLUIR!", MessageBoxButtons.YesNo);

            if (conf == DialogResult.Yes)
            {
                if (tabela == "cadastro_pedido")
                {
                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conexao;

                    cmd.CommandText = "DELETE FROM cadastro_pedido WHERE registro = @registro";
                    cmd.Parameters.AddWithValue("@registro", registro);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contato excluido com sucesso");
                }
                else if (tabela == "cadastro_doacao")
                {
                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conexao;

                    cmd.CommandText = "DELETE FROM cadastro_doacao WHERE registro = @registro";
                    cmd.Parameters.AddWithValue("@registro", registro);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contato excluido com sucesso");

                }
                    this.Close();

            }
        }
        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
