namespace ContabilWindowsFormsApplication
{
    partial class FormEmpresasListar
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAbrirCadastroEmpresa = new System.Windows.Forms.Button();
            this.DataGridViewEmpresasListar = new System.Windows.Forms.DataGridView();
            this.LabelNomeDaEmpresa = new System.Windows.Forms.Label();
            this.TxtBoxNomeDaEmpresa = new System.Windows.Forms.TextBox();
            this.BtnEmpresasListar = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spEmpresasListarTodasResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmpresasListar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEmpresasListarTodasResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(572, 509);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(300, 40);
            this.BtnCancelar.TabIndex = 0;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAbrirCadastroEmpresa
            // 
            this.BtnAbrirCadastroEmpresa.Location = new System.Drawing.Point(12, 509);
            this.BtnAbrirCadastroEmpresa.Name = "BtnAbrirCadastroEmpresa";
            this.BtnAbrirCadastroEmpresa.Size = new System.Drawing.Size(300, 40);
            this.BtnAbrirCadastroEmpresa.TabIndex = 1;
            this.BtnAbrirCadastroEmpresa.Text = "Abrir Cadastro";
            this.BtnAbrirCadastroEmpresa.UseVisualStyleBackColor = true;
            this.BtnAbrirCadastroEmpresa.Click += new System.EventHandler(this.BtnAbrirCadastroEmpresa_Click);
            // 
            // DataGridViewEmpresasListar
            // 
            this.DataGridViewEmpresasListar.AllowUserToDeleteRows = false;
            this.DataGridViewEmpresasListar.AutoGenerateColumns = false;
            this.DataGridViewEmpresasListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewEmpresasListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEmpresasListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeFantasiaDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn});
            this.DataGridViewEmpresasListar.DataSource = this.spEmpresasListarTodasResultBindingSource;
            this.DataGridViewEmpresasListar.Location = new System.Drawing.Point(12, 103);
            this.DataGridViewEmpresasListar.Name = "DataGridViewEmpresasListar";
            this.DataGridViewEmpresasListar.ReadOnly = true;
            this.DataGridViewEmpresasListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewEmpresasListar.Size = new System.Drawing.Size(860, 400);
            this.DataGridViewEmpresasListar.TabIndex = 2;
            // 
            // LabelNomeDaEmpresa
            // 
            this.LabelNomeDaEmpresa.AutoSize = true;
            this.LabelNomeDaEmpresa.Location = new System.Drawing.Point(12, 43);
            this.LabelNomeDaEmpresa.Name = "LabelNomeDaEmpresa";
            this.LabelNomeDaEmpresa.Size = new System.Drawing.Size(133, 13);
            this.LabelNomeDaEmpresa.TabIndex = 11;
            this.LabelNomeDaEmpresa.Text = "Digite o nome da empresa:";
            // 
            // TxtBoxNomeDaEmpresa
            // 
            this.TxtBoxNomeDaEmpresa.Location = new System.Drawing.Point(151, 40);
            this.TxtBoxNomeDaEmpresa.Name = "TxtBoxNomeDaEmpresa";
            this.TxtBoxNomeDaEmpresa.Size = new System.Drawing.Size(415, 20);
            this.TxtBoxNomeDaEmpresa.TabIndex = 10;
            // 
            // BtnEmpresasListar
            // 
            this.BtnEmpresasListar.Location = new System.Drawing.Point(572, 35);
            this.BtnEmpresasListar.Name = "BtnEmpresasListar";
            this.BtnEmpresasListar.Size = new System.Drawing.Size(300, 29);
            this.BtnEmpresasListar.TabIndex = 9;
            this.BtnEmpresasListar.Text = "Pesquisar";
            this.BtnEmpresasListar.UseVisualStyleBackColor = true;
            this.BtnEmpresasListar.Click += new System.EventHandler(this.BtnEmpresasListar_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeFantasiaDataGridViewTextBoxColumn
            // 
            this.nomeFantasiaDataGridViewTextBoxColumn.DataPropertyName = "NomeFantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.HeaderText = "NomeFantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.Name = "nomeFantasiaDataGridViewTextBoxColumn";
            this.nomeFantasiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            this.razaoSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spEmpresasListarTodasResultBindingSource
            // 
            this.spEmpresasListarTodasResultBindingSource.DataSource = typeof(ContabilWindowsFormsApplication.sp_EmpresasListarTodas_Result);
            // 
            // FormEmpresasListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.LabelNomeDaEmpresa);
            this.Controls.Add(this.TxtBoxNomeDaEmpresa);
            this.Controls.Add(this.BtnEmpresasListar);
            this.Controls.Add(this.DataGridViewEmpresasListar);
            this.Controls.Add(this.BtnAbrirCadastroEmpresa);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEmpresasListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmpresasListar";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmpresasListar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEmpresasListarTodasResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAbrirCadastroEmpresa;
        private System.Windows.Forms.DataGridView DataGridViewEmpresasListar;
        private System.Windows.Forms.Label LabelNomeDaEmpresa;
        private System.Windows.Forms.TextBox TxtBoxNomeDaEmpresa;
        private System.Windows.Forms.Button BtnEmpresasListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spEmpresasListarTodasResultBindingSource;
    }
}