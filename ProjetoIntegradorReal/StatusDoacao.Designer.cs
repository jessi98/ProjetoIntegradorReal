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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtCPFDoador = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtSub1 = new System.Windows.Forms.TextBox();
            this.txtSub2 = new System.Windows.Forms.TextBox();
            this.txtSub3 = new System.Windows.Forms.TextBox();
            this.grbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Candara", 12F);
            this.lblRegistro.Location = new System.Drawing.Point(181, 14);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(178, 24);
            this.lblRegistro.TabIndex = 2;
            this.lblRegistro.Text = "Numero do Registro";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Candara", 12F);
            this.lblDescricao.Location = new System.Drawing.Point(35, 277);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(91, 24);
            this.lblDescricao.TabIndex = 35;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Candara", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(40, 304);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(483, 121);
            this.txtDescricao.TabIndex = 34;
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.rdbAtivo);
            this.grbStatus.Controls.Add(this.rdbAguardando);
            this.grbStatus.Font = new System.Drawing.Font("Candara", 12F);
            this.grbStatus.Location = new System.Drawing.Point(40, 81);
            this.grbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Padding = new System.Windows.Forms.Padding(4);
            this.grbStatus.Size = new System.Drawing.Size(516, 85);
            this.grbStatus.TabIndex = 36;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Status do Pedido";
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Location = new System.Drawing.Point(131, 32);
            this.rdbAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(75, 28);
            this.rdbAtivo.TabIndex = 38;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            this.rdbAtivo.CheckedChanged += new System.EventHandler(this.rdbAtivo_CheckedChanged);
            // 
            // rdbAguardando
            // 
            this.rdbAguardando.AutoSize = true;
            this.rdbAguardando.Location = new System.Drawing.Point(245, 32);
            this.rdbAguardando.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAguardando.Name = "rdbAguardando";
            this.rdbAguardando.Size = new System.Drawing.Size(136, 28);
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
            this.txtRegistro.Location = new System.Drawing.Point(187, 41);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(192, 32);
            this.txtRegistro.TabIndex = 37;
            // 
            // txtCPFRecebedor
            // 
            this.txtCPFRecebedor.Font = new System.Drawing.Font("Candara", 12F);
            this.txtCPFRecebedor.Location = new System.Drawing.Point(331, 466);
            this.txtCPFRecebedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPFRecebedor.Name = "txtCPFRecebedor";
            this.txtCPFRecebedor.Size = new System.Drawing.Size(192, 32);
            this.txtCPFRecebedor.TabIndex = 39;
            // 
            // lblCPFDoador
            // 
            this.lblCPFDoador.AutoSize = true;
            this.lblCPFDoador.Font = new System.Drawing.Font("Candara", 12F);
            this.lblCPFDoador.Location = new System.Drawing.Point(35, 439);
            this.lblCPFDoador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPFDoador.Name = "lblCPFDoador";
            this.lblCPFDoador.Size = new System.Drawing.Size(135, 24);
            this.lblCPFDoador.TabIndex = 40;
            this.lblCPFDoador.Text = "CPF do Doador";
            // 
            // lblCPFRecebedor
            // 
            this.lblCPFRecebedor.AutoSize = true;
            this.lblCPFRecebedor.Font = new System.Drawing.Font("Candara", 12F);
            this.lblCPFRecebedor.Location = new System.Drawing.Point(325, 439);
            this.lblCPFRecebedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPFRecebedor.Name = "lblCPFRecebedor";
            this.lblCPFRecebedor.Size = new System.Drawing.Size(167, 24);
            this.lblCPFRecebedor.TabIndex = 41;
            this.lblCPFRecebedor.Text = "CPF do Recebedor ";
            // 
            // lblLinha
            // 
            this.lblLinha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLinha.Location = new System.Drawing.Point(19, 185);
            this.lblLinha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(533, 2);
            this.lblLinha.TabIndex = 50;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Font = new System.Drawing.Font("Candara", 12F);
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.ImageKey = "(nenhum/a)";
            this.btnVoltar.Location = new System.Drawing.Point(27, 538);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(148, 42);
            this.btnVoltar.TabIndex = 52;
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
            this.btnCadastrar.Location = new System.Drawing.Point(376, 538);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(148, 42);
            this.btnCadastrar.TabIndex = 51;
            this.btnCadastrar.Text = "Confirmar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCPFDoador
            // 
            this.txtCPFDoador.Font = new System.Drawing.Font("Candara", 12F);
            this.txtCPFDoador.Location = new System.Drawing.Point(40, 466);
            this.txtCPFDoador.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPFDoador.Name = "txtCPFDoador";
            this.txtCPFDoador.Size = new System.Drawing.Size(192, 32);
            this.txtCPFDoador.TabIndex = 38;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.Font = new System.Drawing.Font("Candara", 12F);
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.ImageKey = "(nenhum/a)";
            this.btnExcluir.Location = new System.Drawing.Point(201, 538);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(148, 42);
            this.btnExcluir.TabIndex = 53;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // txtSub1
            // 
            this.txtSub1.Enabled = false;
            this.txtSub1.Font = new System.Drawing.Font("Candara", 12F);
            this.txtSub1.Location = new System.Drawing.Point(19, 227);
            this.txtSub1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub1.Name = "txtSub1";
            this.txtSub1.Size = new System.Drawing.Size(173, 32);
            this.txtSub1.TabIndex = 54;
            // 
            // txtSub2
            // 
            this.txtSub2.Enabled = false;
            this.txtSub2.Font = new System.Drawing.Font("Candara", 12F);
            this.txtSub2.Location = new System.Drawing.Point(200, 227);
            this.txtSub2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub2.Name = "txtSub2";
            this.txtSub2.Size = new System.Drawing.Size(172, 32);
            this.txtSub2.TabIndex = 55;
            // 
            // txtSub3
            // 
            this.txtSub3.Enabled = false;
            this.txtSub3.Font = new System.Drawing.Font("Candara", 12F);
            this.txtSub3.Location = new System.Drawing.Point(380, 227);
            this.txtSub3.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub3.Name = "txtSub3";
            this.txtSub3.Size = new System.Drawing.Size(172, 32);
            this.txtSub3.TabIndex = 56;
            // 
            // StatusDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 609);
            this.Controls.Add(this.txtSub3);
            this.Controls.Add(this.txtSub2);
            this.Controls.Add(this.txtSub1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.RadioButton rdbAguardando;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtCPFRecebedor;
        private System.Windows.Forms.Label lblCPFDoador;
        private System.Windows.Forms.Label lblCPFRecebedor;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCPFDoador;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtSub1;
        private System.Windows.Forms.TextBox txtSub2;
        private System.Windows.Forms.TextBox txtSub3;
    }
}