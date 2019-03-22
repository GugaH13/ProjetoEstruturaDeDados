using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Celula
{
    Celula direita, abaixo;
    int linha, coluna;
    double valor;

    public Celula Direita { get => direita; set => direita = value; }
    public Celula Abaixo { get => abaixo; set => abaixo = value; }
    public int Linha { get => linha; set => linha = value; }
    public int Coluna { get => coluna; set => coluna = value; }
    public double Valor { get => valor; set => valor = value; }

    public Celula (double valor, int linha, int coluna, Celula direita, Celula abaixo)
    {
        this.valor = valor;
        this.linha = linha;
        this.coluna = coluna;
        this.direita = direita;
        this.abaixo = abaixo;
    }
}
