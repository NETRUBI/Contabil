namespace ContabilWindowsFormsApplication
{
    partial class FormPrincipal
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
            this.menuStripFormPrincipal = new System.Windows.Forms.MenuStrip();
            this.EmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpresasCadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpresasListarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContasCadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContasListarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LancamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LancamentosListarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFormPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripFormPrincipal
            // 
            this.menuStripFormPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmpresasToolStripMenuItem,
            this.ContasToolStripMenuItem,
            this.LancamentosToolStripMenuItem});
            this.menuStripFormPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripFormPrincipal.Name = "menuStripFormPrincipal";
            this.menuStripFormPrincipal.Size = new System.Drawing.Size(602, 24);
            this.menuStripFormPrincipal.TabIndex = 1;
            this.menuStripFormPrincipal.Text = "menuStrip1";
            // 
            // EmpresasToolStripMenuItem
            // 
            this.EmpresasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmpresasCadastrarToolStripMenuItem,
            this.EmpresasListarToolStripMenuItem});
            this.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem";
            this.EmpresasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.EmpresasToolStripMenuItem.Text = "Empresas";
            // 
            // EmpresasCadastrarToolStripMenuItem
            // 
            this.EmpresasCadastrarToolStripMenuItem.Name = "EmpresasCadastrarToolStripMenuItem";
            this.EmpresasCadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.EmpresasCadastrarToolStripMenuItem.Text = "Cadastrar";
            this.EmpresasCadastrarToolStripMenuItem.Click += new System.EventHandler(this.EmpresasCadastrarToolStripMenuItem_Click);
            // 
            // EmpresasListarToolStripMenuItem
            // 
            this.EmpresasListarToolStripMenuItem.Name = "EmpresasListarToolStripMenuItem";
            this.EmpresasListarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.EmpresasListarToolStripMenuItem.Text = "Listar";
            this.EmpresasListarToolStripMenuItem.Click += new System.EventHandler(this.EmpresasListarToolStripMenuItem_Click);
            // 
            // ContasToolStripMenuItem
            // 
            this.ContasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContasCadastrarToolStripMenuItem,
            this.ContasListarToolStripMenuItem1});
            this.ContasToolStripMenuItem.Name = "ContasToolStripMenuItem";
            this.ContasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ContasToolStripMenuItem.Text = "Contas";
            // 
            // ContasCadastrarToolStripMenuItem
            // 
            this.ContasCadastrarToolStripMenuItem.Name = "ContasCadastrarToolStripMenuItem";
            this.ContasCadastrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ContasCadastrarToolStripMenuItem.Text = "Cadastrar";
            this.ContasCadastrarToolStripMenuItem.Click += new System.EventHandler(this.ContasCadastrarToolStripMenuItem_Click);
            // 
            // ContasListarToolStripMenuItem1
            // 
            this.ContasListarToolStripMenuItem1.Name = "ContasListarToolStripMenuItem1";
            this.ContasListarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ContasListarToolStripMenuItem1.Text = "Listar";
            this.ContasListarToolStripMenuItem1.Click += new System.EventHandler(this.ContasListarToolStripMenuItem1_Click);
            // 
            // LancamentosToolStripMenuItem
            // 
            this.LancamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.LancamentosListarToolStripMenuItem3});
            this.LancamentosToolStripMenuItem.Name = "LancamentosToolStripMenuItem";
            this.LancamentosToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.LancamentosToolStripMenuItem.Text = "Lancamentos";
            // 
            // LancamentosListarToolStripMenuItem3
            // 
            this.LancamentosListarToolStripMenuItem3.Name = "LancamentosListarToolStripMenuItem3";
            this.LancamentosListarToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.LancamentosListarToolStripMenuItem3.Text = "Listar";
            this.LancamentosListarToolStripMenuItem3.Click += new System.EventHandler(this.LancamentosListarToolStripMenuItem3_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 272);
            this.Controls.Add(this.menuStripFormPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripFormPrincipal;
            this.Name = "FormPrincipal";
            this.Text = "Contabil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.FormPrincipal_Resize);
            this.menuStripFormPrincipal.ResumeLayout(false);
            this.menuStripFormPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripFormPrincipal;
        private System.Windows.Forms.ToolStripMenuItem EmpresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpresasCadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpresasListarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContasCadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContasListarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LancamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LancamentosListarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
    }
}

