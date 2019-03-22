using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18015_18180_Projeto1ED
{
    public partial class frmMatriz : Form
    {
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
    }
}
