using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _18015_18180_Projeto1ED
{
    public partial class frmMatriz : Form
    {
        static MatrizEsparsa matriz;
        static bool primeiraLinha = true;
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
            FazerLeitura(ref matriz,dgvMatriz);
        }
        public void FazerLeitura(ref MatrizEsparsa qualMatriz,
                                 DataGridView dgv)
        {
            
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                var arquivo = new StreamReader(dlgAbrir.FileName);
                while (!arquivo.EndOfStream)
                {
                    LerArquivo(arquivo);

                    if (primeiraLinha == true)
                    {
                        qualMatriz = new MatrizEsparsa();
                        primeiraLinha = false;
                    }
                        
                    
                }
                arquivo.Close();
                qualMatriz.Listar(dgv);
            }
        }
        public void LerArquivo(StreamReader arquivo)
        {
            if (!arquivo.EndOfStream)
            {
                string linha = arquivo.ReadLine();
                for (int i = 0; i < linha.Trim().Length; i++)
                {
                    if (linha[i])
                }
            }
        }
        public void Listar(DataGridView dgv)
        {

        }

    }
}
