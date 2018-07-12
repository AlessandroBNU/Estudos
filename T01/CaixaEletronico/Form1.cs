using System;
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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Titular = new Cliente ();
            conta.Titular.Nome = "Victor";
            conta.Numero = 1;
            conta.Deposita(250.0);

            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoTitular.Text = conta.Titular.Nome;
        }
    }
}
