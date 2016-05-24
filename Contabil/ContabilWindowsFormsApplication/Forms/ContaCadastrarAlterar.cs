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
    public partial class ContaCadastrarAlterar : Form
    {
        int id;
        public ContaCadastrarAlterar(int id = 0)
        {
            InitializeComponent();
            this.id = id;
            if (id != 0)
            {
                try
                {
                    using (var context = new ContabilEntities())
                    {
                        var conta = context.sp_ContaBuscar(id).FirstOrDefault();
                        txtBoxNome.Text = conta.Nome;
                        txtBoxCodigo.Text = conta.Codigo;
                        if (conta.AtivoContaAnalitica)
                            cmbBoxCategoria.Text = "Ativo Conta Analítica";
                        else if (conta.AtivoContaSintetica)
                            cmbBoxCategoria.Text = "Ativo Conta Sintética";
                        else if (conta.PassivoContaSintetica)
                            cmbBoxCategoria.Text = "Passivo Conta Analítica";
                        else if (conta.PassivoContaSintetica)
                            cmbBoxCategoria.Text = "Passivo Conta Sintética";
                        else if (conta.ReceitaContaSintetica)
                            cmbBoxCategoria.Text = "Receita Conta Analítica";
                        else if (conta.ReceitaContaSintetica)
                            cmbBoxCategoria.Text = "Receita Conta Sintética";
                        else if (conta.DespesaContaSintetica)
                            cmbBoxCategoria.Text = "Despesa Conta Analítica";
                        else if (conta.DespesaContaSintetica)
                            cmbBoxCategoria.Text = "Despesa Conta Sintética";
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
                        if (cmbBoxCategoria.Text == "Ativo Conta Analítica")
                            context.sp_AtivoCadastrarContaAnalitica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Ativo Conta Sintética")
                            context.sp_AtivoCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Passivo Conta Analítica")
                            context.sp_PassivoCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Passivo Conta Sintética")
                            context.sp_PassivoCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Receita Conta Analítica")
                            context.sp_ReceitaCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Receita Conta Sintética")
                            context.sp_ReceitaCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Despesa Conta Analítica")
                            context.sp_DespesaCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Despesa Conta Sintética")
                            context.sp_DespesaCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        MessageBox.Show("Conta Cadastrada com Sucesso!");
                    }
                    else
                    {
                        /*if (cmbBoxCategoria.Text == "Ativo Conta Analítica")
                            context.sp_AtivoCadastrarContaAnalitica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Ativo Conta Sintética")
                            context.sp_AtivoCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Passivo Conta Analítica")
                            context.sp_PassivoCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Passivo Conta Sintética")
                            context.sp_PassivoCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Receita Conta Analítica")
                            context.sp_ReceitaCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Receita Conta Sintética")
                            context.sp_ReceitaCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Despesa Conta Analítica")
                            context.sp_DespesaCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        else if (cmbBoxCategoria.Text == "Despesa Conta Sintética")
                            context.sp_DespesaCadastrarContaSintetica(txtBoxCodigo.Text, txtBoxNome.Text);
                        MessageBox.Show("Empresa Alterada com Sucesso!");*/
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
