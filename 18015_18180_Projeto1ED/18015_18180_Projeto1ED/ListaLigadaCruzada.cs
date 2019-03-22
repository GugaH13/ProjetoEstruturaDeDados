using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ListaLigadaCruzada
{
    Celula noCabeca;
    int numeroLinhas, numeroColunas;

    public Celula NoCabeca { get => noCabeca; set => noCabeca = value; }

    public ListaLigadaCruzada(Celula noCabeca, int nl, int nc)
    {
        this.noCabeca = noCabeca;
        this.numeroLinhas = nl;
        this.numeroColunas = nc;
        Construir(nl,nc);
    }

    protected void Construir(int nl, int nc)
    {
        int nAtualL = 0, nAtualC = 0;

        while (nAtualL < nl && nAtualC < nc)
        {
            
        }
    }


   /* public bool ExisteCelula(Celula c)
    {
        Celula atual = noCabeca;
        
        while ()
    }*/
}
