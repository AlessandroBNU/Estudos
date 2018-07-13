using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herenca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaPoupanca cp = new ContaPoupanca();
            cp.Deposita(100);
            cp.Saca(50);

            MessageBox.Show("Saldo Poupança: " + cp.Saldo);

            Conta c = new Conta();
            c.Deposita(100);
            MessageBox.Show("Saldo da conta: " + c.Saldo);

        }
    }
}
