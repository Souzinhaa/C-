using AvaliacaoP2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoP2
{
    public partial class Pagamento : Form
    {
        private Logica logica;
        private String bebida;
        private FormaPagamento pagamento;
        Random randNum = new Random();

        public Pagamento(Logica logica)
        {
            InitializeComponent();
            this.logica = logica;
            this.bebida = "Não";
            this.pagamento = null;
            setListBox();
        }

        private void setListBox()
        {
            listBoxPedido.Items.Clear();
            foreach (String str in logica.retornarItens())
            {
                listBoxPedido.Items.Add(str);
            }
            listBoxPedido.Items.Add(logica.retornarTotal());
        }
        private void radioEspecialSim_CheckedChanged(object sender, EventArgs e)
        {
            logica.selecionarDiaEspecial(true);
            setListBox();
        }

        private void radioEspecialNao_CheckedChanged(object sender, EventArgs e)
        {
            logica.selecionarDiaEspecial(false);
            setListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (logica.retornarNomePagamento() == null)
                MessageBox.Show("Selecione a forma de pagamento!");
            else {
                gerarNota();

                MessageBox.Show("Finalize o Pagamento!");

                this.Hide();
                concluido p = new concluido();
                p.Closed += (s, args) => this.Close();
                p.Show();
            }
        }

        private void Retorno_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPedido n = new MenuPedido(logica);
            n.Closed += (s, args) => this.Close();
            n.Show();
        }

        private void comboBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            logica.removerItemPedido(this.bebida);
            this.bebida = comboBebida.SelectedItem.ToString();
            if(!this.bebida.Equals("Não"))
                logica.adicionarItemPedido(this.bebida, 1, 50);
            setListBox();
        }

        private void radioCartao_CheckedChanged(object sender, EventArgs e)
        {
            radioCarteiraDigital.Checked = false;
            radioDinheiro.Checked = false;
            logica.selecionarFormaPagamento("Cartão");
            setListBox();
            labelTaxa.Text = logica.retornarFormaPagamento();
        }

        private void radioCarteiraDigital_CheckedChanged(object sender, EventArgs e)
        {
            radioCartao.Checked = false;
            radioDinheiro.Checked = false;
            logica.selecionarFormaPagamento("Carteira Digital");
            setListBox();
            labelTaxa.Text = logica.retornarFormaPagamento();
        }

        private void radioDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            radioCarteiraDigital.Checked = false;
            radioCartao.Checked = false;
            logica.selecionarFormaPagamento("Dinheiro");
            setListBox();
            labelTaxa.Text = logica.retornarFormaPagamento();
        }
        private void gerarNota() {
            try {
                String nfe = randNum.Next().ToString();

                string path = "C:\\NFe-"+nfe+".txt";
                String text = "PASTELARICA \nA melhor pastelaria do Brasil\n";

                text += "\nR. Jacinto Leite n°69 Jardim Das Hortências.";
                text += "\nAraras - SP";
                text += "\nCNPJ:24.699.356/0001-24";

                text += "\n\nNota Fiscal Paulista - NFe "+nfe;

                foreach (String str in logica.retornarItens())
                    text += "\n"+str;

                text += "\n"+logica.retornarTotal();

                text += "\n";

                text += "\nForma de Pagamento: "+logica.retornarNomePagamento();
                text += "\nTaxa da forma de Pagamento: "+logica.retornarFormaPagamento();

                if (logica.retornarDiaEspecial()) { 
                    text += "\n\nCelebração Especial Inclusa.";
                    text += "\nValor de 20% adicional.";
                }

                text += "\n\nConsulte pela chave de acesso";
                text += "\nhttps://portal.fazenda.sp.gov.br/";
                text += "\n" + randNum.Next().ToString().Substring(0, 4) + " " + randNum.Next().ToString().Substring(0, 4) + " " +
                                randNum.Next().ToString().Substring(0, 4) + " " + randNum.Next().ToString().Substring(0, 4) + " " +
                                    randNum.Next().ToString().Substring(0, 4) + " " + randNum.Next().ToString().Substring(0, 4) + " " +
                                        randNum.Next().ToString().Substring(0, 4) + " " + randNum.Next().ToString().Substring(0, 4) + " ";
                text += "\n" + randNum.Next().ToString().Substring(0, 4) + " " + randNum.Next().ToString().Substring(0, 4) + " " +
                                randNum.Next().ToString().Substring(0, 4) + " " + randNum.Next().ToString().Substring(0, 4);

                text += "\n\nPastelarica - © Todos os direitos Reservados.";
                File.WriteAllText(path, text);
            }
            catch (Exception e) {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
