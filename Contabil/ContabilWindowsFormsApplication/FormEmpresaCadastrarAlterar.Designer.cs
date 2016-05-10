namespace ContabilWindowsFormsApplication
{
    partial class FormEmpresaCadastrarAlterar
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
            this.btnSalvarAlterarCadastroEmpresa = new System.Windows.Forms.Button();
            this.btnCancelarExcluir = new System.Windows.Forms.Button();
            this.txtBoxNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.labelNomeFantasia = new System.Windows.Forms.Label();
            this.labelRazaoSocial = new System.Windows.Forms.Label();
            this.spEmpresaBuscarResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spEmpresaBuscarResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarAlterarCadastroEmpresa
            // 
            this.btnSalvarAlterarCadastroEmpresa.Location = new System.Drawing.Point(12, 163);
            this.btnSalvarAlterarCadastroEmpresa.Name = "btnSalvarAlterarCadastroEmpresa";
            this.btnSalvarAlterarCadastroEmpresa.Size = new System.Drawing.Size(230, 40);
            this.btnSalvarAlterarCadastroEmpresa.TabIndex = 3;
            this.btnSalvarAlterarCadastroEmpresa.Text = "Salvar Cadastro";
            this.btnSalvarAlterarCadastroEmpresa.UseVisualStyleBackColor = true;
            this.btnSalvarAlterarCadastroEmpresa.Click += new System.EventHandler(this.btnSalvarAlterarCadastroEmpresa_Click);
            // 
            // btnCancelarExcluir
            // 
            this.btnCancelarExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarExcluir.Location = new System.Drawing.Point(321, 163);
            this.btnCancelarExcluir.Name = "btnCancelarExcluir";
            this.btnCancelarExcluir.Size = new System.Drawing.Size(230, 40);
            this.btnCancelarExcluir.TabIndex = 2;
            this.btnCancelarExcluir.Text = "Cancelar";
            this.btnCancelarExcluir.UseVisualStyleBackColor = true;
            this.btnCancelarExcluir.Click += new System.EventHandler(this.btnCancelarExcluir_Click);
            // 
            // txtBoxNomeFantasia
            // 
            this.txtBoxNomeFantasia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spEmpresaBuscarResultBindingSource, "NomeFantasia", true));
            this.txtBoxNomeFantasia.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.spEmpresaBuscarResultBindingSource, "NomeFantasia", true));
            this.txtBoxNomeFantasia.Location = new System.Drawing.Point(119, 31);
            this.txtBoxNomeFantasia.Name = "txtBoxNomeFantasia";
            this.txtBoxNomeFantasia.Size = new System.Drawing.Size(431, 20);
            this.txtBoxNomeFantasia.TabIndex = 8;
            // 
            // txtBoxRazaoSocial
            // 
            this.txtBoxRazaoSocial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spEmpresaBuscarResultBindingSource, "RazaoSocial", true));
            this.txtBoxRazaoSocial.Location = new System.Drawing.Point(119, 96);
            this.txtBoxRazaoSocial.Name = "txtBoxRazaoSocial";
            this.txtBoxRazaoSocial.Size = new System.Drawing.Size(431, 20);
            this.txtBoxRazaoSocial.TabIndex = 9;
            // 
            // labelNomeFantasia
            // 
            this.labelNomeFantasia.AutoSize = true;
            this.labelNomeFantasia.Location = new System.Drawing.Point(32, 34);
            this.labelNomeFantasia.Name = "labelNomeFantasia";
            this.labelNomeFantasia.Size = new System.Drawing.Size(81, 13);
            this.labelNomeFantasia.TabIndex = 10;
            this.labelNomeFantasia.Text = "Nome Fantasia:";
            // 
            // labelRazaoSocial
            // 
            this.labelRazaoSocial.AutoSize = true;
            this.labelRazaoSocial.Location = new System.Drawing.Point(40, 99);
            this.labelRazaoSocial.Name = "labelRazaoSocial";
            this.labelRazaoSocial.Size = new System.Drawing.Size(73, 13);
            this.labelRazaoSocial.TabIndex = 11;
            this.labelRazaoSocial.Text = "Razão Social:";
            // 
            // spEmpresaBuscarResultBindingSource
            // 
            this.spEmpresaBuscarResultBindingSource.DataSource = typeof(ContabilWindowsFormsApplication.sp_EmpresaBuscar_Result);
            // 
            // FormEmpresaCadastrarAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarExcluir;
            this.ClientSize = new System.Drawing.Size(563, 215);
            this.Controls.Add(this.labelRazaoSocial);
            this.Controls.Add(this.labelNomeFantasia);
            this.Controls.Add(this.txtBoxRazaoSocial);
            this.Controls.Add(this.txtBoxNomeFantasia);
            this.Controls.Add(this.btnSalvarAlterarCadastroEmpresa);
            this.Controls.Add(this.btnCancelarExcluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEmpresaCadastrarAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarAlterarEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.spEmpresaBuscarResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarAlterarCadastroEmpresa;
        private System.Windows.Forms.Button btnCancelarExcluir;
        private System.Windows.Forms.TextBox txtBoxNomeFantasia;
        private System.Windows.Forms.TextBox txtBoxRazaoSocial;
        private System.Windows.Forms.Label labelNomeFantasia;
        private System.Windows.Forms.Label labelRazaoSocial;
        private System.Windows.Forms.BindingSource spEmpresaBuscarResultBindingSource;
    }
}