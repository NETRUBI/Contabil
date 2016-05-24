namespace ContabilWindowsFormsApplication.Forms
{
    partial class PlanoDeContasListarPlanos
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAbrirPlano = new System.Windows.Forms.Button();
            this.dgvListarPlanosDeContas = new System.Windows.Forms.DataGridView();
            this.cmbBoxListarEmpresas = new System.Windows.Forms.ComboBox();
            this.btnListarPlanoDeContas = new System.Windows.Forms.Button();
            this.lblSelecionarEmpresa = new System.Windows.Forms.Label();
            this.btnCriarNovoPlano = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarPlanosDeContas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(597, 326);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAbrirPlano
            // 
            this.btnAbrirPlano.Location = new System.Drawing.Point(12, 326);
            this.btnAbrirPlano.Name = "btnAbrirPlano";
            this.btnAbrirPlano.Size = new System.Drawing.Size(100, 23);
            this.btnAbrirPlano.TabIndex = 1;
            this.btnAbrirPlano.Text = "Abrir Plano";
            this.btnAbrirPlano.UseVisualStyleBackColor = true;
            this.btnAbrirPlano.Click += new System.EventHandler(this.btnAbrirPlano_Click);
            // 
            // dgvListarPlanosDeContas
            // 
            this.dgvListarPlanosDeContas.AllowUserToAddRows = false;
            this.dgvListarPlanosDeContas.AllowUserToDeleteRows = false;
            this.dgvListarPlanosDeContas.AllowUserToOrderColumns = true;
            this.dgvListarPlanosDeContas.AllowUserToResizeColumns = false;
            this.dgvListarPlanosDeContas.AllowUserToResizeRows = false;
            this.dgvListarPlanosDeContas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListarPlanosDeContas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListarPlanosDeContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarPlanosDeContas.Location = new System.Drawing.Point(12, 47);
            this.dgvListarPlanosDeContas.MultiSelect = false;
            this.dgvListarPlanosDeContas.Name = "dgvListarPlanosDeContas";
            this.dgvListarPlanosDeContas.ReadOnly = true;
            this.dgvListarPlanosDeContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarPlanosDeContas.Size = new System.Drawing.Size(660, 273);
            this.dgvListarPlanosDeContas.TabIndex = 2;
            // 
            // cmbBoxListarEmpresas
            // 
            this.cmbBoxListarEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxListarEmpresas.FormattingEnabled = true;
            this.cmbBoxListarEmpresas.Location = new System.Drawing.Point(118, 12);
            this.cmbBoxListarEmpresas.Name = "cmbBoxListarEmpresas";
            this.cmbBoxListarEmpresas.Size = new System.Drawing.Size(448, 21);
            this.cmbBoxListarEmpresas.TabIndex = 3;
            this.cmbBoxListarEmpresas.Click += new System.EventHandler(this.cmbBoxListarEmpresas_Click);
            // 
            // btnListarPlanoDeContas
            // 
            this.btnListarPlanoDeContas.Location = new System.Drawing.Point(572, 10);
            this.btnListarPlanoDeContas.Name = "btnListarPlanoDeContas";
            this.btnListarPlanoDeContas.Size = new System.Drawing.Size(100, 23);
            this.btnListarPlanoDeContas.TabIndex = 4;
            this.btnListarPlanoDeContas.Text = "Listar Planos";
            this.btnListarPlanoDeContas.UseVisualStyleBackColor = true;
            this.btnListarPlanoDeContas.Click += new System.EventHandler(this.btnListarPlanoDeContas_Click);
            // 
            // lblSelecionarEmpresa
            // 
            this.lblSelecionarEmpresa.AutoSize = true;
            this.lblSelecionarEmpresa.Location = new System.Drawing.Point(12, 15);
            this.lblSelecionarEmpresa.Name = "lblSelecionarEmpresa";
            this.lblSelecionarEmpresa.Size = new System.Drawing.Size(104, 13);
            this.lblSelecionarEmpresa.TabIndex = 5;
            this.lblSelecionarEmpresa.Text = "Selecionar Empresa:";
            // 
            // btnCriarNovoPlano
            // 
            this.btnCriarNovoPlano.Location = new System.Drawing.Point(118, 326);
            this.btnCriarNovoPlano.Name = "btnCriarNovoPlano";
            this.btnCriarNovoPlano.Size = new System.Drawing.Size(100, 23);
            this.btnCriarNovoPlano.TabIndex = 6;
            this.btnCriarNovoPlano.Text = "Criar Novo Plano";
            this.btnCriarNovoPlano.UseVisualStyleBackColor = true;
            this.btnCriarNovoPlano.Click += new System.EventHandler(this.btnCriarNovoPlano_Click);
            // 
            // PlanoDeContasListarPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnCriarNovoPlano);
            this.Controls.Add(this.lblSelecionarEmpresa);
            this.Controls.Add(this.btnListarPlanoDeContas);
            this.Controls.Add(this.cmbBoxListarEmpresas);
            this.Controls.Add(this.dgvListarPlanosDeContas);
            this.Controls.Add(this.btnAbrirPlano);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanoDeContasListarPlanos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanoDeContasListar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarPlanosDeContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAbrirPlano;
        private System.Windows.Forms.DataGridView dgvListarPlanosDeContas;
        private System.Windows.Forms.ComboBox cmbBoxListarEmpresas;
        private System.Windows.Forms.Button btnListarPlanoDeContas;
        private System.Windows.Forms.Label lblSelecionarEmpresa;
        private System.Windows.Forms.Button btnCriarNovoPlano;
    }
}