using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContabilWindowsFormsApplication
{
    public partial class FormEmpresaCadastrarAlterar : Form
    {
        Int32 id;
        public FormEmpresaCadastrarAlterar(Int32 id = 0)
        {
            InitializeComponent();

            this.id = id;
            if (id == 0)
            {
                this.Text = "Cadastrar nova Empresa";
                btnSalvarAlterarCadastroEmpresa.Text = "Salvar Cadastro";
                btnCancelarExcluir.Text = "Cancelar Cadastro";
            }
            else
            {
                this.Text = "Alterar cadastro da Empresa";
                btnSalvarAlterarCadastroEmpresa.Text = "Salvar Cadastro";
                btnCancelarExcluir.Text = "Excluir Cadastro";
                using (var context = new ContabilEntities())
                {
                    try
                    {
                        var empresa = context.sp_EmpresaBuscar(id).FirstOrDefault();
                        txtBoxNomeFantasia.Text = empresa.NomeFantasia;
                        txtBoxRazaoSocial.Text = empresa.RazaoSocial;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }
        private void btnSalvarAlterarCadastroEmpresa_Click(object sender, EventArgs e)
        {
            using (var context = new ContabilEntities())
            {
                try
                {
                    if (this.id == 0)
                        context.sp_EmpresaInserir(txtBoxNomeFantasia.Text, txtBoxRazaoSocial.Text);
                    else
                        context.sp_EmpresaAlterar(this.id, txtBoxNomeFantasia.Text, txtBoxRazaoSocial.Text);
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
        private void btnCancelarExcluir_Click(object sender, EventArgs e)
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
    }
}
