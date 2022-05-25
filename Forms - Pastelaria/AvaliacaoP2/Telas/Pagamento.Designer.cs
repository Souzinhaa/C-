namespace AvaliacaoP2
{
    partial class Pagamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBebida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioEspecialNao = new System.Windows.Forms.RadioButton();
            this.radioEspecialSim = new System.Windows.Forms.RadioButton();
            this.listBoxPedido = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCartao = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioCarteiraDigital = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioDinheiro = new System.Windows.Forms.RadioButton();
            this.Voltar3 = new System.Windows.Forms.Button();
            this.labelTaxa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qual será a forma de pagamento?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bebida adicional?";
            // 
            // comboBebida
            // 
            this.comboBebida.FormattingEnabled = true;
            this.comboBebida.Items.AddRange(new object[] {
            "Não",
            "Água",
            "Água com gás",
            "Suco de água",
            "Coca Cola",
            "Guaraná Jesus",
            "Cerveja Cristal"});
            this.comboBebida.Location = new System.Drawing.Point(319, 76);
            this.comboBebida.Name = "comboBebida";
            this.comboBebida.Size = new System.Drawing.Size(144, 21);
            this.comboBebida.TabIndex = 3;
            this.comboBebida.SelectedIndexChanged += new System.EventHandler(this.comboBebida_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "É um dia especial para alguém? (Celebração custa 20% a mais)";
            // 
            // radioEspecialNao
            // 
            this.radioEspecialNao.AutoSize = true;
            this.radioEspecialNao.BackColor = System.Drawing.Color.Transparent;
            this.radioEspecialNao.Checked = true;
            this.radioEspecialNao.Location = new System.Drawing.Point(605, 86);
            this.radioEspecialNao.Name = "radioEspecialNao";
            this.radioEspecialNao.Size = new System.Drawing.Size(45, 17);
            this.radioEspecialNao.TabIndex = 9;
            this.radioEspecialNao.TabStop = true;
            this.radioEspecialNao.Text = "Não";
            this.radioEspecialNao.UseVisualStyleBackColor = false;
            this.radioEspecialNao.CheckedChanged += new System.EventHandler(this.radioEspecialNao_CheckedChanged);
            // 
            // radioEspecialSim
            // 
            this.radioEspecialSim.AutoSize = true;
            this.radioEspecialSim.BackColor = System.Drawing.Color.Transparent;
            this.radioEspecialSim.Location = new System.Drawing.Point(605, 63);
            this.radioEspecialSim.Name = "radioEspecialSim";
            this.radioEspecialSim.Size = new System.Drawing.Size(42, 17);
            this.radioEspecialSim.TabIndex = 9;
            this.radioEspecialSim.TabStop = true;
            this.radioEspecialSim.Text = "Sim";
            this.radioEspecialSim.UseVisualStyleBackColor = false;
            this.radioEspecialSim.CheckedChanged += new System.EventHandler(this.radioEspecialSim_CheckedChanged);
            // 
            // listBoxPedido
            // 
            this.listBoxPedido.FormattingEnabled = true;
            this.listBoxPedido.Location = new System.Drawing.Point(518, 156);
            this.listBoxPedido.Name = "listBoxPedido";
            this.listBoxPedido.Size = new System.Drawing.Size(270, 121);
            this.listBoxPedido.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::AvaliacaoP2.Properties.Resources.botão2;
            this.button1.Location = new System.Drawing.Point(319, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.radioCartao);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(46, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 42);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // radioCartao
            // 
            this.radioCartao.AutoSize = true;
            this.radioCartao.Location = new System.Drawing.Point(6, 19);
            this.radioCartao.Name = "radioCartao";
            this.radioCartao.Size = new System.Drawing.Size(56, 17);
            this.radioCartao.TabIndex = 1;
            this.radioCartao.TabStop = true;
            this.radioCartao.Text = "Cartão";
            this.radioCartao.UseVisualStyleBackColor = true;
            this.radioCartao.CheckedChanged += new System.EventHandler(this.radioCartao_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AvaliacaoP2.Properties.Resources.itau_logo;
            this.pictureBox3.Location = new System.Drawing.Point(62, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AvaliacaoP2.Properties.Resources.banco_do_brasil_logo;
            this.pictureBox2.Location = new System.Drawing.Point(103, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AvaliacaoP2.Properties.Resources.santander_logo;
            this.pictureBox1.Location = new System.Drawing.Point(144, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.radioCarteiraDigital);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(46, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 42);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // radioCarteiraDigital
            // 
            this.radioCarteiraDigital.AutoSize = true;
            this.radioCarteiraDigital.Location = new System.Drawing.Point(6, 19);
            this.radioCarteiraDigital.Name = "radioCarteiraDigital";
            this.radioCarteiraDigital.Size = new System.Drawing.Size(91, 17);
            this.radioCarteiraDigital.TabIndex = 1;
            this.radioCarteiraDigital.TabStop = true;
            this.radioCarteiraDigital.Text = "Carteira digital";
            this.radioCarteiraDigital.UseVisualStyleBackColor = true;
            this.radioCarteiraDigital.CheckedChanged += new System.EventHandler(this.radioCarteiraDigital_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AvaliacaoP2.Properties.Resources.MetaMask;
            this.pictureBox4.Location = new System.Drawing.Point(103, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AvaliacaoP2.Properties.Resources.paypal;
            this.pictureBox6.Location = new System.Drawing.Point(144, 10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.radioDinheiro);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(46, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 42);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // radioDinheiro
            // 
            this.radioDinheiro.AutoSize = true;
            this.radioDinheiro.Location = new System.Drawing.Point(6, 19);
            this.radioDinheiro.Name = "radioDinheiro";
            this.radioDinheiro.Size = new System.Drawing.Size(64, 17);
            this.radioDinheiro.TabIndex = 1;
            this.radioDinheiro.TabStop = true;
            this.radioDinheiro.Text = "Dinheiro";
            this.radioDinheiro.UseVisualStyleBackColor = true;
            this.radioDinheiro.CheckedChanged += new System.EventHandler(this.radioDinheiro_CheckedChanged);
            // 
            // Voltar3
            // 
            this.Voltar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Voltar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Voltar3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Voltar3.Location = new System.Drawing.Point(46, 389);
            this.Voltar3.Name = "Voltar3";
            this.Voltar3.Size = new System.Drawing.Size(82, 26);
            this.Voltar3.TabIndex = 15;
            this.Voltar3.Text = "Retorno";
            this.Voltar3.UseVisualStyleBackColor = false;
            this.Voltar3.Click += new System.EventHandler(this.Retorno_Click);
            // 
            // labelTaxa
            // 
            this.labelTaxa.AutoSize = true;
            this.labelTaxa.Location = new System.Drawing.Point(52, 231);
            this.labelTaxa.Name = "labelTaxa";
            this.labelTaxa.Size = new System.Drawing.Size(48, 13);
            this.labelTaxa.TabIndex = 16;
            this.labelTaxa.Text = "Taxa 0%";
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AvaliacaoP2.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTaxa);
            this.Controls.Add(this.Voltar3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxPedido);
            this.Controls.Add(this.radioEspecialSim);
            this.Controls.Add(this.radioEspecialNao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBebida);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "Pagamento";
            this.Text = "Pagamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBebida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioEspecialNao;
        private System.Windows.Forms.RadioButton radioEspecialSim;
        private System.Windows.Forms.ListBox listBoxPedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Voltar3;
        private System.Windows.Forms.RadioButton radioCartao;
        private System.Windows.Forms.RadioButton radioCarteiraDigital;
        private System.Windows.Forms.RadioButton radioDinheiro;
        private System.Windows.Forms.Label labelTaxa;
    }
}