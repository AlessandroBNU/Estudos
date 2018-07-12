using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Deposita(1000.0);

            conta.Saca(100);
            conta.Saca(200);
            conta.Titular = new Cliente();
            conta.Titular.nome = "Victor";
            MessageBox.Show("O saldo atual  é :" + conta.Saldo);
        }
    }
}
