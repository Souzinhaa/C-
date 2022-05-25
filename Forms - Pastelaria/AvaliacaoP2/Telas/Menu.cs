using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AvaliacaoP2
{
    public partial class Menu : Form
    {
        public Logica logica = new Logica();
        public Menu()
        {
            InitializeComponent();
            
        }

        private void botao_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPedido f = new MenuPedido(logica);
            f.Closed += (s, args) => this.Close();
            f.Show();



        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
