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
    public partial class EmpresaCadastrarAlterar : Form
    {
        int id;
        public EmpresaCadastrarAlterar(int id = 0)
        {
            InitializeComponent();
            this.id = id;
            if (id != 0)
            {
                try
                {
                    using (var context = new ContabilEntities())
                    {
                        var empresa = context.sp_EmpresaBuscar(id).FirstOrDefault();
                        txtBoxRazaoSocial.Text = empresa.RazaoSocial;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    if (ex.InnerException != null)
                        MessageBox.Show(ex.InnerException.Message, "Error");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                using (var context = new ContabilEntities())
                {
                    if (id == 0)
                    {
                        context.sp_EmpresaCadastrar(txtBoxRazaoSocial.Text.Trim());
                        MessageBox.Show("Empresa Cadastrada com Sucesso!");
                    }
                    else
                    {
                        context.sp_EmpresaAlterar(this.id, txtBoxRazaoSocial.Text.Trim());
                        MessageBox.Show("Empresa Alterada com Sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                if (ex.InnerException != null)
                    MessageBox.Show(ex.InnerException.Message, "Error");
            }
            finally
            {
                this.Close();
            }
        }
    }
}
