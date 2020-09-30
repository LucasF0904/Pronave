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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnContas = new System.Windows.Forms.Button();
            this.btnEstoqueMatriz = new System.Windows.Forms.Button();
            this.btnEstoqueVendedor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 100);
            this.panel1.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "data/hora";
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
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicial";
            this.Text = "Inicial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEstoqueVendedor;
        private System.Windows.Forms.Button btnEstoqueMatriz;
        private System.Windows.Forms.Button btnContas;
        private System.Windows.Forms.Button btnClientes;
    }
}