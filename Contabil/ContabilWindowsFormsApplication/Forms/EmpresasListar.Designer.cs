namespace ContabilWindowsFormsApplication.Forms
{
    partial class EmpresasListar
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
            this.dgvEmpresasListar = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAbrirEmpresa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresasListar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpresasListar
            // 
            this.dgvEmpresasListar.AllowUserToAddRows = false;
            this.dgvEmpresasListar.AllowUserToDeleteRows = false;
            this.dgvEmpresasListar.AllowUserToResizeColumns = false;
            this.dgvEmpresasListar.AllowUserToResizeRows = false;
            this.dgvEmpresasListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpresasListar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpresasListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresasListar.Location = new System.Drawing.Point(12, 12);
            this.dgvEmpresasListar.Name = "dgvEmpresasListar";
            this.dgvEmpresasListar.ReadOnly = true;
            this.dgvEmpresasListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresasListar.Size = new System.Drawing.Size(660, 278);
            this.dgvEmpresasListar.TabIndex = 5;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(597, 296);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAbrirEmpresa
            // 
            this.btnAbrirEmpresa.Location = new System.Drawing.Point(12, 296);
            this.btnAbrirEmpresa.Name = "btnAbrirEmpresa";
            this.btnAbrirEmpresa.Size = new System.Drawing.Size(100, 23);
            this.btnAbrirEmpresa.TabIndex = 3;
            this.btnAbrirEmpresa.Text = "Abrir Empresa";
            this.btnAbrirEmpresa.UseVisualStyleBackColor = true;
            this.btnAbrirEmpresa.Click += new System.EventHandler(this.btnAbrirEmpresa_Click);
            // 
            // EmpresasListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 331);
            this.Controls.Add(this.dgvEmpresasListar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAbrirEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpresasListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpresasListar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresasListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpresasListar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAbrirEmpresa;
    }
}