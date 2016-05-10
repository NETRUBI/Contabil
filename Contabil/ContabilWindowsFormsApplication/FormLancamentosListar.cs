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
    public partial class FormLancamentosListar : Form
    {
        Int32 id = 0;
        public FormLancamentosListar()
        {
            InitializeComponent();
            dateTimePickerDataInicial.Format = DateTimePickerFormat.Custom;
            dateTimePickerDataInicial.CustomFormat = "dd-MM-yyyy";
            dateTimePickerDataFinal.Format = DateTimePickerFormat.Custom;
            dateTimePickerDataFinal.CustomFormat = "dd-MM-yyyy";
        }
        
        private void ComboBoxSelecionarEmpresa_Click(object sender, EventArgs e)
        {
            using (var context = new ContabilEntities())
            {
                comboBoxSelecionarEmpresa.DataSource = context.sp_EmpresasListarTodas();
            }
        }

        private void btnLancamentosListar_Click(object sender, EventArgs e)
        {
            using (var context = new ContabilEntities())
            {
                this.id = Convert.ToInt32(comboBoxSelecionarEmpresa.SelectedValue);
                string dataInicial = dateTimePickerDataInicial.Text;
                string dataFinal = dateTimePickerDataFinal.Text;
                //MessageBox.Show(dataInicial);
                //MessageBox.Show(dataFinal);
                dataGridViewLancamentosListar.DataSource = context.sp_LancamentosListarPorEmpresaEPorData(id,Convert.ToDateTime(dataInicial),Convert.ToDateTime(dataFinal));
            }
        }

        private void btnAbrirLancamento_Click(object sender, EventArgs e)
        {
            FormLancamentosCadastrarAlterar formLancamentosCadastrarAlterar = new FormLancamentosCadastrarAlterar(Convert.ToInt32(dataGridViewLancamentosListar.Rows[dataGridViewLancamentosListar.CurrentRow.Index].Cells[0].Value));
            formLancamentosCadastrarAlterar.ShowDialog();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
