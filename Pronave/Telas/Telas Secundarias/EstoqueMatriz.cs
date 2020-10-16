using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pronave.Telas.Telas_Secundarias
{
    public partial class EstoqueMatriz : Form
    {
        public EstoqueMatriz()
        {
            InitializeComponent();
            panelCadastrarEstoqueMatriz.Visible = false;
            panelVisualizarEstoqueMatriz.Visible = false;
            btnAcessarInformacoesProduto.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarEstoque_Click(object sender, EventArgs e)
        {
            if(panelCadastrarEstoqueMatriz.Visible == false)
            {
                panelCadastrarEstoqueMatriz.Visible = true;
                panelVisualizarEstoqueMatriz.Visible = false;
            }
            else
            {
                panelCadastrarEstoqueMatriz.Visible = false;
            }
        }

        private void btnVisualizarEstoqueMatriz_Click(object sender, EventArgs e)
        {
            if (panelVisualizarEstoqueMatriz.Visible == false)
            {
                panelVisualizarEstoqueMatriz.Visible = true;
                panelCadastrarEstoqueMatriz.Visible = false;
            }
            else
            {
                panelVisualizarEstoqueMatriz.Visible = false;
            }
        }
    }
}
