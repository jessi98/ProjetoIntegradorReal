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
            this.lblInformacoes = new System.Windows.Forms.Label();
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
            this.txtInformacoes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Candara", 12F);
            this.txtCPF.Location = new System.Drawing.Point(24, 58);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(116, 27);
            this.txtCPF.TabIndex = 31;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Candara", 12F);
            this.lblCPF.Location = new System.Drawing.Point(24, 35);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(104, 19);
            this.lblCPF.TabIndex = 30;
            this.lblCPF.Text = "Informe o CPF";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Enabled = false;
            this.lblGenero.Font = new System.Drawing.Font("Candara", 12F);
            this.lblGenero.Location = new System.Drawing.Point(155, 107);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(28, 19);
            this.lblGenero.TabIndex = 27;
            this.lblGenero.Text = "RP";
            this.lblGenero.Visible = false;
            // 
            // lblPeca
            // 
            this.lblPeca.AutoSize = true;
            this.lblPeca.Enabled = false;
            this.lblPeca.Font = new System.Drawing.Font("Candara", 12F);
            this.lblPeca.Location = new System.Drawing.Point(288, 107);
            this.lblPeca.Name = "lblPeca";
            this.lblPeca.Size = new System.Drawing.Size(28, 19);
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
            this.cbxGenero.Location = new System.Drawing.Point(159, 129);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(116, 27);
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
            this.cbxPeca.Location = new System.Drawing.Point(292, 129);
            this.cbxPeca.Name = "cbxPeca";
            this.cbxPeca.Size = new System.Drawing.Size(116, 27);
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
            this.cbxTamanho.Location = new System.Drawing.Point(24, 129);
            this.cbxTamanho.Name = "cbxTamanho";
            this.cbxTamanho.Size = new System.Drawing.Size(116, 27);
            this.cbxTamanho.TabIndex = 23;
            this.cbxTamanho.Visible = false;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Enabled = false;
            this.lblTamanho.Font = new System.Drawing.Font("Candara", 12F);
            this.lblTamanho.Location = new System.Drawing.Point(20, 107);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(28, 19);
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
            this.cmbProduto.Location = new System.Drawing.Point(256, 58);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(152, 27);
            this.cmbProduto.TabIndex = 21;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Candara", 12F);
            this.lblProduto.Location = new System.Drawing.Point(252, 36);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(156, 19);
            this.lblProduto.TabIndex = 20;
            this.lblProduto.Text = "Categoria do Produto";
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.SystemColors.Window;
            this.btnConfirma.Font = new System.Drawing.Font("Candara", 12F);
            this.btnConfirma.Location = new System.Drawing.Point(146, 35);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(98, 50);
            this.btnConfirma.TabIndex = 19;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.Enabled = false;
            this.lblInformacoes.Font = new System.Drawing.Font("Candara", 12F);
            this.lblInformacoes.Location = new System.Drawing.Point(20, 199);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(155, 19);
            this.lblInformacoes.TabIndex = 35;
            this.lblInformacoes.Text = "Informações Pessoais";
            this.lblInformacoes.Visible = false;
            // 
            // lblLinha
            // 
            this.lblLinha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLinha.Enabled = false;
            this.lblLinha.Location = new System.Drawing.Point(7, 169);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(421, 2);
            this.lblLinha.TabIndex = 41;
            this.lblLinha.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Font = new System.Drawing.Font("Candara", 12F);
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.ImageKey = "(nenhum/a)";
            this.btnVoltar.Location = new System.Drawing.Point(158, 336);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(111, 34);
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
            this.btnCadastrar.Location = new System.Drawing.Point(296, 336);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(111, 34);
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
            this.lblTamanhoBrinq.Location = new System.Drawing.Point(186, 107);
            this.lblTamanhoBrinq.Name = "lblTamanhoBrinq";
            this.lblTamanhoBrinq.Size = new System.Drawing.Size(39, 19);
            this.lblTamanhoBrinq.TabIndex = 49;
            this.lblTamanhoBrinq.Text = "BRQ";
            this.lblTamanhoBrinq.Visible = false;
            // 
            // lblBrinq
            // 
            this.lblBrinq.AutoSize = true;
            this.lblBrinq.Enabled = false;
            this.lblBrinq.Font = new System.Drawing.Font("Candara", 12F);
            this.lblBrinq.Location = new System.Drawing.Point(319, 107);
            this.lblBrinq.Name = "lblBrinq";
            this.lblBrinq.Size = new System.Drawing.Size(39, 19);
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
            this.cbxTamanhoBrinq.Location = new System.Drawing.Point(159, 129);
            this.cbxTamanhoBrinq.Name = "cbxTamanhoBrinq";
            this.cbxTamanhoBrinq.Size = new System.Drawing.Size(116, 27);
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
            this.cbxBrinq.Location = new System.Drawing.Point(292, 129);
            this.cbxBrinq.Name = "cbxBrinq";
            this.cbxBrinq.Size = new System.Drawing.Size(116, 27);
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
            this.cbxTipoBrinq.Location = new System.Drawing.Point(24, 129);
            this.cbxTipoBrinq.Name = "cbxTipoBrinq";
            this.cbxTipoBrinq.Size = new System.Drawing.Size(116, 27);
            this.cbxTipoBrinq.TabIndex = 45;
            this.cbxTipoBrinq.Visible = false;
            // 
            // lblTipoBrinq
            // 
            this.lblTipoBrinq.AutoSize = true;
            this.lblTipoBrinq.Enabled = false;
            this.lblTipoBrinq.Font = new System.Drawing.Font("Candara", 12F);
            this.lblTipoBrinq.Location = new System.Drawing.Point(51, 107);
            this.lblTipoBrinq.Name = "lblTipoBrinq";
            this.lblTipoBrinq.Size = new System.Drawing.Size(39, 19);
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
            this.cbxGeneroLivro.Location = new System.Drawing.Point(24, 129);
            this.cbxGeneroLivro.Name = "cbxGeneroLivro";
            this.cbxGeneroLivro.Size = new System.Drawing.Size(116, 27);
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
            this.cbxEstadoLivro.Location = new System.Drawing.Point(158, 129);
            this.cbxEstadoLivro.Name = "cbxEstadoLivro";
            this.cbxEstadoLivro.Size = new System.Drawing.Size(116, 27);
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
            this.cbxLivro.Location = new System.Drawing.Point(291, 129);
            this.cbxLivro.Name = "cbxLivro";
            this.cbxLivro.Size = new System.Drawing.Size(116, 27);
            this.cbxLivro.TabIndex = 52;
            this.cbxLivro.Visible = false;
            // 
            // lblGeneroLivro
            // 
            this.lblGeneroLivro.AutoSize = true;
            this.lblGeneroLivro.Enabled = false;
            this.lblGeneroLivro.Font = new System.Drawing.Font("Candara", 12F);
            this.lblGeneroLivro.Location = new System.Drawing.Point(93, 107);
            this.lblGeneroLivro.Name = "lblGeneroLivro";
            this.lblGeneroLivro.Size = new System.Drawing.Size(36, 19);
            this.lblGeneroLivro.TabIndex = 53;
            this.lblGeneroLivro.Text = "LVR";
            this.lblGeneroLivro.Visible = false;
            // 
            // lblEstadoLivro
            // 
            this.lblEstadoLivro.AutoSize = true;
            this.lblEstadoLivro.Enabled = false;
            this.lblEstadoLivro.Font = new System.Drawing.Font("Candara", 12F);
            this.lblEstadoLivro.Location = new System.Drawing.Point(233, 107);
            this.lblEstadoLivro.Name = "lblEstadoLivro";
            this.lblEstadoLivro.Size = new System.Drawing.Size(36, 19);
            this.lblEstadoLivro.TabIndex = 54;
            this.lblEstadoLivro.Text = "LVR";
            this.lblEstadoLivro.Visible = false;
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Enabled = false;
            this.lblLivro.Font = new System.Drawing.Font("Candara", 12F);
            this.lblLivro.Location = new System.Drawing.Point(361, 107);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(36, 19);
            this.lblLivro.TabIndex = 55;
            this.lblLivro.Text = "LVR";
            this.lblLivro.Visible = false;
            // 
            // txtInformacoes
            // 
            this.txtInformacoes.Enabled = false;
            this.txtInformacoes.Font = new System.Drawing.Font("Candara", 12F);
            this.txtInformacoes.Location = new System.Drawing.Point(24, 221);
            this.txtInformacoes.Multiline = true;
            this.txtInformacoes.Name = "txtInformacoes";
            this.txtInformacoes.Size = new System.Drawing.Size(384, 99);
            this.txtInformacoes.TabIndex = 56;
            this.txtInformacoes.Visible = false;
            // 
            // CadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 397);
            this.Controls.Add(this.txtInformacoes);
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
            this.Controls.Add(this.lblInformacoes);
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
        private System.Windows.Forms.Label lblInformacoes;
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
        private System.Windows.Forms.TextBox txtInformacoes;
    }
}