using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoIntegradorReal
{
    public partial class MenuPrincipal: Form
    {

        MySqlConnection Conexao;
        //private string data_source = "datasource=localhost;username=root;password=;database=doacao";
        private string data_source = "datasource=localhost;username=root;password=Martinsfreitas8;database=doacao";


        public MenuPrincipal()
        {
            InitializeComponent();

            lstBusca.Scrollable = true;
            lstBusca.View = View.Details;
            lstBusca.LabelEdit = true;
            lstBusca.AllowColumnReorder = true;
            lstBusca.FullRowSelect = true;
            lstBusca.GridLines = true;

            // Posição dos Cabeçalhos a serem exibidos na tela
            lstBusca.Columns.Add("Subcategoria 1", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Subcategoria 2", 150, HorizontalAlignment.Left);
            lstBusca.Columns.Add("Subcategoria 3", 150, HorizontalAlignment.Left);
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
            MostrarCategoria();
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
            if (cbxCategoria.Text == "Roupas")
            {
                EsconderTudo();
                MostrarRoupa();

                lstBusca.Columns[0].Text = lblRoupa1.Text;
                lstBusca.Columns[1].Text = lblRoupa2.Text;
                lstBusca.Columns[2].Text = lblRoupa3.Text;
                lstBusca.Refresh();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                AtualizarCom3();    
            }

            else if (cbxCategoria.Text == "Livros")
            {
                EsconderTudo();
                MostrarLivro();

                lstBusca.Columns[0].Text = lblRoupa1.Text;
                lstBusca.Columns[1].Text = lblRoupa2.Text;
                lstBusca.Columns[2].Text = lblRoupa3.Text;
                lstBusca.Refresh();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            else if (cbxCategoria.Text == "Brinquedos")
            {
                EsconderTudo();
                MostrarBrinq();

                lstBusca.Columns[0].Text = lblRoupa1.Text;
                lstBusca.Columns[1].Text = lblRoupa2.Text;
                lstBusca.Columns[2].Text = lblRoupa3.Text;
                lstBusca.Refresh();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else if (cbxCategoria.Text == "Eletrodomésticos")
            {
                EsconderTudo();
                MostrarEletro();

                lstBusca.Columns[0].Text = lblRoupa1.Text;
                lstBusca.Columns[1].Text = lblRoupa2.Text;
                lstBusca.Columns[2].Text = lblRoupa3.Text;
                lstBusca.Refresh();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else if (cbxCategoria.Text == "Cesta Básica")
            {
                EsconderTudo();
                MostrarCesta();

                lstBusca.Columns[0].Text = lblRoupa1.Text;
                lstBusca.Columns[1].Text = lblRoupa2.Text;
                lstBusca.Columns[2].Text = lblRoupa3.Text;
                lstBusca.Refresh();
                lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void AtualizarCom3()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                if (cbxPedidoDoacao.Text == "Pedido")
                {
                    String sql = "SELECT subcategoria_1, subcategoria_2, subcategoria_3, descricao FROM cadastro_pedido WHERE status = 0";

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
                                reader.GetString(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3)
                        };

                        var linha_list_view = new ListViewItem(row);
                        lstBusca.Items.Add(linha_list_view);
                    }
                }

                else if (cbxPedidoDoacao.Text == "Doação")
                {
                    String sql = "SELECT subcategoria_1, subcategoria_2, subcategoria_3, descricao FROM cadastro_doacao WHERE status = 0";

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
                                reader.GetString(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3)
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

        private void cbxRoupa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBusca.Columns[0].Text = lblRoupa1.Text;
            lstBusca.Columns[1].Text = lblRoupa2.Text;
            lstBusca.Columns[2].Text = lblRoupa3.Text;
            lstBusca.Refresh();
            AtualizarCom3();
            lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void cbxRoupa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBusca.Columns[0].Text = lblRoupa1.Text;
            lstBusca.Columns[1].Text = lblRoupa2.Text;
            lstBusca.Columns[2].Text = lblRoupa3.Text;
            lstBusca.Refresh();
            AtualizarCom3();
            lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void cbxRoupa3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBusca.Columns[0].Text = lblRoupa1.Text;
            lstBusca.Columns[1].Text = lblRoupa2.Text;
            lstBusca.Columns[2].Text = lblRoupa3.Text;
            lstBusca.Refresh();
            AtualizarCom3();
            lstBusca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
