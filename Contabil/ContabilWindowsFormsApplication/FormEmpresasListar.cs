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
    public partial class FormEmpresasListar : Form
    {
        Int32 id;
        public FormEmpresasListar()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (this.id == 0)
            {
                this.Close();
            }
            else
            {
                using (var context = new ContabilEntities())
                {
                    try
                    {
                        context.sp_EmpresaExcluir(this.id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                    }
                    finally
                    {
                        this.Close();
                    }
                }
            }
        }

        private void BtnEmpresasListar_Click(object sender, EventArgs e)
        {
            using (var context = new ContabilEntities())
            {
                try
                {
                    DataGridViewEmpresasListar.DataSource = context.sp_EmpresasListarTodas();
                    this.id = Convert.ToInt32(DataGridViewEmpresasListar.Rows[DataGridViewEmpresasListar.CurrentRow.Index].Cells[0].Value);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Erro");
                }
            }
        }

        private void BtnAbrirCadastroEmpresa_Click(object sender, EventArgs e)
        {
            FormEmpresaCadastrarAlterar formEmpresaCadastrarAlterar = new FormEmpresaCadastrarAlterar(Convert.ToInt32(DataGridViewEmpresasListar.Rows[DataGridViewEmpresasListar.CurrentRow.Index].Cells[0].Value));
            formEmpresaCadastrarAlterar.ShowDialog();
        }
    }
}
