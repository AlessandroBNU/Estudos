using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.Deposita(10);
            ContaPoupanca c2 = new ContaPoupanca();
            c2.Deposita(100);

            TotalizadorDeConta t = new TotalizadorDeConta();
            t.Adiciona(c1);
            t.Adiciona(c2);

            MessageBox.Show("O total é: " + t.Total);
        }
    }
}
