using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Benner.CaixaEletronico.CtaPoupanca;
using Benner.CaixaEletronico.CtaCorrente;
using Benner.CaixaEletronico.Tri;
using Benner.CaixaEletronico.ITri;
using Benner.CaixaEletronico.SiE;
using Benner.CaixaEletronico.TContas;
using Benner.CaixaEletronico.SVida;
using Benner.CaixaEletronico.GImposto;
using Benner.CaixaEletronico.TTri;
using Benner.CaixaEletronico.FormP;
using Benner.CaixaEletronico.Contas;
using Benner.CaixaEletronico.Usuarios;

namespace Benner.CaixaEletronico.CContas
{
    public partial class CadastroDeContas : Form 
    {
        private Form1 aplicacaoPrincipal;
        public CadastroDeContas(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = null;
            if (tipoDeConta.Text == "Poupanca")
            {
                 conta = new ContaPoupanca();
            }
            else 
            {
                 conta = new ContaCorrente();
            }
            conta.Numero = Convert.ToInt32(numeroConta.Text);
            conta.Titular = new Cliente(titularConta.Text);
            this.aplicacaoPrincipal.AdicionaConta(conta);
        }

    }     
}

