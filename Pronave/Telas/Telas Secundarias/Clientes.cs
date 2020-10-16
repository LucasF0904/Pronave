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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            panelCadastrar.Visible = false;
            panelEndereco.Visible = false;
            panelVIsualizarClientes.Visible = false;
            btnAcessarInformacoesCliente.Enabled = false;
            panelVIsualizarClientes.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            if (panelCadastrar.Visible == true)
            {
                panelCadastrar.Visible = false;
            }
            else
            {
                panelCadastrar.Visible = true;
                panelVIsualizarClientes.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelEndereco.Visible == true)
            {
                panelEndereco.Visible = false;
            }
            else
            {
                panelEndereco.Visible = true;
                panelVIsualizarClientes.Visible = false;
            }
        }

        private void btnAtualizarEndereco_Click(object sender, EventArgs e)
        {
            if (panelEndereco.Visible == true)
            {
                panelEndereco.Visible = false;
            }
            else
            {
                panelEndereco.Visible = true;
                panelVIsualizarClientes.Visible = false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (panelCadastrar.Visible == true)
            {
                panelCadastrar.Visible = false;
            }
            else
            {
                panelCadastrar.Visible = true;
                panelVIsualizarClientes.Visible = false;
            }
        }

        private void btnVisualizarDadosCliente_Click(object sender, EventArgs e)
        {
            if(panelVIsualizarClientes.Visible == true)
            {
                panelVIsualizarClientes.Visible = false;
            }
            else
            {
                panelVIsualizarClientes.Visible = true;
                panelCadastrar.Visible = false;
            }
        }
    }
}
