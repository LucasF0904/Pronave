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
    public partial class ContasReceber : Form
    {
        public ContasReceber()
        {
            InitializeComponent();
            panelCadastrarContasReceber.Visible = false;
            panelVisualizaConta.Visible = false;
            btnAcessarInformacoesContasReceber.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarContaReceber_Click(object sender, EventArgs e)
        {
            if(panelCadastrarContasReceber.Visible == true)
            {
                panelCadastrarContasReceber.Visible = false;
            }
            else
            {
                panelCadastrarContasReceber.Visible = true;
                panelVisualizaConta.Visible = false;
            }
        }

        private void btnVisualizarDadosContaReceber_Click(object sender, EventArgs e)
        {
            if (panelVisualizaConta.Visible == true)
            {
                panelVisualizaConta.Visible = false;
            }
            else
            {
                panelVisualizaConta.Visible = true;
                panelCadastrarContasReceber.Visible = false;
            }
        }
    }
}
