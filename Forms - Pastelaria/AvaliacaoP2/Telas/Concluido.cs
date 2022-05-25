using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoP2
{
    public partial class concluido : Form
    {
        public concluido()
        {
            InitializeComponent();
        }

        private void Retorno_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) {

            this.Hide();
            Menu c = new Menu();
            c.Closed += (s, args) => this.Close();
            c.Show();
        }
    }
}
