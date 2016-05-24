using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContabilWindowsFormsApplication.Forms;

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
        private void empresasListarToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            byte i = 0;
            foreach (Form form in this.MdiChildren)
            {
                i += 1;
            }
            if (i == 0)
            {
                EmpresasListar empresasListar = new EmpresasListar() { MdiParent = this };
                empresasListar.Show();
            }
            else
                MessageBox.Show("Para abrir outros formulários, feche o formulário atual.");
        }
        private void empresaCadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte i = 0;
            foreach (Form form in this.MdiChildren)
            {
                i += 1;
            }
            if (i == 0)
            {
                EmpresaCadastrarAlterar empresaCadastrarAlterar = new EmpresaCadastrarAlterar() { MdiParent = this };
                empresaCadastrarAlterar.Show();
            }
            else
                MessageBox.Show("Para abrir outros formulários, feche o formulário atual.");

        }

        private void contasListarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte i = 0;
            foreach (Form form in this.MdiChildren)
            {
                i += 1;
            }
            if (i == 0)
            {
                ContasListar contasListar = new ContasListar() { MdiParent = this };
                contasListar.Show();
            }
            else
                MessageBox.Show("Para abrir outros formulários, feche o formulário atual.");

        }
        private void contaCadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte i = 0;
            foreach (Form form in this.MdiChildren)
            {
                i += 1;
            }
            if (i == 0)
            {
                ContaCadastrarAlterar contaCadastrarAlterar = new ContaCadastrarAlterar() { MdiParent = this };
                contaCadastrarAlterar.Show();
            }
            else
                MessageBox.Show("Para abrir outros formulários, feche o formulário atual.");
        }

        private void planoDeContasListarTodosAnterioresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte i = 0;
            foreach (Form form in this.MdiChildren)
            {
                i += 1;
            }
            if (i == 0)
            {
                PlanoDeContasListarPlanos planoDeContasListar = new PlanoDeContasListarPlanos() { MdiParent = this };
                planoDeContasListar.Show();
            }
            else
                MessageBox.Show("Para abrir outros formulários, feche o formulário atual.");
        }
    }
}
