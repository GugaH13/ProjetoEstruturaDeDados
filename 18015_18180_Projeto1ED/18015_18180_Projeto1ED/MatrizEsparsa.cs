using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MatrizEsparsa
{
    Celula noCabeca;
    int numeroLinhas, numeroColunas;
    ListaCircular<Celula> lColuna;

    public Celula NoCabeca { get => noCabeca; set => noCabeca = value; }

    public MatrizEsparsa(Celula noCabeca, int nl, int nc)
    {
        this.noCabeca = noCabeca;
        this.numeroLinhas = nl;
        this.numeroColunas = nc;
        Construir(nl,nc);
    }

    protected void Construir(int nl, int nc)
    {
        lColuna = new ListaCircular<Celula>();
        int nAtualL = 0, nAtualC = 0;
        NoLista<Celula> atual = lColuna.Primeiro;

        while (nAtualL < nl)
        {
            ListaCircular<Celula> lLinha = new ListaCircular<Celula>();
            lColuna.Atual = lLinha.Primeiro;

            atual = atual.Prox;
            nAtualL++;
        }
    }


   /* public bool ExisteCelula(Celula c)
    {
        Celula atual = noCabeca;
        
        while ()
    }*/
}
