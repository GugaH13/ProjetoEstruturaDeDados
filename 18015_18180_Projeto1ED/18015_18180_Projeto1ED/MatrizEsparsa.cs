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
        if (nLinhas <= 0 || nColunas <= 0)
            throw new Exception("Valores inválidos para a criação da Matriz!");

        this.numeroLinhas = nLinhas;
        this.numeroColunas = nColunas;
        CriarNosCabeca(nLinhas, nColunas);
    }

    public bool EstaVazia()
    {
        bool vazia = true;
        Celula atualC = noCabeca.Direita;
        while (atualC != noCabeca && vazia == true)//for para percorrer as colunas enquanto não encontrar elementos ou finalizar a matriz
        {
            if (atualC.Abaixo != atualC)//se não apontar para ele tem algum item
                vazia = false;
            atualC = atualC.Direita;
        }
        return vazia;
    }

    public Celula Procurar(int coluna, int linha)
    {
        Celula atualColuna = this.NoCabeca.Direita;
        while (atualColuna.Coluna != coluna)// posicionar atual coluna na coluna do item procurado 
            atualColuna = atualColuna.Direita;

        Celula atual = atualColuna.Abaixo;
        while (atual != atualColuna)
        {
            if (atual.Linha == linha)
                return atual;
            else
                atual = atual.Abaixo;//vai para baixo até chegar a linha procurada
        }

        return default(Celula);// se não achar retorna o default(Celula)
    }

    public void Inserir(Celula novaCelula)
    {
        if (novaCelula.Linha <= this.numeroLinhas && novaCelula.Coluna <= this.numeroColunas && novaCelula.Linha > 0 && novaCelula.Coluna > 0)
        {
            Celula esq, dir, cima, baixo;
            esq = dir = cima = baixo = null;
            if (!ExisteDado(novaCelula, ref cima, ref esq, ref dir, ref baixo))//baixo,cima,esquerda,direita configurados
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
            if (ExisteDado(celulaARemover, ref cima, ref esq, ref dir, ref baixo))//baixo,cima,esquerda,direita configurados
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
        this.noCabeca = null;//anula para o garbage collector remover os dados
        CriarNosCabeca(numeroLinhas, numeroColunas);//recria
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
        Celula atualC = noCabeca.Direita,
        atualL = noCabeca.Abaixo;
        while (atualC.Coluna != celulaNova.Coluna || atualL.Linha != celulaNova.Linha)
        {
            if (atualC.Coluna != celulaNova.Coluna) //chega na coluna do item desejado
            {
                atualC = atualC.Direita;
            }
            if (atualL.Linha != celulaNova.Linha)// chega na linha do item desejado
            {
                atualL = atualL.Abaixo;
            }
        }
        Celula noCabecaC = atualC;
        Celula noCabecaL = atualL;
        bool achouAcima = false;
        while (achouAcima == false) // acha a de cima
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
                atualC.Abaixo.Linha == celulaNova.Linha)// se mesmas cordenadas e valor são iguais
            {
                achou = true;
                cima = atualC;
                baixo = atualC.Abaixo.Abaixo;
                achouAcima = true;
            }
            else
            if (atualC.Abaixo.Coluna == celulaNova.Coluna &&
                atualC.Abaixo.Linha == celulaNova.Linha)// checa se coordenadas são iguais, mas o valor é diferente
            {
                cima = atualC;
                baixo = atualC.Abaixo.Abaixo;
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
        while (achouEsq == false)// acha a da esquerda
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

        return achou;

    }
    public void SomarEmColuna(int c, double valor)
    {
        if (c > numeroColunas || c <= 0)
            throw new Exception("Fora do intervalo!");

        Celula atualColuna = NoCabeca.Direita;

        while (atualColuna.Coluna != c)
        {
            atualColuna = atualColuna.Direita;
        }

        Celula atual = atualColuna.Abaixo;
        int linhaAtual = 1, ateOnde = atual.Linha;

        while (linhaAtual < NumeroLinhas)//enquanto a auxiliar for menor que o número de linhas
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
                    RemoverCelula(atual.Coluna, atual.Linha);// remove se o valor for 0
                }
                atual = atual.Abaixo;
                if (atual.Linha == 0)
                    ateOnde = NumeroLinhas;//ateOnde recebe o número de colunas para ir até o final, se não cairia em loop por nunca chegar a 0
                else
                    ateOnde = atual.Linha;
                linhaAtual++;
            }
        }
        //chegou a última linha
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
