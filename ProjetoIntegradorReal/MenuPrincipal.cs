using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoIntegradorReal
{
    public partial class MenuPrincipal : Form
    {

        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=doacao";

        public MenuPrincipal()
        {
            InitializeComponent();

            lstBusca.Scrollable = true;
            lstBusca.View = View.Details;
            lstBusca.LabelEdit = true;
            lstBusca.AllowColumnReorder = true;
            lstBusca.FullRowSelect = true;
            lstBusca.GridLines = true;

            //Posição dos Cabeçalhos a serem exibidos na tela
            lstBusca.Columns.Add("ID", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Subcategoria 1", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Subcategoria 2", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Subcategoria 3", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Descrição", 150, HorizontalAlignment.Left);

            Atualizar();
            
        }
        private void Carregar3Colunas()
        {
            lstBusca.Columns.Clear();
            lstBusca.Columns.Add("ID", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Subcategoria 1", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Subcategoria 2", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Subcategoria 3", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Descrição", 150, HorizontalAlignment.Left);
        }

        private void Carregar2Colunas()
        {

            lstBusca.Columns.Clear();
            lstBusca.Columns.Add("ID", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Subcategoria 1", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Subcategoria 2", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Descrição", 150, HorizontalAlignment.Left);
        }
        private void Carregar1Colunas()
        {

            lstBusca.Columns.Clear();
            lstBusca.Columns.Add("ID", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Subcategoria 1", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Descrição", 150, HorizontalAlignment.Left);
        }


        private void btnCadastroDoacao_Click(object sender, EventArgs e)
        {
            CadastroDoacao form = new CadastroDoacao();
            form.ShowDialog();
        }

        private void btnCadastroPedido_Click(object sender, EventArgs e)
        {
            CadastroPedido form = new CadastroPedido();
            form.ShowDialog();
        }

        private void btnEditarDoacao_Click(object sender, EventArgs e)
        {
            StatusDoacao form = new StatusDoacao();
            form.ShowDialog();
        }

        private void btnCadastrarPessoa_Click(object sender, EventArgs e)
        {
            CadastroPessoas form = new CadastroPessoas();
            form.ShowDialog();
        }

        private void cbxPedidoDoacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            EsconderTudo();
            cbxCategoria.SelectedIndex = -1;
            lstBusca.Items.Clear();
            MostrarCategoria();
        }


        private void LimparTudo()
        {
            var controles = new Control[]
            {
                cbxBrinq1, cbxBrinq2, cbxRoupa1, cbxRoupa2, cbxRoupa3, cbxEletrodomestico, cbxEletrodomestico2, cbxEletrodomestico3,
                cbxLivro1, cbxLivro2, cbxCestaBasica
            };
            foreach (var controle in controles)
            {
                if (controle is System.Windows.Forms.ComboBox)
                {
                    ((System.Windows.Forms.ComboBox)controle).SelectedIndex = -1;
                }
            }
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
                lblEletro1, lblEletro2, lblEletro3, lblCesta
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
                cbxEletrodomestico, cbxEletrodomestico2, cbxEletrodomestico3, lblEletro1, lblEletro2, lblEletro3
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
                cbxCestaBasica, lblCesta
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
                cbxCategoria
            };
            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;

            }
        }
        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparTudo();

            if (cbxCategoria.Text == "Roupas")
            {
                Carregar3Colunas();
                lstBusca.Items.Clear();
                EsconderTudo();
                MostrarRoupa();

                lstBusca.Columns[1].Text = lblRoupa1.Text;
                lstBusca.Columns[2].Text = lblRoupa2.Text;
                lstBusca.Columns[3].Text = lblRoupa3.Text;
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                if (cbxPedidoDoacao.Text == "Pedido")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, subcategoria_3, descricao FROM cadastro_pedido WHERE status = 0 AND categoria = @categoria";
                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.AddWithValue("@categoria", "Roupas");

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4)
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                    lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else if (cbxPedidoDoacao.Text == "Doação")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, subcategoria_3, descricao FROM cadastro_doacao WHERE status = 0 AND categoria = @categoria";
                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.AddWithValue("@categoria", "Roupas");

                    MySqlDataReader reader = buscar.ExecuteReader();


                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4)
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                }

                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            else if (cbxCategoria.Text == "Livros")
            {
                Carregar2Colunas();
                lstBusca.Items.Clear();
                EsconderTudo();
                MostrarLivro();

                lstBusca.Columns[1].Text = lblLivro1.Text;
                lstBusca.Columns[2].Text = lblLivro2.Text;

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                if (cbxPedidoDoacao.Text == "Pedido")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, descricao FROM cadastro_pedido WHERE status = 0 AND categoria = @categoria";
                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.AddWithValue("@categoria", "Livros");

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3)
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                    lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else if (cbxPedidoDoacao.Text == "Doação")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, descricao FROM cadastro_doacao WHERE status = 0 AND categoria = @categoria";
                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.AddWithValue("@categoria", "Livros");

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();


                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3)
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                    lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }

            else if (cbxCategoria.Text == "Brinquedos")
            {
                Carregar2Colunas();
                lstBusca.Items.Clear();
                EsconderTudo();
                MostrarBrinq();

                lstBusca.Columns[1].Text = lblBrinq1.Text;
                lstBusca.Columns[2].Text = lblBrinq2.Text;

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                if (cbxPedidoDoacao.Text == "Pedido")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, descricao FROM cadastro_pedido WHERE status = 0 AND categoria = @categoria";
                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.AddWithValue("@categoria", "Brinquedos");

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3)
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                    lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else if (cbxPedidoDoacao.Text == "Doação")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, descricao FROM cadastro_doacao WHERE status = 0 AND categoria = @categoria";
                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.AddWithValue("@categoria", "Brinquedos");

                    MySqlDataReader reader = buscar.ExecuteReader();


                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3)
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                    lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            else if (cbxCategoria.Text == "Eletrodomésticos")
            {
                Carregar3Colunas();
                lstBusca.Items.Clear();
                EsconderTudo();
                MostrarEletro();
                lstBusca.Columns[1].Text = lblEletro1.Text;
                lstBusca.Columns[2].Text = lblEletro2.Text;
                lstBusca.Columns[3].Text = lblEletro3.Text;
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                if (cbxPedidoDoacao.Text == "Pedido")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, subcategoria_3, descricao FROM cadastro_pedido WHERE status = 0 AND categoria = @categoria";
                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.AddWithValue("@categoria", "Eletrodomésticos");

                    MySqlDataReader reader = buscar.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4)
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                    lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else if (cbxPedidoDoacao.Text == "Doação")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, subcategoria_3, descricao FROM cadastro_doacao WHERE status = 0 AND categoria = @categoria";
                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.AddWithValue("@categoria", "Eletrodomésticos");

                    MySqlDataReader reader = buscar.ExecuteReader();


                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4)
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                    lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            else if (cbxCategoria.Text == "Cesta Básica")
            {
                Carregar1Colunas();
                lstBusca.Items.Clear();
                EsconderTudo();
                MostrarCesta();

                lstBusca.Columns[1].Text = lblCesta.Text;

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                if (cbxPedidoDoacao.Text == "Pedido")
                {
                    String sql = "SELECT registro, subcategoria_1, descricao FROM cadastro_pedido WHERE status = 0 AND categoria = @categoria";
                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.AddWithValue("@categoria", "Cesta Básica");

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2)
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                    lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else if (cbxPedidoDoacao.Text == "Doação")
                {
                    String sql = "SELECT registro, subcategoria_1, descricao FROM cadastro_doacao WHERE status = 0 AND categoria = @categoria";
                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.AddWithValue("@categoria", "Cesta Básica");

                    MySqlDataReader reader = buscar.ExecuteReader();


                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                    lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
        }

        //PESQUISA ROUPAS

        private void cbxRoupa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRoupa1.SelectedItem != null)
            {
                lstBusca.Columns[1].Text = lblRoupa1.Text;
                lstBusca.Columns[2].Text = lblRoupa2.Text;
                lstBusca.Columns[3].Text = lblRoupa3.Text;
                lstBusca.Refresh();
                AtualizarRoupa();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void cbxRoupa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRoupa2.SelectedItem != null)
            {
                lstBusca.Columns[1].Text = lblRoupa1.Text;
                lstBusca.Columns[2].Text = lblRoupa2.Text;
                lstBusca.Columns[3].Text = lblRoupa3.Text;
                lstBusca.Refresh();
                AtualizarRoupa();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void cbxRoupa3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRoupa3.SelectedItem != null)
            {
                lstBusca.Columns[1].Text = lblRoupa1.Text;
                lstBusca.Columns[2].Text = lblRoupa2.Text;
                lstBusca.Columns[3].Text = lblRoupa3.Text;
                lstBusca.Refresh();
                AtualizarRoupa();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }


        //PESQUISA BRINQUEDOS
        private void cbxBrinq1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBrinq1.SelectedItem != null)
            {
                Carregar2Colunas();
                lstBusca.Items.Clear();
                EsconderTudo();
                MostrarBrinq();
                lstBusca.Columns[1].Text = lblBrinq1.Text;
                lstBusca.Columns[2].Text = lblBrinq2.Text;
                AtualizarBrinq();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void cbxBrinq2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBrinq2.SelectedItem != null)
            {
                Carregar2Colunas();
                lstBusca.Items.Clear();
                EsconderTudo();
                MostrarBrinq();
                lstBusca.Columns[1].Text = lblBrinq1.Text;
                lstBusca.Columns[2].Text = lblBrinq2.Text;
                AtualizarBrinq();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }


        //PESQUISA ELETRODOMESTICOS
        private void cbxEletrodomestico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEletrodomestico.SelectedItem != null)
            {
                Carregar3Colunas();
                lstBusca.Items.Clear();
                EsconderTudo();
                MostrarEletro();
                lstBusca.Columns[1].Text = lblEletro1.Text;
                lstBusca.Columns[2].Text = lblEletro2.Text;
                lstBusca.Columns[3].Text = lblEletro3.Text;
                AtualizarEletro();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void cbxEletrodomestico2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEletrodomestico2.SelectedItem != null)
            {
                Carregar3Colunas();
                lstBusca.Items.Clear();
                EsconderTudo();
                MostrarEletro();
                lstBusca.Columns[1].Text = lblEletro1.Text;
                lstBusca.Columns[2].Text = lblEletro2.Text;
                lstBusca.Columns[3].Text = lblEletro3.Text;
                AtualizarEletro();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void cbxEletrodomestico3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEletrodomestico3.SelectedItem != null)
            {
                Carregar3Colunas();
                lstBusca.Items.Clear();
                EsconderTudo();
                MostrarEletro();
                lstBusca.Columns[1].Text = lblEletro1.Text;
                lstBusca.Columns[2].Text = lblEletro2.Text;
                lstBusca.Columns[3].Text = lblEletro3.Text;
                AtualizarEletro();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }


        //PESQUISA LIVROS
        private void cbxLivro1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLivro1.SelectedItem != null)
            {
                Carregar2Colunas();
                lstBusca.Items.Clear();
                EsconderTudo();
                MostrarLivro();
                lstBusca.Columns[1].Text = lblLivro1.Text;
                lstBusca.Columns[2].Text = lblLivro2.Text;
                AtualizarLivro();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void cbxLivro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLivro2.SelectedItem != null)
            {
                Carregar2Colunas();
                lstBusca.Items.Clear();
                EsconderTudo();
                MostrarLivro();
                lstBusca.Columns[1].Text = lblLivro1.Text;
                lstBusca.Columns[2].Text = lblLivro2.Text;
                AtualizarLivro();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }


        //PESQUISA CESTA-BASICA
        private void cbxCestaBasica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCestaBasica.SelectedItem != null)
            {
                Carregar1Colunas();
                lstBusca.Items.Clear();
                EsconderTudo();
                MostrarCesta();
                lstBusca.Columns[1].Text = lblCesta.Text;
                AtualizarCesta();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void AtualizarEletro()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                if (cbxPedidoDoacao.Text == "Pedido")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, subcategoria_3, descricao FROM cadastro_pedido WHERE status = 0";

                    if (cbxEletrodomestico.SelectedItem != null)
                    {
                        sql += " AND subcategoria_1 = @subcategoria1";
                    }
                    if (cbxEletrodomestico2.SelectedItem != null)
                    {
                        sql += " AND subcategoria_2 = @subcategoria2";
                    }
                    if (cbxEletrodomestico3.SelectedItem != null)
                    {
                        sql += " AND subcategoria_3 = @subcategoria3";
                    }

                    sql += " ORDER BY registro ASC";

                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.Clear();

                    if (cbxEletrodomestico.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria1", cbxEletrodomestico.Text);
                    }
                    if (cbxEletrodomestico2.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria2", cbxEletrodomestico2.Text);
                    }
                    if (cbxEletrodomestico3.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria3", cbxEletrodomestico3.Text);
                    }

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4)
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                }

                else if (cbxPedidoDoacao.Text == "Doação")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, subcategoria_3, descricao FROM cadastro_doacao WHERE status = 0";

                    if (cbxEletrodomestico.SelectedItem != null)
                    {
                        sql += " AND subcategoria_1 = @subcategoria1";
                    }
                    if (cbxEletrodomestico2.SelectedItem != null)
                    {
                        sql += " AND subcategoria_2 = @subcategoria2";
                    }
                    if (cbxEletrodomestico3.SelectedItem != null)
                    {
                        sql += " AND subcategoria_3 = @subcategoria3";
                    }

                    sql += " ORDER BY registro ASC";

                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    buscar.Parameters.Clear();

                    if (cbxEletrodomestico.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria1", cbxEletrodomestico.Text);
                    }
                    if (cbxEletrodomestico2.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria2", cbxEletrodomestico2.Text);
                    }
                    if (cbxEletrodomestico3.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria3", cbxEletrodomestico3.Text);
                    }

                    MySqlDataReader reader = buscar.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4)
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void AtualizarRoupa()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                if (cbxPedidoDoacao.Text == "Pedido")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, subcategoria_3, descricao FROM cadastro_pedido WHERE status = 0";

                    if (cbxRoupa1.SelectedItem != null)
                    {
                        sql += " AND subcategoria_1 = @subcategoria1";
                    }
                    if (cbxRoupa2.SelectedItem != null)
                    {
                        sql += " AND subcategoria_2 = @subcategoria2";
                    }
                    if (cbxRoupa3.SelectedItem != null)
                    {
                        sql += " AND subcategoria_3 = @subcategoria3";
                    }

                    sql += " ORDER BY registro ASC";

                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    lstBusca.Items.Clear();

                    if (cbxRoupa1.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria1", cbxRoupa1.Text);
                    }
                    if (cbxRoupa2.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria2", cbxRoupa2.Text);
                    }
                    if (cbxRoupa3.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria3", cbxRoupa3.Text);
                    }

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4)
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);

                    }
                }

                else if (cbxPedidoDoacao.Text == "Doação")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, subcategoria_3, descricao FROM cadastro_doacao WHERE status = 0";

                    if (cbxRoupa1.SelectedItem != null)
                    {
                        sql += " AND subcategoria_1 = @subcategoria1";
                    }
                    if (cbxRoupa2.SelectedItem != null)
                    {
                        sql += " AND subcategoria_2 = @subcategoria2";
                    }
                    if (cbxRoupa3.SelectedItem != null)
                    {
                        sql += " AND subcategoria_3 = @subcategoria3";
                    }

                    sql += " ORDER BY registro ASC";

                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);

                    if (cbxRoupa1.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria1", cbxRoupa1.Text);
                    }
                    if (cbxRoupa2.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria2", cbxRoupa2.Text);
                    }
                    if (cbxRoupa3.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria3", cbxRoupa3.Text);
                    }

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4)
                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void AtualizarLivro()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                if (cbxPedidoDoacao.Text == "Pedido")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, descricao FROM cadastro_pedido WHERE status = 0";

                    if (cbxLivro1.SelectedItem != null)
                    {
                        sql += " AND subcategoria_1 = @subcategoria1";
                    }
                    if (cbxLivro2.SelectedItem != null)
                    {
                        sql += " AND subcategoria_2 = @subcategoria2";
                    }

                    sql += " ORDER BY registro ASC";

                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);

                    if (cbxLivro1.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria1", cbxLivro1.Text);
                    }
                    if (cbxLivro2.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria2", cbxLivro2.Text);
                    }

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                        };

                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                }

                else if (cbxPedidoDoacao.Text == "Doação")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, descricao FROM cadastro_doacao WHERE status = 0";

                    if (cbxLivro1.SelectedItem != null)
                    {
                        sql += " AND subcategoria_1 = @subcategoria1";
                    }
                    if (cbxLivro2.SelectedItem != null)
                    {
                        sql += " AND subcategoria_2 = @subcategoria2";
                    }

                    sql += " ORDER BY registro ASC";

                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);

                    if (cbxLivro1.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria1", cbxLivro1.Text);
                    }
                    if (cbxLivro2.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria2", cbxLivro2.Text);
                    }

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                        };

                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void AtualizarBrinq()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                if (cbxPedidoDoacao.Text == "Pedido")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, descricao FROM cadastro_pedido WHERE status = 0";

                    if (cbxBrinq1.SelectedItem != null)
                    {
                        sql += " AND subcategoria_1 = @subcategoria1";
                    }
                    if (cbxBrinq2.SelectedItem != null)
                    {
                        sql += " AND subcategoria_2 = @subcategoria2";
                    }

                    sql += " ORDER BY registro ASC";

                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);

                    if (cbxBrinq1.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria1", cbxBrinq1.Text);
                    }
                    if (cbxBrinq2.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria2", cbxBrinq2.Text);
                    }

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),

                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);

                    }
                }

                else if (cbxPedidoDoacao.Text == "Doação")
                {
                    String sql = "SELECT registro, subcategoria_1, subcategoria_2, descricao FROM cadastro_doacao WHERE status = 0";

                    if (cbxBrinq1.SelectedItem != null)
                    {
                        sql += " AND subcategoria_1 = @subcategoria1";
                    }
                    if (cbxBrinq2.SelectedItem != null)
                    {
                        sql += " AND subcategoria_2 = @subcategoria2";
                    }

                    sql += " ORDER BY registro ASC";

                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);

                    if (cbxBrinq1.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria1", cbxBrinq1.Text);
                    }
                    if (cbxBrinq2.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria2", cbxBrinq2.Text);
                    }

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                        };

                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }

        }

        private void AtualizarCesta()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                if (cbxPedidoDoacao.Text == "Pedido")
                {
                    String sql = "SELECT registro, subcategoria_1, descricao FROM cadastro_pedido WHERE status = 0";

                    if (cbxCestaBasica.SelectedItem != null)
                    {
                        sql += " AND subcategoria_1 = @subcategoria1";
                    }

                    sql += " ORDER BY registro ASC";

                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);

                    if (cbxCestaBasica.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria1", cbxCestaBasica.Text);
                    }

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2)

                        };
                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);

                    }
                }

                else if (cbxPedidoDoacao.Text == "Doação")
                {
                    String sql = "SELECT registro, subcategoria_1, descricao FROM cadastro_doacao WHERE status = 0";

                    if (cbxCestaBasica.SelectedItem != null)
                    {
                        sql += " AND subcategoria_1 = @subcategoria1";
                    }

                    sql += " ORDER BY registro ASC";

                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);

                    if (cbxCestaBasica.SelectedItem != null)
                    {
                        buscar.Parameters.AddWithValue("@subcategoria1", cbxCestaBasica.Text);
                    }

                    MySqlDataReader reader = buscar.ExecuteReader();
                    lstBusca.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row =
                        {
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetString(2)
                        };

                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }

        }

        private void Status_Click(object sender, EventArgs e)
        {
            StatusDoacao form = new StatusDoacao();
            form.ShowDialog();
        }

        private void lstBusca_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            System.Windows.Forms.ListView.SelectedListViewItemCollection itens_selecionados = lstBusca.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {


                status status = new status();
                status.registro = Convert.ToInt32(item.SubItems[0].Text);
                status.tabela = cbxPedidoDoacao.Text;
                status.list.Clear();

                status.list.Add(status);
            }

        }

        public void Atualizar()
        {
            try
            {
                lstEspera.Clear();
                #region
                lstEspera.Scrollable = true;
                lstEspera.View = View.Details;
                lstEspera.LabelEdit = true;
                lstEspera.AllowColumnReorder = true;
                lstEspera.FullRowSelect = true;
                lstEspera.GridLines = true;

                //Posição dos Cabeçalhos a serem exibidos na tela
                lstEspera.Columns.Add("ID", 10, HorizontalAlignment.Left);
                lstEspera.Columns.Add("Doador", 75, HorizontalAlignment.Left);
                lstEspera.Columns.Add("Telefone", 75, HorizontalAlignment.Left);
                lstEspera.Columns.Add("Item", 100, HorizontalAlignment.Left);
                lstEspera.Columns.Add("Recebedor", 75, HorizontalAlignment.Left);
                lstEspera.Columns.Add("Telefone", 75, HorizontalAlignment.Left);
                lstEspera.Columns.Add("Origem", 75, HorizontalAlignment.Left);

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                string sql = "SELECT dc.registro, d.nome, d.telefone, dc.categoria, r.nome, r.telefone, 'Pedido' AS origem" +
                                " FROM cadastro_pedido dc" +
                                " JOIN pessoa_doador d ON dc.doador_cpf = d.cpf_doador" +
                                " JOIN pessoa_recebedor r ON dc.recebedor_cpf = r.cpf_recebedor" +
                                " WHERE status = 1";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var item = new ListViewItem(reader.GetInt32(0).ToString());
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetString(2));
                    item.SubItems.Add(reader.GetString(3));
                    item.SubItems.Add(reader.GetString(4));
                    item.SubItems.Add(reader.GetString(5));
                    item.SubItems.Add(reader.GetString(6));
                    lstEspera.Items.Add(item);
                }
                lstEspera.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                reader.Close();

                string sql2 = "SELECT dc.registro, d.nome, d.telefone, dc.categoria, r.nome, r.telefone, 'Doação' AS origem" +
                                " FROM cadastro_doacao dc" +
                                " JOIN pessoa_doador d ON dc.doador2_cpf = d.cpf_doador" +
                                " JOIN pessoa_recebedor r ON dc.recebedor_cpf = r.cpf_recebedor" +
                                " WHERE status = 1";
                MySqlCommand cmd2 = new MySqlCommand(sql2, Conexao);

                MySqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read())
                {
                    var item2 = new ListViewItem(reader2.GetInt32(0).ToString());
                    item2.SubItems.Add(reader2.GetString(1));
                    item2.SubItems.Add(reader2.GetString(2));
                    item2.SubItems.Add(reader2.GetString(3));
                    item2.SubItems.Add(reader2.GetString(4));
                    item2.SubItems.Add(reader2.GetString(5));
                    item2.SubItems.Add(reader2.GetString(6));
                    lstEspera.Items.Add(item2);
                }
                lstEspera.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                #endregion

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                Conexao.Close();
            }
           

        }

        private void lstEspera_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //public void MenuPrincipal_Load(object sender, EventArgs e)
        //{


        //}

        int id;
        string table;

        private void lstEspera_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            System.Windows.Forms.ListView.SelectedListViewItemCollection itens_selecionados = lstEspera.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                id = Convert.ToInt32(item.SubItems[0].Text);
                table = item.SubItems[6].Text;
                status status = new status();
                status.registro = id;
                status.tabela = table;

                status.list.Clear();

                status.list.Add(status);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa desenvolvido por: \n\n" +
                            "Andre Viana \n" +
                            "Jessica Batista \n" +
                            "Kauany Santos \n" +
                            "Theodoro Martins \n\n" +
                            "Versão 1.0 \n\n" +
                            "Agradecimento especial ao programa Tranforme-se, \n" +
                            "Senac e a todos os colaboradores e professores do projeto.",
                            "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information
                            );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Atualizar();
            lstBusca.Clear();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
