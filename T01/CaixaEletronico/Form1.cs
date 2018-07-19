using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Benner.CaixaEletronico.Contas;
using Benner.CaixaEletronico.Usuarios;
using Benner.CaixaEletronico.CtaPoupanca;
using Benner.CaixaEletronico.CtaCorrente;
using Benner.CaixaEletronico.Tri;
using Benner.CaixaEletronico.ITri;
using Benner.CaixaEletronico.SiE;
using Benner.CaixaEletronico.TContas;
using Benner.CaixaEletronico.SVida;
using Benner.CaixaEletronico.GImposto;
using Benner.CaixaEletronico.TTri;
using Benner.CaixaEletronico.CContas;
using Benner.CaixaEletronico.CIv;

namespace Benner.CaixaEletronico.FormP

{
    public partial class Form1 : Form
    {
        Conta[] contas;
        private int quantidadeDeContas = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[10];

            contas[0] = new ContaPoupanca();
            contas[0].Titular = new Cliente();
            contas[0].Numero = 1;
            contas[0].Titular.Nome = "Victor";


            contas[1] = new ContaPoupanca();
            contas[1].Titular = new Cliente();
            contas[1].Numero = 2;
            contas[1].Titular.Nome = "Mario";


            contas[2] = new ContaPoupanca();
            contas[2].Titular = new Cliente();
            contas[2].Numero = 3;
            contas[2].Titular.Nome = "Guilherme";

            foreach (Conta conta in contas)
            {
                if (conta != null)
                {
                    comboContas.Items.Add(conta);
                    destinoDaTransferencia.Items.Add(conta.Titular.Nome);
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];
            contaSelecionada.Deposita(valorDeposito);
            this.MostraConta(contaSelecionada);




        }
        private void MostraConta(Conta conta)
        {
            textoTitular.Text = conta.Titular.Nome;
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoNumero.Text = Convert.ToString(conta.Numero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoDoValorDoSaque = textoValor.Text;
            double valorSaque = Convert.ToDouble(textoDoValorDoSaque);
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];
            try
            {
                contaSelecionada.Saca(valorSaque);
                MessageBox.Show("Dinheiro Liberado");
            }
            catch (SaldoIE exception)
            {
                MessageBox.Show("Saldo Insuficiente");
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show("Valor Inválido para o Saque");
            }

            this.MostraConta(contaSelecionada);



        }
        private Conta BuscaContaSelecionada()
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            return contas[indiceSelecionado];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta c1 = new ContaCorrente();
            c1.Deposita(100);
            ContaPoupanca c2 = new ContaPoupanca();
            c2.Deposita(20);


            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Adiciona(c1);
            t.Adiciona(c2);



            MessageBox.Show("O total é: " + t.Total);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conta[] contas = new Conta[20];
            contas[0] = new ContaCorrente();
            contas[1] = new ContaPoupanca();

            contas[0].Deposita(20);
            contas[1].Deposita(100);
            foreach (Conta conta in contas)
            {
                MessageBox.Show("O saldo da conta é: " + conta.Saldo);
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];

            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Conta contaSelecionada = this.BuscaContaSelecionada();

            int indiceDaContaDestino = destinoDaTransferencia.SelectedIndex;

            Conta contaDestino = this.contas[indiceDaContaDestino];
            string valorDaOperacao = textoValor.Text;
            double valorTransferencia = Convert.ToDouble(valorDaOperacao);

            contaSelecionada.TransferePara(valorTransferencia, contaDestino);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CadastroDeContas cadastroC = new CadastroDeContas(this);
            cadastroC.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            ContaPoupanca contaPoupanca = new ContaPoupanca();

            contaCorrente.Deposita(100);
            contaPoupanca.Deposita(100);

            Conta conta = contaPoupanca;

            contaCorrente.Saca(10);

            MessageBox.Show("Saldo Atual: " + contaCorrente.Saldo);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ContaPoupanca cp = new ContaPoupanca();
            ContaInvestimento ci = new ContaInvestimento();
            cp.Deposita(10);
            ci.Deposita(100);
            TotalizadorDeTributos t = new TotalizadorDeTributos();
            t.Acumula(cp);
            t.Acumula(ci);

            MessageBox.Show("Tributos: " + t.Total);
        }


        private void button9_Click(object sender, EventArgs e)
        {
            GerenciadorDeImposto gerenciador = new GerenciadorDeImposto();
            ContaPoupanca cp = new ContaPoupanca();
            SeguroDeVida sv = new SeguroDeVida();
            gerenciador.Adiciona(cp);
            gerenciador.Adiciona(sv);
            MessageBox.Show("Total: " + gerenciador.Total);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ContaCorrente c = new ContaCorrente();
            MessageBox.Show("Total: " + ContaCorrente.TotalDeContas);
            ContaCorrente c2 = new ContaCorrente();
            MessageBox.Show("Total: " + ContaCorrente.TotalDeContas);
            MessageBox.Show("Proximo " + ContaCorrente.ProximoNumero());
        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente("Guilherme");
            cliente1.Rg = "1234-5";

            Cliente cliente2 = new Cliente("Guilherme");
            cliente2.Rg = "1234-5";
            MessageBox.Show(cliente1.ToString());

        }
        public void AdicionaConta(Conta conta)
        {
            if (this.quantidadeDeContas == this.contas.Length)
            {
                Conta[] novo = new Conta[this.contas.Length * 2];
                for (int i = 0; i < this.quantidadeDeContas; i++)
                {
                    novo[i] = this.contas[i];
                }
                this.contas = novo;
            }
            this.contas[this.quantidadeDeContas] = conta;
            this.quantidadeDeContas++;
            comboContas.Items.Add(conta);
        }

        public void removeConta (Conta conta)
        {
            comboContas.Items.Remove(conta);
            int i;
            for (i = 0; i < this.quantidadeDeContas; i++)
            {
                if (this.contas[i] == conta)
                {
                    break;
                }
            }
            while (i + 1 < this.quantidadeDeContas)
            {
                this.contas[i] = this.contas[i + 1];
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            var contas = new List<Conta>();
            var cliente1 = new ContaCorrente();
            cliente1.Titular = new Cliente();
            cliente1.Titular.Nome = "Victor";
            contas.Add(cliente1);

            Conta copiac1 = contas[0];

            var cliente2 = new ContaPoupanca();
            cliente2.Titular = new Cliente();
            cliente2.Titular.Nome = "Marioco";

            MessageBox.Show("Está lá " + contas.Contains(cliente1));
            MessageBox.Show("Está lá " + contas.Contains(cliente2));
        }
    }
}
