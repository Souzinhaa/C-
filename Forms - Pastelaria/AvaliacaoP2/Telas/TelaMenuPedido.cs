using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoP2 {
    public partial class MenuPedido : Form {

        public Logica logica;

        public MenuPedido(Logica l) {
            InitializeComponent();
            this.logica = l;
            iniciarComponentes();
        }
        public void iniciarComponentes() {
            numCoxinha.Value = logica.retornarQtdItem("Coxinha");
            numPastel.Value = logica.retornarQtdItem("Pastel");
            numBacalhau.Value = logica.retornarQtdItem("Bacalhau");
            numCamarao.Value = logica.retornarQtdItem("Camarão");
            numCroquete.Value = logica.retornarQtdItem("Croquete");
            numFrango.Value = logica.retornarQtdItem("Frango");
            numKibe.Value = logica.retornarQtdItem("Kibe");
            numTrufa.Value = logica.retornarQtdItem("Trufa");
        }

        private void botaocardapio_Click(object sender, EventArgs e)
        {
            if (logica.verificarPedido()) { 
                this.Hide();
                Pagamento p = new Pagamento(logica);
                p.Closed += (s, args) => this.Close();
                p.Show();
            } else {
                MessageBox.Show("O pedido precisa ter ao menos 1 item!!!");
            }
        }
        private void adicionarItem(String nome, int qtd, Double valor)
        {
            logica.adicionarItemPedido(nome, qtd, valor);
            labelTotal.Text = logica.retornarTotal();
        }

        private void numCoxinha_ValueChanged(object sender, EventArgs e)
        {
            adicionarItem("Coxinha", Decimal.ToInt32(numCoxinha.Value), 3.5);
        }

        private void numPastel_ValueChanged(object sender, EventArgs e)
        {
            adicionarItem("Pastel", Decimal.ToInt32(numPastel.Value), 9.6);
        }

        private void numBacalhau_ValueChanged(object sender, EventArgs e)
        {
            adicionarItem("Bacalhau", Decimal.ToInt32(numBacalhau.Value), 5);
        }

        private void numCamarao_ValueChanged(object sender, EventArgs e)
        {
            adicionarItem("Camarao", Decimal.ToInt32(numCamarao.Value), 3);
        }

        private void numCroquete_ValueChanged(object sender, EventArgs e)
        {
            adicionarItem("Croquete", Decimal.ToInt32(numCroquete.Value), 4.75);
        }

        private void numFrango_ValueChanged(object sender, EventArgs e)
        {
            adicionarItem("Frango", Decimal.ToInt32(numFrango.Value), 6.2);
        }

        private void numKibe_ValueChanged(object sender, EventArgs e)
        {
            adicionarItem("Kibe", Decimal.ToInt32(numKibe.Value), 12.5);
        }

        private void numTrufa_ValueChanged(object sender, EventArgs e)
        {
            adicionarItem("Trufa", Decimal.ToInt32(numTrufa.Value), 100.35);
        }

        private void Retorno_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaConcluido m = new TelaConcluido();
            m.Closed += (s, args) => this.Close();
            m.Show();

        }
    }
}
