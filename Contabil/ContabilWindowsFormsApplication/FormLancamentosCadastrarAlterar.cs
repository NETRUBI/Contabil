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
    public partial class FormLancamentosCadastrarAlterar : Form
    {
        Int32 idLancamento;
        Int32 idEmpresa;
        Int32 idConta;
        Int32 idContaDebito;
        Int32 idContaCredito;
        public FormLancamentosCadastrarAlterar(Int32 idLancamento = 0)
        {
            InitializeComponent();
            dateTimePickerData.Format = DateTimePickerFormat.Custom;
            dateTimePickerData.CustomFormat = "dd/MM/yyyy";
            this.idLancamento = idLancamento;
            //MessageBox.Show(Convert.ToString(idLancamento));
            if (idLancamento == 0)
            {
                this.Text = "Cadastrar Novo Lançamento";
                btnLancamentoSalvarAlterar.Text = "Salvar Lançamento";
                btnCancelarExcluir.Text = "Cancelar";
            }
            else
            {
                this.Text = "Alterar Lançamento";
                btnLancamentoSalvarAlterar.Text = "Salvar Cadastro";
                btnCancelarExcluir.Text = "Excluir Lançamento";
                using (var context = new ContabilEntities())
                {
                    try
                    {
                        
                        var lancamento = context.sp_LancamentoBuscar(idLancamento).FirstOrDefault();
                        this.idConta = lancamento.IdConta;
                        this.idEmpresa = lancamento.IdEmpresa;
                        this.idContaDebito = lancamento.IdContaDebito;
                        this.idContaCredito = lancamento.IdContaCredito;
                        
                        var conta = context.sp_ContaBuscar(this.idConta).FirstOrDefault();
                        var empresa = context.sp_EmpresaBuscar(this.idEmpresa).FirstOrDefault();
                        var contaDebito = context.sp_ContaBuscar(this.idContaDebito).FirstOrDefault();
                        var contaCredito = context.sp_ContaBuscar(this.idContaCredito).FirstOrDefault();

                        cmbBoxConta.Items.Add(conta.Codigo);
                        cmbBoxConta.SelectedItem=conta.Codigo;
                        cmbBoxConta.ValueMember = Convert.ToString(conta.Id);
                        cmbBoxEmpresa.Items.Add(empresa.RazaoSocial);
                        cmbBoxEmpresa.SelectedItem = empresa.RazaoSocial;
                        cmbBoxEmpresa.ValueMember = Convert.ToString(empresa.Id);
                        txtBoxValor.Text = Convert.ToString(lancamento.Valor);
                        cmbBoxContaDebito.Items.Add(contaDebito.Codigo);
                        cmbBoxContaDebito.Text = contaDebito.Codigo;
                        cmbBoxContaDebito.ValueMember = Convert.ToString(contaDebito.Id);
                        cmbBoxContaCredito.Items.Add(contaCredito.Codigo);
                        cmbBoxContaCredito.Text = contaCredito.Codigo;
                        cmbBoxContaCredito.ValueMember = Convert.ToString(contaCredito.Id);
                        txtBoxHistorico.Text = lancamento.Historico;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }
        private void btnLancamentoSalvarAlterar_Click(object sender, EventArgs e)
        {
            using (var context = new ContabilEntities())
            {
                try
                {
                    if (this.idLancamento == 0)
                        context.sp_LancamentoInserir(Convert.ToInt32(cmbBoxEmpresa.SelectedValue), Convert.ToInt32(cmbBoxConta.SelectedValue), Convert.ToDateTime(dateTimePickerData.Text), Convert.ToDecimal(txtBoxValor.Text), Convert.ToInt32(cmbBoxContaDebito.SelectedValue), Convert.ToInt32(cmbBoxContaCredito.SelectedValue), txtBoxHistorico.Text);
                    else
                    {
                        //MessageBox.Show(Convert.ToString(this.idLancamento), "IDLancamento");
                        //MessageBox.Show(Convert.ToString(txtBoxValor.Text), "Valor");
                        //MessageBox.Show(Convert.ToString(cmbBoxContaDebito.SelectedValue), "Debito");
                        //MessageBox.Show(Convert.ToString(cmbBoxContaCredito.SelectedValue), "Credito");
                        //MessageBox.Show(Convert.ToString(txtBoxHistorico.Text), "Historico");
                        string data = dateTimePickerData.Text;
                        context.sp_LancamentoAlterar(this.idLancamento, Convert.ToDateTime(data), Convert.ToDecimal(txtBoxValor.Text), Convert.ToInt32(cmbBoxContaDebito.SelectedValue), Convert.ToInt32(cmbBoxContaCredito.SelectedValue), txtBoxHistorico.Text);
                    }
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
            if (this.idLancamento == 0)
            {
                this.Close();
            }
            else
            {
                using (var context = new ContabilEntities())
                {
                    try
                    {
                        context.sp_LancamentoExcluir(this.idLancamento);
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
        private void cmbBoxEmpresa_Click(object sender, EventArgs e)
        {
            using (var context = new ContabilEntities())
            {
                var empresas = context.sp_EmpresasListarTodas().ToArray();
                cmbBoxEmpresa.DataSource = empresas;
                cmbBoxEmpresa.ValueMember = "Id";
                cmbBoxEmpresa.DisplayMember = "RazaoSocial";
                //MessageBox.Show(Convert.ToString(cmbBoxEmpresa.SelectedValue));
                
            }
        }
        private void cmbBoxContaDebito_Click(object sender, EventArgs e)
        {
            using (var context = new ContabilEntities())
            {
                var contasDebito = context.sp_ContasListarTodas().ToArray();
                cmbBoxContaDebito.DataSource = contasDebito;
                cmbBoxContaDebito.ValueMember = "Id";
                cmbBoxContaDebito.DisplayMember = "Codigo";
            }
        }
        private void cmbBoxContaCredito_Click(object sender, EventArgs e)
        {
            using (var context = new ContabilEntities())
            {
                var contasCredito = context.sp_ContasListarTodas().ToArray();
                cmbBoxContaCredito.DataSource = contasCredito;
                cmbBoxContaCredito.ValueMember = "Id";
                cmbBoxContaCredito.DisplayMember = "Codigo";
            }
        }
        private void cmbBoxConta_Click(object sender, EventArgs e)
        {
            using (var context = new ContabilEntities())
            {
                var contas = context.sp_ContasListarTodas().ToArray();
                cmbBoxConta.DataSource = contas;
                cmbBoxConta.ValueMember = "Id";
                cmbBoxConta.DisplayMember = "Codigo";
            }
        }
    }
}
