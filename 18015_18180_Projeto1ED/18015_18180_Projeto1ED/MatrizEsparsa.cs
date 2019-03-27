using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MatrizEsparsa
{
    Celula noCabeca;
    int numeroLinhas, numeroColunas;

    public Celula NoCabeca { get => noCabeca; set => noCabeca = value; }
    public int NumeroLinhas { get => numeroLinhas; set => numeroLinhas = value; }
    public int NumeroColunas { get => numeroColunas; set => numeroColunas = value; }

    public MatrizEsparsa()
    {
        this.noCabeca = null;
        this.numeroLinhas = this.numeroColunas = 0;
    }
    public MatrizEsparsa(int nLinhas, int nColunas)
    {
        this.numeroLinhas = nLinhas;
        this.numeroColunas = nColunas;
        CriarNosCabeca(nLinhas,nColunas);
    }

    public bool EstaVazia
    {
        get => this.noCabeca == null;
    }

    public void Inserir(Celula novaCelula)//não finalizado
    {
        if (EstaVazia)
        {
            this.noCabeca.Direita.Abaixo = novaCelula;
            this.noCabeca.Abaixo.Direita = novaCelula;
        }
        else
        {
            Celula anteriorLinha, atualLinha, anteriorColuna, atualColuna, noCabecaLinhaAtual, noCabecaColunaAtual;
            anteriorLinha = atualLinha = anteriorColuna  = atualColuna = noCabecaLinhaAtual = noCabecaColunaAtual = noCabeca;

            novaCelula.Abaixo = novaCelula.Direita = null;

            if (numeroLinhas >= novaCelula.Linha && numeroColunas >= novaCelula.Coluna)
            {
                while (atualLinha.Linha != novaCelula.Linha)
                {
                    anteriorLinha = atualLinha;
                    atualLinha = atualLinha.Abaixo;
                    noCabecaLinhaAtual = atualLinha;
                }
                while (atualColuna.Coluna != novaCelula.Coluna)
                {
                    anteriorColuna = atualColuna;
                    atualColuna = atualColuna.Direita;
                    noCabecaColunaAtual = atualColuna;
                }
                if (noCabecaColunaAtual.Direita != noCabecaColunaAtual &&
                    noCabecaLinhaAtual.Abaixo != noCabecaLinhaAtual)
                {
                    while (anteriorColuna.Linha != novaCelula.Linha)
                    {
                        anteriorColuna  = anteriorColuna.Abaixo;
                        atualColuna = atualColuna.Abaixo;
                    }
                    novaCelula.Direita = atualColuna.Direita;
                    anteriorColuna.Direita = novaCelula;

                    novaCelula.Abaixo = atualColuna.Abaixo;
                }
                else
                {
                    if (noCabecaLinhaAtual.Direita == noCabecaLinhaAtual)
                    {
                        noCabecaLinhaAtual.Direita = novaCelula;
                    }
                    if (noCabecaColunaAtual.Abaixo == noCabecaColunaAtual)
                    {
                        noCabecaColunaAtual.Abaixo = novaCelula;
                    }

                }
                
                
                
            }

        }

    }
    protected void CriarNosCabeca(int nLinhas, int nColunas)
    {
        int c = default(int);
        Celula anterior = this.noCabeca; 
        for (int l = -1; l <= nLinhas; l++)
        {
            if (l == -1)
            for (c = -1; c <= nColunas; c++)
            {
                if (l == -1 && c == -1)
                {
                    this.noCabeca = new Celula(default(double),l,c,null,null);
                }
                else
                {
                    if (c == nColunas)
                    {
                        anterior.Direita = new Celula(default(double), l, c, anterior.Direita, null);
                    }
                    else
                    {
                        anterior.Direita = new Celula(default(double), l, c, null, null);//como está vazia seu direita recebe a si mesma
                        anterior = anterior.Direita;
                    }
                    
                }
            }
            else
            {
                c = -1;
                anterior = this.noCabeca;
                anterior.Abaixo = new Celula(default(double),l,c,anterior.Abaixo,null);
                anterior = anterior.Abaixo;
            }
        }
    }

   /* public bool ExisteCelula(Celula c)
    {
        Celula atual = noCabeca;
        
        while ()
    }*/
}
