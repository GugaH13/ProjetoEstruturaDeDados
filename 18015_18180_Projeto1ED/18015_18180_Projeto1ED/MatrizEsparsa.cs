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

    public MatrizEsparsa(Celula noCabeca, int nl, int nc)
    {
        this.noCabeca = noCabeca;
        this.numeroLinhas = nl;
        this.numeroColunas = nc;
    }

 


   /* public bool ExisteCelula(Celula c)
    {
        Celula atual = noCabeca;
        
        while ()
    }*/
}
