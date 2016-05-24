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
    public partial class PlanoDeContasAbrirPlano : Form
    {
        int id;
        public PlanoDeContasAbrirPlano(int id)
        {
            InitializeComponent();
            this.id = id;
            try
            {
                using (var context = new ContabilEntities())
                {
                    dgvPlanoDeContas.DataSource = context.sp_PlanoDeContasListarContasDoPlano(id);
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

        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            PlanoDeContasAdicionarConta planoDeContasAdicionarConta = new PlanoDeContasAdicionarConta(this.id);
            planoDeContasAdicionarConta.ShowDialog();
        }

        private void btnRemoverConta_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ContabilEntities())
                {
                    context.sp_PlanoDeContasRemoverConta(Convert.ToInt32(dgvPlanoDeContas.Rows[dgvPlanoDeContas.CurrentRow.Index].Cells[0].Value));
                }
                MessageBox.Show("Conta Removida do Plano com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                if (ex.InnerException != null)
                    MessageBox.Show(ex.InnerException.Message, "Error");
                this.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
