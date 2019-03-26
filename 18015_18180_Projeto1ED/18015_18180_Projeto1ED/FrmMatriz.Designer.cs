namespace _18015_18180_Projeto1ED
{
    partial class frmMatriz
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
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtCelulaProcurada = new System.Windows.Forms.TextBox();
            this.gbOperacoes = new System.Windows.Forms.GroupBox();
            this.gbMultiplicar = new System.Windows.Forms.GroupBox();
            this.txtConstMult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColunaMult = new System.Windows.Forms.TextBox();
            this.txtLinhaMult = new System.Windows.Forms.TextBox();
            this.gbSomar = new System.Windows.Forms.GroupBox();
            this.txtConstSomar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtColunaSoma = new System.Windows.Forms.TextBox();
            this.txtLinhaSoma = new System.Windows.Forms.TextBox();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.lsbResultado = new System.Windows.Forms.ListBox();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.gbOperacoes.SuspendLayout();
            this.gbMultiplicar.SuspendLayout();
            this.gbSomar.SuspendLayout();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(12, 98);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.Size = new System.Drawing.Size(527, 472);
            this.dgvMatriz.TabIndex = 0;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(199, 22);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // txtCelulaProcurada
            // 
            this.txtCelulaProcurada.Location = new System.Drawing.Point(6, 22);
            this.txtCelulaProcurada.Name = "txtCelulaProcurada";
            this.txtCelulaProcurada.Size = new System.Drawing.Size(187, 23);
            this.txtCelulaProcurada.TabIndex = 2;
            // 
            // gbOperacoes
            // 
            this.gbOperacoes.Controls.Add(this.gbMultiplicar);
            this.gbOperacoes.Controls.Add(this.gbSomar);
            this.gbOperacoes.Controls.Add(this.txtCelulaProcurada);
            this.gbOperacoes.Controls.Add(this.btnProcurar);
            this.gbOperacoes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperacoes.Location = new System.Drawing.Point(545, 88);
            this.gbOperacoes.Name = "gbOperacoes";
            this.gbOperacoes.Size = new System.Drawing.Size(333, 355);
            this.gbOperacoes.TabIndex = 3;
            this.gbOperacoes.TabStop = false;
            this.gbOperacoes.Text = "Operações";
            // 
            // gbMultiplicar
            // 
            this.gbMultiplicar.Controls.Add(this.txtConstMult);
            this.gbMultiplicar.Controls.Add(this.label6);
            this.gbMultiplicar.Controls.Add(this.label5);
            this.gbMultiplicar.Controls.Add(this.label3);
            this.gbMultiplicar.Controls.Add(this.label4);
            this.gbMultiplicar.Controls.Add(this.txtColunaMult);
            this.gbMultiplicar.Controls.Add(this.txtLinhaMult);
            this.gbMultiplicar.Location = new System.Drawing.Point(0, 187);
            this.gbMultiplicar.Name = "gbMultiplicar";
            this.gbMultiplicar.Size = new System.Drawing.Size(333, 168);
            this.gbMultiplicar.TabIndex = 4;
            this.gbMultiplicar.TabStop = false;
            this.gbMultiplicar.Text = "Multiplicar Por Constante";
            // 
            // txtConstMult
            // 
            this.txtConstMult.Location = new System.Drawing.Point(23, 106);
            this.txtConstMult.Name = "txtConstMult";
            this.txtConstMult.Size = new System.Drawing.Size(100, 23);
            this.txtConstMult.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Constante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "OU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coluna:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Linha: ";
            // 
            // txtColunaMult
            // 
            this.txtColunaMult.Location = new System.Drawing.Point(193, 48);
            this.txtColunaMult.Name = "txtColunaMult";
            this.txtColunaMult.Size = new System.Drawing.Size(100, 23);
            this.txtColunaMult.TabIndex = 1;
            this.txtColunaMult.TextChanged += new System.EventHandler(this.txtColunaMult_TextChanged);
            this.txtColunaMult.Leave += new System.EventHandler(this.txtColunaMult_Leave);
            // 
            // txtLinhaMult
            // 
            this.txtLinhaMult.Location = new System.Drawing.Point(23, 48);
            this.txtLinhaMult.Name = "txtLinhaMult";
            this.txtLinhaMult.Size = new System.Drawing.Size(100, 23);
            this.txtLinhaMult.TabIndex = 0;
            this.txtLinhaMult.TextChanged += new System.EventHandler(this.txtLinhaMult_TextChanged);
            this.txtLinhaMult.Leave += new System.EventHandler(this.txtLinhaMult_Leave);
            // 
            // gbSomar
            // 
            this.gbSomar.Controls.Add(this.txtConstSomar);
            this.gbSomar.Controls.Add(this.label1);
            this.gbSomar.Controls.Add(this.label2);
            this.gbSomar.Controls.Add(this.label7);
            this.gbSomar.Controls.Add(this.label8);
            this.gbSomar.Controls.Add(this.txtColunaSoma);
            this.gbSomar.Controls.Add(this.txtLinhaSoma);
            this.gbSomar.Location = new System.Drawing.Point(0, 51);
            this.gbSomar.Name = "gbSomar";
            this.gbSomar.Size = new System.Drawing.Size(333, 130);
            this.gbSomar.TabIndex = 3;
            this.gbSomar.TabStop = false;
            this.gbSomar.Text = "Somar Constante";
            // 
            // txtConstSomar
            // 
            this.txtConstSomar.Location = new System.Drawing.Point(17, 101);
            this.txtConstSomar.Name = "txtConstSomar";
            this.txtConstSomar.Size = new System.Drawing.Size(100, 23);
            this.txtConstSomar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Constante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "OU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Coluna:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Linha: ";
            // 
            // txtColunaSoma
            // 
            this.txtColunaSoma.Location = new System.Drawing.Point(187, 43);
            this.txtColunaSoma.Name = "txtColunaSoma";
            this.txtColunaSoma.Size = new System.Drawing.Size(100, 23);
            this.txtColunaSoma.TabIndex = 9;
            this.txtColunaSoma.TextChanged += new System.EventHandler(this.txtColunaSoma_TextChanged);
            this.txtColunaSoma.Leave += new System.EventHandler(this.txtColunaSoma_Leave);
            // 
            // txtLinhaSoma
            // 
            this.txtLinhaSoma.Location = new System.Drawing.Point(17, 43);
            this.txtLinhaSoma.Name = "txtLinhaSoma";
            this.txtLinhaSoma.Size = new System.Drawing.Size(100, 23);
            this.txtLinhaSoma.TabIndex = 8;
            this.txtLinhaSoma.TextChanged += new System.EventHandler(this.txtLinhaSoma_TextChanged);
            this.txtLinhaSoma.Leave += new System.EventHandler(this.txtLinhaSoma_Leave);
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.lsbResultado);
            this.gbResultado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(545, 449);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(333, 121);
            this.gbResultado.TabIndex = 5;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado";
            // 
            // lsbResultado
            // 
            this.lsbResultado.FormattingEnabled = true;
            this.lsbResultado.ItemHeight = 17;
            this.lsbResultado.Location = new System.Drawing.Point(6, 22);
            this.lsbResultado.Name = "lsbResultado";
            this.lsbResultado.Size = new System.Drawing.Size(321, 89);
            this.lsbResultado.TabIndex = 6;
            // 
            // btnArquivo
            // 
            this.btnArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivo.Location = new System.Drawing.Point(12, 13);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(168, 79);
            this.btnArquivo.TabIndex = 6;
            this.btnArquivo.Text = "Arquivo";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 600);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbOperacoes);
            this.Controls.Add(this.dgvMatriz);
            this.Name = "frmMatriz";
            this.Text = "Matriz Esparsa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.gbOperacoes.ResumeLayout(false);
            this.gbOperacoes.PerformLayout();
            this.gbMultiplicar.ResumeLayout(false);
            this.gbMultiplicar.PerformLayout();
            this.gbSomar.ResumeLayout(false);
            this.gbSomar.PerformLayout();
            this.gbResultado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtCelulaProcurada;
        private System.Windows.Forms.GroupBox gbOperacoes;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.ListBox lsbResultado;
        private System.Windows.Forms.GroupBox gbSomar;
        private System.Windows.Forms.GroupBox gbMultiplicar;
        private System.Windows.Forms.TextBox txtConstMult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColunaMult;
        private System.Windows.Forms.TextBox txtLinhaMult;
        private System.Windows.Forms.TextBox txtConstSomar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtColunaSoma;
        private System.Windows.Forms.TextBox txtLinhaSoma;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
    }
}

