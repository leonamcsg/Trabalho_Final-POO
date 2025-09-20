namespace trab_final_Gestao_Estufas
{
    partial class FormEstufas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEstufas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.txtTamanho_m2 = new System.Windows.Forms.TextBox();
            this.txtCultura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelGestorEstufas = new System.Windows.Forms.Panel();
            this.rb_controle_irrigacao = new System.Windows.Forms.RadioButton();
            this.rb_log_atmosferico = new System.Windows.Forms.RadioButton();
            this.rb_gestor_estufas = new System.Windows.Forms.RadioButton();
            this.panelControleIrrigacao = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.num_duracao_irrigacao = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ligar_irrigacao = new System.Windows.Forms.Button();
            this.txt_Id_estufa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelLogAtmosferico = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstufas)).BeginInit();
            this.panelGestorEstufas.SuspendLayout();
            this.panelControleIrrigacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_duracao_irrigacao)).BeginInit();
            this.panelLogAtmosferico.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEstufas
            // 
            this.dgvEstufas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstufas.Location = new System.Drawing.Point(263, 1);
            this.dgvEstufas.Name = "dgvEstufas";
            this.dgvEstufas.Size = new System.Drawing.Size(536, 446);
            this.dgvEstufas.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(237, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Location = new System.Drawing.Point(10, 108);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(237, 20);
            this.txtLocalizacao.TabIndex = 5;
            // 
            // txtTamanho_m2
            // 
            this.txtTamanho_m2.Location = new System.Drawing.Point(10, 160);
            this.txtTamanho_m2.Name = "txtTamanho_m2";
            this.txtTamanho_m2.Size = new System.Drawing.Size(237, 20);
            this.txtTamanho_m2.TabIndex = 6;
            // 
            // txtCultura
            // 
            this.txtCultura.Location = new System.Drawing.Point(10, 211);
            this.txtCultura.Name = "txtCultura";
            this.txtCultura.Size = new System.Drawing.Size(237, 20);
            this.txtCultura.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Localização:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tamanho_m^2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cultura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gestor de Estufas";
            // 
            // panelGestorEstufas
            // 
            this.panelGestorEstufas.Controls.Add(this.txtNome);
            this.panelGestorEstufas.Controls.Add(this.label5);
            this.panelGestorEstufas.Controls.Add(this.label4);
            this.panelGestorEstufas.Controls.Add(this.txtLocalizacao);
            this.panelGestorEstufas.Controls.Add(this.label3);
            this.panelGestorEstufas.Controls.Add(this.txtTamanho_m2);
            this.panelGestorEstufas.Controls.Add(this.label2);
            this.panelGestorEstufas.Controls.Add(this.txtCultura);
            this.panelGestorEstufas.Controls.Add(this.label1);
            this.panelGestorEstufas.Controls.Add(this.button2);
            this.panelGestorEstufas.Controls.Add(this.button1);
            this.panelGestorEstufas.Controls.Add(this.button3);
            this.panelGestorEstufas.Location = new System.Drawing.Point(-1, 1);
            this.panelGestorEstufas.Name = "panelGestorEstufas";
            this.panelGestorEstufas.Size = new System.Drawing.Size(258, 292);
            this.panelGestorEstufas.TabIndex = 13;
            // 
            // rb_controle_irrigacao
            // 
            this.rb_controle_irrigacao.AutoSize = true;
            this.rb_controle_irrigacao.Location = new System.Drawing.Point(15, 399);
            this.rb_controle_irrigacao.Name = "rb_controle_irrigacao";
            this.rb_controle_irrigacao.Size = new System.Drawing.Size(123, 17);
            this.rb_controle_irrigacao.TabIndex = 5;
            this.rb_controle_irrigacao.TabStop = true;
            this.rb_controle_irrigacao.Text = "Controle de Irrigação";
            this.rb_controle_irrigacao.UseVisualStyleBackColor = true;
            this.rb_controle_irrigacao.CheckedChanged += new System.EventHandler(this.rb_controle_irrigacao_CheckedChanged);
            // 
            // rb_log_atmosferico
            // 
            this.rb_log_atmosferico.AutoSize = true;
            this.rb_log_atmosferico.Location = new System.Drawing.Point(15, 364);
            this.rb_log_atmosferico.Name = "rb_log_atmosferico";
            this.rb_log_atmosferico.Size = new System.Drawing.Size(101, 17);
            this.rb_log_atmosferico.TabIndex = 4;
            this.rb_log_atmosferico.TabStop = true;
            this.rb_log_atmosferico.Text = "Log Atmosférico";
            this.rb_log_atmosferico.UseVisualStyleBackColor = true;
            this.rb_log_atmosferico.CheckedChanged += new System.EventHandler(this.rb_log_atmosferico_CheckedChanged);
            // 
            // rb_gestor_estufas
            // 
            this.rb_gestor_estufas.AutoSize = true;
            this.rb_gestor_estufas.Location = new System.Drawing.Point(15, 325);
            this.rb_gestor_estufas.Name = "rb_gestor_estufas";
            this.rb_gestor_estufas.Size = new System.Drawing.Size(94, 17);
            this.rb_gestor_estufas.TabIndex = 3;
            this.rb_gestor_estufas.TabStop = true;
            this.rb_gestor_estufas.Text = "Gestor Estufas";
            this.rb_gestor_estufas.UseVisualStyleBackColor = true;
            this.rb_gestor_estufas.CheckedChanged += new System.EventHandler(this.rb_gestor_estufas_CheckedChanged);
            // 
            // panelControleIrrigacao
            // 
            this.panelControleIrrigacao.Controls.Add(this.label8);
            this.panelControleIrrigacao.Controls.Add(this.txt_Id_estufa);
            this.panelControleIrrigacao.Controls.Add(this.label7);
            this.panelControleIrrigacao.Controls.Add(this.num_duracao_irrigacao);
            this.panelControleIrrigacao.Controls.Add(this.label6);
            this.panelControleIrrigacao.Controls.Add(this.btn_ligar_irrigacao);
            this.panelControleIrrigacao.Location = new System.Drawing.Point(-1, 1);
            this.panelControleIrrigacao.Name = "panelControleIrrigacao";
            this.panelControleIrrigacao.Size = new System.Drawing.Size(258, 292);
            this.panelControleIrrigacao.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Duração em segundos:";
            // 
            // num_duracao_irrigacao
            // 
            this.num_duracao_irrigacao.Location = new System.Drawing.Point(64, 134);
            this.num_duracao_irrigacao.Name = "num_duracao_irrigacao";
            this.num_duracao_irrigacao.Size = new System.Drawing.Size(120, 20);
            this.num_duracao_irrigacao.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Controle de Irrigação";
            // 
            // btn_ligar_irrigacao
            // 
            this.btn_ligar_irrigacao.Location = new System.Drawing.Point(64, 229);
            this.btn_ligar_irrigacao.Name = "btn_ligar_irrigacao";
            this.btn_ligar_irrigacao.Size = new System.Drawing.Size(119, 23);
            this.btn_ligar_irrigacao.TabIndex = 0;
            this.btn_ligar_irrigacao.Text = "Enviar Comando";
            this.btn_ligar_irrigacao.UseVisualStyleBackColor = true;
            this.btn_ligar_irrigacao.Click += new System.EventHandler(this.btn_ligar_irrigacao_Click);
            // 
            // txt_Id_estufa
            // 
            this.txt_Id_estufa.Location = new System.Drawing.Point(66, 185);
            this.txt_Id_estufa.Name = "txt_Id_estufa";
            this.txt_Id_estufa.Size = new System.Drawing.Size(112, 20);
            this.txt_Id_estufa.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "ID Estufa:";
            // 
            // panelLogAtmosferico
            // 
            this.panelLogAtmosferico.Controls.Add(this.label9);
            this.panelLogAtmosferico.Location = new System.Drawing.Point(2, 1);
            this.panelLogAtmosferico.Name = "panelLogAtmosferico";
            this.panelLogAtmosferico.Size = new System.Drawing.Size(255, 292);
            this.panelLogAtmosferico.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Logger Atmosférico";
            // 
            // FormEstufas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogAtmosferico);
            this.Controls.Add(this.panelControleIrrigacao);
            this.Controls.Add(this.rb_controle_irrigacao);
            this.Controls.Add(this.rb_log_atmosferico);
            this.Controls.Add(this.rb_gestor_estufas);
            this.Controls.Add(this.dgvEstufas);
            this.Controls.Add(this.panelGestorEstufas);
            this.Name = "FormEstufas";
            this.Text = "FormEstufas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstufas)).EndInit();
            this.panelGestorEstufas.ResumeLayout(false);
            this.panelGestorEstufas.PerformLayout();
            this.panelControleIrrigacao.ResumeLayout(false);
            this.panelControleIrrigacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_duracao_irrigacao)).EndInit();
            this.panelLogAtmosferico.ResumeLayout(false);
            this.panelLogAtmosferico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstufas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.TextBox txtTamanho_m2;
        private System.Windows.Forms.TextBox txtCultura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelGestorEstufas;
        private System.Windows.Forms.RadioButton rb_controle_irrigacao;
        private System.Windows.Forms.RadioButton rb_log_atmosferico;
        private System.Windows.Forms.RadioButton rb_gestor_estufas;
        private System.Windows.Forms.Panel panelControleIrrigacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ligar_irrigacao;
        private System.Windows.Forms.NumericUpDown num_duracao_irrigacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Id_estufa;
        private System.Windows.Forms.Panel panelLogAtmosferico;
        private System.Windows.Forms.Label label9;
    }
}

