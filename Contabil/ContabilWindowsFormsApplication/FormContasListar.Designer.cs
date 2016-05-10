namespace ContabilWindowsFormsApplication
{
    partial class FormContasListar
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
            this.components = new System.ComponentModel.Container();
            this.BtnContaAbrirCadastro = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnContasListar = new System.Windows.Forms.Button();
            this.TxtBoxNomeDaConta = new System.Windows.Forms.TextBox();
            this.LabelNomeDaConta = new System.Windows.Forms.Label();
            this.DataGridViewContasListar = new System.Windows.Forms.DataGridView();
            this.spContasListarTodasResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewContasListar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spContasListarTodasResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnContaAbrirCadastro
            // 
            this.BtnContaAbrirCadastro.Location = new System.Drawing.Point(12, 509);
            this.BtnContaAbrirCadastro.Name = "BtnContaAbrirCadastro";
            this.BtnContaAbrirCadastro.Size = new System.Drawing.Size(300, 40);
            this.BtnContaAbrirCadastro.TabIndex = 4;
            this.BtnContaAbrirCadastro.Text = "Abrir Cadastro";
            this.BtnContaAbrirCadastro.UseVisualStyleBackColor = true;
            this.BtnContaAbrirCadastro.Click += new System.EventHandler(this.BtnContaAbrirCadastro_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(572, 509);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(300, 40);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnContasListar
            // 
            this.BtnContasListar.Location = new System.Drawing.Point(572, 35);
            this.BtnContasListar.Name = "BtnContasListar";
            this.BtnContasListar.Size = new System.Drawing.Size(300, 29);
            this.BtnContasListar.TabIndex = 6;
            this.BtnContasListar.Text = "Pesquisar";
            this.BtnContasListar.UseVisualStyleBackColor = true;
            this.BtnContasListar.Click += new System.EventHandler(this.BtnContasListar_Click);
            // 
            // TxtBoxNomeDaConta
            // 
            this.TxtBoxNomeDaConta.Location = new System.Drawing.Point(138, 40);
            this.TxtBoxNomeDaConta.Name = "TxtBoxNomeDaConta";
            this.TxtBoxNomeDaConta.Size = new System.Drawing.Size(428, 20);
            this.TxtBoxNomeDaConta.TabIndex = 7;
            // 
            // LabelNomeDaConta
            // 
            this.LabelNomeDaConta.AutoSize = true;
            this.LabelNomeDaConta.Location = new System.Drawing.Point(12, 43);
            this.LabelNomeDaConta.Name = "LabelNomeDaConta";
            this.LabelNomeDaConta.Size = new System.Drawing.Size(120, 13);
            this.LabelNomeDaConta.TabIndex = 8;
            this.LabelNomeDaConta.Text = "Digite o nome da conta:";
            // 
            // DataGridViewContasListar
            // 
            this.DataGridViewContasListar.AllowUserToDeleteRows = false;
            this.DataGridViewContasListar.AutoGenerateColumns = false;
            this.DataGridViewContasListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewContasListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.classificacaoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.DataGridViewContasListar.DataSource = this.spContasListarTodasResultBindingSource;
            this.DataGridViewContasListar.Location = new System.Drawing.Point(12, 103);
            this.DataGridViewContasListar.Name = "DataGridViewContasListar";
            this.DataGridViewContasListar.ReadOnly = true;
            this.DataGridViewContasListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewContasListar.Size = new System.Drawing.Size(860, 400);
            this.DataGridViewContasListar.TabIndex = 9;
            // 
            // spContasListarResultBindingSource
            // 
            this.spContasListarTodasResultBindingSource.DataSource = typeof(ContabilWindowsFormsApplication.sp_ContasListarTodas_Result);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 65;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classificacaoDataGridViewTextBoxColumn
            // 
            this.classificacaoDataGridViewTextBoxColumn.DataPropertyName = "Classificacao";
            this.classificacaoDataGridViewTextBoxColumn.HeaderText = "Classificacao";
            this.classificacaoDataGridViewTextBoxColumn.Name = "classificacaoDataGridViewTextBoxColumn";
            this.classificacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormContasListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.DataGridViewContasListar);
            this.Controls.Add(this.LabelNomeDaConta);
            this.Controls.Add(this.TxtBoxNomeDaConta);
            this.Controls.Add(this.BtnContasListar);
            this.Controls.Add(this.BtnContaAbrirCadastro);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormContasListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContasListar";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewContasListar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spContasListarTodasResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnContaAbrirCadastro;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnContasListar;
        private System.Windows.Forms.TextBox TxtBoxNomeDaConta;
        private System.Windows.Forms.Label LabelNomeDaConta;
        private System.Windows.Forms.DataGridView DataGridViewContasListar;
        private System.Windows.Forms.BindingSource spContasListarTodasResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
    }
}