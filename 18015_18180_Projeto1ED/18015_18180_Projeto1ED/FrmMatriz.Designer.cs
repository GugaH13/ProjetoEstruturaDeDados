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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMatriz1 = new System.Windows.Forms.DataGridView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.gbOperacoes = new System.Windows.Forms.GroupBox();
            this.cbxMatrizInserir = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLinhas = new System.Windows.Forms.TextBox();
            this.txtColunas = new System.Windows.Forms.TextBox();
            this.btnCriarMatriz = new System.Windows.Forms.Button();
            this.btnEsvaziar = new System.Windows.Forms.Button();
            this.cbxQualMatriz = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbSomar = new System.Windows.Forms.GroupBox();
            this.cbxMatrizSomarConstante = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSomarConstante = new System.Windows.Forms.Button();
            this.txtConstSomar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColunaSoma = new System.Windows.Forms.TextBox();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.txtColuna = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSomarMatrizes = new System.Windows.Forms.Button();
            this.gbMultiplicar = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxOpções = new System.Windows.Forms.ComboBox();
            this.btnMultiplicarMatrizes = new System.Windows.Forms.Button();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dgvMatriz3 = new System.Windows.Forms.DataGridView();
            this.dgvMatriz2 = new System.Windows.Forms.DataGridView();
            this.btnArquivo1 = new System.Windows.Forms.Button();
            this.btnArquivo2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).BeginInit();
            this.gbOperacoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSomar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbMultiplicar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatriz1
            // 
            this.dgvMatriz1.ColumnHeadersHeight = 25;
            this.dgvMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMatriz1.Location = new System.Drawing.Point(12, 44);
            this.dgvMatriz1.MultiSelect = false;
            this.dgvMatriz1.Name = "dgvMatriz1";
            this.dgvMatriz1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriz1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatriz1.RowHeadersWidth = 45;
            this.dgvMatriz1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMatriz1.Size = new System.Drawing.Size(308, 290);
            this.dgvMatriz1.TabIndex = 0;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(96, 23);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 30);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(78, 104);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(174, 23);
            this.txtValor.TabIndex = 2;
            // 
            // gbOperacoes
            // 
            this.gbOperacoes.Controls.Add(this.cbxMatrizInserir);
            this.gbOperacoes.Controls.Add(this.label5);
            this.gbOperacoes.Controls.Add(this.groupBox1);
            this.gbOperacoes.Controls.Add(this.label10);
            this.gbOperacoes.Controls.Add(this.label11);
            this.gbOperacoes.Controls.Add(this.label9);
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
            // cbxMatrizInserir
            // 
            this.cbxMatrizInserir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatrizInserir.FormattingEnabled = true;
            this.cbxMatrizInserir.Location = new System.Drawing.Point(78, 73);
            this.cbxMatrizInserir.Name = "cbxMatrizInserir";
            this.cbxMatrizInserir.Size = new System.Drawing.Size(172, 25);
            this.cbxMatrizInserir.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Qual?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLinhas);
            this.groupBox1.Controls.Add(this.txtColunas);
            this.groupBox1.Controls.Add(this.btnCriarMatriz);
            this.groupBox1.Controls.Add(this.btnEsvaziar);
            this.groupBox1.Controls.Add(this.cbxQualMatriz);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(6, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros de Criação da Matrizes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Linhas: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Colunas:";
            // 
            // txtLinhas
            // 
            this.txtLinhas.Location = new System.Drawing.Point(78, 65);
            this.txtLinhas.Name = "txtLinhas";
            this.txtLinhas.Size = new System.Drawing.Size(172, 23);
            this.txtLinhas.TabIndex = 18;
            // 
            // txtColunas
            // 
            this.txtColunas.Location = new System.Drawing.Point(78, 36);
            this.txtColunas.Name = "txtColunas";
            this.txtColunas.Size = new System.Drawing.Size(172, 23);
            this.txtColunas.TabIndex = 19;
            // 
            // btnCriarMatriz
            // 
            this.btnCriarMatriz.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCriarMatriz.Location = new System.Drawing.Point(17, 129);
            this.btnCriarMatriz.Name = "btnCriarMatriz";
            this.btnCriarMatriz.Size = new System.Drawing.Size(108, 30);
            this.btnCriarMatriz.TabIndex = 16;
            this.btnCriarMatriz.Text = "Criar";
            this.btnCriarMatriz.UseVisualStyleBackColor = true;
            this.btnCriarMatriz.Click += new System.EventHandler(this.btnCriarMatriz_Click);
            // 
            // btnEsvaziar
            // 
            this.btnEsvaziar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEsvaziar.Location = new System.Drawing.Point(131, 129);
            this.btnEsvaziar.Name = "btnEsvaziar";
            this.btnEsvaziar.Size = new System.Drawing.Size(108, 30);
            this.btnEsvaziar.TabIndex = 16;
            this.btnEsvaziar.Text = "Esvaziar";
            this.btnEsvaziar.UseVisualStyleBackColor = true;
            this.btnEsvaziar.Click += new System.EventHandler(this.btnEsvaziar_Click);
            // 
            // cbxQualMatriz
            // 
            this.cbxQualMatriz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQualMatriz.FormattingEnabled = true;
            this.cbxQualMatriz.Location = new System.Drawing.Point(78, 94);
            this.cbxQualMatriz.Name = "cbxQualMatriz";
            this.cbxQualMatriz.Size = new System.Drawing.Size(172, 25);
            this.cbxQualMatriz.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Matriz:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Linha: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Valor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Coluna:";
            // 
            // gbSomar
            // 
            this.gbSomar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSomar.Controls.Add(this.cbxMatrizSomarConstante);
            this.gbSomar.Controls.Add(this.label6);
            this.gbSomar.Controls.Add(this.btnSomarConstante);
            this.gbSomar.Controls.Add(this.txtConstSomar);
            this.gbSomar.Controls.Add(this.label1);
            this.gbSomar.Controls.Add(this.label7);
            this.gbSomar.Controls.Add(this.txtColunaSoma);
            this.gbSomar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gbSomar.Location = new System.Drawing.Point(6, 379);
            this.gbSomar.Name = "gbSomar";
            this.gbSomar.Size = new System.Drawing.Size(255, 201);
            this.gbSomar.TabIndex = 3;
            this.gbSomar.TabStop = false;
            this.gbSomar.Text = "Somar Constante";
            // 
            // cbxMatrizSomarConstante
            // 
            this.cbxMatrizSomarConstante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatrizSomarConstante.FormattingEnabled = true;
            this.cbxMatrizSomarConstante.Location = new System.Drawing.Point(93, 40);
            this.cbxMatrizSomarConstante.Name = "cbxMatrizSomarConstante";
            this.cbxMatrizSomarConstante.Size = new System.Drawing.Size(156, 25);
            this.cbxMatrizSomarConstante.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Qual?";
            // 
            // btnSomarConstante
            // 
            this.btnSomarConstante.Location = new System.Drawing.Point(9, 133);
            this.btnSomarConstante.Name = "btnSomarConstante";
            this.btnSomarConstante.Size = new System.Drawing.Size(236, 44);
            this.btnSomarConstante.TabIndex = 15;
            this.btnSomarConstante.Text = "Somar Constante";
            this.btnSomarConstante.UseVisualStyleBackColor = true;
            this.btnSomarConstante.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // txtConstSomar
            // 
            this.txtConstSomar.Location = new System.Drawing.Point(93, 100);
            this.txtConstSomar.Name = "txtConstSomar";
            this.txtConstSomar.Size = new System.Drawing.Size(156, 23);
            this.txtConstSomar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Constante:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Coluna:";
            // 
            // txtColunaSoma
            // 
            this.txtColunaSoma.Location = new System.Drawing.Point(93, 71);
            this.txtColunaSoma.Name = "txtColunaSoma";
            this.txtColunaSoma.Size = new System.Drawing.Size(156, 23);
            this.txtColunaSoma.TabIndex = 9;
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(78, 162);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(174, 23);
            this.txtLinha.TabIndex = 2;
            // 
            // txtColuna
            // 
            this.txtColuna.Location = new System.Drawing.Point(78, 133);
            this.txtColuna.Name = "txtColuna";
            this.txtColuna.Size = new System.Drawing.Size(174, 23);
            this.txtColuna.TabIndex = 2;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(15, 23);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 30);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(177, 23);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 30);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSomarMatrizes);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(326, 518);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 109);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Somar Matrizes";
            // 
            // btnSomarMatrizes
            // 
            this.btnSomarMatrizes.Location = new System.Drawing.Point(34, 41);
            this.btnSomarMatrizes.Name = "btnSomarMatrizes";
            this.btnSomarMatrizes.Size = new System.Drawing.Size(236, 44);
            this.btnSomarMatrizes.TabIndex = 16;
            this.btnSomarMatrizes.Text = "Somar Matrizes";
            this.btnSomarMatrizes.UseVisualStyleBackColor = true;
            this.btnSomarMatrizes.Click += new System.EventHandler(this.btnSomarMatrizes_Click);
            // 
            // gbMultiplicar
            // 
            this.gbMultiplicar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMultiplicar.Controls.Add(this.label4);
            this.gbMultiplicar.Controls.Add(this.cbxOpções);
            this.gbMultiplicar.Controls.Add(this.btnMultiplicarMatrizes);
            this.gbMultiplicar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gbMultiplicar.Location = new System.Drawing.Point(326, 345);
            this.gbMultiplicar.Name = "gbMultiplicar";
            this.gbMultiplicar.Size = new System.Drawing.Size(308, 167);
            this.gbMultiplicar.TabIndex = 4;
            this.gbMultiplicar.TabStop = false;
            this.gbMultiplicar.Text = "Multiplicar Matrizes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Opções:";
            // 
            // cbxOpções
            // 
            this.cbxOpções.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOpções.FormattingEnabled = true;
            this.cbxOpções.Items.AddRange(new object[] {
            "AxB",
            "BxA"});
            this.cbxOpções.Location = new System.Drawing.Point(34, 62);
            this.cbxOpções.Name = "cbxOpções";
            this.cbxOpções.Size = new System.Drawing.Size(236, 25);
            this.cbxOpções.TabIndex = 17;
            // 
            // btnMultiplicarMatrizes
            // 
            this.btnMultiplicarMatrizes.Location = new System.Drawing.Point(34, 98);
            this.btnMultiplicarMatrizes.Name = "btnMultiplicarMatrizes";
            this.btnMultiplicarMatrizes.Size = new System.Drawing.Size(236, 44);
            this.btnMultiplicarMatrizes.TabIndex = 16;
            this.btnMultiplicarMatrizes.Text = "Multiplicar Matrizes";
            this.btnMultiplicarMatrizes.UseVisualStyleBackColor = true;
            this.btnMultiplicarMatrizes.Click += new System.EventHandler(this.btnMultiplicarMatrizes_Click);
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.DefaultExt = "*.mat";
            this.dlgAbrir.Filter = "Arquivos de Matrizes|*.mat|Arquivos de Texto|*.txt";
            this.dlgAbrir.InitialDirectory = ".\\18015_18180_Projeto1ED";
            // 
            // dgvMatriz3
            // 
            this.dgvMatriz3.ColumnHeadersHeight = 25;
            this.dgvMatriz3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMatriz3.Location = new System.Drawing.Point(12, 340);
            this.dgvMatriz3.MultiSelect = false;
            this.dgvMatriz3.Name = "dgvMatriz3";
            this.dgvMatriz3.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriz3.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatriz3.RowHeadersWidth = 45;
            this.dgvMatriz3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMatriz3.Size = new System.Drawing.Size(308, 290);
            this.dgvMatriz3.TabIndex = 0;
            // 
            // dgvMatriz2
            // 
            this.dgvMatriz2.ColumnHeadersHeight = 25;
            this.dgvMatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMatriz2.Location = new System.Drawing.Point(326, 44);
            this.dgvMatriz2.MultiSelect = false;
            this.dgvMatriz2.Name = "dgvMatriz2";
            this.dgvMatriz2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriz2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatriz2.RowHeadersWidth = 45;
            this.dgvMatriz2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMatriz2.Size = new System.Drawing.Size(308, 290);
            this.dgvMatriz2.TabIndex = 0;
            // 
            // btnArquivo1
            // 
            this.btnArquivo1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnArquivo1.Location = new System.Drawing.Point(12, 8);
            this.btnArquivo1.Name = "btnArquivo1";
            this.btnArquivo1.Size = new System.Drawing.Size(108, 30);
            this.btnArquivo1.TabIndex = 4;
            this.btnArquivo1.Text = "Arquivo 1";
            this.btnArquivo1.UseVisualStyleBackColor = true;
            this.btnArquivo1.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // btnArquivo2
            // 
            this.btnArquivo2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnArquivo2.Location = new System.Drawing.Point(126, 8);
            this.btnArquivo2.Name = "btnArquivo2";
            this.btnArquivo2.Size = new System.Drawing.Size(108, 30);
            this.btnArquivo2.TabIndex = 4;
            this.btnArquivo2.Text = "Arquivo 2";
            this.btnArquivo2.UseVisualStyleBackColor = true;
            this.btnArquivo2.Click += new System.EventHandler(this.btnArquivo2_Click);
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnArquivo2);
            this.Controls.Add(this.btnArquivo1);
            this.Controls.Add(this.gbOperacoes);
            this.Controls.Add(this.gbMultiplicar);
            this.Controls.Add(this.dgvMatriz3);
            this.Controls.Add(this.dgvMatriz2);
            this.Controls.Add(this.dgvMatriz1);
            this.Name = "frmMatriz";
            this.Text = "Operações com Matriz Esparsa | Estrutura de Dados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).EndInit();
            this.gbOperacoes.ResumeLayout(false);
            this.gbOperacoes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSomar.ResumeLayout(false);
            this.gbSomar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbMultiplicar.ResumeLayout(false);
            this.gbMultiplicar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvMatriz3;
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
        private System.Windows.Forms.Button btnEsvaziar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLinhas;
        private System.Windows.Forms.TextBox txtColunas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxOpções;
        private System.Windows.Forms.Button btnCriarMatriz;
        private System.Windows.Forms.ComboBox cbxMatrizInserir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMatrizSomarConstante;
        private System.Windows.Forms.Label label6;
    }
}

