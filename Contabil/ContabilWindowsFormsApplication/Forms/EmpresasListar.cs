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
    public partial class EmpresasListar : Form
    {
        public EmpresasListar()
        {
            InitializeComponent();

            try
            {
                using (var context = new ContabilEntities())
                {
                    dgvEmpresasListar.DataSource = context.sp_EmpresasListarTodas();
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

        private void btnAbrirEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaCadastrarAlterar empresaCadastrarAlterar = new EmpresaCadastrarAlterar(Convert.ToInt32(dgvEmpresasListar.Rows[dgvEmpresasListar.CurrentRow.Index].Cells[0].Value));
            empresaCadastrarAlterar.ShowDialog();
        }
    }
}
