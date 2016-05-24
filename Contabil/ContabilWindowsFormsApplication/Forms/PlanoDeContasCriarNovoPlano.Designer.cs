namespace ContabilWindowsFormsApplication.Forms
{
    partial class PlanoDeContasCriarNovoPlano
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
            this.lblSelecionarEmpresa = new System.Windows.Forms.Label();
            this.cmbBoxListarEmpresas = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPlanoDeContasMesAno = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelecionarEmpresa
            // 
            this.lblSelecionarEmpresa.AutoSize = true;
            this.lblSelecionarEmpresa.Location = new System.Drawing.Point(24, 15);
            this.lblSelecionarEmpresa.Name = "lblSelecionarEmpresa";
            this.lblSelecionarEmpresa.Size = new System.Drawing.Size(104, 13);
            this.lblSelecionarEmpresa.TabIndex = 7;
            this.lblSelecionarEmpresa.Text = "Selecionar Empresa:";
            // 
            // cmbBoxListarEmpresas
            // 
            this.cmbBoxListarEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxListarEmpresas.FormattingEnabled = true;
            this.cmbBoxListarEmpresas.Location = new System.Drawing.Point(134, 12);
            this.cmbBoxListarEmpresas.Name = "cmbBoxListarEmpresas";
            this.cmbBoxListarEmpresas.Size = new System.Drawing.Size(338, 21);
            this.cmbBoxListarEmpresas.TabIndex = 6;
            this.cmbBoxListarEmpresas.Click += new System.EventHandler(this.cmbBoxListarEmpresas_Click);
            // 
            // dateTimePickerPlanoDeContasMesAno
            // 
            this.dateTimePickerPlanoDeContasMesAno.Checked = false;
            this.dateTimePickerPlanoDeContasMesAno.CustomFormat = "";
            this.dateTimePickerPlanoDeContasMesAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPlanoDeContasMesAno.Location = new System.Drawing.Point(134, 48);
            this.dateTimePickerPlanoDeContasMesAno.Name = "dateTimePickerPlanoDeContasMesAno";
            this.dateTimePickerPlanoDeContasMesAno.Size = new System.Drawing.Size(84, 20);
            this.dateTimePickerPlanoDeContasMesAno.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecionar Mês e Ano:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(397, 86);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 86);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // PlanoDeContasCriarNovoPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 121);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerPlanoDeContasMesAno);
            this.Controls.Add(this.lblSelecionarEmpresa);
            this.Controls.Add(this.cmbBoxListarEmpresas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanoDeContasCriarNovoPlano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanoDeContasCriarNovo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelecionarEmpresa;
        private System.Windows.Forms.ComboBox cmbBoxListarEmpresas;
        private System.Windows.Forms.DateTimePicker dateTimePickerPlanoDeContasMesAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}