using Pronave.Telas.Telas_Secundarias;
using System;
using System.Windows.Forms;
using System.Timers;
using System.Windows.Threading;

namespace Pronave.Telas
{
    public partial class Inicial : Form
    {
        private string _currenttime;

        public Inicial()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Background);
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.IsEnabled = true;
            timer.Tick += (s, e) =>
            {
                UpdateTime();
            };
        }
        public string CurrentTime
        {
            get { return _currenttime; }
            set { _currenttime = value; lblDateTimeNow.Text = value; }
        }

        private void UpdateTime()
        {
            CurrentTime = DateTime.Now.ToLongTimeString();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnContas_Click(object sender, EventArgs e)
        {
            ContasReceber contasReceber = new ContasReceber();
            contasReceber.ShowDialog();
        }

        private void btnEstoqueMatriz_Click(object sender, EventArgs e)
        {
            EstoqueMatriz estoqueMatriz = new EstoqueMatriz();
            estoqueMatriz.ShowDialog();
        }

        private void btnEstoqueVendedor_Click(object sender, EventArgs e)
        {
            EstoqueVendedor estoqueVendedor = new EstoqueVendedor();
            estoqueVendedor.ShowDialog();
        }
    }
}
