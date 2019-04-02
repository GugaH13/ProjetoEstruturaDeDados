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
            this.dgvMatriz1 = new System.Windows.Forms.DataGridView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.gbOperacoes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxQualMatriz = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbMultiplicar = new System.Windows.Forms.GroupBox();
            this.gbSomar = new System.Windows.Forms.GroupBox();
            this.txtConstSomar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColunaSoma = new System.Windows.Forms.TextBox();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.txtColuna = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvMatriz2 = new System.Windows.Forms.DataGridView();
            this.btnArquivo1 = new System.Windows.Forms.Button();
            this.btnArquivo2 = new System.Windows.Forms.Button();
            this.btnSomarConstante = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSomarMatrizes = new System.Windows.Forms.Button();
            this.btnMultiplicarMatrizes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).BeginInit();
            this.gbOperacoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMultiplicar.SuspendLayout();
            this.gbSomar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMatriz1
            // 
            this.dgvMatriz1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriz1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMatriz1.ColumnHeadersVisible = false;
            this.dgvMatriz1.Location = new System.Drawing.Point(12, 44);
            this.dgvMatriz1.MultiSelect = false;
            this.dgvMatriz1.Name = "dgvMatriz1";
            this.dgvMatriz1.ReadOnly = true;
            this.dgvMatriz1.RowHeadersVisible = false;
            this.dgvMatriz1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMatriz1.Size = new System.Drawing.Size(308, 290);
            this.dgvMatriz1.TabIndex = 0;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(96, 26);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(78, 62);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(174, 23);
            this.txtValor.TabIndex = 2;
            // 
            // gbOperacoes
            // 
            this.gbOperacoes.Controls.Add(this.label10);
            this.gbOperacoes.Controls.Add(this.label11);
            this.gbOperacoes.Controls.Add(this.label9);
            this.gbOperacoes.Controls.Add(this.groupBox2);
            this.gbOperacoes.Controls.Add(this.gbMultiplicar);
            this.gbOperacoes.Controls.Add(this.gbSomar);
            this.gbOperacoes.Controls.Add(this.txtLinha);
            this.gbOperacoes.Controls.Add(this.txtColuna);
            this.gbOperacoes.Controls.Add(this.txtValor);
            this.gbOperacoes.Controls.Add(this.btnInserir);
            this.gbOperacoes.Controls.Add(this.btnRemover);
            this.gbOperacoes.Controls.Add(this.btnProcurar);
            this.gbOperacoes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperacoes.Location = new System.Drawing.Point(640, 44);
            this.gbOperacoes.Name = "gbOperacoes";
            this.gbOperacoes.Size = new System.Drawing.Size(267, 586);
            this.gbOperacoes.TabIndex = 3;
            this.gbOperacoes.TabStop = false;
            this.gbOperacoes.Text = "Operações";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbxQualMatriz);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(326, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 290);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qual Matriz?";
            // 
            // cbxQualMatriz
            // 
            this.cbxQualMatriz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQualMatriz.FormattingEnabled = true;
            this.cbxQualMatriz.Location = new System.Drawing.Point(100, 39);
            this.cbxQualMatriz.Name = "cbxQualMatriz";
            this.cbxQualMatriz.Size = new System.Drawing.Size(174, 25);
            this.cbxQualMatriz.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Matriz:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Linha: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Valor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Coluna:";
            // 
            // gbMultiplicar
            // 
            this.gbMultiplicar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMultiplicar.Controls.Add(this.btnMultiplicarMatrizes);
            this.gbMultiplicar.Location = new System.Drawing.Point(6, 449);
            this.gbMultiplicar.Name = "gbMultiplicar";
            this.gbMultiplicar.Size = new System.Drawing.Size(255, 130);
            this.gbMultiplicar.TabIndex = 4;
            this.gbMultiplicar.TabStop = false;
            this.gbMultiplicar.Text = "Multiplicar Matrizes";
            // 
            // gbSomar
            // 
            this.gbSomar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSomar.Controls.Add(this.btnSomarConstante);
            this.gbSomar.Controls.Add(this.txtConstSomar);
            this.gbSomar.Controls.Add(this.label1);
            this.gbSomar.Controls.Add(this.label7);
            this.gbSomar.Controls.Add(this.txtColunaSoma);
            this.gbSomar.Location = new System.Drawing.Point(6, 162);
            this.gbSomar.Name = "gbSomar";
            this.gbSomar.Size = new System.Drawing.Size(255, 138);
            this.gbSomar.TabIndex = 3;
            this.gbSomar.TabStop = false;
            this.gbSomar.Text = "Somar Constante";
            // 
            // txtConstSomar
            // 
            this.txtConstSomar.Location = new System.Drawing.Point(118, 51);
            this.txtConstSomar.Name = "txtConstSomar";
            this.txtConstSomar.Size = new System.Drawing.Size(100, 23);
            this.txtConstSomar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Constante:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Coluna:";
            // 
            // txtColunaSoma
            // 
            this.txtColunaSoma.Location = new System.Drawing.Point(118, 22);
            this.txtColunaSoma.Name = "txtColunaSoma";
            this.txtColunaSoma.Size = new System.Drawing.Size(100, 23);
            this.txtColunaSoma.TabIndex = 9;
            this.txtColunaSoma.TextChanged += new System.EventHandler(this.txtColunaSoma_TextChanged);
            this.txtColunaSoma.Leave += new System.EventHandler(this.txtColunaSoma_Leave);
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(78, 120);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(174, 23);
            this.txtLinha.TabIndex = 2;
            // 
            // txtColuna
            // 
            this.txtColuna.Location = new System.Drawing.Point(78, 91);
            this.txtColuna.Name = "txtColuna";
            this.txtColuna.Size = new System.Drawing.Size(174, 23);
            this.txtColuna.TabIndex = 2;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(15, 26);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(177, 26);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 340);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(308, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvMatriz2
            // 
            this.dgvMatriz2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriz2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMatriz2.ColumnHeadersVisible = false;
            this.dgvMatriz2.Location = new System.Drawing.Point(326, 44);
            this.dgvMatriz2.MultiSelect = false;
            this.dgvMatriz2.Name = "dgvMatriz2";
            this.dgvMatriz2.ReadOnly = true;
            this.dgvMatriz2.RowHeadersVisible = false;
            this.dgvMatriz2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMatriz2.Size = new System.Drawing.Size(308, 290);
            this.dgvMatriz2.TabIndex = 0;
            // 
            // btnArquivo1
            // 
            this.btnArquivo1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnArquivo1.Location = new System.Drawing.Point(12, 8);
            this.btnArquivo1.Name = "btnArquivo1";
            this.btnArquivo1.Size = new System.Drawing.Size(84, 30);
            this.btnArquivo1.TabIndex = 4;
            this.btnArquivo1.Text = "Arquivo 1";
            this.btnArquivo1.UseVisualStyleBackColor = true;
            this.btnArquivo1.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // btnArquivo2
            // 
            this.btnArquivo2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnArquivo2.Location = new System.Drawing.Point(102, 8);
            this.btnArquivo2.Name = "btnArquivo2";
            this.btnArquivo2.Size = new System.Drawing.Size(84, 30);
            this.btnArquivo2.TabIndex = 4;
            this.btnArquivo2.Text = "Arquivo 2";
            this.btnArquivo2.UseVisualStyleBackColor = true;
            this.btnArquivo2.Click += new System.EventHandler(this.btnArquivo2_Click);
            // 
            // btnSomarConstante
            // 
            this.btnSomarConstante.Location = new System.Drawing.Point(10, 83);
            this.btnSomarConstante.Name = "btnSomarConstante";
            this.btnSomarConstante.Size = new System.Drawing.Size(236, 44);
            this.btnSomarConstante.TabIndex = 15;
            this.btnSomarConstante.Text = "Somar";
            this.btnSomarConstante.UseVisualStyleBackColor = true;
            this.btnSomarConstante.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Esvaziar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSomarMatrizes);
            this.groupBox2.Location = new System.Drawing.Point(6, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 127);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Somar Matrizes";
            // 
            // btnSomarMatrizes
            // 
            this.btnSomarMatrizes.Location = new System.Drawing.Point(9, 41);
            this.btnSomarMatrizes.Name = "btnSomarMatrizes";
            this.btnSomarMatrizes.Size = new System.Drawing.Size(236, 44);
            this.btnSomarMatrizes.TabIndex = 16;
            this.btnSomarMatrizes.Text = "Somar";
            this.btnSomarMatrizes.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicarMatrizes
            // 
            this.btnMultiplicarMatrizes.Location = new System.Drawing.Point(9, 43);
            this.btnMultiplicarMatrizes.Name = "btnMultiplicarMatrizes";
            this.btnMultiplicarMatrizes.Size = new System.Drawing.Size(236, 44);
            this.btnMultiplicarMatrizes.TabIndex = 16;
            this.btnMultiplicarMatrizes.Text = "Multiplicar";
            this.btnMultiplicarMatrizes.UseVisualStyleBackColor = true;
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 639);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnArquivo2);
            this.Controls.Add(this.btnArquivo1);
            this.Controls.Add(this.gbOperacoes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvMatriz2);
            this.Controls.Add(this.dgvMatriz1);
            this.Name = "frmMatriz";
            this.Text = "Operações com Matriz Esparsa | Estrutura de Dados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).EndInit();
            this.gbOperacoes.ResumeLayout(false);
            this.gbOperacoes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMultiplicar.ResumeLayout(false);
            this.gbSomar.ResumeLayout(false);
            this.gbSomar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatriz1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox gbOperacoes;
        private System.Windows.Forms.GroupBox gbSomar;
        private System.Windows.Forms.GroupBox gbMultiplicar;
        private System.Windows.Forms.TextBox txtConstSomar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColunaSoma;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvMatriz2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.TextBox txtColuna;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxQualMatriz;
        private System.Windows.Forms.Button btnArquivo1;
        private System.Windows.Forms.Button btnArquivo2;
        private System.Windows.Forms.Button btnSomarConstante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSomarMatrizes;
        private System.Windows.Forms.Button btnMultiplicarMatrizes;
        private System.Windows.Forms.Button button1;
    }
}

