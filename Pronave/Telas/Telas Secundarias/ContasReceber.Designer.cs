namespace Pronave.Telas.Telas_Secundarias
{
    partial class ContasReceber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.lblContasReceber = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnAcessarInformacoesContasReceber = new System.Windows.Forms.Button();
            this.btnVisualizarDadosContaReceber = new System.Windows.Forms.Button();
            this.btnCadastrarContaReceber = new System.Windows.Forms.Button();
            this.panelCadastrarContasReceber = new System.Windows.Forms.Panel();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataInicioCadastro = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFimCadastrar = new System.Windows.Forms.DateTimePicker();
            this.btnCadastrarConta = new System.Windows.Forms.Button();
            this.lblCadastrarConta = new System.Windows.Forms.Label();
            this.panelVisualizaConta = new System.Windows.Forms.Panel();
            this.lblVisualizaCliente = new System.Windows.Forms.Label();
            this.btnPesquisaC = new System.Windows.Forms.Button();
            this.dtgPesquisaClientes = new System.Windows.Forms.DataGridView();
            this.lblDataInicioBusca = new System.Windows.Forms.Label();
            this.lblDataFimPesquisa = new System.Windows.Forms.Label();
            this.dtpDataInicioBusca = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFimBusca = new System.Windows.Forms.DateTimePicker();
            this.panelButtons.SuspendLayout();
            this.panelCadastrarContasReceber.SuspendLayout();
            this.panelVisualizaConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = global::Pronave.Properties.Resources.costas;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(10, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 33);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblContasReceber
            // 
            this.lblContasReceber.AutoSize = true;
            this.lblContasReceber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContasReceber.Location = new System.Drawing.Point(303, 13);
            this.lblContasReceber.Name = "lblContasReceber";
            this.lblContasReceber.Size = new System.Drawing.Size(154, 23);
            this.lblContasReceber.TabIndex = 2;
            this.lblContasReceber.Text = "Contas à Receber";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.panelVisualizaConta);
            this.panelButtons.Controls.Add(this.panelCadastrarContasReceber);
            this.panelButtons.Controls.Add(this.btnAcessarInformacoesContasReceber);
            this.panelButtons.Controls.Add(this.btnVisualizarDadosContaReceber);
            this.panelButtons.Controls.Add(this.btnCadastrarContaReceber);
            this.panelButtons.Location = new System.Drawing.Point(1, 47);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(793, 431);
            this.panelButtons.TabIndex = 3;
            // 
            // btnAcessarInformacoesContasReceber
            // 
            this.btnAcessarInformacoesContasReceber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessarInformacoesContasReceber.Location = new System.Drawing.Point(568, 24);
            this.btnAcessarInformacoesContasReceber.Name = "btnAcessarInformacoesContasReceber";
            this.btnAcessarInformacoesContasReceber.Size = new System.Drawing.Size(212, 48);
            this.btnAcessarInformacoesContasReceber.TabIndex = 8;
            this.btnAcessarInformacoesContasReceber.Text = "Informações da Conta à Receber";
            this.btnAcessarInformacoesContasReceber.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarDadosContaReceber
            // 
            this.btnVisualizarDadosContaReceber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarDadosContaReceber.Location = new System.Drawing.Point(255, 24);
            this.btnVisualizarDadosContaReceber.Name = "btnVisualizarDadosContaReceber";
            this.btnVisualizarDadosContaReceber.Size = new System.Drawing.Size(237, 48);
            this.btnVisualizarDadosContaReceber.TabIndex = 7;
            this.btnVisualizarDadosContaReceber.Text = "Visualizar Contas à Receber";
            this.btnVisualizarDadosContaReceber.UseVisualStyleBackColor = true;
            this.btnVisualizarDadosContaReceber.Click += new System.EventHandler(this.btnVisualizarDadosContaReceber_Click);
            // 
            // btnCadastrarContaReceber
            // 
            this.btnCadastrarContaReceber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarContaReceber.Location = new System.Drawing.Point(11, 24);
            this.btnCadastrarContaReceber.Name = "btnCadastrarContaReceber";
            this.btnCadastrarContaReceber.Size = new System.Drawing.Size(197, 48);
            this.btnCadastrarContaReceber.TabIndex = 6;
            this.btnCadastrarContaReceber.Text = "Cadastrar Contas à Receber";
            this.btnCadastrarContaReceber.UseVisualStyleBackColor = true;
            this.btnCadastrarContaReceber.Click += new System.EventHandler(this.btnCadastrarContaReceber_Click);
            // 
            // panelCadastrarContasReceber
            // 
            this.panelCadastrarContasReceber.Controls.Add(this.lblCadastrarConta);
            this.panelCadastrarContasReceber.Controls.Add(this.btnCadastrarConta);
            this.panelCadastrarContasReceber.Controls.Add(this.dtpDataFimCadastrar);
            this.panelCadastrarContasReceber.Controls.Add(this.dtpDataInicioCadastro);
            this.panelCadastrarContasReceber.Controls.Add(this.label1);
            this.panelCadastrarContasReceber.Controls.Add(this.lblDataInicio);
            this.panelCadastrarContasReceber.Location = new System.Drawing.Point(3, 91);
            this.panelCadastrarContasReceber.Name = "panelCadastrarContasReceber";
            this.panelCadastrarContasReceber.Size = new System.Drawing.Size(787, 330);
            this.panelCadastrarContasReceber.TabIndex = 9;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(214, 50);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(64, 13);
            this.lblDataInicio.TabIndex = 3;
            this.lblDataInicio.Text = "Data Inicio: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Fim: ";
            // 
            // dtpDataInicioCadastro
            // 
            this.dtpDataInicioCadastro.Location = new System.Drawing.Point(284, 50);
            this.dtpDataInicioCadastro.Name = "dtpDataInicioCadastro";
            this.dtpDataInicioCadastro.Size = new System.Drawing.Size(230, 20);
            this.dtpDataInicioCadastro.TabIndex = 7;
            // 
            // dtpDataFimCadastrar
            // 
            this.dtpDataFimCadastrar.Location = new System.Drawing.Point(284, 93);
            this.dtpDataFimCadastrar.Name = "dtpDataFimCadastrar";
            this.dtpDataFimCadastrar.Size = new System.Drawing.Size(230, 20);
            this.dtpDataFimCadastrar.TabIndex = 8;
            // 
            // btnCadastrarConta
            // 
            this.btnCadastrarConta.Location = new System.Drawing.Point(341, 176);
            this.btnCadastrarConta.Name = "btnCadastrarConta";
            this.btnCadastrarConta.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarConta.TabIndex = 9;
            this.btnCadastrarConta.Text = "Cadastrar";
            this.btnCadastrarConta.UseVisualStyleBackColor = true;
            // 
            // lblCadastrarConta
            // 
            this.lblCadastrarConta.AutoSize = true;
            this.lblCadastrarConta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarConta.Location = new System.Drawing.Point(300, 11);
            this.lblCadastrarConta.Name = "lblCadastrarConta";
            this.lblCadastrarConta.Size = new System.Drawing.Size(170, 17);
            this.lblCadastrarConta.TabIndex = 10;
            this.lblCadastrarConta.Text = "Cadastrar Conta à Receber";
            // 
            // panelVisualizaConta
            // 
            this.panelVisualizaConta.Controls.Add(this.dtpDataFimBusca);
            this.panelVisualizaConta.Controls.Add(this.dtpDataInicioBusca);
            this.panelVisualizaConta.Controls.Add(this.lblDataFimPesquisa);
            this.panelVisualizaConta.Controls.Add(this.lblDataInicioBusca);
            this.panelVisualizaConta.Controls.Add(this.lblVisualizaCliente);
            this.panelVisualizaConta.Controls.Add(this.btnPesquisaC);
            this.panelVisualizaConta.Controls.Add(this.dtgPesquisaClientes);
            this.panelVisualizaConta.Location = new System.Drawing.Point(3, 94);
            this.panelVisualizaConta.Name = "panelVisualizaConta";
            this.panelVisualizaConta.Size = new System.Drawing.Size(787, 340);
            this.panelVisualizaConta.TabIndex = 11;
            // 
            // lblVisualizaCliente
            // 
            this.lblVisualizaCliente.AutoSize = true;
            this.lblVisualizaCliente.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizaCliente.Location = new System.Drawing.Point(300, 11);
            this.lblVisualizaCliente.Name = "lblVisualizaCliente";
            this.lblVisualizaCliente.Size = new System.Drawing.Size(175, 17);
            this.lblVisualizaCliente.TabIndex = 9;
            this.lblVisualizaCliente.Text = "Visualizar Contas à Receber";
            // 
            // btnPesquisaC
            // 
            this.btnPesquisaC.Location = new System.Drawing.Point(329, 51);
            this.btnPesquisaC.Name = "btnPesquisaC";
            this.btnPesquisaC.Size = new System.Drawing.Size(75, 36);
            this.btnPesquisaC.TabIndex = 8;
            this.btnPesquisaC.Text = "Pesquisar";
            this.btnPesquisaC.UseVisualStyleBackColor = true;
            // 
            // dtgPesquisaClientes
            // 
            this.dtgPesquisaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisaClientes.Location = new System.Drawing.Point(3, 115);
            this.dtgPesquisaClientes.Name = "dtgPesquisaClientes";
            this.dtgPesquisaClientes.Size = new System.Drawing.Size(773, 201);
            this.dtgPesquisaClientes.TabIndex = 6;
            // 
            // lblDataInicioBusca
            // 
            this.lblDataInicioBusca.AutoSize = true;
            this.lblDataInicioBusca.Location = new System.Drawing.Point(8, 50);
            this.lblDataInicioBusca.Name = "lblDataInicioBusca";
            this.lblDataInicioBusca.Size = new System.Drawing.Size(64, 13);
            this.lblDataInicioBusca.TabIndex = 10;
            this.lblDataInicioBusca.Text = "Data Inicio: ";
            // 
            // lblDataFimPesquisa
            // 
            this.lblDataFimPesquisa.AutoSize = true;
            this.lblDataFimPesquisa.Location = new System.Drawing.Point(8, 78);
            this.lblDataFimPesquisa.Name = "lblDataFimPesquisa";
            this.lblDataFimPesquisa.Size = new System.Drawing.Size(55, 13);
            this.lblDataFimPesquisa.TabIndex = 11;
            this.lblDataFimPesquisa.Text = "Data Fim: ";
            // 
            // dtpDataInicioBusca
            // 
            this.dtpDataInicioBusca.Location = new System.Drawing.Point(79, 42);
            this.dtpDataInicioBusca.Name = "dtpDataInicioBusca";
            this.dtpDataInicioBusca.Size = new System.Drawing.Size(220, 20);
            this.dtpDataInicioBusca.TabIndex = 12;
            // 
            // dtpDataFimBusca
            // 
            this.dtpDataFimBusca.Location = new System.Drawing.Point(79, 78);
            this.dtpDataFimBusca.Name = "dtpDataFimBusca";
            this.dtpDataFimBusca.Size = new System.Drawing.Size(220, 20);
            this.dtpDataFimBusca.TabIndex = 13;
            // 
            // ContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 480);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.lblContasReceber);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContasReceber";
            this.panelButtons.ResumeLayout(false);
            this.panelCadastrarContasReceber.ResumeLayout(false);
            this.panelCadastrarContasReceber.PerformLayout();
            this.panelVisualizaConta.ResumeLayout(false);
            this.panelVisualizaConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblContasReceber;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAcessarInformacoesContasReceber;
        private System.Windows.Forms.Button btnVisualizarDadosContaReceber;
        private System.Windows.Forms.Button btnCadastrarContaReceber;
        private System.Windows.Forms.Panel panelCadastrarContasReceber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Button btnCadastrarConta;
        private System.Windows.Forms.DateTimePicker dtpDataFimCadastrar;
        private System.Windows.Forms.DateTimePicker dtpDataInicioCadastro;
        private System.Windows.Forms.Label lblCadastrarConta;
        private System.Windows.Forms.Panel panelVisualizaConta;
        private System.Windows.Forms.Label lblVisualizaCliente;
        private System.Windows.Forms.Button btnPesquisaC;
        private System.Windows.Forms.DataGridView dtgPesquisaClientes;
        private System.Windows.Forms.Label lblDataInicioBusca;
        private System.Windows.Forms.Label lblDataFimPesquisa;
        private System.Windows.Forms.DateTimePicker dtpDataFimBusca;
        private System.Windows.Forms.DateTimePicker dtpDataInicioBusca;
    }
}