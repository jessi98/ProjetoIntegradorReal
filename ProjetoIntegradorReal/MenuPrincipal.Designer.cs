namespace ProjetoIntegradorReal
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.cbxPedidoDoacao = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lstBusca = new System.Windows.Forms.ListView();
            this.lstEspera = new System.Windows.Forms.ListView();
            this.lblPedidosDoacao = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCesta = new System.Windows.Forms.Label();
            this.lblEletro3 = new System.Windows.Forms.Label();
            this.lblEletro2 = new System.Windows.Forms.Label();
            this.lblEletro1 = new System.Windows.Forms.Label();
            this.cbxCestaBasica = new System.Windows.Forms.ComboBox();
            this.cbxEletrodomestico3 = new System.Windows.Forms.ComboBox();
            this.cbxEletrodomestico2 = new System.Windows.Forms.ComboBox();
            this.cbxEletrodomestico = new System.Windows.Forms.ComboBox();
            this.lblLivro2 = new System.Windows.Forms.Label();
            this.lblLivro1 = new System.Windows.Forms.Label();
            this.cbxLivro2 = new System.Windows.Forms.ComboBox();
            this.cbxLivro1 = new System.Windows.Forms.ComboBox();
            this.lblBrinq2 = new System.Windows.Forms.Label();
            this.cbxBrinq2 = new System.Windows.Forms.ComboBox();
            this.cbxBrinq1 = new System.Windows.Forms.ComboBox();
            this.lblBrinq1 = new System.Windows.Forms.Label();
            this.lblRoupa2 = new System.Windows.Forms.Label();
            this.lblRoupa3 = new System.Windows.Forms.Label();
            this.cbxRoupa2 = new System.Windows.Forms.ComboBox();
            this.cbxRoupa3 = new System.Windows.Forms.ComboBox();
            this.cbxRoupa1 = new System.Windows.Forms.ComboBox();
            this.lblRoupa1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Status = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarPessoa = new System.Windows.Forms.Button();
            this.btnCadastroPedido = new System.Windows.Forms.Button();
            this.btnCadastroDoacao = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPedidoDoacao
            // 
            this.cbxPedidoDoacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPedidoDoacao.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxPedidoDoacao.FormattingEnabled = true;
            this.cbxPedidoDoacao.Items.AddRange(new object[] {
            "Doação",
            "Pedido"});
            this.cbxPedidoDoacao.Location = new System.Drawing.Point(776, 25);
            this.cbxPedidoDoacao.Name = "cbxPedidoDoacao";
            this.cbxPedidoDoacao.Size = new System.Drawing.Size(150, 27);
            this.cbxPedidoDoacao.TabIndex = 5;
            this.cbxPedidoDoacao.SelectedIndexChanged += new System.EventHandler(this.cbxPedidoDoacao_SelectedIndexChanged);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Enabled = false;
            this.cbxCategoria.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Roupas",
            "Brinquedos",
            "Livros",
            "Eletrodomésticos",
            "Cesta Básica"});
            this.cbxCategoria.Location = new System.Drawing.Point(776, 58);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(150, 27);
            this.cbxCategoria.TabIndex = 6;
            this.cbxCategoria.Visible = false;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // lstBusca
            // 
            this.lstBusca.Font = new System.Drawing.Font("Candara", 12F);
            this.lstBusca.HideSelection = false;
            this.lstBusca.Location = new System.Drawing.Point(473, 159);
            this.lstBusca.Name = "lstBusca";
            this.lstBusca.Size = new System.Drawing.Size(564, 420);
            this.lstBusca.TabIndex = 10;
            this.lstBusca.UseCompatibleStateImageBehavior = false;
            this.lstBusca.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstBusca_ItemSelectionChanged);
            this.lstBusca.Click += new System.EventHandler(this.Status_Click);
            // 
            // lstEspera
            // 
            this.lstEspera.Font = new System.Drawing.Font("Candara", 12F);
            this.lstEspera.HideSelection = false;
            this.lstEspera.Location = new System.Drawing.Point(12, 159);
            this.lstEspera.Name = "lstEspera";
            this.lstEspera.Size = new System.Drawing.Size(452, 361);
            this.lstEspera.TabIndex = 11;
            this.lstEspera.UseCompatibleStateImageBehavior = false;
            this.lstEspera.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstEspera_ItemSelectionChanged);
            this.lstEspera.SelectedIndexChanged += new System.EventHandler(this.lstEspera_SelectedIndexChanged);
            this.lstEspera.Click += new System.EventHandler(this.Status_Click);
            // 
            // lblPedidosDoacao
            // 
            this.lblPedidosDoacao.AutoSize = true;
            this.lblPedidosDoacao.BackColor = System.Drawing.Color.Transparent;
            this.lblPedidosDoacao.Font = new System.Drawing.Font("Candara", 12F);
            this.lblPedidosDoacao.Location = new System.Drawing.Point(657, 33);
            this.lblPedidosDoacao.Name = "lblPedidosDoacao";
            this.lblPedidosDoacao.Size = new System.Drawing.Size(118, 19);
            this.lblPedidosDoacao.TabIndex = 13;
            this.lblPedidosDoacao.Text = "Pedidos/Doação";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Enabled = false;
            this.lblCategoria.Font = new System.Drawing.Font("Candara", 12F);
            this.lblCategoria.Location = new System.Drawing.Point(695, 66);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 19);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCategoria.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(653, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 2);
            this.label1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ProjetoIntegradorReal.Properties.Resources.info;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(949, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Sobre";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCesta
            // 
            this.lblCesta.AutoSize = true;
            this.lblCesta.BackColor = System.Drawing.Color.Transparent;
            this.lblCesta.Enabled = false;
            this.lblCesta.Font = new System.Drawing.Font("Candara", 12F);
            this.lblCesta.Location = new System.Drawing.Point(616, 103);
            this.lblCesta.Name = "lblCesta";
            this.lblCesta.Size = new System.Drawing.Size(42, 19);
            this.lblCesta.TabIndex = 87;
            this.lblCesta.Text = "Tipo:";
            this.lblCesta.Visible = false;
            // 
            // lblEletro3
            // 
            this.lblEletro3.AutoSize = true;
            this.lblEletro3.BackColor = System.Drawing.Color.Transparent;
            this.lblEletro3.Enabled = false;
            this.lblEletro3.Font = new System.Drawing.Font("Candara", 12F);
            this.lblEletro3.Location = new System.Drawing.Point(930, 104);
            this.lblEletro3.Name = "lblEletro3";
            this.lblEletro3.Size = new System.Drawing.Size(60, 19);
            this.lblEletro3.TabIndex = 86;
            this.lblEletro3.Text = "Estado:";
            this.lblEletro3.Visible = false;
            // 
            // lblEletro2
            // 
            this.lblEletro2.AutoSize = true;
            this.lblEletro2.BackColor = System.Drawing.Color.Transparent;
            this.lblEletro2.Enabled = false;
            this.lblEletro2.Font = new System.Drawing.Font("Candara", 12F);
            this.lblEletro2.Location = new System.Drawing.Point(766, 104);
            this.lblEletro2.Name = "lblEletro2";
            this.lblEletro2.Size = new System.Drawing.Size(79, 19);
            this.lblEletro2.TabIndex = 85;
            this.lblEletro2.Text = "Voltagem:";
            this.lblEletro2.Visible = false;
            // 
            // lblEletro1
            // 
            this.lblEletro1.AutoSize = true;
            this.lblEletro1.BackColor = System.Drawing.Color.Transparent;
            this.lblEletro1.Enabled = false;
            this.lblEletro1.Font = new System.Drawing.Font("Candara", 12F);
            this.lblEletro1.Location = new System.Drawing.Point(616, 103);
            this.lblEletro1.Name = "lblEletro1";
            this.lblEletro1.Size = new System.Drawing.Size(42, 19);
            this.lblEletro1.TabIndex = 84;
            this.lblEletro1.Text = "Tipo:";
            this.lblEletro1.Visible = false;
            // 
            // cbxCestaBasica
            // 
            this.cbxCestaBasica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCestaBasica.Enabled = false;
            this.cbxCestaBasica.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxCestaBasica.FormattingEnabled = true;
            this.cbxCestaBasica.Items.AddRange(new object[] {
            "Cesta Básica",
            "Congelados",
            "Produtos de Limpeza",
            "Produtos de Higiene"});
            this.cbxCestaBasica.Location = new System.Drawing.Point(572, 126);
            this.cbxCestaBasica.Name = "cbxCestaBasica";
            this.cbxCestaBasica.Size = new System.Drawing.Size(150, 27);
            this.cbxCestaBasica.TabIndex = 83;
            this.cbxCestaBasica.Visible = false;
            this.cbxCestaBasica.SelectedIndexChanged += new System.EventHandler(this.cbxCestaBasica_SelectedIndexChanged);
            // 
            // cbxEletrodomestico3
            // 
            this.cbxEletrodomestico3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEletrodomestico3.Enabled = false;
            this.cbxEletrodomestico3.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxEletrodomestico3.FormattingEnabled = true;
            this.cbxEletrodomestico3.Items.AddRange(new object[] {
            "Semi-novo",
            "Usado"});
            this.cbxEletrodomestico3.Location = new System.Drawing.Point(884, 125);
            this.cbxEletrodomestico3.Name = "cbxEletrodomestico3";
            this.cbxEletrodomestico3.Size = new System.Drawing.Size(150, 27);
            this.cbxEletrodomestico3.TabIndex = 82;
            this.cbxEletrodomestico3.Visible = false;
            this.cbxEletrodomestico3.SelectedIndexChanged += new System.EventHandler(this.cbxEletrodomestico3_SelectedIndexChanged);
            // 
            // cbxEletrodomestico2
            // 
            this.cbxEletrodomestico2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEletrodomestico2.Enabled = false;
            this.cbxEletrodomestico2.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxEletrodomestico2.FormattingEnabled = true;
            this.cbxEletrodomestico2.Items.AddRange(new object[] {
            "110V",
            "220V",
            "Bivolt"});
            this.cbxEletrodomestico2.Location = new System.Drawing.Point(728, 125);
            this.cbxEletrodomestico2.Name = "cbxEletrodomestico2";
            this.cbxEletrodomestico2.Size = new System.Drawing.Size(150, 27);
            this.cbxEletrodomestico2.TabIndex = 81;
            this.cbxEletrodomestico2.Visible = false;
            this.cbxEletrodomestico2.SelectedIndexChanged += new System.EventHandler(this.cbxEletrodomestico2_SelectedIndexChanged);
            // 
            // cbxEletrodomestico
            // 
            this.cbxEletrodomestico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEletrodomestico.Enabled = false;
            this.cbxEletrodomestico.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxEletrodomestico.FormattingEnabled = true;
            this.cbxEletrodomestico.Items.AddRange(new object[] {
            "Aspirador",
            "Batedeira",
            "Fogão",
            "Geladeira",
            "Liquidificador",
            "Máquina de lavar",
            "Televisão",
            "Ventilador"});
            this.cbxEletrodomestico.Location = new System.Drawing.Point(572, 126);
            this.cbxEletrodomestico.Name = "cbxEletrodomestico";
            this.cbxEletrodomestico.Size = new System.Drawing.Size(150, 27);
            this.cbxEletrodomestico.TabIndex = 80;
            this.cbxEletrodomestico.Visible = false;
            this.cbxEletrodomestico.SelectedIndexChanged += new System.EventHandler(this.cbxEletrodomestico_SelectedIndexChanged);
            // 
            // lblLivro2
            // 
            this.lblLivro2.AutoSize = true;
            this.lblLivro2.BackColor = System.Drawing.Color.Transparent;
            this.lblLivro2.Enabled = false;
            this.lblLivro2.Font = new System.Drawing.Font("Candara", 12F);
            this.lblLivro2.Location = new System.Drawing.Point(776, 104);
            this.lblLivro2.Name = "lblLivro2";
            this.lblLivro2.Size = new System.Drawing.Size(60, 19);
            this.lblLivro2.TabIndex = 79;
            this.lblLivro2.Text = "Estado:";
            this.lblLivro2.Visible = false;
            // 
            // lblLivro1
            // 
            this.lblLivro1.AutoSize = true;
            this.lblLivro1.BackColor = System.Drawing.Color.Transparent;
            this.lblLivro1.Enabled = false;
            this.lblLivro1.Font = new System.Drawing.Font("Candara", 12F);
            this.lblLivro1.Location = new System.Drawing.Point(616, 103);
            this.lblLivro1.Name = "lblLivro1";
            this.lblLivro1.Size = new System.Drawing.Size(63, 19);
            this.lblLivro1.TabIndex = 78;
            this.lblLivro1.Text = "Gênero:";
            this.lblLivro1.Visible = false;
            // 
            // cbxLivro2
            // 
            this.cbxLivro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLivro2.Enabled = false;
            this.cbxLivro2.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxLivro2.FormattingEnabled = true;
            this.cbxLivro2.Items.AddRange(new object[] {
            "Novo",
            "Semi-novo",
            "Usado"});
            this.cbxLivro2.Location = new System.Drawing.Point(728, 125);
            this.cbxLivro2.Name = "cbxLivro2";
            this.cbxLivro2.Size = new System.Drawing.Size(150, 27);
            this.cbxLivro2.TabIndex = 77;
            this.cbxLivro2.Visible = false;
            this.cbxLivro2.SelectedIndexChanged += new System.EventHandler(this.cbxLivro2_SelectedIndexChanged);
            // 
            // cbxLivro1
            // 
            this.cbxLivro1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLivro1.Enabled = false;
            this.cbxLivro1.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxLivro1.FormattingEnabled = true;
            this.cbxLivro1.Items.AddRange(new object[] {
            "Aventura",
            "Biografia",
            "Clássicos",
            "Contos",
            "Crônica",
            "Didático",
            "Drama",
            "Fantasia",
            "Ficção Científica",
            "Infantil",
            "Mistério",
            "Poesia",
            "Religioso",
            "Romance",
            "Suspense",
            "Terror"});
            this.cbxLivro1.Location = new System.Drawing.Point(572, 126);
            this.cbxLivro1.Name = "cbxLivro1";
            this.cbxLivro1.Size = new System.Drawing.Size(150, 27);
            this.cbxLivro1.TabIndex = 76;
            this.cbxLivro1.Visible = false;
            this.cbxLivro1.SelectedIndexChanged += new System.EventHandler(this.cbxLivro1_SelectedIndexChanged);
            // 
            // lblBrinq2
            // 
            this.lblBrinq2.AutoSize = true;
            this.lblBrinq2.BackColor = System.Drawing.Color.Transparent;
            this.lblBrinq2.Enabled = false;
            this.lblBrinq2.Font = new System.Drawing.Font("Candara", 12F);
            this.lblBrinq2.Location = new System.Drawing.Point(778, 104);
            this.lblBrinq2.Name = "lblBrinq2";
            this.lblBrinq2.Size = new System.Drawing.Size(51, 19);
            this.lblBrinq2.TabIndex = 75;
            this.lblBrinq2.Text = "Idade:";
            this.lblBrinq2.Visible = false;
            // 
            // cbxBrinq2
            // 
            this.cbxBrinq2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBrinq2.Enabled = false;
            this.cbxBrinq2.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxBrinq2.FormattingEnabled = true;
            this.cbxBrinq2.Items.AddRange(new object[] {
            "0 - 12 Meses",
            "1 - 3 Anos",
            "4 - 6 Anos",
            "1 - 12 Anos",
            "13+ Anos"});
            this.cbxBrinq2.Location = new System.Drawing.Point(728, 125);
            this.cbxBrinq2.Name = "cbxBrinq2";
            this.cbxBrinq2.Size = new System.Drawing.Size(150, 27);
            this.cbxBrinq2.TabIndex = 74;
            this.cbxBrinq2.Visible = false;
            this.cbxBrinq2.SelectedIndexChanged += new System.EventHandler(this.cbxBrinq2_SelectedIndexChanged);
            // 
            // cbxBrinq1
            // 
            this.cbxBrinq1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBrinq1.Enabled = false;
            this.cbxBrinq1.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxBrinq1.FormattingEnabled = true;
            this.cbxBrinq1.Items.AddRange(new object[] {
            "Bonecos",
            "Cartas",
            "Construção",
            "Criativo",
            "Educativo",
            "Eletrônico",
            "Esporte",
            "Musical",
            "Tabuleiro",
            "Veículos"});
            this.cbxBrinq1.Location = new System.Drawing.Point(572, 126);
            this.cbxBrinq1.Name = "cbxBrinq1";
            this.cbxBrinq1.Size = new System.Drawing.Size(150, 27);
            this.cbxBrinq1.TabIndex = 73;
            this.cbxBrinq1.Visible = false;
            this.cbxBrinq1.SelectedIndexChanged += new System.EventHandler(this.cbxBrinq1_SelectedIndexChanged);
            // 
            // lblBrinq1
            // 
            this.lblBrinq1.AutoSize = true;
            this.lblBrinq1.BackColor = System.Drawing.Color.Transparent;
            this.lblBrinq1.Enabled = false;
            this.lblBrinq1.Font = new System.Drawing.Font("Candara", 12F);
            this.lblBrinq1.Location = new System.Drawing.Point(616, 103);
            this.lblBrinq1.Name = "lblBrinq1";
            this.lblBrinq1.Size = new System.Drawing.Size(42, 19);
            this.lblBrinq1.TabIndex = 72;
            this.lblBrinq1.Text = "Tipo:";
            this.lblBrinq1.Visible = false;
            // 
            // lblRoupa2
            // 
            this.lblRoupa2.AutoSize = true;
            this.lblRoupa2.BackColor = System.Drawing.Color.Transparent;
            this.lblRoupa2.Enabled = false;
            this.lblRoupa2.Font = new System.Drawing.Font("Candara", 12F);
            this.lblRoupa2.Location = new System.Drawing.Point(769, 104);
            this.lblRoupa2.Name = "lblRoupa2";
            this.lblRoupa2.Size = new System.Drawing.Size(76, 19);
            this.lblRoupa2.TabIndex = 71;
            this.lblRoupa2.Text = "Tamanho:";
            this.lblRoupa2.Visible = false;
            // 
            // lblRoupa3
            // 
            this.lblRoupa3.AutoSize = true;
            this.lblRoupa3.BackColor = System.Drawing.Color.Transparent;
            this.lblRoupa3.Enabled = false;
            this.lblRoupa3.Font = new System.Drawing.Font("Candara", 12F);
            this.lblRoupa3.Location = new System.Drawing.Point(930, 103);
            this.lblRoupa3.Name = "lblRoupa3";
            this.lblRoupa3.Size = new System.Drawing.Size(45, 19);
            this.lblRoupa3.TabIndex = 70;
            this.lblRoupa3.Text = "Peça:";
            this.lblRoupa3.Visible = false;
            // 
            // cbxRoupa2
            // 
            this.cbxRoupa2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoupa2.Enabled = false;
            this.cbxRoupa2.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxRoupa2.FormattingEnabled = true;
            this.cbxRoupa2.Items.AddRange(new object[] {
            "Infantil - RN",
            "Infantil - n1 a n4",
            "Infantil - n6 a n8",
            "Infantil - n10 a n12",
            "Infantil - n14 a n16",
            "P",
            "M",
            "G",
            "GG",
            "XG"});
            this.cbxRoupa2.Location = new System.Drawing.Point(728, 125);
            this.cbxRoupa2.Name = "cbxRoupa2";
            this.cbxRoupa2.Size = new System.Drawing.Size(150, 27);
            this.cbxRoupa2.TabIndex = 69;
            this.cbxRoupa2.Visible = false;
            this.cbxRoupa2.SelectedIndexChanged += new System.EventHandler(this.cbxRoupa2_SelectedIndexChanged);
            // 
            // cbxRoupa3
            // 
            this.cbxRoupa3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoupa3.Enabled = false;
            this.cbxRoupa3.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxRoupa3.FormattingEnabled = true;
            this.cbxRoupa3.Items.AddRange(new object[] {
            "Camiseta",
            "Calça",
            "Bermuda",
            "Vestido",
            "Blusa",
            "Roupa Íntima"});
            this.cbxRoupa3.Location = new System.Drawing.Point(884, 126);
            this.cbxRoupa3.Name = "cbxRoupa3";
            this.cbxRoupa3.Size = new System.Drawing.Size(150, 27);
            this.cbxRoupa3.TabIndex = 68;
            this.cbxRoupa3.Visible = false;
            this.cbxRoupa3.SelectedIndexChanged += new System.EventHandler(this.cbxRoupa3_SelectedIndexChanged);
            // 
            // cbxRoupa1
            // 
            this.cbxRoupa1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoupa1.Enabled = false;
            this.cbxRoupa1.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxRoupa1.FormattingEnabled = true;
            this.cbxRoupa1.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cbxRoupa1.Location = new System.Drawing.Point(572, 126);
            this.cbxRoupa1.Name = "cbxRoupa1";
            this.cbxRoupa1.Size = new System.Drawing.Size(150, 27);
            this.cbxRoupa1.TabIndex = 67;
            this.cbxRoupa1.Visible = false;
            this.cbxRoupa1.SelectedIndexChanged += new System.EventHandler(this.cbxRoupa1_SelectedIndexChanged);
            // 
            // lblRoupa1
            // 
            this.lblRoupa1.AutoSize = true;
            this.lblRoupa1.BackColor = System.Drawing.Color.Transparent;
            this.lblRoupa1.Enabled = false;
            this.lblRoupa1.Font = new System.Drawing.Font("Candara", 12F);
            this.lblRoupa1.Location = new System.Drawing.Point(616, 103);
            this.lblRoupa1.Name = "lblRoupa1";
            this.lblRoupa1.Size = new System.Drawing.Size(63, 19);
            this.lblRoupa1.TabIndex = 66;
            this.lblRoupa1.Text = "Gênero:";
            this.lblRoupa1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 26);
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(106, 22);
            this.Status.Text = "Status";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(205, 535);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(281, 547);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 535);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrarPessoa
            // 
            this.btnCadastrarPessoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarPessoa.FlatAppearance.BorderSize = 2;
            this.btnCadastrarPessoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnCadastrarPessoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarPessoa.Font = new System.Drawing.Font("Candara", 12F);
            this.btnCadastrarPessoa.Image = global::ProjetoIntegradorReal.Properties.Resources.pessoa2;
            this.btnCadastrarPessoa.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCadastrarPessoa.Location = new System.Drawing.Point(12, 45);
            this.btnCadastrarPessoa.Name = "btnCadastrarPessoa";
            this.btnCadastrarPessoa.Size = new System.Drawing.Size(150, 60);
            this.btnCadastrarPessoa.TabIndex = 12;
            this.btnCadastrarPessoa.Text = "Cadastrar\r\nPessoa";
            this.btnCadastrarPessoa.UseVisualStyleBackColor = false;
            this.btnCadastrarPessoa.Click += new System.EventHandler(this.btnCadastrarPessoa_Click);
            // 
            // btnCadastroPedido
            // 
            this.btnCadastroPedido.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroPedido.FlatAppearance.BorderSize = 2;
            this.btnCadastroPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroPedido.Font = new System.Drawing.Font("Candara", 12F);
            this.btnCadastroPedido.Image = global::ProjetoIntegradorReal.Properties.Resources.pedido;
            this.btnCadastroPedido.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCadastroPedido.Location = new System.Drawing.Point(163, 45);
            this.btnCadastroPedido.Name = "btnCadastroPedido";
            this.btnCadastroPedido.Size = new System.Drawing.Size(150, 60);
            this.btnCadastroPedido.TabIndex = 1;
            this.btnCadastroPedido.Text = "Cadastro de\r\nPedido";
            this.btnCadastroPedido.UseVisualStyleBackColor = false;
            this.btnCadastroPedido.Click += new System.EventHandler(this.btnCadastroPedido_Click);
            // 
            // btnCadastroDoacao
            // 
            this.btnCadastroDoacao.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadastroDoacao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroDoacao.FlatAppearance.BorderSize = 2;
            this.btnCadastroDoacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroDoacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroDoacao.Font = new System.Drawing.Font("Candara", 12F);
            this.btnCadastroDoacao.Image = global::ProjetoIntegradorReal.Properties.Resources.coracao__1_;
            this.btnCadastroDoacao.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCadastroDoacao.Location = new System.Drawing.Point(314, 45);
            this.btnCadastroDoacao.Name = "btnCadastroDoacao";
            this.btnCadastroDoacao.Size = new System.Drawing.Size(150, 60);
            this.btnCadastroDoacao.TabIndex = 0;
            this.btnCadastroDoacao.Text = "Cadastor de\r\nDoação";
            this.btnCadastroDoacao.UseVisualStyleBackColor = false;
            this.btnCadastroDoacao.Click += new System.EventHandler(this.btnCadastroDoacao_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Font = new System.Drawing.Font("Candara", 9.75F);
            this.button2.Image = global::ProjetoIntegradorReal.Properties.Resources.atualizar__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 27);
            this.button2.TabIndex = 88;
            this.button2.Text = "Atualizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::ProjetoIntegradorReal.Properties.Resources.fundo2;
            this.ClientSize = new System.Drawing.Size(1049, 621);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCesta);
            this.Controls.Add(this.lblEletro3);
            this.Controls.Add(this.lblEletro2);
            this.Controls.Add(this.lblEletro1);
            this.Controls.Add(this.cbxCestaBasica);
            this.Controls.Add(this.cbxEletrodomestico3);
            this.Controls.Add(this.cbxEletrodomestico2);
            this.Controls.Add(this.cbxEletrodomestico);
            this.Controls.Add(this.lblLivro2);
            this.Controls.Add(this.lblLivro1);
            this.Controls.Add(this.cbxLivro2);
            this.Controls.Add(this.cbxLivro1);
            this.Controls.Add(this.lblBrinq2);
            this.Controls.Add(this.cbxBrinq2);
            this.Controls.Add(this.cbxBrinq1);
            this.Controls.Add(this.lblBrinq1);
            this.Controls.Add(this.lblRoupa2);
            this.Controls.Add(this.lblRoupa3);
            this.Controls.Add(this.cbxRoupa2);
            this.Controls.Add(this.cbxRoupa3);
            this.Controls.Add(this.cbxRoupa1);
            this.Controls.Add(this.lblRoupa1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPedidosDoacao);
            this.Controls.Add(this.btnCadastrarPessoa);
            this.Controls.Add(this.lstEspera);
            this.Controls.Add(this.lstBusca);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxPedidoDoacao);
            this.Controls.Add(this.btnCadastroPedido);
            this.Controls.Add(this.btnCadastroDoacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroDoacao;
        private System.Windows.Forms.Button btnCadastroPedido;
        private System.Windows.Forms.ComboBox cbxPedidoDoacao;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ListView lstBusca;
        private System.Windows.Forms.ListView lstEspera;
        private System.Windows.Forms.Button btnCadastrarPessoa;
        private System.Windows.Forms.Label lblPedidosDoacao;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblCesta;
        private System.Windows.Forms.Label lblEletro3;
        private System.Windows.Forms.Label lblEletro2;
        private System.Windows.Forms.Label lblEletro1;
        private System.Windows.Forms.ComboBox cbxCestaBasica;
        private System.Windows.Forms.ComboBox cbxEletrodomestico3;
        private System.Windows.Forms.ComboBox cbxEletrodomestico2;
        private System.Windows.Forms.ComboBox cbxEletrodomestico;
        private System.Windows.Forms.Label lblLivro2;
        private System.Windows.Forms.Label lblLivro1;
        private System.Windows.Forms.ComboBox cbxLivro2;
        private System.Windows.Forms.ComboBox cbxLivro1;
        private System.Windows.Forms.Label lblBrinq2;
        private System.Windows.Forms.ComboBox cbxBrinq2;
        private System.Windows.Forms.ComboBox cbxBrinq1;
        private System.Windows.Forms.Label lblBrinq1;
        private System.Windows.Forms.Label lblRoupa2;
        private System.Windows.Forms.Label lblRoupa3;
        private System.Windows.Forms.ComboBox cbxRoupa2;
        private System.Windows.Forms.ComboBox cbxRoupa3;
        private System.Windows.Forms.ComboBox cbxRoupa1;
        private System.Windows.Forms.Label lblRoupa1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Status;
        private System.Windows.Forms.Button button2;
    }
}