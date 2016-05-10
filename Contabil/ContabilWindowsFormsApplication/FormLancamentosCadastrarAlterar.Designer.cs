namespace ContabilWindowsFormsApplication
{
    partial class FormLancamentosCadastrarAlterar
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
            this.btnLancamentoSalvarAlterar = new System.Windows.Forms.Button();
            this.btnCancelarExcluir = new System.Windows.Forms.Button();
            this.cmbBoxContaDebito = new System.Windows.Forms.ComboBox();
            this.cmbBoxContaCredito = new System.Windows.Forms.ComboBox();
            this.txtBoxValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxHistorico = new System.Windows.Forms.TextBox();
            this.lblContaCredito = new System.Windows.Forms.Label();
            this.lblContaDebito = new System.Windows.Forms.Label();
            this.cmbBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.cmbBoxConta = new System.Windows.Forms.ComboBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnLancamentoSalvarAlterar
            // 
            this.btnLancamentoSalvarAlterar.Location = new System.Drawing.Point(12, 206);
            this.btnLancamentoSalvarAlterar.Name = "btnLancamentoSalvarAlterar";
            this.btnLancamentoSalvarAlterar.Size = new System.Drawing.Size(232, 40);
            this.btnLancamentoSalvarAlterar.TabIndex = 8;
            this.btnLancamentoSalvarAlterar.Text = "Salvar Cadastro";
            this.btnLancamentoSalvarAlterar.UseVisualStyleBackColor = true;
            this.btnLancamentoSalvarAlterar.Click += new System.EventHandler(this.btnLancamentoSalvarAlterar_Click);
            // 
            // btnCancelarExcluir
            // 
            this.btnCancelarExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarExcluir.Location = new System.Drawing.Point(398, 207);
            this.btnCancelarExcluir.Name = "btnCancelarExcluir";
            this.btnCancelarExcluir.Size = new System.Drawing.Size(232, 40);
            this.btnCancelarExcluir.TabIndex = 7;
            this.btnCancelarExcluir.Text = "Cancelar";
            this.btnCancelarExcluir.UseVisualStyleBackColor = true;
            this.btnCancelarExcluir.Click += new System.EventHandler(this.btnCancelarExcluir_Click);
            // 
            // cmbBoxContaDebito
            // 
            this.cmbBoxContaDebito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxContaDebito.FormattingEnabled = true;
            this.cmbBoxContaDebito.Location = new System.Drawing.Point(100, 121);
            this.cmbBoxContaDebito.Name = "cmbBoxContaDebito";
            this.cmbBoxContaDebito.Size = new System.Drawing.Size(213, 21);
            this.cmbBoxContaDebito.TabIndex = 9;
            this.cmbBoxContaDebito.Click += new System.EventHandler(this.cmbBoxContaDebito_Click);
            // 
            // cmbBoxContaCredito
            // 
            this.cmbBoxContaCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxContaCredito.FormattingEnabled = true;
            this.cmbBoxContaCredito.Location = new System.Drawing.Point(405, 121);
            this.cmbBoxContaCredito.Name = "cmbBoxContaCredito";
            this.cmbBoxContaCredito.Size = new System.Drawing.Size(213, 21);
            this.cmbBoxContaCredito.TabIndex = 10;
            this.cmbBoxContaCredito.Click += new System.EventHandler(this.cmbBoxContaCredito_Click);
            // 
            // txtBoxValor
            // 
            this.txtBoxValor.Location = new System.Drawing.Point(518, 74);
            this.txtBoxValor.Name = "txtBoxValor";
            this.txtBoxValor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValor.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Histórico:";
            // 
            // txtBoxHistorico
            // 
            this.txtBoxHistorico.Location = new System.Drawing.Point(100, 161);
            this.txtBoxHistorico.Name = "txtBoxHistorico";
            this.txtBoxHistorico.Size = new System.Drawing.Size(518, 20);
            this.txtBoxHistorico.TabIndex = 16;
            // 
            // lblContaCredito
            // 
            this.lblContaCredito.AutoSize = true;
            this.lblContaCredito.Location = new System.Drawing.Point(325, 124);
            this.lblContaCredito.Name = "lblContaCredito";
            this.lblContaCredito.Size = new System.Drawing.Size(74, 13);
            this.lblContaCredito.TabIndex = 18;
            this.lblContaCredito.Text = "Conta Crédito:";
            // 
            // lblContaDebito
            // 
            this.lblContaDebito.AutoSize = true;
            this.lblContaDebito.Location = new System.Drawing.Point(22, 124);
            this.lblContaDebito.Name = "lblContaDebito";
            this.lblContaDebito.Size = new System.Drawing.Size(72, 13);
            this.lblContaDebito.TabIndex = 19;
            this.lblContaDebito.Text = "Conta Débito:";
            // 
            // cmbBoxEmpresa
            // 
            this.cmbBoxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxEmpresa.FormattingEnabled = true;
            this.cmbBoxEmpresa.Location = new System.Drawing.Point(99, 25);
            this.cmbBoxEmpresa.Name = "cmbBoxEmpresa";
            this.cmbBoxEmpresa.Size = new System.Drawing.Size(358, 21);
            this.cmbBoxEmpresa.TabIndex = 20;
            this.cmbBoxEmpresa.Click += new System.EventHandler(this.cmbBoxEmpresa_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(42, 28);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 21;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(55, 76);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(38, 13);
            this.lblConta.TabIndex = 22;
            this.lblConta.Text = "Conta:";
            // 
            // cmbBoxConta
            // 
            this.cmbBoxConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxConta.FormattingEnabled = true;
            this.cmbBoxConta.Location = new System.Drawing.Point(99, 73);
            this.cmbBoxConta.Name = "cmbBoxConta";
            this.cmbBoxConta.Size = new System.Drawing.Size(299, 21);
            this.cmbBoxConta.TabIndex = 23;
            this.cmbBoxConta.Click += new System.EventHandler(this.cmbBoxConta_Click);
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(518, 26);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerData.TabIndex = 24;
            // 
            // FormLancamentosCadastrarAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarExcluir;
            this.ClientSize = new System.Drawing.Size(642, 261);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.cmbBoxConta);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.cmbBoxEmpresa);
            this.Controls.Add(this.lblContaDebito);
            this.Controls.Add(this.lblContaCredito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxHistorico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxValor);
            this.Controls.Add(this.cmbBoxContaCredito);
            this.Controls.Add(this.cmbBoxContaDebito);
            this.Controls.Add(this.btnLancamentoSalvarAlterar);
            this.Controls.Add(this.btnCancelarExcluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLancamentosCadastrarAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLancamentosCadastrarAlterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLancamentoSalvarAlterar;
        private System.Windows.Forms.Button btnCancelarExcluir;
        private System.Windows.Forms.ComboBox cmbBoxContaDebito;
        private System.Windows.Forms.ComboBox cmbBoxContaCredito;
        private System.Windows.Forms.TextBox txtBoxValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxHistorico;
        private System.Windows.Forms.Label lblContaCredito;
        private System.Windows.Forms.Label lblContaDebito;
        private System.Windows.Forms.ComboBox cmbBoxEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.ComboBox cmbBoxConta;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
    }
}