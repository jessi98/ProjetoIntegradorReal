namespace ProjetoIntegradorReal
{
    partial class StatusDoacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusDoacao));
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.rdbAguardando = new System.Windows.Forms.RadioButton();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtCPFRecebedor = new System.Windows.Forms.TextBox();
            this.lblCPFDoador = new System.Windows.Forms.Label();
            this.lblCPFRecebedor = new System.Windows.Forms.Label();
            this.lblLinha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtCPFDoador = new System.Windows.Forms.TextBox();
            this.txtSub1 = new System.Windows.Forms.TextBox();
            this.txtSub2 = new System.Windows.Forms.TextBox();
            this.txtSub3 = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Font = new System.Drawing.Font("Candara", 12F);
            this.lblRegistro.Location = new System.Drawing.Point(136, 11);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(147, 19);
            this.lblRegistro.TabIndex = 2;
            this.lblRegistro.Text = "Numero do Registro";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Candara", 12F);
            this.lblDescricao.Location = new System.Drawing.Point(26, 225);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(74, 19);
            this.lblDescricao.TabIndex = 35;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Candara", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(30, 247);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(363, 99);
            this.txtDescricao.TabIndex = 34;
            // 
            // grbStatus
            // 
            this.grbStatus.BackColor = System.Drawing.Color.Transparent;
            this.grbStatus.Controls.Add(this.rdbAtivo);
            this.grbStatus.Controls.Add(this.rdbAguardando);
            this.grbStatus.Font = new System.Drawing.Font("Candara", 12F);
            this.grbStatus.Location = new System.Drawing.Point(30, 66);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(387, 69);
            this.grbStatus.TabIndex = 36;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Status do Pedido";
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Location = new System.Drawing.Point(98, 26);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(63, 23);
            this.rdbAtivo.TabIndex = 38;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            this.rdbAtivo.CheckedChanged += new System.EventHandler(this.rdbAtivo_CheckedChanged);
            // 
            // rdbAguardando
            // 
            this.rdbAguardando.AutoSize = true;
            this.rdbAguardando.Location = new System.Drawing.Point(184, 26);
            this.rdbAguardando.Name = "rdbAguardando";
            this.rdbAguardando.Size = new System.Drawing.Size(113, 23);
            this.rdbAguardando.TabIndex = 39;
            this.rdbAguardando.TabStop = true;
            this.rdbAguardando.Text = "Aguardando";
            this.rdbAguardando.UseVisualStyleBackColor = true;
            this.rdbAguardando.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtRegistro
            // 
            this.txtRegistro.Enabled = false;
            this.txtRegistro.Font = new System.Drawing.Font("Candara", 12F);
            this.txtRegistro.Location = new System.Drawing.Point(140, 33);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(145, 27);
            this.txtRegistro.TabIndex = 37;
            // 
            // txtCPFRecebedor
            // 
            this.txtCPFRecebedor.Font = new System.Drawing.Font("Candara", 12F);
            this.txtCPFRecebedor.Location = new System.Drawing.Point(248, 379);
            this.txtCPFRecebedor.Name = "txtCPFRecebedor";
            this.txtCPFRecebedor.Size = new System.Drawing.Size(145, 27);
            this.txtCPFRecebedor.TabIndex = 39;
            // 
            // lblCPFDoador
            // 
            this.lblCPFDoador.AutoSize = true;
            this.lblCPFDoador.BackColor = System.Drawing.Color.Transparent;
            this.lblCPFDoador.Font = new System.Drawing.Font("Candara", 12F);
            this.lblCPFDoador.Location = new System.Drawing.Point(26, 357);
            this.lblCPFDoador.Name = "lblCPFDoador";
            this.lblCPFDoador.Size = new System.Drawing.Size(110, 19);
            this.lblCPFDoador.TabIndex = 40;
            this.lblCPFDoador.Text = "CPF do Doador";
            // 
            // lblCPFRecebedor
            // 
            this.lblCPFRecebedor.AutoSize = true;
            this.lblCPFRecebedor.BackColor = System.Drawing.Color.Transparent;
            this.lblCPFRecebedor.Font = new System.Drawing.Font("Candara", 12F);
            this.lblCPFRecebedor.Location = new System.Drawing.Point(244, 357);
            this.lblCPFRecebedor.Name = "lblCPFRecebedor";
            this.lblCPFRecebedor.Size = new System.Drawing.Size(136, 19);
            this.lblCPFRecebedor.TabIndex = 41;
            this.lblCPFRecebedor.Text = "CPF do Recebedor ";
            // 
            // lblLinha
            // 
            this.lblLinha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLinha.Location = new System.Drawing.Point(14, 150);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(400, 2);
            this.lblLinha.TabIndex = 50;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadastrar.Font = new System.Drawing.Font("Candara", 12F);
            this.btnCadastrar.Image = global::ProjetoIntegradorReal.Properties.Resources.salvar;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.Location = new System.Drawing.Point(282, 437);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(111, 34);
            this.btnCadastrar.TabIndex = 51;
            this.btnCadastrar.Text = "Confirmar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCPFDoador
            // 
            this.txtCPFDoador.Font = new System.Drawing.Font("Candara", 12F);
            this.txtCPFDoador.Location = new System.Drawing.Point(30, 379);
            this.txtCPFDoador.Name = "txtCPFDoador";
            this.txtCPFDoador.Size = new System.Drawing.Size(145, 27);
            this.txtCPFDoador.TabIndex = 38;
            // 
            // txtSub1
            // 
            this.txtSub1.Enabled = false;
            this.txtSub1.Font = new System.Drawing.Font("Candara", 12F);
            this.txtSub1.Location = new System.Drawing.Point(14, 184);
            this.txtSub1.Name = "txtSub1";
            this.txtSub1.Size = new System.Drawing.Size(131, 27);
            this.txtSub1.TabIndex = 54;
            // 
            // txtSub2
            // 
            this.txtSub2.Enabled = false;
            this.txtSub2.Font = new System.Drawing.Font("Candara", 12F);
            this.txtSub2.Location = new System.Drawing.Point(150, 184);
            this.txtSub2.Name = "txtSub2";
            this.txtSub2.Size = new System.Drawing.Size(130, 27);
            this.txtSub2.TabIndex = 55;
            // 
            // txtSub3
            // 
            this.txtSub3.Enabled = false;
            this.txtSub3.Font = new System.Drawing.Font("Candara", 12F);
            this.txtSub3.Location = new System.Drawing.Point(285, 184);
            this.txtSub3.Name = "txtSub3";
            this.txtSub3.Size = new System.Drawing.Size(130, 27);
            this.txtSub3.TabIndex = 56;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.Font = new System.Drawing.Font("Candara", 12F);
            this.btnExcluir.Image = global::ProjetoIntegradorReal.Properties.Resources.lixo;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(153, 437);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 34);
            this.btnExcluir.TabIndex = 57;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Font = new System.Drawing.Font("Candara", 12F);
            this.btnVoltar.Image = global::ProjetoIntegradorReal.Properties.Resources.voltar;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(25, 437);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(111, 34);
            this.btnVoltar.TabIndex = 58;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // StatusDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIntegradorReal.Properties.Resources.fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(429, 496);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtSub3);
            this.Controls.Add(this.txtSub2);
            this.Controls.Add(this.txtSub1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblLinha);
            this.Controls.Add(this.lblCPFRecebedor);
            this.Controls.Add(this.lblCPFDoador);
            this.Controls.Add(this.txtCPFRecebedor);
            this.Controls.Add(this.txtCPFDoador);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.grbStatus);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatusDoacao";
            this.Text = "StatusDoacao";
            this.Load += new System.EventHandler(this.StatusDoacao_Load);
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.RadioButton rdbAguardando;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtCPFRecebedor;
        private System.Windows.Forms.Label lblCPFDoador;
        private System.Windows.Forms.Label lblCPFRecebedor;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCPFDoador;
        private System.Windows.Forms.TextBox txtSub1;
        private System.Windows.Forms.TextBox txtSub2;
        private System.Windows.Forms.TextBox txtSub3;
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
    }
}