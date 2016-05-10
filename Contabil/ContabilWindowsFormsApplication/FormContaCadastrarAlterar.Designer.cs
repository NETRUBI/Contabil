namespace ContabilWindowsFormsApplication
{
    partial class FormContaCadastrarAlterar
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
            this.btnSalvarAlterarCadastroConta = new System.Windows.Forms.Button();
            this.btnCancelarExcluir = new System.Windows.Forms.Button();
            this.txtBoxClassificacao = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.cmbBoxTipo = new System.Windows.Forms.ComboBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvarAlterarCadastroConta
            // 
            this.btnSalvarAlterarCadastroConta.Location = new System.Drawing.Point(12, 205);
            this.btnSalvarAlterarCadastroConta.Name = "btnSalvarAlterarCadastroConta";
            this.btnSalvarAlterarCadastroConta.Size = new System.Drawing.Size(183, 40);
            this.btnSalvarAlterarCadastroConta.TabIndex = 6;
            this.btnSalvarAlterarCadastroConta.Text = "Salvar Cadastro";
            this.btnSalvarAlterarCadastroConta.UseVisualStyleBackColor = true;
            this.btnSalvarAlterarCadastroConta.Click += new System.EventHandler(this.btnSalvarAlterarCadastroConta_Click);
            // 
            // btnCancelarExcluir
            // 
            this.btnCancelarExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarExcluir.Location = new System.Drawing.Point(261, 205);
            this.btnCancelarExcluir.Name = "btnCancelarExcluir";
            this.btnCancelarExcluir.Size = new System.Drawing.Size(192, 40);
            this.btnCancelarExcluir.TabIndex = 5;
            this.btnCancelarExcluir.Text = "Cancelar";
            this.btnCancelarExcluir.UseVisualStyleBackColor = true;
            this.btnCancelarExcluir.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBoxClassificacao
            // 
            this.txtBoxClassificacao.Location = new System.Drawing.Point(95, 129);
            this.txtBoxClassificacao.Name = "txtBoxClassificacao";
            this.txtBoxClassificacao.Size = new System.Drawing.Size(157, 20);
            this.txtBoxClassificacao.TabIndex = 8;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(95, 93);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(358, 20);
            this.txtBoxNome.TabIndex = 9;
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(95, 55);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(157, 20);
            this.txtBoxCodigo.TabIndex = 10;
            // 
            // cmbBoxTipo
            // 
            this.cmbBoxTipo.FormattingEnabled = true;
            this.cmbBoxTipo.Items.AddRange(new object[] {
            "T",
            "A"});
            this.cmbBoxTipo.Location = new System.Drawing.Point(332, 129);
            this.cmbBoxTipo.Name = "cmbBoxTipo";
            this.cmbBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxTipo.TabIndex = 11;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(46, 58);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 12;
            this.labelCodigo.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Classificacao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipo:";
            // 
            // FormContaCadastrarAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarExcluir;
            this.ClientSize = new System.Drawing.Size(475, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.cmbBoxTipo);
            this.Controls.Add(this.txtBoxCodigo);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.txtBoxClassificacao);
            this.Controls.Add(this.btnSalvarAlterarCadastroConta);
            this.Controls.Add(this.btnCancelarExcluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormContaCadastrarAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContasCadastrarAlterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarAlterarCadastroConta;
        private System.Windows.Forms.Button btnCancelarExcluir;
        private System.Windows.Forms.TextBox txtBoxClassificacao;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.ComboBox cmbBoxTipo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}