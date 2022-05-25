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
    public partial class Form1 : Form {

        public Pedido pedido = new Pedido();

        public Form1() {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void botaocardapio_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagamento p = new pagamento();
            p.Closed += (s, args) => this.Close();
            p.Show();
        }

        private void NumUpDownKibe_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numCoxinha_ValueChanged(object sender, EventArgs e)
        {
            this.pedido;
        }
    }
}
