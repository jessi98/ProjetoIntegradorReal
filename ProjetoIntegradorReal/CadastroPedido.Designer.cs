namespace ProjetoIntegradorReal
{
    partial class CadastroPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPedido));
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblPeca = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.cbxPeca = new System.Windows.Forms.ComboBox();
            this.cbxTamanho = new System.Windows.Forms.ComboBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.lblLinha = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblTamanhoBrinq = new System.Windows.Forms.Label();
            this.lblBrinq = new System.Windows.Forms.Label();
            this.cbxTamanhoBrinq = new System.Windows.Forms.ComboBox();
            this.cbxBrinq = new System.Windows.Forms.ComboBox();
            this.cbxTipoBrinq = new System.Windows.Forms.ComboBox();
            this.lblTipoBrinq = new System.Windows.Forms.Label();
            this.cbxGeneroLivro = new System.Windows.Forms.ComboBox();
            this.cbxEstadoLivro = new System.Windows.Forms.ComboBox();
            this.cbxLivro = new System.Windows.Forms.ComboBox();
            this.lblGeneroLivro = new System.Windows.Forms.Label();
            this.lblEstadoLivro = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Candara", 12F);
            this.txtCPF.Location = new System.Drawing.Point(400, 71);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(153, 32);
            this.txtCPF.TabIndex = 31;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Candara", 12F);
            this.lblCPF.Location = new System.Drawing.Point(400, 43);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(129, 24);
            this.lblCPF.TabIndex = 30;
            this.lblCPF.Text = "Informe o CPF";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Enabled = false;
            this.lblGenero.Font = new System.Drawing.Font("Candara", 12F);
            this.lblGenero.Location = new System.Drawing.Point(207, 132);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(33, 24);
            this.lblGenero.TabIndex = 27;
            this.lblGenero.Text = "RP";
            this.lblGenero.Visible = false;
            // 
            // lblPeca
            // 
            this.lblPeca.AutoSize = true;
            this.lblPeca.Enabled = false;
            this.lblPeca.Font = new System.Drawing.Font("Candara", 12F);
            this.lblPeca.Location = new System.Drawing.Point(384, 132);
            this.lblPeca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeca.Name = "lblPeca";
            this.lblPeca.Size = new System.Drawing.Size(33, 24);
            this.lblPeca.TabIndex = 26;
            this.lblPeca.Text = "RP";
            this.lblPeca.Visible = false;
            // 
            // cbxGenero
            // 
            this.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenero.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Roupa"});
            this.cbxGenero.Location = new System.Drawing.Point(212, 159);
            this.cbxGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(153, 32);
            this.cbxGenero.TabIndex = 25;
            this.cbxGenero.Visible = false;
            // 
            // cbxPeca
            // 
            this.cbxPeca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeca.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxPeca.FormattingEnabled = true;
            this.cbxPeca.Items.AddRange(new object[] {
            "Roupa"});
            this.cbxPeca.Location = new System.Drawing.Point(389, 159);
            this.cbxPeca.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPeca.Name = "cbxPeca";
            this.cbxPeca.Size = new System.Drawing.Size(153, 32);
            this.cbxPeca.TabIndex = 24;
            this.cbxPeca.Visible = false;
            // 
            // cbxTamanho
            // 
            this.cbxTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTamanho.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxTamanho.FormattingEnabled = true;
            this.cbxTamanho.Items.AddRange(new object[] {
            "Roupa"});
            this.cbxTamanho.Location = new System.Drawing.Point(32, 159);
            this.cbxTamanho.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTamanho.Name = "cbxTamanho";
            this.cbxTamanho.Size = new System.Drawing.Size(153, 32);
            this.cbxTamanho.TabIndex = 23;
            this.cbxTamanho.Visible = false;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Enabled = false;
            this.lblTamanho.Font = new System.Drawing.Font("Candara", 12F);
            this.lblTamanho.Location = new System.Drawing.Point(27, 132);
            this.lblTamanho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(33, 24);
            this.lblTamanho.TabIndex = 22;
            this.lblTamanho.Text = "RP";
            this.lblTamanho.Visible = false;
            // 
            // cmbProduto
            // 
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.Font = new System.Drawing.Font("Candara", 12F);
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Items.AddRange(new object[] {
            "Roupas",
            "Brinquedos",
            "Livros"});
            this.cmbProduto.Location = new System.Drawing.Point(16, 71);
            this.cmbProduto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(201, 32);
            this.cmbProduto.TabIndex = 21;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Candara", 12F);
            this.lblProduto.Location = new System.Drawing.Point(11, 43);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(190, 24);
            this.lblProduto.TabIndex = 20;
            this.lblProduto.Text = "Categoria do Produto";
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.SystemColors.Window;
            this.btnConfirma.Font = new System.Drawing.Font("Candara", 12F);
            this.btnConfirma.Location = new System.Drawing.Point(232, 43);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(131, 62);
            this.btnConfirma.TabIndex = 19;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Candara", 12F);
            this.txtNome.Location = new System.Drawing.Point(16, 289);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(337, 32);
            this.txtNome.TabIndex = 36;
            this.txtNome.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Enabled = false;
            this.lblNome.Font = new System.Drawing.Font("Candara", 12F);
            this.lblNome.Location = new System.Drawing.Point(11, 262);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 24);
            this.lblNome.TabIndex = 35;
            this.lblNome.Text = "Nome";
            this.lblNome.Visible = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Candara", 12F);
            this.txtTelefone.Location = new System.Drawing.Point(380, 289);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(173, 32);
            this.txtTelefone.TabIndex = 37;
            this.txtTelefone.Visible = false;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Enabled = false;
            this.lblTelefone.Font = new System.Drawing.Font("Candara", 12F);
            this.lblTelefone.Location = new System.Drawing.Point(375, 262);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(83, 24);
            this.lblTelefone.TabIndex = 38;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Visible = false;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Enabled = false;
            this.lblRegistro.Font = new System.Drawing.Font("Candara", 12F);
            this.lblRegistro.Location = new System.Drawing.Point(375, 347);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(80, 24);
            this.lblRegistro.TabIndex = 40;
            this.lblRegistro.Text = "Registro";
            this.lblRegistro.Visible = false;
            // 
            // txtRegistro
            // 
            this.txtRegistro.Enabled = false;
            this.txtRegistro.Font = new System.Drawing.Font("Candara", 12F);
            this.txtRegistro.Location = new System.Drawing.Point(380, 374);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(173, 32);
            this.txtRegistro.TabIndex = 39;
            this.txtRegistro.Visible = false;
            // 
            // lblLinha
            // 
            this.lblLinha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLinha.Enabled = false;
            this.lblLinha.Location = new System.Drawing.Point(9, 239);
            this.lblLinha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(561, 2);
            this.lblLinha.TabIndex = 41;
            this.lblLinha.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Font = new System.Drawing.Font("Candara", 12F);
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.ImageKey = "(nenhum/a)";
            this.btnVoltar.Location = new System.Drawing.Point(16, 366);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(148, 42);
            this.btnVoltar.TabIndex = 43;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadastrar.Font = new System.Drawing.Font("Candara", 12F);
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(207, 366);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(148, 42);
            this.btnCadastrar.TabIndex = 42;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // lblTamanhoBrinq
            // 
            this.lblTamanhoBrinq.AutoSize = true;
            this.lblTamanhoBrinq.Enabled = false;
            this.lblTamanhoBrinq.Font = new System.Drawing.Font("Candara", 12F);
            this.lblTamanhoBrinq.Location = new System.Drawing.Point(248, 132);
            this.lblTamanhoBrinq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamanhoBrinq.Name = "lblTamanhoBrinq";
            this.lblTamanhoBrinq.Size = new System.Drawing.Size(48, 24);
            this.lblTamanhoBrinq.TabIndex = 49;
            this.lblTamanhoBrinq.Text = "BRQ";
            this.lblTamanhoBrinq.Visible = false;
            // 
            // lblBrinq
            // 
            this.lblBrinq.AutoSize = true;
            this.lblBrinq.Enabled = false;
            this.lblBrinq.Font = new System.Drawing.Font("Candara", 12F);
            this.lblBrinq.Location = new System.Drawing.Point(425, 132);
            this.lblBrinq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrinq.Name = "lblBrinq";
            this.lblBrinq.Size = new System.Drawing.Size(48, 24);
            this.lblBrinq.TabIndex = 48;
            this.lblBrinq.Text = "BRQ";
            this.lblBrinq.Visible = false;
            // 
            // cbxTamanhoBrinq
            // 
            this.cbxTamanhoBrinq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTamanhoBrinq.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxTamanhoBrinq.FormattingEnabled = true;
            this.cbxTamanhoBrinq.Items.AddRange(new object[] {
            "Brinquedo"});
            this.cbxTamanhoBrinq.Location = new System.Drawing.Point(212, 159);
            this.cbxTamanhoBrinq.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTamanhoBrinq.Name = "cbxTamanhoBrinq";
            this.cbxTamanhoBrinq.Size = new System.Drawing.Size(153, 32);
            this.cbxTamanhoBrinq.TabIndex = 47;
            this.cbxTamanhoBrinq.Visible = false;
            // 
            // cbxBrinq
            // 
            this.cbxBrinq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBrinq.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxBrinq.FormattingEnabled = true;
            this.cbxBrinq.Items.AddRange(new object[] {
            "Brinquedo"});
            this.cbxBrinq.Location = new System.Drawing.Point(389, 159);
            this.cbxBrinq.Margin = new System.Windows.Forms.Padding(4);
            this.cbxBrinq.Name = "cbxBrinq";
            this.cbxBrinq.Size = new System.Drawing.Size(153, 32);
            this.cbxBrinq.TabIndex = 46;
            this.cbxBrinq.Visible = false;
            // 
            // cbxTipoBrinq
            // 
            this.cbxTipoBrinq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoBrinq.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxTipoBrinq.FormattingEnabled = true;
            this.cbxTipoBrinq.Items.AddRange(new object[] {
            "Brinquedo"});
            this.cbxTipoBrinq.Location = new System.Drawing.Point(32, 159);
            this.cbxTipoBrinq.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipoBrinq.Name = "cbxTipoBrinq";
            this.cbxTipoBrinq.Size = new System.Drawing.Size(153, 32);
            this.cbxTipoBrinq.TabIndex = 45;
            this.cbxTipoBrinq.Visible = false;
            // 
            // lblTipoBrinq
            // 
            this.lblTipoBrinq.AutoSize = true;
            this.lblTipoBrinq.Enabled = false;
            this.lblTipoBrinq.Font = new System.Drawing.Font("Candara", 12F);
            this.lblTipoBrinq.Location = new System.Drawing.Point(68, 132);
            this.lblTipoBrinq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoBrinq.Name = "lblTipoBrinq";
            this.lblTipoBrinq.Size = new System.Drawing.Size(48, 24);
            this.lblTipoBrinq.TabIndex = 44;
            this.lblTipoBrinq.Text = "BRQ";
            this.lblTipoBrinq.Visible = false;
            // 
            // cbxGeneroLivro
            // 
            this.cbxGeneroLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGeneroLivro.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxGeneroLivro.FormattingEnabled = true;
            this.cbxGeneroLivro.Items.AddRange(new object[] {
            "Livro"});
            this.cbxGeneroLivro.Location = new System.Drawing.Point(32, 159);
            this.cbxGeneroLivro.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGeneroLivro.Name = "cbxGeneroLivro";
            this.cbxGeneroLivro.Size = new System.Drawing.Size(153, 32);
            this.cbxGeneroLivro.TabIndex = 50;
            this.cbxGeneroLivro.Visible = false;
            // 
            // cbxEstadoLivro
            // 
            this.cbxEstadoLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoLivro.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxEstadoLivro.FormattingEnabled = true;
            this.cbxEstadoLivro.Items.AddRange(new object[] {
            "Livro"});
            this.cbxEstadoLivro.Location = new System.Drawing.Point(211, 159);
            this.cbxEstadoLivro.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEstadoLivro.Name = "cbxEstadoLivro";
            this.cbxEstadoLivro.Size = new System.Drawing.Size(153, 32);
            this.cbxEstadoLivro.TabIndex = 51;
            this.cbxEstadoLivro.Visible = false;
            // 
            // cbxLivro
            // 
            this.cbxLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLivro.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxLivro.FormattingEnabled = true;
            this.cbxLivro.Items.AddRange(new object[] {
            "Livro"});
            this.cbxLivro.Location = new System.Drawing.Point(388, 159);
            this.cbxLivro.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLivro.Name = "cbxLivro";
            this.cbxLivro.Size = new System.Drawing.Size(153, 32);
            this.cbxLivro.TabIndex = 52;
            this.cbxLivro.Visible = false;
            // 
            // lblGeneroLivro
            // 
            this.lblGeneroLivro.AutoSize = true;
            this.lblGeneroLivro.Enabled = false;
            this.lblGeneroLivro.Font = new System.Drawing.Font("Candara", 12F);
            this.lblGeneroLivro.Location = new System.Drawing.Point(124, 132);
            this.lblGeneroLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneroLivro.Name = "lblGeneroLivro";
            this.lblGeneroLivro.Size = new System.Drawing.Size(42, 24);
            this.lblGeneroLivro.TabIndex = 53;
            this.lblGeneroLivro.Text = "LVR";
            this.lblGeneroLivro.Visible = false;
            // 
            // lblEstadoLivro
            // 
            this.lblEstadoLivro.AutoSize = true;
            this.lblEstadoLivro.Enabled = false;
            this.lblEstadoLivro.Font = new System.Drawing.Font("Candara", 12F);
            this.lblEstadoLivro.Location = new System.Drawing.Point(311, 132);
            this.lblEstadoLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoLivro.Name = "lblEstadoLivro";
            this.lblEstadoLivro.Size = new System.Drawing.Size(42, 24);
            this.lblEstadoLivro.TabIndex = 54;
            this.lblEstadoLivro.Text = "LVR";
            this.lblEstadoLivro.Visible = false;
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Enabled = false;
            this.lblLivro.Font = new System.Drawing.Font("Candara", 12F);
            this.lblLivro.Location = new System.Drawing.Point(481, 132);
            this.lblLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(42, 24);
            this.lblLivro.TabIndex = 55;
            this.lblLivro.Text = "LVR";
            this.lblLivro.Visible = false;
            // 
            // CadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 437);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.lblEstadoLivro);
            this.Controls.Add(this.lblGeneroLivro);
            this.Controls.Add(this.cbxLivro);
            this.Controls.Add(this.cbxEstadoLivro);
            this.Controls.Add(this.cbxGeneroLivro);
            this.Controls.Add(this.lblTamanhoBrinq);
            this.Controls.Add(this.lblBrinq);
            this.Controls.Add(this.cbxTamanhoBrinq);
            this.Controls.Add(this.cbxBrinq);
            this.Controls.Add(this.cbxTipoBrinq);
            this.Controls.Add(this.lblTipoBrinq);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblLinha);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblPeca);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.cbxPeca);
            this.Controls.Add(this.cbxTamanho);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnConfirma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroPedido";
            this.Text = "CadastroPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPeca;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.ComboBox cbxPeca;
        private System.Windows.Forms.ComboBox cbxTamanho;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblTamanhoBrinq;
        private System.Windows.Forms.Label lblBrinq;
        private System.Windows.Forms.ComboBox cbxTamanhoBrinq;
        private System.Windows.Forms.ComboBox cbxBrinq;
        private System.Windows.Forms.ComboBox cbxTipoBrinq;
        private System.Windows.Forms.Label lblTipoBrinq;
        private System.Windows.Forms.ComboBox cbxGeneroLivro;
        private System.Windows.Forms.ComboBox cbxEstadoLivro;
        private System.Windows.Forms.ComboBox cbxLivro;
        private System.Windows.Forms.Label lblGeneroLivro;
        private System.Windows.Forms.Label lblEstadoLivro;
        private System.Windows.Forms.Label lblLivro;
    }
}