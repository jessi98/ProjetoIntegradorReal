namespace ProjetoIntegradorReal
{
    partial class CadastroPessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPessoas));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblBusca = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTefone = new System.Windows.Forms.Label();
            this.grbSelecionar = new System.Windows.Forms.GroupBox();
            this.rdbRecebedor = new System.Windows.Forms.RadioButton();
            this.rdbDoador = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblLinha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grbSelecionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Candara", 12F);
            this.btnPesquisar.Location = new System.Drawing.Point(24, 87);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(137, 33);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Candara", 12F);
            this.txtBusca.Location = new System.Drawing.Point(24, 46);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(137, 27);
            this.txtBusca.TabIndex = 1;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Candara", 12F);
            this.lblBusca.Location = new System.Drawing.Point(46, 24);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(104, 19);
            this.lblBusca.TabIndex = 2;
            this.lblBusca.Text = "Informe o CPF";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Candara", 12F);
            this.txtNome.Location = new System.Drawing.Point(24, 203);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 27);
            this.txtNome.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Candara", 12F);
            this.txtEndereco.Location = new System.Drawing.Point(24, 255);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(265, 27);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Candara", 12F);
            this.txtCPF.Location = new System.Drawing.Point(179, 307);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(110, 27);
            this.txtCPF.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Candara", 12F);
            this.lblNome.Location = new System.Drawing.Point(21, 181);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(120, 19);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome Completo";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Candara", 12F);
            this.lblEndereco.Location = new System.Drawing.Point(21, 233);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(73, 19);
            this.lblEndereco.TabIndex = 9;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Candara", 12F);
            this.lblCPF.Location = new System.Drawing.Point(175, 285);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(35, 19);
            this.lblCPF.TabIndex = 10;
            this.lblCPF.Text = "CPF";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Candara", 12F);
            this.txtTelefone.Location = new System.Drawing.Point(25, 307);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(116, 27);
            this.txtTelefone.TabIndex = 11;
            this.txtTelefone.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // lblTefone
            // 
            this.lblTefone.AutoSize = true;
            this.lblTefone.Font = new System.Drawing.Font("Candara", 12F);
            this.lblTefone.Location = new System.Drawing.Point(21, 285);
            this.lblTefone.Name = "lblTefone";
            this.lblTefone.Size = new System.Drawing.Size(67, 19);
            this.lblTefone.TabIndex = 14;
            this.lblTefone.Text = "Telefone";
            // 
            // grbSelecionar
            // 
            this.grbSelecionar.Controls.Add(this.rdbRecebedor);
            this.grbSelecionar.Controls.Add(this.rdbDoador);
            this.grbSelecionar.Font = new System.Drawing.Font("Candara", 12F);
            this.grbSelecionar.Location = new System.Drawing.Point(179, 35);
            this.grbSelecionar.Name = "grbSelecionar";
            this.grbSelecionar.Size = new System.Drawing.Size(111, 85);
            this.grbSelecionar.TabIndex = 17;
            this.grbSelecionar.TabStop = false;
            // 
            // rdbRecebedor
            // 
            this.rdbRecebedor.AutoSize = true;
            this.rdbRecebedor.Location = new System.Drawing.Point(6, 52);
            this.rdbRecebedor.Name = "rdbRecebedor";
            this.rdbRecebedor.Size = new System.Drawing.Size(90, 23);
            this.rdbRecebedor.TabIndex = 1;
            this.rdbRecebedor.TabStop = true;
            this.rdbRecebedor.Text = "Receptor";
            this.rdbRecebedor.UseVisualStyleBackColor = true;
            // 
            // rdbDoador
            // 
            this.rdbDoador.AutoSize = true;
            this.rdbDoador.Location = new System.Drawing.Point(6, 15);
            this.rdbDoador.Name = "rdbDoador";
            this.rdbDoador.Size = new System.Drawing.Size(78, 23);
            this.rdbDoador.TabIndex = 0;
            this.rdbDoador.TabStop = true;
            this.rdbDoador.Text = "Doador";
            this.rdbDoador.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadastrar.Font = new System.Drawing.Font("Candara", 12F);
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(178, 360);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(111, 34);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // lblLinha
            // 
            this.lblLinha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLinha.Location = new System.Drawing.Point(7, 150);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(300, 2);
            this.lblLinha.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Font = new System.Drawing.Font("Candara", 12F);
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.ImageKey = "(nenhum/a)";
            this.btnVoltar.Location = new System.Drawing.Point(24, 360);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(111, 34);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // CadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 434);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLinha);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.grbSelecionar);
            this.Controls.Add(this.lblTefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroPessoas";
            this.Text = "CadastroPessoas";
            this.Load += new System.EventHandler(this.CadastroPessoas_Load);
            this.grbSelecionar.ResumeLayout(false);
            this.grbSelecionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTefone;
        private System.Windows.Forms.GroupBox grbSelecionar;
        private System.Windows.Forms.RadioButton rdbRecebedor;
        private System.Windows.Forms.RadioButton rdbDoador;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
    }
}