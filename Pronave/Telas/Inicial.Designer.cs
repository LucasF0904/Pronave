namespace Pronave.Telas
{
    partial class Inicial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEstoqueVendedor = new System.Windows.Forms.Button();
            this.btnEstoqueMatriz = new System.Windows.Forms.Button();
            this.btnContas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblEstoqueMatriz = new System.Windows.Forms.Label();
            this.lblEstoqueVendedor = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDateTimeNow = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDateTimeNow);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo,";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEstoqueVendedor);
            this.panel2.Controls.Add(this.btnEstoqueMatriz);
            this.panel2.Controls.Add(this.btnContas);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 444);
            this.panel2.TabIndex = 1;
            // 
            // btnEstoqueVendedor
            // 
            this.btnEstoqueVendedor.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueVendedor.Location = new System.Drawing.Point(37, 274);
            this.btnEstoqueVendedor.Name = "btnEstoqueVendedor";
            this.btnEstoqueVendedor.Size = new System.Drawing.Size(124, 36);
            this.btnEstoqueVendedor.TabIndex = 4;
            this.btnEstoqueVendedor.Text = "Estoque Vendedor";
            this.btnEstoqueVendedor.UseVisualStyleBackColor = true;
            this.btnEstoqueVendedor.Click += new System.EventHandler(this.btnEstoqueVendedor_Click);
            // 
            // btnEstoqueMatriz
            // 
            this.btnEstoqueMatriz.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueMatriz.Location = new System.Drawing.Point(37, 201);
            this.btnEstoqueMatriz.Name = "btnEstoqueMatriz";
            this.btnEstoqueMatriz.Size = new System.Drawing.Size(124, 36);
            this.btnEstoqueMatriz.TabIndex = 3;
            this.btnEstoqueMatriz.Text = "Estoque Matriz";
            this.btnEstoqueMatriz.UseVisualStyleBackColor = true;
            this.btnEstoqueMatriz.Click += new System.EventHandler(this.btnEstoqueMatriz_Click);
            // 
            // btnContas
            // 
            this.btnContas.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContas.Location = new System.Drawing.Point(37, 134);
            this.btnContas.Name = "btnContas";
            this.btnContas.Size = new System.Drawing.Size(124, 36);
            this.btnContas.TabIndex = 1;
            this.btnContas.Text = "Contas a Receber";
            this.btnContas.UseVisualStyleBackColor = true;
            this.btnContas.Click += new System.EventHandler(this.btnContas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(37, 61);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(124, 36);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(229, 161);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(83, 20);
            this.lblClientes.TabIndex = 2;
            this.lblClientes.Text = "Clientes:";
            // 
            // lblEstoqueMatriz
            // 
            this.lblEstoqueMatriz.AutoSize = true;
            this.lblEstoqueMatriz.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoqueMatriz.Location = new System.Drawing.Point(229, 374);
            this.lblEstoqueMatriz.Name = "lblEstoqueMatriz";
            this.lblEstoqueMatriz.Size = new System.Drawing.Size(138, 20);
            this.lblEstoqueMatriz.TabIndex = 3;
            this.lblEstoqueMatriz.Text = "Estoque Matriz:";
            // 
            // lblEstoqueVendedor
            // 
            this.lblEstoqueVendedor.AutoSize = true;
            this.lblEstoqueVendedor.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoqueVendedor.Location = new System.Drawing.Point(485, 161);
            this.lblEstoqueVendedor.Name = "lblEstoqueVendedor";
            this.lblEstoqueVendedor.Size = new System.Drawing.Size(171, 20);
            this.lblEstoqueVendedor.TabIndex = 4;
            this.lblEstoqueVendedor.Text = "Estoque Vendedor: ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::Pronave.Properties.Resources.fechar;
            this.btnClose.Location = new System.Drawing.Point(731, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDateTimeNow
            // 
            this.lblDateTimeNow.AutoSize = true;
            this.lblDateTimeNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeNow.Location = new System.Drawing.Point(626, 9);
            this.lblDateTimeNow.Name = "lblDateTimeNow";
            this.lblDateTimeNow.Size = new System.Drawing.Size(0, 21);
            this.lblDateTimeNow.TabIndex = 3;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 544);
            this.Controls.Add(this.lblEstoqueVendedor);
            this.Controls.Add(this.lblEstoqueMatriz);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEstoqueVendedor;
        private System.Windows.Forms.Button btnEstoqueMatriz;
        private System.Windows.Forms.Button btnContas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblEstoqueMatriz;
        private System.Windows.Forms.Label lblEstoqueVendedor;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDateTimeNow;
    }
}