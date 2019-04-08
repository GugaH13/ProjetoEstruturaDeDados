//////////////////////////////////////////////////
//PROJETO MATRIZ ESPARSA - ESTRUTURA DE DADOS   //
//////////////////////////////////////////////////
//NOME: GUSTAVO HENRIQUE BÉRA         RA: 18180 //
//NOME: GUSTAVO HENRIQUE DE MEIRA     RA: 18015 //
//////////////////////////////////////////////////

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
        CriarNosCabeca(nLinhas, nColunas);
    }

    public bool EstaVazia()
    {
        bool vazia = true;
        Celula atualC = noCabeca.Direita;
        while (atualC != noCabeca && vazia == true)
        {
            if (atualC.Abaixo != atualC)
                vazia = false;
            atualC = atualC.Direita;
        }
        return vazia;
    }

    public Celula Procurar(int coluna, int linha)
    {
        Celula atualColuna = this.NoCabeca.Direita;
        while (atualColuna.Coluna != coluna)
            atualColuna = atualColuna.Direita;

        Celula atual = atualColuna.Abaixo;
        while (atual != atualColuna)
        {
            if (atual.Linha == linha)
                return atual;
            else
                atual = atual.Abaixo;
        }

        return default(Celula);
    }

    public void Inserir(Celula novaCelula)
    {
        if (novaCelula.Linha <= this.numeroLinhas && novaCelula.Coluna <= this.numeroColunas)
        {
            Celula esq, dir, cima, baixo;
            esq = dir = cima = baixo = null;
            if (!ExisteDado(novaCelula, ref cima, ref esq, ref dir, ref baixo))
            {
                cima.Abaixo = novaCelula;
                esq.Direita = novaCelula;
                novaCelula.Abaixo = baixo;
                novaCelula.Direita = dir;
            }
        }
        else
            throw new Exception("Coordenadas fora do intervalo!");
    }
    public void RemoverCelula(int coluna, int linha)
    {
        Celula celulaARemover = Procurar(coluna, linha);
        if (celulaARemover != default(Celula))
        {
            Celula esq, dir, cima, baixo;
            esq = dir = cima = baixo = null;
            if (ExisteDado(celulaARemover, ref cima, ref esq, ref dir, ref baixo))
            {
                cima.Abaixo = baixo;
                esq.Direita = dir;
            }
        }
        else
            throw new Exception("Impossível remover célula nula!");
    }
    public void EsvaziarMatriz()
    {
        this.noCabeca = null;
        CriarNosCabeca(numeroLinhas, numeroColunas);
    }
    protected void CriarNosCabeca(int nLinhas, int nColunas)
    {
        int c = default(int);
        int l = 0;
        Celula anterior = this.noCabeca;
        this.noCabeca = new Celula(default(double), l, c, default(Celula), default(Celula));//instanciar noCabeca
        anterior = this.noCabeca;
        for (c = 1; c < nColunas; c++)//sabemos que o primeiro já foi criado
        {
            anterior.Direita = new Celula(default(double), l, c, default(Celula), anterior.Direita);//como está vazia seu abaixo recebe a si mesma
            anterior.Direita.Abaixo = anterior.Direita;
            anterior = anterior.Direita;
        }
        anterior.Direita = new Celula(default(double), l, c, this.noCabeca, anterior.Direita);//última coluna
        anterior.Direita.Abaixo = anterior.Direita;
        anterior = this.noCabeca;
        c = 0;
        for (l = 1; l < nLinhas; l++)//já criou todos na linha 0, então vai iniciar na um
        {
                anterior.Abaixo = new Celula(default(double), l, c, anterior.Abaixo, default(Celula));
                anterior.Abaixo.Direita = anterior.Abaixo;
                anterior = anterior.Abaixo;
        }
        anterior.Abaixo = new Celula(default(double), l, c, anterior.Abaixo, default(Celula));//é a última linha
        anterior.Abaixo.Direita = anterior.Abaixo;
        anterior.Abaixo.Abaixo = this.noCabeca;
    }


    protected bool ExisteDado(Celula celulaNova, ref Celula cima, ref Celula esq, ref Celula dir, ref Celula baixo)
    {
        bool achou = false;
        if (EstaVazia())
        {
            cima = noCabeca.Direita;
            esq = noCabeca.Abaixo;
            dir = noCabeca.Abaixo;
            baixo = noCabeca.Direita;
            achou = false;
        }
        else
        {
            Celula atualC = noCabeca.Direita,
            atualL = noCabeca.Abaixo;
            while (atualC.Coluna != celulaNova.Coluna || atualL.Linha != celulaNova.Linha)
            {
                if (atualC.Coluna != celulaNova.Coluna)
                {
                    atualC = atualC.Direita;
                }
                if (atualL.Linha != celulaNova.Linha)
                {
                    atualL = atualL.Abaixo;
                }
            }
            Celula noCabecaC = atualC;
            Celula noCabecaL = atualL;
            bool achouAcima = false;
            while (achouAcima == false)
            {
                if (atualC.Abaixo == noCabecaC)
                {
                    achouAcima = true;
                    cima = atualC;
                    achou = false;
                    baixo = atualC.Abaixo;
                }
                else
                if (atualC.Abaixo.Valor == celulaNova.Valor &&
                    atualC.Abaixo.Coluna == celulaNova.Coluna &&
                    atualC.Abaixo.Linha == celulaNova.Linha)
                {
                    achou = true;
                    cima = atualC;
                    baixo = atualC.Abaixo.Abaixo; // talvez esteja errado
                    achouAcima = true;
                }
                else
                if (atualC.Abaixo.Coluna == celulaNova.Coluna &&
                    atualC.Abaixo.Linha == celulaNova.Linha)
                {
                    cima = atualC;
                    baixo = atualC.Abaixo.Abaixo; // talvez esteja errado
                    achouAcima = true;
                }
                else
                if (atualC.Abaixo.Linha < celulaNova.Linha)
                {
                    atualC = atualC.Abaixo;
                }
                else
                if (atualC.Abaixo.Linha > celulaNova.Linha)
                {
                    cima = atualC;
                    achou = false;
                    achouAcima = true;
                    baixo = atualC.Abaixo;
                }
            }
            bool achouEsq = false;
            while (achouEsq == false)
            {
                if (atualL.Direita.Coluna > celulaNova.Coluna)
                {
                    esq = atualL;
                    achouEsq = true;
                    dir = atualL.Direita;
                }
                else
                if (atualL.Direita == noCabecaL)
                {
                    esq = atualL;
                    achouEsq = true;
                    dir = atualL.Direita;
                }
                if (atualL.Direita.Valor == celulaNova.Valor &&
                    atualL.Direita.Coluna == celulaNova.Coluna &&
                    atualL.Direita.Linha == celulaNova.Linha)
                {
                    achouEsq = true;
                    esq = atualL;
                    dir = atualL.Direita.Direita;
                }
                else
                if (atualL.Direita.Coluna == celulaNova.Coluna &&
                    atualL.Direita.Linha == celulaNova.Linha)
                {
                    achouEsq = true;
                    esq = atualL;
                    dir = atualL.Direita.Direita;
                }
                else
                    atualL = atualL.Direita;

            }

        }
        return achou;

    }
    public void SomarEmColuna(int c, double valor)
    {
        Celula atualColuna = NoCabeca.Direita;

        while (atualColuna.Coluna != c)
        {
            atualColuna = atualColuna.Direita;
        }

        Celula atual = atualColuna.Abaixo;
        int linhaAtual = 1, ateOnde = atual.Linha;

        while (linhaAtual < NumeroLinhas)
        {
            if (linhaAtual != ateOnde)
            {
                Inserir(new Celula(valor, linhaAtual, atualColuna.Coluna, default(Celula), default(Celula)));
                linhaAtual++;
            }
            else
            {
                atual.Valor += valor;
                if (atual.Valor == 0)
                {
                    RemoverCelula(atual.Coluna, atual.Linha);
                }
                atual = atual.Abaixo;
                if (atual.Linha == 0)
                    ateOnde = NumeroLinhas;
                else
                    ateOnde = atual.Linha;
                linhaAtual++;
            }

        }
        if (Procurar(atualColuna.Coluna, linhaAtual) != default(Celula))
        {
            Procurar(atualColuna.Coluna, linhaAtual).Valor += valor;
            if (Procurar(atualColuna.Coluna, linhaAtual).Valor == 0)
            {
                RemoverCelula(atualColuna.Coluna, linhaAtual);
            }
        }
        else
        {
            Inserir(new Celula(valor, linhaAtual, atualColuna.Coluna, default(Celula), default(Celula)));
        }

        
    }
}
