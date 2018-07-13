﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        private Conta conta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new Conta();
            this.conta.Titular = new Cliente ();
            this.conta.Titular.Nome = "Victor";
            this.conta.Numero = 1;
            this.conta.Deposita(250.0);

            this.MostraConta();
            
                
          }
        private void button1_Click(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            this.conta.Deposita(valorDeposito);

            this.MostraConta();


        }
        private void MostraConta()
        {
            textoNumero.Text = Convert.ToString(this.conta.Numero);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            textoTitular.Text = this.conta.Titular.Nome;

            textoTitular.Text = conta.Titular.Nome;
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoNumero.Text = Convert.ToString(conta.Numero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoDoValorDoSaque = textoValor.Text;
            double valorSaque = Convert.ToDouble(textoDoValorDoSaque);
            this.conta.Saca(valorSaque);

            this.MostraConta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textoP.Text = Convert.ToString (conta.Saldo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
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
            Conta[] contas = new Conta[2];
            contas[0] = new Conta();
            contas[1] = new ContaPoupanca();

            contas[0].Deposita(20);
            contas[1].Deposita(100);
            foreach(Conta conta in contas)
            {
                MessageBox.Show("O saldo da conta é: " + conta.Saldo);
            }
        }
    }
}
