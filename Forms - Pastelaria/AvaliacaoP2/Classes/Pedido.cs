using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AvaliacaoP2.Classes
{
    public class Pedido
    {
        public FormaPagamento pagamento { get; set; }
        public Double valorPedido { get; set; }
        public List<Item> itens { get; set; }
        public bool diaEspecial { get; set; }

        public Pedido () {
            this.itens = new List<Item>();
            this.valorPedido = 0;
            this.pagamento = new FormaPagamento(null, 404);
        }

        public void inserirPedido(String nome, int qtd, Double valor)
        {
            this.itens.Add(new Item(nome, qtd, valor));
            atualizarValorPedido();
        }

        public void atualizarValorPedido()
        {

            this.valorPedido = 0;
            foreach(Item i in itens)
            {
                this.valorPedido += i.valorTotal;
            }
            if (this.diaEspecial)
                this.valorPedido *= 1.2;

            if (this.pagamento.nomePagamento != null)
                this.valorPedido *= (pagamento.taxaPagamento / 100 + 1);
        }
        public List<String> retornarListaDeItensFormatado()
        {
            List<String> listaItens = new List<String>();
            foreach(Item i in itens)
            {
                listaItens.Add(i.detalharItem());
            }
            return listaItens;
        }

        public Item buscarItem(String nomeItem)
        {
            foreach(Item i in itens)
            {
                if (i.nome.Equals(nomeItem))
                    return i;
            }

            return null;
        }

        public String retornarTotal()
        {
            return "Total: R$" + string.Format("{0:0,0.00}", this.valorPedido);
        }

        public void removerItem(String nome)
        {
            itens.Remove(buscarItem(nome));
        }

        public void selecionarDiaEspecial(bool diaEspecial)
        {
            this.diaEspecial = diaEspecial;
            atualizarValorPedido();
        }

        public void selecionarFormaPagamento(FormaPagamento fp)
        {
            this.pagamento = fp;
            atualizarValorPedido();
        }
        public String retornarNomePagamento() {
            return pagamento.nomePagamento;
        }
        public String retornarFormaPagamento()
        {
            return "Taxa " + this.pagamento.taxaPagamento.ToString() + "%";
        }

    }
}
