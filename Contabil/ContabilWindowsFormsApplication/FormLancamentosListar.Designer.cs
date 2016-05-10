namespace ContabilWindowsFormsApplication
{
    partial class FormLancamentosListar
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
            this.dataGridViewLancamentosListar = new System.Windows.Forms.DataGridView();
            this.btnAbrirLancamento = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.comboBoxSelecionarEmpresa = new System.Windows.Forms.ComboBox();
            this.spEmpresasListarResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLancamentosListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLancamentosListar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEmpresasListarResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLancamentosListar
            // 
            this.dataGridViewLancamentosListar.AllowUserToDeleteRows = false;
            this.dataGridViewLancamentosListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewLancamentosListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLancamentosListar.Location = new System.Drawing.Point(12, 103);
            this.dataGridViewLancamentosListar.Name = "dataGridViewLancamentosListar";
            this.dataGridViewLancamentosListar.ReadOnly = true;
            this.dataGridViewLancamentosListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLancamentosListar.Size = new System.Drawing.Size(860, 400);
            this.dataGridViewLancamentosListar.TabIndex = 8;
            // 
            // btnAbrirLancamento
            // 
            this.btnAbrirLancamento.Location = new System.Drawing.Point(12, 509);
            this.btnAbrirLancamento.Name = "btnAbrirLancamento";
            this.btnAbrirLancamento.Size = new System.Drawing.Size(260, 40);
            this.btnAbrirLancamento.TabIndex = 7;
            this.btnAbrirLancamento.Text = "Abrir Lancamento";
            this.btnAbrirLancamento.UseVisualStyleBackColor = true;
            this.btnAbrirLancamento.Click += new System.EventHandler(this.btnAbrirLancamento_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(612, 509);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(260, 40);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // comboBoxSelecionarEmpresa
            // 
            this.comboBoxSelecionarEmpresa.DataSource = this.spEmpresasListarResultBindingSource;
            this.comboBoxSelecionarEmpresa.DisplayMember = "RazaoSocial";
            this.comboBoxSelecionarEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelecionarEmpresa.FormattingEnabled = true;
            this.comboBoxSelecionarEmpresa.Location = new System.Drawing.Point(128, 13);
            this.comboBoxSelecionarEmpresa.Name = "comboBoxSelecionarEmpresa";
            this.comboBoxSelecionarEmpresa.Size = new System.Drawing.Size(438, 21);
            this.comboBoxSelecionarEmpresa.TabIndex = 9;
            this.comboBoxSelecionarEmpresa.ValueMember = "Id";
            this.comboBoxSelecionarEmpresa.Click += new System.EventHandler(this.ComboBoxSelecionarEmpresa_Click);
            // 
            // btnLancamentosListar
            // 
            this.btnLancamentosListar.Location = new System.Drawing.Point(15, 57);
            this.btnLancamentosListar.Name = "btnLancamentosListar";
            this.btnLancamentosListar.Size = new System.Drawing.Size(557, 22);
            this.btnLancamentosListar.TabIndex = 10;
            this.btnLancamentosListar.Text = "Pesquisar";
            this.btnLancamentosListar.UseVisualStyleBackColor = true;
            this.btnLancamentosListar.Click += new System.EventHandler(this.btnLancamentosListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selecione a Empresa:";
            // 
            // dateTimePickerDataInicial
            // 
            this.dateTimePickerDataInicial.Location = new System.Drawing.Point(615, 58);
            this.dateTimePickerDataInicial.Name = "dateTimePickerDataInicial";
            this.dateTimePickerDataInicial.Size = new System.Drawing.Size(110, 20);
            this.dateTimePickerDataInicial.TabIndex = 13;
            // 
            // dateTimePickerDataFinal
            // 
            this.dateTimePickerDataFinal.Location = new System.Drawing.Point(754, 58);
            this.dateTimePickerDataFinal.Name = "dateTimePickerDataFinal";
            this.dateTimePickerDataFinal.Size = new System.Drawing.Size(104, 20);
            this.dateTimePickerDataFinal.TabIndex = 14;
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(612, 17);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(63, 13);
            this.lblDataInicial.TabIndex = 15;
            this.lblDataInicial.Text = "Data Inicial:";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(751, 17);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(58, 13);
            this.lblDataFinal.TabIndex = 16;
            this.lblDataFinal.Text = "Data Final:";
            // 
            // FormLancamentosListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.dateTimePickerDataFinal);
            this.Controls.Add(this.dateTimePickerDataInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLancamentosListar);
            this.Controls.Add(this.comboBoxSelecionarEmpresa);
            this.Controls.Add(this.dataGridViewLancamentosListar);
            this.Controls.Add(this.btnAbrirLancamento);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLancamentosListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLancamentosListar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLancamentosListar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEmpresasListarResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLancamentosListar;
        private System.Windows.Forms.Button btnAbrirLancamento;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox comboBoxSelecionarEmpresa;
        private System.Windows.Forms.Button btnLancamentosListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource spEmpresasListarResultBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicial;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFinal;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.Label lblDataFinal;
    }
}