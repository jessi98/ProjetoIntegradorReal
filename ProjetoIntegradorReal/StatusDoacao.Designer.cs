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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
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
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Font = new System.Drawing.Font("Candara", 12F);
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.ImageKey = "(nenhum/a)";
            this.btnVoltar.Location = new System.Drawing.Point(20, 437);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(111, 34);
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
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.Location = new System.Drawing.Point(293, 437);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(111, 34);
            this.btnCadastrar.TabIndex = 51;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Text = "Confirmar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // txtCPFDoador
            // 
            this.txtCPFDoador.Font = new System.Drawing.Font("Candara", 12F);
            this.txtCPFDoador.Location = new System.Drawing.Point(30, 379);
            this.txtCPFDoador.Name = "txtCPFDoador";
            this.txtCPFDoador.Size = new System.Drawing.Size(145, 27);
            this.txtCPFDoador.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 12F);
            this.label2.Location = new System.Drawing.Point(16, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "SubCategoria 1";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Candara", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(20, 185);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(116, 27);
            this.comboBox2.TabIndex = 45;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Candara", 12F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(288, 185);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(116, 27);
            this.comboBox3.TabIndex = 46;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Candara", 12F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(155, 185);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(116, 27);
            this.comboBox4.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 12F);
            this.label3.Location = new System.Drawing.Point(284, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "SubCategoria 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara", 12F);
            this.label4.Location = new System.Drawing.Point(151, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "SubCategoria 2";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Font = new System.Drawing.Font("Candara", 12F);
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(20, 433);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(111, 34);
            this.btnVoltar.TabIndex = 53;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.Font = new System.Drawing.Font("Candara", 12F);
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.ImageKey = "(nenhum/a)";
            this.btnExcluir.Location = new System.Drawing.Point(151, 437);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 34);
            this.btnExcluir.TabIndex = 53;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // StatusDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(429, 496);
            this.ClientSize = new System.Drawing.Size(429, 495);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblLinha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCPFDoador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluir;
    }
}