namespace ContabilWindowsFormsApplication.Forms
{
    partial class ContasListar
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
            this.btnAbrirConta = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvContasListar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasListar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirConta
            // 
            this.btnAbrirConta.Location = new System.Drawing.Point(12, 296);
            this.btnAbrirConta.Name = "btnAbrirConta";
            this.btnAbrirConta.Size = new System.Drawing.Size(100, 23);
            this.btnAbrirConta.TabIndex = 0;
            this.btnAbrirConta.Text = "Abrir Conta";
            this.btnAbrirConta.UseVisualStyleBackColor = true;
            this.btnAbrirConta.Click += new System.EventHandler(this.btnAbrirConta_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(597, 296);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvContasListar
            // 
            this.dgvContasListar.AllowUserToAddRows = false;
            this.dgvContasListar.AllowUserToDeleteRows = false;
            this.dgvContasListar.AllowUserToResizeColumns = false;
            this.dgvContasListar.AllowUserToResizeRows = false;
            this.dgvContasListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContasListar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContasListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasListar.Location = new System.Drawing.Point(12, 12);
            this.dgvContasListar.Name = "dgvContasListar";
            this.dgvContasListar.ReadOnly = true;
            this.dgvContasListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContasListar.Size = new System.Drawing.Size(660, 278);
            this.dgvContasListar.TabIndex = 2;
            // 
            // ContasListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 331);
            this.Controls.Add(this.dgvContasListar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAbrirConta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContasListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContasListar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirConta;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvContasListar;
    }
}