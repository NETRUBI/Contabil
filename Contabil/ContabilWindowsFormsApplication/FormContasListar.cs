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
    public partial class FormContasListar : Form
    {
        public FormContasListar()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnContasListar_Click(object sender, EventArgs e)
        {
            using (var context = new ContabilEntities())
            {
                try
                {
                    DataGridViewContasListar.DataSource = context.sp_ContasListarTodas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro");
                }
            }
        }

        private void BtnContaAbrirCadastro_Click(object sender, EventArgs e)
        {
            FormContaCadastrarAlterar formContaCadastrarAlterar = new FormContaCadastrarAlterar(Convert.ToInt32(DataGridViewContasListar.Rows[DataGridViewContasListar.CurrentRow.Index].Cells[0].Value));
            formContaCadastrarAlterar.ShowDialog();
        }
    }
}
