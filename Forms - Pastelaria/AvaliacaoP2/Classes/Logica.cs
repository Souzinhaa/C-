using AvaliacaoP2.Classes;
using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoP2
{
    public class Logica
    {
        private Pedido pedido = new Pedido();
        private List<FormaPagamento> listaPagamentos = new List<FormaPagamento>();

        public Logica()
        {
            listaPagamentos.Add(new FormaPagamento("Cartão", 20.5));
            listaPagamentos.Add(new FormaPagamento("Carteira Digital", 10.25));
            listaPagamentos.Add(new FormaPagamento("Dinheiro", 0));
        }

        public void adicionarItemPedido(String nome, int qtd, Double valor)
        {
            Item item = buscarItem(nome);

            if (item != null) { 
                item.atualizarPedido(qtd);
                pedido.atualizarValorPedido();
            } else
                pedido.inserirPedido(nome, qtd, valor);
        }
        public void removerItemPedido(String nome)
        {
            pedido.removerItem(nome);
            
        }
        public Item buscarItem(String nome)
        {
            return pedido.buscarItem(nome);
        }
        public bool verificarPedido()
        {
            if (pedido.itens.Count() > 0)
                return true;

            return false;
        }
        public List<String> retornarItens()
        {
            return pedido.retornarListaDeItensFormatado();
        }
        public String retornarTotal()
        {
            return pedido.retornarTotal();
        }
        public FormaPagamento buscarFormaPagamento(String nome)
        {
            foreach(FormaPagamento fp in listaPagamentos)
            {
                if (fp.nomePagamento.Equals(nome))
                    return fp;
            }
            return null;
        }
        public void selecionarDiaEspecial(bool diaEspecial)
        {
            this.pedido.selecionarDiaEspecial(diaEspecial);
        }
        public void selecionarFormaPagamento(String nome)
        {
            this.pedido.selecionarFormaPagamento(buscarFormaPagamento(nome));
        }
        public String retornarNomePagamento() {
            return this.pedido.retornarNomePagamento();
        }
        public String retornarFormaPagamento()
        {
            return this.pedido.retornarFormaPagamento();
        }
        public int retornarValor(String nome) {
            Item i = buscarItem(nome);

            if (i != null)
                return i.quantidade;

            return 0;
        }
        public bool retornarDiaEspecial() {
            return pedido.diaEspecial;
        }
      
    }
}
