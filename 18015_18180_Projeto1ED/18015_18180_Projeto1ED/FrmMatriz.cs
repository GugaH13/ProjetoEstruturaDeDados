//////////////////////////////////////////////////
//PROJETO MATRIZ ESPARSA - ESTRUTURA DE DADOS   //
//////////////////////////////////////////////////
//NOME: GUSTAVO HENRIQUE BÉRA         RA: 18180 //
//NOME: GUSTAVO HENRIQUE DE MEIRA     RA: 18015 //
//////////////////////////////////////////////////

using System;
using System.Windows.Forms;
using System.IO;

namespace _18015_18180_Projeto1ED
{
    public partial class frmMatriz : Form
    {
        MatrizEsparsa matriz1, matriz2, matriz3;

        public frmMatriz()
        {
            InitializeComponent();
        }

        private void txtLinhaMult_TextChanged(object sender, EventArgs e)
        {
            txtChange(txtLinhaMult,txtColunaMult);
        }

        private void txtColunaMult_TextChanged(object sender, EventArgs e)
        {
            txtChange(txtColunaMult, txtLinhaMult);
        }

        private void txtLinhaMult_Leave(object sender, EventArgs e)
        {
            txtLeave(txtLinhaMult,txtColunaMult);
        }

        private void txtColunaMult_Leave(object sender, EventArgs e)
        {
            txtLeave(txtColunaMult,txtLinhaMult);
        }

        private void txtLinhaSoma_TextChanged(object sender, EventArgs e)
        {
            txtChange(txtLinhaSoma,txtColunaSoma);
        }

        private void txtColunaSoma_TextChanged(object sender, EventArgs e)
        {
            txtChange(txtColunaSoma, txtLinhaSoma);
        }
        static void txtChange(TextBox txtAlterando, TextBox txtBloqueado)
        {
            if (txtAlterando.Text == "")
                txtBloqueado.Enabled = true;
            else
                txtBloqueado.Enabled = false;
        }
        static void txtLeave(TextBox txtDeixado, TextBox txtOutro)
        {
            if (txtDeixado.Text.Trim() == "")
            {
                txtDeixado.Text = "";
                txtOutro.Enabled = true;
            }
        }

        private void txtLinhaSoma_Leave(object sender, EventArgs e)
        {
            txtLeave(txtLinhaSoma,txtColunaSoma);
        }

        private void txtColunaSoma_Leave(object sender, EventArgs e)
        {
            txtLeave(txtColunaSoma,txtLinhaSoma);
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            FazerLeitura(ref matriz1, dgvMatriz1);
            cbxQualMatriz.Items.Add("Matriz 1");
            cbxQualMatriz.SelectedItem = "Matriz 1";
        }

        private void btnArquivo2_Click(object sender, EventArgs e)
        {
            FazerLeitura(ref matriz2, dgvMatriz2);
            cbxQualMatriz.Items.Add("Matriz 2");
            cbxQualMatriz.SelectedItem = "Matriz 2";
        }

        public void FazerLeitura(ref MatrizEsparsa qualMatriz, DataGridView dgv)
        {            
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                var arquivo = new StreamReader(dlgAbrir.FileName);
                LerArquivo(ref qualMatriz, arquivo);
                Exibir(dgv, qualMatriz);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            int coluna = int.Parse(txtColuna.Text);
            int linha = int.Parse(txtLinha.Text);

            if (cbxQualMatriz.SelectedItem.ToString() == "Matriz 1")
            {
                try
                {
                    matriz1.Inserir(new Celula(valor, linha, coluna, default(Celula), default(Celula)));
                    Exibir(dgvMatriz1, matriz1);
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message, "Operações com Matriz Esparsa | Erro de inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    matriz2.Inserir(new Celula(valor, linha, coluna, default(Celula), default(Celula)));
                    Exibir(dgvMatriz1, matriz2);
                }
                catch
                {
                    MessageBox.Show("Linha ou coluna fora do intervalo", "Operações com Matriz Esparsa | Erro de inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int coluna = int.Parse(txtColuna.Text);
            int linha = int.Parse(txtLinha.Text);

            if (coluna != default(int) && linha != default(int))
            {
                if (cbxQualMatriz.SelectedItem.ToString() == "Matriz 1")
                {
                    try
                    {
                        matriz1.RemoverCelula(coluna, linha);
                        Exibir(dgvMatriz1, matriz1);
                    }
                    catch(Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Operações com Matriz Esparsa | Erro de inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    try
                    {
                        matriz2.RemoverCelula(coluna, linha);
                        Exibir(dgvMatriz2, matriz2);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Operações com Matriz Esparsa | Erro de inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!", "Operações com Matriz Esparsa | Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            int coluna = int.Parse(txtColuna.Text);
            int linha = int.Parse(txtLinha.Text);

            if (coluna != default(int) && linha != default(int) && coluna != 0 && linha != 0)
            {
                if (cbxQualMatriz.SelectedItem.ToString() == "Matriz 1")
                {
                    if (matriz1.Procurar(int.Parse(txtColuna.Text), int.Parse(txtLinha.Text)) != default(Celula))
                        txtValor.Text = matriz1.Procurar(int.Parse(txtColuna.Text), int.Parse(txtLinha.Text)).Valor.ToString();
                    else
                        MessageBox.Show("Valor não encontrado!", "Operações com Matriz Esparsa | Erro de procura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (matriz2.Procurar(int.Parse(txtColuna.Text), int.Parse(txtLinha.Text)) != default(Celula))
                        txtValor.Text = matriz2.Procurar(int.Parse(txtColuna.Text), int.Parse(txtLinha.Text)).Valor.ToString();
                    else
                        MessageBox.Show("Valor não encontrado!", "Operações com Matriz Esparsa | Erro na procura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Coordenadas fora do intervalo!", "Operações com Matriz Esparsa | Erro na procura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LerArquivo(ref MatrizEsparsa qualMatriz, StreamReader arquivo)
        {
            if (!arquivo.EndOfStream)
            {
                int posX = 0;
                string linha = arquivo.ReadLine();
                // for para descobrir as proporções da matriz
                for (int i = 0; i < linha.Trim().Length; i++)
                {
                    if (linha[i] == 'x')
                    {
                        posX = i;
                        break; // interrompe o for quando o 'x' for encontrado
                    }                    
                }
                // define as proporções das matrizes
                qualMatriz = new MatrizEsparsa(int.Parse(linha.Substring(posX + 1).Trim()),
                                           int.Parse(linha.Substring(0, posX))); 
                int primeiraSeparacao = 0;
                int segundaSeparacao = 0;
                // while para pegar os dados
                while (!arquivo.EndOfStream)
                {
                    linha = arquivo.ReadLine();
                    for(int i = 0; i < linha.Trim().Length; i++)
                    {
                        if(linha[i] == ';')
                        {
                            if (primeiraSeparacao != 0)
                                segundaSeparacao = i;
                            else
                                primeiraSeparacao = i;
                        }
                    }

                    int colunaDado = int.Parse(linha.Substring(0, primeiraSeparacao));
                    int linhaDado = int.Parse(linha.Substring(primeiraSeparacao + 1, segundaSeparacao - (primeiraSeparacao + 1)));
                    double valorDado = double.Parse(linha.Substring(segundaSeparacao + 1).Trim());

                    Celula celulaAtual = new Celula(valorDado, linhaDado, colunaDado, default(Celula), default(Celula));
                    if (linhaDado > qualMatriz.NumeroLinhas || colunaDado > qualMatriz.NumeroColunas)
                        throw new Exception("Célula fora das dimensões da Matriz!");
                    else
                        qualMatriz.Inserir(celulaAtual);
                }
                arquivo.Close();
            }
        }

        public void Exibir(DataGridView dgv, MatrizEsparsa matriz)
        {
            dgv.Rows.Clear();
            dgv.Refresh();

            Celula atualColuna = matriz.NoCabeca.Direita;
            Celula atual = atualColuna.Abaixo;

            dgv.RowCount = matriz.NumeroLinhas;
            dgv.ColumnCount = matriz.NumeroColunas;

            while (atualColuna != matriz.NoCabeca)
            {
                while (atual != atualColuna)
                {
                    if (atual.Valor != default(double))
                    {
                        dgv.Rows[atual.Linha - 1].Cells[atual.Coluna - 1].Value = atual.Valor;//deve estar errado
                    }
                    atual = atual.Abaixo;
                }
                atualColuna = atualColuna.Direita;
                atual = atualColuna.Abaixo;
            }
        }
    }
}
