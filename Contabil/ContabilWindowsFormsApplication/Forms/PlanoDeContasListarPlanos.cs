using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContabilWindowsFormsApplication.Forms
{
    public partial class PlanoDeContasListarPlanos : Form
    {
        public PlanoDeContasListarPlanos()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirPlano_Click(object sender, EventArgs e)
        {
            try
            {
                PlanoDeContasAbrirPlano planoDeContasAbrir = new PlanoDeContasAbrirPlano(Convert.ToInt32(dgvListarPlanosDeContas.Rows[dgvListarPlanosDeContas.CurrentRow.Index].Cells[0].Value));
                planoDeContasAbrir.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                if (ex.InnerException != null)
                    MessageBox.Show(ex.InnerException.Message, "Error");
                this.Close();
            }

        }

        private void btnCriarNovoPlano_Click(object sender, EventArgs e)
        {
            PlanoDeContasCriarNovoPlano planoDeContasCriarNovo = new PlanoDeContasCriarNovoPlano();
            planoDeContasCriarNovo.ShowDialog();
        }

        private void cmbBoxListarEmpresas_Click(object sender, EventArgs e)
        {
            using (var context = new ContabilEntities())
            {
                cmbBoxListarEmpresas.DataSource = context.sp_EmpresasListarTodas().ToArray();
                cmbBoxListarEmpresas.DisplayMember = "RazaoSocial";
                cmbBoxListarEmpresas.ValueMember = "Id";
            }
        }

        private void btnListarPlanoDeContas_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ContabilEntities())
                {
                    dgvListarPlanosDeContas.DataSource = context.sp_PlanosDeContasListarTodosPlanosDaEmpresa(Convert.ToInt32(cmbBoxListarEmpresas.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                if (ex.InnerException != null)
                    MessageBox.Show(ex.InnerException.Message, "Error");
                this.Close();
            }
        }
    }
}
