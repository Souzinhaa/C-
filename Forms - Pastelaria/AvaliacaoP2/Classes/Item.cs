using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoP2.Classes
{
    public class Item
    {
        public String nome { get; set; }
        public int quantidade { get; set; }
        public Double valor { get; set; }
        public Double valorTotal { get; set; }

        public Item (String nome, int qtd, Double valor)
        {
            this.nome = nome;
            this.quantidade = qtd;
            this.valor = valor;
            this.valorTotal = qtd * valor;
        }
        public void atualizarValorTotal() {
            this.valorTotal = this.valor * this.quantidade;
        }
        public void atualizarPedido(int qtd)
        {
            this.quantidade = qtd;
            atualizarValorTotal();
        }
        public String detalharItem()
        {
            return this.nome + " - " + "Qtd: " + this.quantidade + " - Un: R$" + this.valor + " - Total: R$" + this.valorTotal;
        }

    }
}
