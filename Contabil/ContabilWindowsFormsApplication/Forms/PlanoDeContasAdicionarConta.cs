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
    public partial class PlanoDeContasAdicionarConta : Form
    {
        int id;
        public PlanoDeContasAdicionarConta(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void cmbBoxListarContasForaDoPlano_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ContabilEntities())
                {
                    cmbBoxListarContasForaDoPlano.DataSource = context.sp_PlanoDeContasListarContasForaDoPlano(id).ToArray();
                    cmbBoxListarContasForaDoPlano.DisplayMember = "Nome";
                    cmbBoxListarContasForaDoPlano.ValueMember = "Id";
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
            if (cmbBoxListarContasForaDoPlano.SelectedValue == null)
                MessageBox.Show("Selecione a conta.");
            else if(txtBoxClassificacao.Text == "")
                MessageBox.Show("Insira a classificação.");
            else
            {
                try
                {
                    using (var context = new ContabilEntities())
                    {
                        context.sp_PlanoDeContasAdicionarConta(this.id, Convert.ToInt32(cmbBoxListarContasForaDoPlano.SelectedValue), txtBoxClassificacao.Text);
                    }
                    MessageBox.Show("Conta Adicionada com sucesso.");
                    this.Close();
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
