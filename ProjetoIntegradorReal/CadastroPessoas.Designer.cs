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
            this.label3 = new System.Windows.Forms.Label();
            this.grbSelecionar = new System.Windows.Forms.GroupBox();
            this.rdbDoador = new System.Windows.Forms.RadioButton();
            this.rdbRecebedor = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbSelecionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(26, 73);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(137, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(26, 39);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(137, 20);
            this.txtBusca.TabIndex = 1;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Location = new System.Drawing.Point(50, 23);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(74, 13);
            this.lblBusca.TabIndex = 2;
            this.lblBusca.Text = "Informe o CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(26, 166);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(26, 208);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(265, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(181, 256);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(110, 20);
            this.txtCPF.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 150);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(82, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome Completo";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(23, 192);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 9;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(178, 240);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 10;
            this.lblCPF.Text = "CPF";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(26, 256);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(116, 20);
            this.txtTelefone.TabIndex = 11;
            this.txtTelefone.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // lblTefone
            // 
            this.lblTefone.AutoSize = true;
            this.lblTefone.Location = new System.Drawing.Point(23, 240);
            this.lblTefone.Name = "lblTefone";
            this.lblTefone.Size = new System.Drawing.Size(49, 13);
            this.lblTefone.TabIndex = 14;
            this.lblTefone.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "---------";
            // 
            // grbSelecionar
            // 
            this.grbSelecionar.Controls.Add(this.rdbRecebedor);
            this.grbSelecionar.Controls.Add(this.rdbDoador);
            this.grbSelecionar.Location = new System.Drawing.Point(169, 32);
            this.grbSelecionar.Name = "grbSelecionar";
            this.grbSelecionar.Size = new System.Drawing.Size(122, 64);
            this.grbSelecionar.TabIndex = 17;
            this.grbSelecionar.TabStop = false;
            // 
            // rdbDoador
            // 
            this.rdbDoador.AutoSize = true;
            this.rdbDoador.Location = new System.Drawing.Point(12, 10);
            this.rdbDoador.Name = "rdbDoador";
            this.rdbDoador.Size = new System.Drawing.Size(60, 17);
            this.rdbDoador.TabIndex = 0;
            this.rdbDoador.TabStop = true;
            this.rdbDoador.Text = "Doador";
            this.rdbDoador.UseVisualStyleBackColor = true;
            // 
            // rdbRecebedor
            // 
            this.rdbRecebedor.AutoSize = true;
            this.rdbRecebedor.Location = new System.Drawing.Point(12, 42);
            this.rdbRecebedor.Name = "rdbRecebedor";
            this.rdbRecebedor.Size = new System.Drawing.Size(69, 17);
            this.rdbRecebedor.TabIndex = 1;
            this.rdbRecebedor.TabStop = true;
            this.rdbRecebedor.Text = "Receptor";
            this.rdbRecebedor.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(26, 299);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(265, 23);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // CadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 344);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.grbSelecionar);
            this.Controls.Add(this.label3);
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
            this.Name = "CadastroPessoas";
            this.Text = "CadastroPessoas";
            this.Load += new System.EventHandler(this.CadastroPessoas_Load);
            this.grbSelecionar.ResumeLayout(false);
            this.grbSelecionar.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbSelecionar;
        private System.Windows.Forms.RadioButton rdbRecebedor;
        private System.Windows.Forms.RadioButton rdbDoador;
        private System.Windows.Forms.Button btnCadastrar;
    }
}