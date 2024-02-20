using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPDS
{
    public partial class CadastroE : Form
    {
        public CadastroE()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            try
            {
                if (ValidarCpf.ValidaCPF(mk_cpf.Text))
                {

                    Empresa empresa = new Empresa()
                    {
                        Cnpj = mk_cnpj.Text,  //definindo propriedades
                        RazaoSocial = tx_razaoS.Text,
                        NomeF = tx_nomeF.Text,
                        Cpf = mk_cpf.Text,
                        SituacaoC = cb_situacaoC.Text,
                        DataInicioAtividade = dt_dataI.Text,
                        Endereco = cb_endereco.Text,
                        NaturezaJ = cb_naturezaJ.Text,
                        Telefone = mk_telefone.Text,
                        CapitalS = tx_capitalS.Text,
                        Nome = tx_nome.Text,


                    };

                    //regime tributario
                    if (rb_lucro.Checked)
                    {
                        empresa.RegimeT = rb_lucro.Text;
                    }
                    else if (rb_simplesN.Checked)
                    {
                        empresa.RegimeT = rb_simplesN.Text;
                    }
                    else
                    {
                        empresa.RegimeT = rb_real.Text;
                    }

                    //tipo
                    if (rb_matriz.Checked)
                    {
                        empresa.Tipo = rb_matriz.Text;
                    }
                    else
                    {
                        empresa.Tipo = rb_filial.Text;

                    }

                    //porte
                    if (rb_pequeno.Checked)
                    {
                        empresa.PorteEmpresa = rb_pequeno.Text;
                    }
                    else if (rb_medio.Checked)
                    {
                        empresa.PorteEmpresa = rb_medio.Text;
                    }
                    else
                    {
                        empresa.Tipo = rb_grande.Text;
                    }

                    cadastro.em.Add(empresa);
                    ValidaCampus();

                    //     bool resultadoCpf = ValidarCpf.ValidaCPF(Cpf);
                    //   MessageBox.Show(resultadoCpf.ToString());
                    cadastro.SalvarEmpresasEmBlocoDeNotas();   // Execute o método para salvar empresas
                    MessageBox.Show("Seu cadastro foi efetuado!");

                }
                else
                {
                    MessageBox.Show("CPF inválido!!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ops! Houve algo de errado");
                //errorProvider1.SetError(bt_salvar, "Erro ao salvar empresas");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            mk_cnpj.Text = "";
            tx_razaoS.Text = "";
            tx_nomeF.Text = "";
            mk_cpf.Text = "";
            cb_situacaoC.Text = "";
            dt_dataI.Text = "";
            cb_endereco.Text = "";
            cb_naturezaJ.Text = "";
            mk_telefone.Text = "";
            tx_capitalS.Text = "";
            tx_nome.Text = "";
            rb_lucro.Checked = false;
            rb_simplesN.Checked = false;
            rb_real.Checked = false;
            rb_matriz.Checked = false;
            rb_filial.Checked = false;
            rb_pequeno.Checked = false;
            rb_medio.Checked = false;
            rb_grande.Checked = false;

        }

        private bool ValidaCampus()
        {
           
                bool estado = true;
                if (mk_cpf.Text == "" || mk_cpf.Text != "11")
                {
                    estado = false;
                    errorProvider1.SetError(mk_cpf, "Campo obrigatório!");
                   
                }
                if (mk_cnpj.Text == "" || mk_cnpj.Text != "14")
                {
                    estado = false;
                    errorProvider1.SetError(mk_cnpj, "Campo obrigatório!");
                   
                }

                if (tx_razaoS.Text == "")
                {
                    estado = false;
                    errorProvider1.SetError(tx_razaoS, "Campo obrigatório!");
                  
                }

                if (tx_nomeF.Text == "")
                {
                    estado = false;
                    errorProvider1.SetError(tx_nomeF, "Campo obrigatório!");
                   
                }

                if (cb_situacaoC.Text == "")
                {
                    estado = false;
                    errorProvider1.SetError(cb_situacaoC, "Campo obrigatório!");
                }  

                if (dt_dataI.Text == "")
                {
                    estado = false;
                    errorProvider1.SetError(dt_dataI, "Campo obrigatório!");
                   
                }

                if (cb_endereco.Text == "")
                {

                    estado = false;
                    errorProvider1.SetError(cb_endereco, "Campo obrigatório!");
                    
                }

                if (cb_naturezaJ.Text == "")
                {

                    estado = false;
                    errorProvider1.SetError(cb_naturezaJ, "Campo obrigatório!");
                    
                }

                if (mk_telefone.Text == "" || mk_telefone.Text != "9")
                {

                    estado = false;
                    errorProvider1.SetError(mk_telefone, "Campo obrigatório!");
                    
                }

                if (tx_capitalS.Text == "")
                {

                    estado = false;
                    errorProvider1.SetError(tx_capitalS, "Campo obrigatório!");
                   
                }

                if (tx_nome.Text == "")
                {

                    estado = false;
                    errorProvider1.SetError(tx_nome, "Campo obrigatório!");
                   
                }





                if (rb_lucro.Checked == false)
                {

                    estado = false;
                    errorProvider1.SetError(rb_lucro, "Campo obrigatório!");
                   
                }

                if (rb_simplesN.Checked == false)
                {
                    estado = false;
                    errorProvider1.SetError(rb_simplesN, "Campo obrigatório!");
                  

                }

                if (rb_real.Checked == false)
                {
                    estado = false;
                    errorProvider1.SetError(rb_real, "Campo obrigatório!");
                    

                }




                if (rb_matriz.Checked == false)
                {
                    estado = false;
                    errorProvider1.SetError(rb_matriz, "Campo obrigatório!");
                   
                }

                if (rb_filial.Checked == false)
                {
                    estado = false;
                    errorProvider1.SetError(rb_filial, "Campo obrigatório!");
                   

                }




               

                if (rb_pequeno.Checked == false)
                {
                    estado = false;
                    errorProvider1.SetError(rb_pequeno, "Campo obrigatório!");
                     

                }

                if (rb_medio.Checked == false)
                {
                    estado = false;
                    errorProvider1.SetError(rb_medio, "Campo obrigatório!");
                   

                }

                if (rb_grande.Checked == false)
                {
                    estado = false;
                    errorProvider1.SetError(rb_grande, "Campo obrigatório!");
                   

                }
                return estado;
                
        }
     
    }
}

        
    

