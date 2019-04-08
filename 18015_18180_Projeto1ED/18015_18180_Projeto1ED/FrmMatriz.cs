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
        MatrizEsparsa matriz1, matriz2;

        public frmMatriz()
        {
            InitializeComponent();
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            FazerLeitura(ref matriz1, dgvMatriz1);
            if (cbxQualMatriz.Items.Contains("Matriz 1") == false)
                cbxQualMatriz.Items.Add("Matriz 1");
            cbxQualMatriz.SelectedItem = "Matriz 1";
            cbxQualMatriz.Enabled = true;
        }

        private void btnArquivo2_Click(object sender, EventArgs e)
        {
            FazerLeitura(ref matriz2, dgvMatriz2);
            if (!cbxQualMatriz.Items.Contains("Matriz 2"))
                cbxQualMatriz.Items.Add("Matriz 2");
            cbxQualMatriz.SelectedItem = "Matriz 2";
            cbxQualMatriz.Enabled = true;
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
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Operações com Matriz Esparsa | Erro de inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    matriz2.Inserir(new Celula(valor, linha, coluna, default(Celula), default(Celula)));
                    Exibir(dgvMatriz2, matriz2);
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
                    catch (Exception erro)
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

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (cbxQualMatriz.SelectedItem.ToString() == "Matriz 1")
            {
                matriz1.SomarEmColuna(int.Parse(txtColunaSoma.Text), int.Parse(txtConstSomar.Text));
                Exibir(dgvMatriz1, matriz1);
            }
            else
            {
                matriz2.SomarEmColuna(int.Parse(txtColunaSoma.Text), int.Parse(txtConstSomar.Text));
                Exibir(dgvMatriz2, matriz2);
            }
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
                    for (int i = 0; i < linha.Trim().Length; i++)
                    {
                        if (linha[i] == ';')
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

        private void btnSomarMatrizes_Click(object sender, EventArgs e)
        {
            try
            {
                Exibir(dgvMatriz3, SomarMatrizes(matriz1, matriz2));
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Operações com Matriz Esparsa | Erro na soma de matrizes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnMultiplicarMatrizes_Click(object sender, EventArgs e)
        {
            try
            {
                Exibir(dgvMatriz3, MultiplicarMatrizes(matriz1, matriz2));
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Operações com Matriz Esparsa | Erro na soma de matrizes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public MatrizEsparsa SomarMatrizes(MatrizEsparsa matriz1, MatrizEsparsa matriz2)
        {
            MatrizEsparsa resultado;
            if (matriz1.NumeroLinhas == matriz2.NumeroLinhas && matriz1.NumeroColunas == matriz2.NumeroColunas)
            {
                resultado = new MatrizEsparsa(matriz1.NumeroLinhas, matriz1.NumeroColunas);

                Celula topo1 = matriz1.NoCabeca.Direita,
                       topo2 = matriz2.NoCabeca.Direita;
                Celula atual1 = topo1.Abaixo,
                       atual2 = topo2.Abaixo;
                while (topo1 != matriz1.NoCabeca && topo2 != matriz2.NoCabeca)
                {
                    if (atual1.Linha == atual2.Linha && atual1.Coluna == atual2.Coluna)
                    {
                        if (atual1.Valor + atual2.Valor != 0)
                            resultado.Inserir(new Celula(atual1.Valor + atual2.Valor, atual1.Linha, atual1.Coluna, default(Celula), default(Celula)));

                        atual1 = atual1.Abaixo;
                        atual2 = atual2.Abaixo;
                    }
                    else
                    if (atual1.Linha < atual2.Linha && atual1.Coluna == atual2.Coluna)
                    {
                        resultado.Inserir(new Celula(atual1.Valor, atual1.Linha, atual1.Coluna, default(Celula), default(Celula)));
                        atual1 = atual1.Abaixo;
                    }
                    else
                    if (atual2.Linha < atual1.Linha && atual2.Coluna == atual1.Coluna)
                    {
                        resultado.Inserir(new Celula(atual2.Valor, atual2.Linha, atual2.Coluna, default(Celula), default(Celula)));
                        atual2 = atual2.Abaixo;
                    }
                    else
                    if (atual1.Coluna != atual2.Coluna)
                    {
                        if (atual1.Coluna < atual2.Coluna)
                        {
                            resultado.Inserir(new Celula(atual1.Valor, atual1.Linha, atual1.Coluna, default(Celula), default(Celula)));
                            atual1 = atual1.Abaixo;
                        }
                        else
                        {
                            resultado.Inserir(new Celula(atual2.Valor, atual2.Linha, atual2.Coluna, default(Celula), default(Celula)));
                            atual2 = atual2.Abaixo;
                        }
                    }
                    while (atual1 == topo1)
                    {
                        topo1 = topo1.Direita;
                        atual1 = topo1.Abaixo;
                    }
                    while (atual2 == topo2)
                    {
                        topo2 = topo2.Direita;
                        atual2 = topo2.Abaixo;
                    }

                }
                while (topo1 != matriz1.NoCabeca)
                {
                    resultado.Inserir(new Celula(atual1.Valor, atual1.Linha, atual1.Coluna, default(Celula), default(Celula)));
                    atual1 = atual1.Abaixo;
                    if (atual1 == topo1)
                    {
                        topo1 = topo1.Direita;
                        atual1 = topo1.Abaixo;
                    }
                }
                while (topo2 != matriz2.NoCabeca)
                {
                    resultado.Inserir(new Celula(atual2.Valor, atual2.Linha, atual2.Coluna, default(Celula), default(Celula)));
                    atual2 = atual2.Abaixo;
                    if (atual2 == topo2)
                    {
                        topo2 = topo2.Direita;
                        atual2 = topo2.Abaixo;
                    }
                }
            }
            else
                throw new Exception("Matrizes com dimensões diferentes não podem ser somadas!");

            return resultado;
        }

        public MatrizEsparsa MultiplicarMatrizes(MatrizEsparsa matriz1, MatrizEsparsa matriz2)
        {
            MatrizEsparsa resultado;

            if (matriz1.NumeroColunas == matriz2.NumeroLinhas)
            {
                resultado = new MatrizEsparsa(matriz1.NumeroLinhas, matriz2.NumeroColunas);
                double valorCelulaAInserir = 0;
                int quantoPercorrer = matriz1.NumeroColunas;

                for(int linha = 1; linha <= resultado.NumeroLinhas; linha++)
                {
                    for(int coluna = 1; coluna <= resultado.NumeroColunas; coluna++)
                    {
                        for (int indice = 1; indice <= quantoPercorrer; indice++)
                        {
                            valorCelulaAInserir += matriz1.Procurar(indice, linha).Valor * matriz2.Procurar(coluna, indice).Valor;
                        }
                        if (valorCelulaAInserir != 0)
                            resultado.Inserir(new Celula(valorCelulaAInserir, linha, coluna, null, null));
                        valorCelulaAInserir = 0;
                    }
                }
                
            }
            else
                throw new Exception("O número de colunas da matriz A não corresponde ao número de linhas da matriz B!");

            return resultado;
        }
    }
}
