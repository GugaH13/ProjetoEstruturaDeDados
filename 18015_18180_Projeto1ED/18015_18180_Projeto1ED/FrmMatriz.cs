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

        //Os componentes são configurados na inicialização da aplicação
        public frmMatriz()
        {
            InitializeComponent();
            cbxOpções.SelectedIndex = 0;

            cbxQualMatriz.Items.Add("Matriz 1");
            cbxQualMatriz.Items.Add("Matriz 2");
            cbxQualMatriz.SelectedIndex = 0;

            cbxMatrizInserir.Items.Add("Matriz 1");
            cbxMatrizInserir.Items.Add("Matriz 2");
            cbxMatrizInserir.SelectedIndex = 0;

            cbxMatrizSomarConstante.Items.Add("Matriz 1");
            cbxMatrizSomarConstante.Items.Add("Matriz 2");
            cbxMatrizSomarConstante.SelectedIndex = 0;
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            FazerLeitura(ref matriz1, dgvMatriz1);
        }

        private void btnArquivo2_Click(object sender, EventArgs e)
        {
            FazerLeitura(ref matriz2, dgvMatriz2);
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
            //Ele tenta converter os valores dos textboxes,
            //caso os campos não estejam preenchidos corretamente,
            //jogamos uma exceção informando o usuário
            try
            {
                double valor = double.Parse(txtValor.Text.Trim());
                int coluna = int.Parse(txtColuna.Text.Trim());
                int linha = int.Parse(txtLinha.Text.Trim());

                //Verifica em qual matriz o dado deverá ser inserido e, em seguida, 
                //chama o método Inserir da classe MatrizEsparsa
                if (cbxMatrizInserir.SelectedItem.ToString() == "Matriz 1")
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
            catch
            {
                MessageBox.Show("Parâmetros não passados corretamente!", "Operações com Matriz Esparsa | Erro de inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Ele tenta converter os valores dos textboxes,
            //caso os campos não estejam preenchidos corretamente,
            //jogamos uma exceção informando o usuário
            try
            {
                int coluna = int.Parse(txtColuna.Text.Trim());
                int linha = int.Parse(txtLinha.Text.Trim());

                //Caso os parâmetros não tenham sido passados incorretamente,
                //chamamos o método RemoverCelula da classe MatrizEsparsa
                if (coluna != default(int) && linha != default(int))
                {
                    //Verifica de qual matriz deveremos remover o dado desejado
                    if (cbxMatrizInserir.SelectedItem.ToString() == "Matriz 1")
                    {
                        try
                        {
                            matriz1.RemoverCelula(coluna, linha);
                            Exibir(dgvMatriz1, matriz1);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "Operações com Matriz Esparsa | Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show(erro.Message, "Operações com Matriz Esparsa | Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Operações com Matriz Esparsa | Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Parâmetros não passados corretamente!", "Operações com Matriz Esparsa | Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //Ele tenta converter os valores dos textboxes,
            //caso os campos não estejam preenchidos corretamente,
            //jogamos uma exceção informando o usuário
            try
            {
                int coluna = int.Parse(txtColuna.Text.Trim());
                int linha = int.Parse(txtLinha.Text.Trim());

                //Caso os parâmetros estejam corretos, 
                //chamamos o método Procurar da classe MatrizEsparsa
                if (coluna != default(int) && linha != default(int) && coluna != 0 && linha != 0)
                {
                    //Verificamos em qual matriz devemos procurar pelo dado desejado
                    if (cbxMatrizInserir.SelectedItem.ToString() == "Matriz 1")
                    {
                        if (matriz1.Procurar(int.Parse(txtColuna.Text.Trim()), int.Parse(txtLinha.Text.Trim())) != default(Celula))
                            txtValor.Text = matriz1.Procurar(int.Parse(txtColuna.Text.Trim()), int.Parse(txtLinha.Text.Trim())).Valor.ToString();
                        else
                            MessageBox.Show("Valor não encontrado!", "Operações com Matriz Esparsa | Erro de procura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (matriz2.Procurar(int.Parse(txtColuna.Text.Trim()), int.Parse(txtLinha.Text.Trim())) != default(Celula))
                            txtValor.Text = matriz2.Procurar(int.Parse(txtColuna.Text.Trim()), int.Parse(txtLinha.Text.Trim())).Valor.ToString();
                        else
                            MessageBox.Show("Valor não encontrado!", "Operações com Matriz Esparsa | Erro na procura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Coordenadas fora do intervalo!", "Operações com Matriz Esparsa | Erro na procura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Parâmetros não passados corretamente!", "Operações com Matriz Esparsa | Erro na procura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificamos em qual das matrizes iremos efetuar a soma de constante,
                //e em seguida chamamos o método SomarEmColuna da classe MatrizEsparsa
                if (cbxMatrizSomarConstante.SelectedItem.ToString() == "Matriz 1")
                {
                    matriz1.SomarEmColuna(int.Parse(txtColunaSoma.Text.Trim()), double.Parse(txtConstSomar.Text.Trim()));
                    Exibir(dgvMatriz1, matriz1);
                }
                else
                {
                    matriz2.SomarEmColuna(int.Parse(txtColunaSoma.Text.Trim()), double.Parse(txtConstSomar.Text.Trim()));
                    Exibir(dgvMatriz2, matriz2);
                }
            }
            catch
            {
                MessageBox.Show("Parâmetros não passados corretamente!", "Operações com Matriz Esparsa | Erro na Soma de Constante", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    //for para identificar as separações, para que seja possível
                    //quebrar a string linha em "valor, coluna e linha"
                    for (int i = 0; i < linha.Trim().Length; i++)
                    {
                        if (linha[i] == ';')
                        {
                            //se a primeiraSeparacao já foi encontrada, 
                            //segundaSeparacao receberá o índice onde foi encontrado
                            //o ponto e vírgula, senão a primeiraSeparação receberá esse índice
                            if (primeiraSeparacao != 0) 
                                segundaSeparacao = i;
                            else
                                primeiraSeparacao = i;
                        }
                    }

                    //estabelecemos variáveis auxiliares para encurtar os parâmetros para a criação
                    //de um objeto da classe Celula
                    int colunaDado = int.Parse(linha.Substring(0, primeiraSeparacao));
                    int linhaDado = int.Parse(linha.Substring(primeiraSeparacao + 1, segundaSeparacao - (primeiraSeparacao + 1)));
                    double valorDado = double.Parse(linha.Substring(segundaSeparacao + 1).Trim());

                    //insere a célula lida na matriz
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

            //percorremos a nossa matriz e exibimos os dados no gridview
            while (atualColuna != matriz.NoCabeca)
            {
                while (atual != atualColuna)
                {
                    if (atual.Valor != default(double))
                    {
                        dgv.Rows[atual.Linha - 1].Cells[atual.Coluna - 1].Value = atual.Valor;
                        //dgv.Columns[atual.Coluna - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    atual = atual.Abaixo;
                }
                atualColuna = atualColuna.Direita;
                atual = atualColuna.Abaixo;
            }

            //adicionamos índices aos cabeçalhos de linhas e colunas do gridview

            foreach (DataGridViewRow linha in dgv.Rows)
            {
                linha.HeaderCell.Value = (linha.Index + 1).ToString();
            }

            foreach (DataGridViewColumn coluna in dgv.Columns)
            {
                coluna.HeaderCell.Value = (coluna.Index + 1).ToString();
            }
        }

        private void btnMultiplicarMatrizes_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificamos a maneira que o usuário deseja multiplicar as matrizes:
                //AxB ou BxA, caso suas proporções sigam os critérios de multiplicação
                //de matrizes
                if (cbxOpções.SelectedIndex == 0)
                    Exibir(dgvMatriz3, MultiplicarMatrizes(matriz1, matriz2));
                else
                    Exibir(dgvMatriz3, MultiplicarMatrizes(matriz2, matriz1));
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

        //Método utilizado no caso de o usuário querer criar a matriz manualmente,
        //e então chamamos um outro método que de fato cria ela, pois esse apenas
        //define qual matriz será criada (A ou B)
        private void btnCriarMatriz_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxQualMatriz.SelectedIndex == 0)
                {
                    CriarMatriz(ref matriz1);
                    Exibir(dgvMatriz1, matriz1);
                }
                else
                {
                    CriarMatriz(ref matriz2);
                    Exibir(dgvMatriz2, matriz2);
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message, "Operações com Matriz Esparsa | Erro na criação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CriarMatriz(ref MatrizEsparsa matriz)
        {
            matriz = new MatrizEsparsa(int.Parse(txtLinhas.Text.Trim()), int.Parse(txtColunas.Text.Trim()));
            dgvMatriz3.Rows.Clear();
            dgvMatriz3.Refresh();
        }

        //Método criado para esvaziar a matriz
        private void btnEsvaziar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxQualMatriz.SelectedItem.ToString() == "Matriz 1")
                {
                    Esvaziar(ref matriz1);
                    Exibir(dgvMatriz1, matriz1);
                }
                else
                {
                    Esvaziar(ref matriz2);
                    Exibir(dgvMatriz2, matriz2);
                }
            }
            catch
            {
                MessageBox.Show("Não é possível esvaziar uma matriz não existente!", "Operações com Matriz Esparsa | Erro ao esvaziar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Esvaziar(ref MatrizEsparsa matriz)
        {
            //É verificado se a matriz está vazia,
            //para então limparmos ela, pois é impossível remover dados
            //de uma matriz que não possui dados
            if (matriz != null)
                matriz.EsvaziarMatriz();
        }

        public MatrizEsparsa MultiplicarMatrizes(MatrizEsparsa matriz1, MatrizEsparsa matriz2)
        {
            MatrizEsparsa resultado;

            //Verifica se as matrizes estão em condições ideias para efetuar a multiplicação
            if (matriz1.NumeroColunas == matriz2.NumeroLinhas && matriz1 != null && matriz2 != null)
            {
                //Geramos uma terceira matriz para armazenar o resultado da multiplicação
                resultado = new MatrizEsparsa(matriz1.NumeroLinhas, matriz2.NumeroColunas);

                //Variável para armazenar a soma dos elementos multiplicados
                //que serão dispostos em uma célula da matriz resultante
                double valorCelulaAInserir = 0;

                //Índice auxiliar que percorrerá tanto as colunas da matriz1, 
                //quanto as linhas da matriz2
                int quantoPercorrer = matriz1.NumeroColunas;

                //Percorre uma linha da matriz resultante
                for (int linha = 1; linha <= resultado.NumeroLinhas; linha++)
                {
                    //Percorre uma linha da matriz resultante
                    for (int coluna = 1; coluna <= resultado.NumeroColunas; coluna++)
                    {
                        //Percorre uma coluna da matriz1 e uma linha da matriz2 em paralelo
                        for (int indice = 1; indice <= quantoPercorrer; indice++)
                        {
                            //Caso o objeto retornado seja nulo, isso significado 
                            //que o valor da célula é zero
                            if (matriz1.Procurar(indice, linha) == default(Celula))
                            {
                                if (matriz2.Procurar(coluna, indice) == default(Celula))
                                    valorCelulaAInserir += 0;
                                else
                                    valorCelulaAInserir += 0 * matriz2.Procurar(coluna, indice).Valor;
                            }
                            else
                            if (matriz2.Procurar(coluna, indice) == default(Celula))
                                valorCelulaAInserir += matriz1.Procurar(indice, linha).Valor * 0;
                            else
                                valorCelulaAInserir += matriz1.Procurar(indice, linha).Valor * matriz2.Procurar(coluna, indice).Valor;
                        }
                        //Após efetuar a multiplicação, inserimos o a somatória das multiplicações
                        //na linha e coluna atual, caso ele seja diferente de zero, pois não há
                        //necessidade de armazenar o zero
                        if (valorCelulaAInserir != 0)
                            resultado.Inserir(new Celula(valorCelulaAInserir, linha, coluna, null, null));
                        //reiniciamos a variável que armazena a somatória das multiplicações
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
