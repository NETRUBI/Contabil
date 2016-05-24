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
    public partial class PlanoDeContasCriarNovoPlano : Form
    {
        public PlanoDeContasCriarNovoPlano()
        {
            InitializeComponent();
            dateTimePickerPlanoDeContasMesAno.Format = DateTimePickerFormat.Custom;
            dateTimePickerPlanoDeContasMesAno.CustomFormat = "dd/MM/yyyy";
        }
        private void cmbBoxListarEmpresas_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ContabilEntities())
                {
                    cmbBoxListarEmpresas.DataSource = context.sp_EmpresasListarTodas().ToArray();
                    cmbBoxListarEmpresas.DisplayMember = "RazaoSocial";
                    cmbBoxListarEmpresas.ValueMember = "Id";
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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbBoxListarEmpresas.SelectedValue == null)
                MessageBox.Show("Selecione a empresa.");
            else
            {
                try
                {
                    using (var context = new ContabilEntities())
                    {
                        context.sp_PlanoDeContasCriarNovoPlano(Convert.ToInt32(cmbBoxListarEmpresas.SelectedValue), dateTimePickerPlanoDeContasMesAno.Text);

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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
