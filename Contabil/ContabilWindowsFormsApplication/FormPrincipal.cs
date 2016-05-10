using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContabilWindowsFormsApplication
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bloqueia o redimensionamento deste form, mantendo-o sempre maximizado.
        /// </summary>
        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                return;
            else
                this.WindowState = FormWindowState.Maximized;
        }
       
        /// <summary>
        /// Funcionando perfeitamente
        /// </summary>
        private void EmpresasCadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte i = 0;

            foreach (Form form in this.MdiChildren)
            {
                i += 1;
            }

            if (i == 0)
            {
                FormEmpresaCadastrarAlterar formCadastrarAlterarEmpresa = new FormEmpresaCadastrarAlterar(0) { MdiParent = this };
                formCadastrarAlterarEmpresa.Show();
            }
            else
                MessageBox.Show("Para abrir outros formulários, feche o formulário atual.");
        }
        
        /// <summary>
        /// Funcionando perfeitamente
        /// </summary>
        private void EmpresasListarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte i = 0;

            foreach (Form form in this.MdiChildren)
            {
                i += 1;
            }

            if (i == 0)
            {
                FormEmpresasListar formEmpresasListar = new FormEmpresasListar() { MdiParent = this };
                formEmpresasListar.Show();
            }
            else
                MessageBox.Show("Para abrir outros formulários, feche o formulário atual.");
        }
        
        /// <summary>
        /// Funcionando perfeitamente
        /// </summary>
        private void ContasCadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte i = 0;

            foreach (Form form in this.MdiChildren)
            {
                i += 1;
            }

            if (i == 0)
            {
                FormContaCadastrarAlterar formContaCadastrarAlterar = new FormContaCadastrarAlterar() { MdiParent = this };
                formContaCadastrarAlterar.Show();
            }
            else
                MessageBox.Show("Para abrir outros formulários, feche o formulário atual.");
        }

        /// <summary>
        /// Funcionando perfeitamente
        /// </summary>
        private void ContasListarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            byte i = 0;

            foreach (Form form in this.MdiChildren)
            {
                i += 1;
            }

            if (i == 0)
            {
                FormContasListar formContasListar = new FormContasListar() { MdiParent = this };
                formContasListar.Show();
            }
            else
                MessageBox.Show("Para abrir outros formulários, feche o formulário atual.");
        }

        /// <summary>
        /// Funcionando perfeitamente
        /// </summary>
        private void LancamentosListarToolStripMenuItem3_Click(object sender, EventArgs e) 
        {
            byte i = 0;

            foreach (Form form in this.MdiChildren)
            {
                i += 1;
            }

            if (i == 0)
            {
                FormLancamentosListar formLancamentosListar = new FormLancamentosListar() { MdiParent = this };
                formLancamentosListar.Show();
            }
            else
                MessageBox.Show("Para abrir outros formulários, feche o formulário atual.");
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte i = 0;

            foreach (Form form in this.MdiChildren)
            {
                i += 1;
            }

            if (i == 0)
            {
                FormLancamentosCadastrarAlterar formLancamentosCadastrarAlterar = new FormLancamentosCadastrarAlterar() { MdiParent = this };
                formLancamentosCadastrarAlterar.Show();
            }
            else
                MessageBox.Show("Para abrir outros formulários, feche o formulário atual.");
        }
    }
}
