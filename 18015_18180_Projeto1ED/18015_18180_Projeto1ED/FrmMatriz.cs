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
        static MatrizEsparsa matriz;
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
            FazerLeitura(ref matriz, dgvMatriz);
        }
        public void FazerLeitura(ref MatrizEsparsa qualMatriz, DataGridView dgv)
        {            
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                var arquivo = new StreamReader(dlgAbrir.FileName);
                LerArquivo(arquivo);
                Listar(qualMatriz, dgv);
            }
        }
        public void LerArquivo(StreamReader arquivo)
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
                matriz = new MatrizEsparsa(int.Parse(linha.Substring(0, posX)),
                                           int.Parse(linha.Substring(posX + 1).Trim()));
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

                    Celula celulaAtual = new Celula(valorDado, linhaDado, colunaDado, null, null);                    
                    matriz.Inserir(celulaAtual);
                }
                arquivo.Close();
            }
        }
        public void Listar(MatrizEsparsa qualMatriz, DataGridView dgv)
        {

        }
    }
}
