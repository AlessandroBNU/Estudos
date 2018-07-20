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
using System.IO;
using Benner.CaixaEletronico.Sistema;

namespace Benner.CaixaEletronico.FormP

{
    public partial class Form1 : Form
    {
        List<Conta> contas;
        private int quantidadeDeContas = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            contas = new List<Conta>();

            Conta contaDoVictor = new ContaCorrente();
            contaDoVictor.Titular = new Cliente();
            contaDoVictor.Titular.Nome = "Victor";
            contaDoVictor.Numero = 1;
            contas.Add(contaDoVictor);


            Conta contaDoGuilherme = new ContaPoupanca();
            contaDoGuilherme.Titular = new Cliente();
            contaDoGuilherme.Titular.Nome = "Guilherme";
            contaDoGuilherme.Numero = 2;
            contas.Add(contaDoGuilherme);


            Conta contaDoMauricio = new ContaInvestimento();
            contaDoMauricio.Titular = new Cliente();
            contaDoMauricio.Titular.Nome = "Mauricio";
            contaDoMauricio.Numero = 3;
            contas.Add(contaDoMauricio);

            foreach (Conta conta in this.contas)
            {
                if (conta != null)
                {
                    comboContas.Items.Add(conta);
                    destinoDaTransferencia.Items.Add(conta.Titular.Nome);
                }                            
            }
            if (File.Exists("entrada.txt")) 
                {
                    Stream entrada = File.Open("entrada.txt", FileMode.Open);
                    StreamReader leitor = new StreamReader(entrada);
                    string linha = leitor.ReadLine();

                    while (linha != null)
                    {
                        texto.Text += linha;
                        linha = leitor.ReadLine();
                    }
                    leitor.Close();
                    entrada.Close();
                }
        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            Stream saida = File.Open("Entrada.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.Write(texto.Text);

            escritor.Close();
            saida.Close();
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
            
                this.contas.Add(conta);

                comboContas.Items.Add(conta);
        }

            public void RemoveConta(Conta c)
            {
                this.contas.Remove(c);
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
            var contas = new HashSet<Conta>();

            var cliente1 = new ContaCorrente();
            cliente1.Titular = new Cliente();
            cliente1.Titular.Nome = "Victor";

            contas.Add(cliente1);

            var cliente2 = new ContaPoupanca();
            cliente2.Titular = new Cliente();
            cliente2.Titular.Nome = "Marioco";

            contas.Add(cliente1);

            foreach (var c in contas)
            {
                MessageBox.Show(c.Titular.Nome);
            }

            MessageBox.Show("Está lá " + contas.Contains(cliente1));
            MessageBox.Show("Está lá " + contas.Contains(cliente2));
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string nomeCompleto = "guilherme silveira";

            int posicaoDoS = nomeCompleto.IndexOf("s");
            string segundoNome = nomeCompleto.Substring(posicaoDoS);
            MessageBox.Show(segundoNome);
        }

       

        private void button8_Click_1(object sender, EventArgs e)
        {
            var filtradas = from conta in contas
                            where conta.Saldo > 2000
                            select conta;

            foreach (Conta conta in filtradas)
            {
                MessageBox.Show("O saldo é: " + conta.Saldo);
            }    
            
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show(StringUteis.Pluralize("conta"));
        }
    }
}
