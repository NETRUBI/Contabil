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
    public partial class FormContaCadastrarAlterar : Form
    {
        Int32 id;
        public FormContaCadastrarAlterar(Int32 id = 0)
        {
            InitializeComponent();
            this.id = id;
            if (id == 0)
            {
                this.Text = "Cadastrar Nova Conta";
                btnSalvarAlterarCadastroConta.Text = "Salvar Cadastro";
                btnCancelarExcluir.Text = "Cancelar Cadastro";
            }
            else
            {
                this.Text = "Alterar Cadastro da Conta";
                btnSalvarAlterarCadastroConta.Text = "Salvar Cadastro";
                btnCancelarExcluir.Text = "Excluir Cadastro";
                using (var context = new ContabilEntities())
                {
                    try
                    {
                        var conta = context.sp_ContaBuscar(id).FirstOrDefault();
                        txtBoxCodigo.Text = conta.Codigo;
                        txtBoxNome.Text = conta.Nome;
                        txtBoxClassificacao.Text = conta.Classificacao;
                        cmbBoxTipo.Text = conta.Tipo;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }

        private void btnSalvarAlterarCadastroConta_Click(object sender, EventArgs e)
        {
            using (var context = new ContabilEntities())
            {
                try
                {
                    if (this.id == 0)
                        context.sp_ContaInserir(txtBoxCodigo.Text, txtBoxNome.Text, txtBoxClassificacao.Text, cmbBoxTipo.Text);
                    else
                        context.sp_ContaAlterar(this.id, txtBoxCodigo.Text, txtBoxNome.Text, txtBoxClassificacao.Text, cmbBoxTipo.Text);
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

        private void btnCancelar_Click(object sender, EventArgs e)
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
                        context.sp_ContaExcluir(this.id);
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
