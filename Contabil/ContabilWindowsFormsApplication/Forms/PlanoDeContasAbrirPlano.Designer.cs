namespace ContabilWindowsFormsApplication.Forms
{
    partial class PlanoDeContasAbrirPlano
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
            this.dgvPlanoDeContas = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAdicionarConta = new System.Windows.Forms.Button();
            this.btnRemoverConta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanoDeContas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanoDeContas
            // 
            this.dgvPlanoDeContas.AllowUserToAddRows = false;
            this.dgvPlanoDeContas.AllowUserToDeleteRows = false;
            this.dgvPlanoDeContas.AllowUserToOrderColumns = true;
            this.dgvPlanoDeContas.AllowUserToResizeColumns = false;
            this.dgvPlanoDeContas.AllowUserToResizeRows = false;
            this.dgvPlanoDeContas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanoDeContas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlanoDeContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanoDeContas.Location = new System.Drawing.Point(12, 12);
            this.dgvPlanoDeContas.Name = "dgvPlanoDeContas";
            this.dgvPlanoDeContas.ReadOnly = true;
            this.dgvPlanoDeContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanoDeContas.Size = new System.Drawing.Size(860, 408);
            this.dgvPlanoDeContas.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(797, 426);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAdicionarConta
            // 
            this.btnAdicionarConta.Location = new System.Drawing.Point(12, 426);
            this.btnAdicionarConta.Name = "btnAdicionarConta";
            this.btnAdicionarConta.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionarConta.TabIndex = 2;
            this.btnAdicionarConta.Text = "Adicionar Conta";
            this.btnAdicionarConta.UseVisualStyleBackColor = true;
            this.btnAdicionarConta.Click += new System.EventHandler(this.btnAdicionarConta_Click);
            // 
            // btnRemoverConta
            // 
            this.btnRemoverConta.Location = new System.Drawing.Point(118, 426);
            this.btnRemoverConta.Name = "btnRemoverConta";
            this.btnRemoverConta.Size = new System.Drawing.Size(100, 23);
            this.btnRemoverConta.TabIndex = 3;
            this.btnRemoverConta.Text = "Remover Conta";
            this.btnRemoverConta.UseVisualStyleBackColor = true;
            this.btnRemoverConta.Click += new System.EventHandler(this.btnRemoverConta_Click);
            // 
            // PlanoDeContasAbrirPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnRemoverConta);
            this.Controls.Add(this.btnAdicionarConta);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvPlanoDeContas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanoDeContasAbrirPlano";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanoDeContasAbrir";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanoDeContas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanoDeContas;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAdicionarConta;
        private System.Windows.Forms.Button btnRemoverConta;
    }
}