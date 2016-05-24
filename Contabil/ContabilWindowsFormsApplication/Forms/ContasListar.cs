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
    public partial class ContasListar : Form
    {
        public ContasListar()
        {
            InitializeComponent();

            try
            {
                using (var context = new ContabilEntities())
                {
                    dgvContasListar.DataSource = context.sp_ContasListarTodas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                if (ex.InnerException != null)
                    MessageBox.Show(ex.InnerException.Message, "Erro");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirConta_Click(object sender, EventArgs e)
        {
            ContaCadastrarAlterar contaCadastrarAlterar = new ContaCadastrarAlterar(Convert.ToInt32(dgvContasListar.Rows[dgvContasListar.CurrentRow.Index].Cells[0].Value));
            contaCadastrarAlterar.ShowDialog();
        }
    }
}
